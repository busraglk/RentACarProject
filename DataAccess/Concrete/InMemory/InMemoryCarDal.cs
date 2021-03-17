using DataAccess.Abstract;
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
        // List<Car> _cars; -- Bunu bütün methodların dışında tanımladığımızda, bu tip tanımlanan değişkenlere global değişken deniyor. Ve bunları _ (_cars)ile veriyoruz. 
        // constructor: bellekte referans aldığı zaman oluşacak olan bloktur. (ctor)

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
               new Car{Id=1, ColorId=1,BrandId=1, ModelYear=2017, DailyPrice= 1000, Description="Yeni Model 1" },
               new Car{Id=2, ColorId=1,BrandId=2, ModelYear=2018, DailyPrice= 2000, Description="Yeni Model 2" },
               new Car{Id=3, ColorId=2,BrandId=3, ModelYear=2019, DailyPrice= 3000, Description="Yeni Model 3" },
               new Car{Id=4, ColorId=2,BrandId=4, ModelYear=2020, DailyPrice= 4000, Description="Yeni Model 4" },
               new Car{Id=5, ColorId=3,BrandId=2, ModelYear=2021, DailyPrice= 5000, Description="Yeni Model 5" }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            // c => = Lambda
            // SingleOrDefault = Döngüyü tek tek dolaşmayı sağlar. Id olan aramalarda genelde bu kullanılır. 
            //(c, döngü de dolaşırken verdiğimiz takma ad)
           
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == c.Id);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
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

        public List<Car> GetById(int Id)
        {
            // Where koşulu içinde ki şarta uyan bütün elemanları yeni bir liste haline getirir ve onu döndürür.
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == c.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}

    