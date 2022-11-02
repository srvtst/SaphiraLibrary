using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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