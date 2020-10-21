using BookStore.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.API.Contracts
{
    public interface IBookRepository : IRepositoryBase<Book>
    {
        public Task<string> GetImageFileName(int id);
    }
}
