using Business.Abstract;
using Business.Constants.NorthwindConstants;
using Business.Validation.FluentValidation;
using Core.Aspects.AutoFac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDAL _carDAL;

        public CarManager(ICarDAL carDAL)
        {
            _carDAL = carDAL;
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            //business code
            _carDAL.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            

            _carDAL.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==23)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDAL.GetAll(),Messages.CarsListed);
        }

        public IDataResult<Car> GetById(int carId)
        {
            //select * from cars where id=carId
            return new SuccessDataResult<Car>(_carDAL.Get(c=>c.Id==carId));
        }

        public IDataResult<List<CarDetailDTO>> GetCarDetails()
        {
            //iş kuralları sonradan yazılacak
            return new SuccessDataResult<List<CarDetailDTO>>(_carDAL.GetCarDetails());
        }

        public IResult Update(Car car)
        {
            _carDAL.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
