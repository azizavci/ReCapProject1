using Business.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        InMemoryCarDAL _memoryCarDAL;

        public CarManager(InMemoryCarDAL memoryCarDAL)
        {
            _memoryCarDAL = memoryCarDAL;
        }

        public void Add(Car car)
        {
            _memoryCarDAL.Add(car);
        }

        public void Delete(Car car)
        {
            _memoryCarDAL.Delete(car);
        }

        public void Update(Car car)
        {
            _memoryCarDAL.Update(car);
        }

        public List<Car> GetAll()
        {
            return _memoryCarDAL.GetAll(); 
        }

        public List<Car> GetById(int id)
        {
            return _memoryCarDAL.GetById(id);
        }

        
    }
}
