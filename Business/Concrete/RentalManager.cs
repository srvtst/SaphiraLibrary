using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public void Add(Rental rental)
        {
            _rentalDal.Add(rental);
        }

        public void Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
        }

        public List<Rental> GetAll()
        {
            return _rentalDal.GetAll();
        }

        public List<Rental> GetByCustomerId(int customerId)
        {
            return _rentalDal.GetAll(r => r.CustomerId == customerId);
        }

        public List<Rental> GetById(int id)
        {
            return _rentalDal.GetAll(r => r.Id == id);
        }

        public List<RentalDetailDto> GetRentalDetails()
        {
            return _rentalDal.GetRentalDetails();
        }

        public void Update(Rental rental)
        {
            _rentalDal.Update(rental);
        }
    }
}