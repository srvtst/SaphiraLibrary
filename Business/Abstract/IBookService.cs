using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBookService
    {
        List<BookDetailDto> GetBookDetails();
        List<Book> GetAll();
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);
        List<Book> GetByCategoryId(int categoryId);
        List<Book> GetByBookName(string name);
    }
}