using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
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

        public List<Car> GetAll()
        {
            //iş kodları
            // bir iş sınıfı başka sınıfları newlemez.

            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
            return _carDal.GetAll(c => c.BrandId == Id);
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            return _carDal.GetAll(c => c.ColorId == Id);
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0 && car.CarName.Length > 2)
            {
                _carDal.Add(car);
                Console.WriteLine("Araç Kaydedildi");
            }
            else
            {
                Console.WriteLine("Lütfen Girdiğiniz Bilgileri Kontrol Edin");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Araç Silindi");
        }

        public void Update(Car car)
        {
            if (car.DailyPrice > 0 && car.CarName.Length > 2)
            {
                _carDal.Update(car);
            }
            else
            {
                Console.WriteLine("Lütfen Girdiğiniz Bilgileri Kontrol Edin");
            }
        }

        public List<Car> GetByDailyPrice(decimal min)
        {
            return _carDal.GetAll(c => c.DailyPrice > min);
        }
    }
}
