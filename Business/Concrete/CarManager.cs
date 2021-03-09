using Business.Abstract;
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

        public void Add(Car car)
        {
            _carDAL.Add(car);
        }

        public void Delete(Car car)
        {
            _carDAL.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDAL.GetAll();
        }

        public Car GetById(int carId)
        {
            //select * from cars where id=carId
            return _carDAL.Get(c=>c.Id==carId);
        }

        public List<CarDetailDTO> GetCarDetails()
        {
            //iş kuralları sonradan yazılacak
            return _carDAL.GetCarDetails();
        }

        public void Update(Car car)
        {
            _carDAL.Update(car);
        }
    }
}
