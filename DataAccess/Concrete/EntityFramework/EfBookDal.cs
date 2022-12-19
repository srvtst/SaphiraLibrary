using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class EfBookDal : EfEntityRepositoryBase<Book, SaphiraContext>, IBookDal
    {
        public List<BookDetailDto> GetBookDetails()
        {
            using (SaphiraContext saphiraContext = new SaphiraContext())
            {
                var result = from b in saphiraContext.Books
                             join a in saphiraContext.Authors
                             on b.AuthorId equals a.Id
                             join ca in saphiraContext.Categories
                             on b.CategoryId equals ca.Id
                             select new BookDetailDto
                             {
                                 Id = b.Id,
                                 Author = a.Writer,
                                 Category = ca.Name,
                                 BookName = b.BookName,
                                 Price = b.Price,
                                 PageCount = b.PageCount,
                                 Publisher = b.Publisher
                             };
                return result.ToList();
            }
        }
    }
}