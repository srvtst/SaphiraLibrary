using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, SaphiraContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (SaphiraContext saphiraContext = new SaphiraContext())
            {
                var result = from r in saphiraContext.Rentals
                             join b in saphiraContext.Books
                             on r.BookId equals b.Id
                             join customer in saphiraContext.Customers
                             on r.CustomerId equals customer.Id
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 BookName = b.BookName,
                                 CustomerName = customer.CustomerName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}