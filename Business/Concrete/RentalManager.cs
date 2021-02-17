using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        
            IRentalDal _rentalDal;
            
            public RentalManager (IRentalDal rentalDal)
            {
                _rentalDal = rentalDal;
            }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.CarAdded);
        }

        public IDataResult<List<RentalDetailDto>> GetRentableCars()
        {
            foreach (var rental in _rentalDal.GetAll())
            {
                if (rental.ReturnDate!=null)
                {
                    return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentDetail(), Messages.CarsRentable);
                }
                
            }
            return new ErrorDataResult<List<RentalDetailDto>>(Messages.CarsCannotRent);
            
        }
    }
}
