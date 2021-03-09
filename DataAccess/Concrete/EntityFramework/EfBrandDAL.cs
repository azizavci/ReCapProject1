using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //sen bir IBrandDAL sın
    //IBrandDAL bir IEntityRepository olduğu için 
    //sen IEntityRepository nin metotlarını implement ettin
    public class EfBrandDAL : EfEntityRepositoryBase<Brand, ReCapContext>, IBrandDAL
    {
       
    }
}
