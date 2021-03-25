using Core.Utilities.Results;
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
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDTO>> GetCarDetails();
        IDataResult<Car> GetById(int carId);
    }
}
