﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=800,CarName="Nice Car",ModelYear="1990"},
                new Car{CarId=2,BrandId=2,ColorId=2,DailyPrice=1400,CarName="Nice Car",ModelYear="2018"},
                new Car{CarId=3,BrandId=1,ColorId=4,DailyPrice=1100,CarName="Nice Car",ModelYear="1999"},
                new Car{CarId=4,BrandId=3,ColorId=5,DailyPrice=1600,CarName="Nice Car",ModelYear="2010"},
                new Car{CarId=5,BrandId=3,ColorId=3,DailyPrice=1700,CarName="Nice Car",ModelYear="2009"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=> c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId,int brandId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public List<Car> GetById(int carId)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.CarName = car.CarName;
        }
    }
}
