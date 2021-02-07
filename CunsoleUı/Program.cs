using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace CunsoleUı
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carmanager = new CarManager(new EfCarDal());
            foreach (var car in carmanager.GetByDailyPrice(800,1000))       
            {
                Console.WriteLine(car.BrandId);
            }
            
        }
    }
}
