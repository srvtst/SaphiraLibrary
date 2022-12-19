using Business.Abstract;
using Business.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using FluentValidation.Results;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void Add(Book book)
        {
            BookValidator bookValidator = new BookValidator();
            ValidationResult result = bookValidator.Validate(book);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
            _bookDal.Add(book);
        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }

        public List<BookDetailDto> GetBookDetails()
        {
            return _bookDal.GetBookDetails();
        }

        public List<Book> GetByBookName(string name)
        {
            return _bookDal.GetAll(b => b.BookName.ToLower().Contains(name.ToLower()));
        }

        public List<Book> GetByCategoryId(int categoryId)
        {
            return _bookDal.GetAll(b => b.CategoryId == categoryId);
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }
    }
}