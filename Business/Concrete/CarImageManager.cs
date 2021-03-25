using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {

        ICarImageDAL _carImageDAL;

        public CarImageManager(ICarImageDAL carImageDAL)
        {
            _carImageDAL = carImageDAL;
        }

        public IResult Add(CarImage carImage, IFormFile file)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> CheckIfCarHaveNoImage(int carId)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int carImageId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarImage> GetById(int carImageId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(int carImageId, IFormFile file)
        {
            throw new NotImplementedException();
        }
    }
}
