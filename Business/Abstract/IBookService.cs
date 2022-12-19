using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

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