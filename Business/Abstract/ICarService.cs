using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //car entity si ile ilgili dış dünyaya neyi servis etmek istiyorsam
    //bunu yönetiyorum
    public interface ICarService
    {
        List<Car> GetAll();
        List<CarDetailDTO> GetCarDetails();
        Car GetById(int carId);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    }
}
