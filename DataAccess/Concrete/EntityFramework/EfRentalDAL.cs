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
    public class EfRentalDAL : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDAL
    {
        public List<RentalDetailDTO> GetRentalDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in context.Rentals
                             join cus in context.Customers on r.CustomerId equals cus.Id
                             join u in context.Users on cus.UserId equals u.Id
                             join c in context.Cars on r.CarId equals c.Id
                             join b in context.Brands on c.BrandId equals b.Id
                             join clr in context.Colors on c.ColorId equals clr.Id

                             select new RentalDetailDTO
                             {
                                 Id = r.Id,
                                 BrandName = b.BrandName,
                                 CustomerName = u.FirstName + " " + u.LastName,
                                 RentalDate = r.RentalDate,
                                 ReturnDate = r.ReturnDate

                             };

                return result.ToList();
            }
        }
    }
}
