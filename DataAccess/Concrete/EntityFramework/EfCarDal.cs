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
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDataContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarDataContext context = new CarDataContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join r in context.Colors
                             on c.ColorId equals r.ColorId
                             select new CarDetailDto { CarId = c.CarId, CarName = c.CarName,
                              BrandName=b.BrandName ,ColorName = r.ColorName , DailyPrice=c.DailyPrice
                             };
                return result.ToList();
            }
        }

    }
}
