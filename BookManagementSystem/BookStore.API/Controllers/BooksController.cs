using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.API.Contracts;
using BookStore.API.Data;
using BookStore.API.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers
{
    /// <summary>
    /// Interacts with the Books Table
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;

        public BooksController(IBookRepository bookRepository, ILoggerService logger, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// Get All Books
        /// </summary>
        /// <returns>List Of Books</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetBooks()
        {
            var location = GetControllerActionNames();
            try
            {
                _logger.LogInfo($"{location}: Attempted Get All Books");
                var books = await _bookRepository.FindAll();
                var response = _mapper.Map<IList<BookDTO>>(books);
                _logger.LogInfo($"{location}: Successfully got all Books");
                return Ok(response);
            }
            catch (Exception e)
            {
                return InternalError($"{location}: {e.Message} - {e.InnerException}");
            }
        }


        /// <summary>
        /// Get a Book By an Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A book record</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetBook(int id)
        {
            var location = GetControllerActionNames();
            try
            {
                _logger.LogInfo($"{location}: Attempted call for id: {id}");
                var book = await _bookRepository.FindById(id);
                if (book == null)
                {
                    _logger.LogWarn($"{location}: Failed to retrieve with id: {id}");
                    return NotFound();
                }
                var response = _mapper.Map<BookDTO>(book);
                _logger.LogInfo($"{location}: Successfully got record with id: {id}");
                return Ok(response);
            }
            catch (Exception e)
            {
                return InternalError($"{location}: {e.Message} - {e.InnerException}");
            }
        }

        /// <summary>
        /// Creates A New Book
        /// </summary>
        /// <param name="bookDTO"></param>
        /// <returns>Book Created</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody] BookCreateDTO bookDTO)
        {
            var location = GetControllerActionNames();
            try
            {
                _logger.LogInfo($"{location}: Create Attempted");
                if (bookDTO == null)
                {
                    _logger.LogWarn($"{location}: Empty Request was submitted");
                    return BadRequest(ModelState);
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogWarn($"{location}: Data was Incomplete");
                    return BadRequest(ModelState);
                }
                var book = _mapper.Map<Book>(bookDTO);
                var isSuccess = await _bookRepository.Create(book);
                if (!isSuccess)
                {
                    _logger.LogWarn($"{location}: Creation failed");
                    return InternalError($"{location}: Creation failed");
                }

                _logger.LogInfo($"{location}: Book Created");
                _logger.LogInfo($"{location}: {book}");
                return Created("Create", new { book });

            }
            catch (Exception e)
            {
                return InternalError($"{location}: {e.Message} - {e.InnerException}");
            }
        }


        /// <summary>
        /// Updates A Book
        /// </summary>
        /// <param name="id"></param>
        /// <param name="bookDTO"></param>
        /// <returns>Book Created</returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(int id, [FromBody] BookUpdateDTO bookDTO)
        {
            var location = GetControllerActionNames();
            try
            {
                _logger.LogInfo($"{location}: Update Attempted on record with id: {id}");
                if (id < 1 || bookDTO == null || id != bookDTO.Id)
                {
                    _logger.LogWarn($"{location}: Update failed with bad data -id: {id}");
                    return BadRequest();
                }
                var isExists = await _bookRepository.isExists(id);
                if (!isExists)
                {
                    _logger.LogWarn($"{location}: Failed to retrieve with id: {id}");
                    return NotFound();
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogWarn($"{location}: Data was incomplete");
                    return BadRequest(ModelState);
                }
                var book = _mapper.Map<Book>(bookDTO);
                var isSuccess = await _bookRepository.Update(book);

                if (!isSuccess)
                {
                    return InternalError($"{location}: Update operation failed for record with id: {id}");
                }
                _logger.LogInfo($"{location}: Record with id: {id} successfully updated");
                return NoContent();
            }
            catch (Exception e)
            {
                return InternalError($"{location}: {e.Message} - {e.InnerException}");
            }
        }

        /// <summary>
        /// Delete A Book by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A Book's record deletion</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(int id)
        {
            var location = GetControllerActionNames();
            try
            {
                _logger.LogInfo($"{location}: Delete Attempted on record with id: {id}");
                if (id < 1)
                {
                    _logger.LogWarn($"{location}: Delete failed with bad data -id: {id}");
                    return BadRequest();
                }
                var isExists = await _bookRepository.isExists(id);
                if (!isExists)
                {
                    _logger.LogWarn($"{location}: Failed to retrieve reocrd with id: {id}");
                    return NotFound();
                }
                var book = await _bookRepository.FindById(id);
                var isSuccess = await _bookRepository.Delete(book);
                if (!isSuccess)
                {
                    return InternalError($"{location}: Delete Failed for record with id: {id}");
                }

                _logger.LogInfo($"{location}: Record with id: {id} successfully deleted");
                return NoContent();
            }
            catch (Exception e)
            {
                return InternalError($"{location}: {e.Message} - {e.InnerException}");
            }
        }


        /// <summary>
        /// Gives access to which controller and which action has taken place
        /// </summary>
        /// <returns>returns string value of the controller and action</returns>
        private string GetControllerActionNames()
        {
            var controller = ControllerContext.ActionDescriptor.ControllerName;
            var action = ControllerContext.ActionDescriptor.ActionName;

            return $"{controller} - {action}";
        }


        /// <summary>
        /// Logs and Return Internal Error
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private ObjectResult InternalError(string message)
        {
            _logger.LogError(message);
            return StatusCode(500, "Something went wrong, Please contact the Administrator!");
        }

    }
}
