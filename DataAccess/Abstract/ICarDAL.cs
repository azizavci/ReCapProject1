using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //sen bir IEntityRepository sin ve çalışma alanın Car dır
    public interface ICarDAL:IEntityRepository<Car>
    {
        List<CarDetailDTO> GetCarDetails();
    }
}
