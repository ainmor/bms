using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.API.Contracts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStore.API.Controllers
{
    /// <summary>
    /// This is the test API controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILoggerService _logger;

        public HomeController(ILoggerService logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get Values  
        /// </summary>
        /// <returns></returns>
        // GET: api/<HomeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Accessed Home controller");
            return new string[] { "value1", "value2" };
        }
        /// <summary>
        ///  Get A Value
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<HomeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            _logger.LogDebug("Got A Value");
            return "value";
        }
        /// <summary>
        /// Post A Value
        /// </summary>
        /// <param name="value"></param>
        // POST api/<HomeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _logger.LogError("This is an Error");
        }
        /// <summary>
        /// Update a Value
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT api/<HomeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        /// <summary>
        /// Delete a value
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/<HomeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _logger.LogWarn("This is a warning");
        }
    }
}
