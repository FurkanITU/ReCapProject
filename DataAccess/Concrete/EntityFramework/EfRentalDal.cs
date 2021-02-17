using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarDataContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentDetail()
        {
            using (CarDataContext context = new CarDataContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.CarId
                             join m in context.Customers
                             on r.CustomerId equals m.UserId
                
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 CarName = c.CarName,
                                 CustomerName = m.CompanyName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }
        }

        
    }
        
    
}
