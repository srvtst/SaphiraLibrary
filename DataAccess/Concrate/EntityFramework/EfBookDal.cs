using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrate.Context;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntityFramework.Context
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