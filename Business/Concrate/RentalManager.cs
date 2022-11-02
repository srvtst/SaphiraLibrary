using Business.Abstract;
using Business.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
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