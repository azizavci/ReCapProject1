using Business.Abstract;
using Business.Constants.ReCapConstants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {

        IRentalDAL _rentalDAL;

        public RentalManager(IRentalDAL rentalDAL)
        {
            _rentalDAL = rentalDAL;
        }

        public IResult Add(Rental rental)
        {
            _rentalDAL.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDAL.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            
            return new SuccessDataResult<List<Rental>>(_rentalDAL.GetAll(),Messages.RentalsListed);
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDAL.Get(r => r.Id == rentalId));
        }

        public IDataResult<List<RentalDetailDTO>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDTO>>(_rentalDAL.GetRentalDetails());
        }

        public IResult Update(Rental rental)
        {
            _rentalDAL.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
