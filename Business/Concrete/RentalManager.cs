using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilies.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
using Core.Utilies.Business;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        private ICustomerService _customerService;
        private ICarService _carService;

        public RentalManager(IRentalDal rentalDal, ICarService carService, ICustomerService customerService)
        {
            _rentalDal = rentalDal;
            _carService = carService;
            _customerService = customerService;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            IResult result = BusinessRules.Run(CheckCarDate(rental), 
                CheckFindexPoint(rental.CarId, rental.CustomerId));
                UpdateCustomerFindexPoint(rental.CustomerId, rental.CarId);

            if (result  != null)
            {
                return new ErrorResult(Messages.CarNotRented);
              
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.CarRented);

        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.DeletedRental);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
        }

        public IDataResult<List<Rental>> GetRentalByCarId(int carId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CarId == carId));
        }

        private IResult CheckFindexPoint(int carId, int customerId)
        {
           var customerFindexPoint = _customerService.GetByCustomerId(customerId).Data[0].FindexPoint;

            if (customerFindexPoint == 0)
                return new ErrorResult(Messages.CustomerFindexPointInvalid);

            var carFindexPoint = _carService.GetById(carId).Data.FindexPoint;

            if (customerFindexPoint < carFindexPoint)
                return new ErrorResult(Messages.FindexPointInvalid);

            return new SuccessResult();
        }

        private IResult CheckCarDate(Rental rental)
        {
            var results = _rentalDal.GetAll(r => r.CarId == rental.CarId);
            foreach (var result in results)
            {
                if (result.ReturnDate == null || rental.RentDate < result.ReturnDate)
                {
                    return new ErrorResult(Messages.DateNotSuitable);
                }           
            }
            return new SuccessResult(Messages.DateSuitable);
        }
        private IResult UpdateCustomerFindexPoint(int customerId, int carId)
        {
            var customer = _customerService.GetByCustomerId(customerId).Data[0];
            var car = _carService.GetById(carId).Data;

            customer.FindexPoint = (car.FindexPoint / 2) + customer.FindexPoint;

            _customerService.Update(customer);
            return new SuccessResult();
        }
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.UpdatedRental);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            var getRentalDetails = _rentalDal.GetRentalDetails();
            return new SuccessDataResult<List<RentalDetailDto>>(getRentalDetails);
        }

        public IDataResult<List<Rental>> GetByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CustomerId == customerId));
        }

        public IDataResult<List<Rental>> GetByRentDate(DateTime first, DateTime last)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.RentDate == first && r.ReturnDate == last));
        }

        public IDataResult<Rental> CheckReturnDate(int carId)
        {
            List<Rental> resultRental = _rentalDal.GetAll(r => r.CarId == carId && r.ReturnDate == null);
            if (resultRental.Count > 0)
            {
                return new ErrorDataResult<Rental>(Messages.CarAlreadyRented);
            }

            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.CarId == carId));
        }
    }
}
