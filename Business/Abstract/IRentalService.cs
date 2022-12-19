using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IRentalService
    {
        List<RentalDetailDto> GetRentalDetails();
        List<Rental> GetAll();
        List<Rental> GetById(int id);
        List<Rental> GetByCustomerId(int customerId);
        void Add(Rental rental);
        void Update(Rental rental);
        void Delete(Rental rental);
    }
}