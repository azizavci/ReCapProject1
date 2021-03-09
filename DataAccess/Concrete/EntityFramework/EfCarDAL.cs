using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //sen bir ICarDAL sın
    //ICarDAL bir IEntityRepository olduğu için 
    //sen IEntityRepository nin metotlarını implement ettin
    public class EfCarDAL : EfEntityRepositoryBase<Car, ReCapContext>, ICarDAL
    {
        public List<CarDetailDTO> GetCarDetails()
        {
            using (ReCapContext context=new ReCapContext())
            {
                var result = from cr in context.Cars
                             join cl in context.Colors
                             on cr.ColorId equals cl.Id
                             join b in context.Brands
                             on cr.BrandId equals b.Id
                             select new CarDetailDTO
                             {
                                 Id = cr.Id,
                                 BrandName=b.BrandName,
                                 Information = cr.Information,
                                 ColorName = cl.ColorName,
                                 ModelYear = cr.ModelYear
                             };
                return result.ToList();
            }
        }
    }
}
