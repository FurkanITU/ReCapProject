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
            CarTest();
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}
        }

        private static void CarTest()
        {
            CarManager carmanager = new CarManager(new EfCarDal());
            foreach (var car in carmanager.GetCarDetails().Data)
            {
                Console.WriteLine(car.BrandName +"/" + car.DailyPrice);
            }
        }
    }
}
