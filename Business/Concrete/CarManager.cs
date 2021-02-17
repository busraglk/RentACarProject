using Business.Abstract;
using Business.Constants;
using Core.Utilies.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IDataResult<List<Car>> GetAll()
        {
            //iş kodları
            // bir iş sınıfı başka sınıfları newlemez.

            if (DateTime.Now.Hour == 16)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.ListedCars);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == Id));
        }

            public IDataResult<List<Car>> GetCarsByColorId(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == Id));
        }

        public IResult Add(Car car)
        {
            if (car.DailyPrice > 0  && car.Description.Length > 2)
            {
                 _carDal.Add(car);
                return new SuccessResult(Messages.AddedCar);
            }
            else
            {
                return new ErrorResult(Messages.FailedCarAddOrUpdate);
            }
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.DeletedCar);
        }

        public IResult Update(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length > 2)
            {
                _carDal.Update(car);
                return new SuccessResult(Messages.UpdatedCar);
            }
            else
            {
                return new ErrorResult(Messages.FailedCarAddOrUpdate);
            }
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice > min));
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour == 18)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }
    }
}
