using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
   class Program
    {
        static void Main(string[] args)
        {
//            //CarDescription();

//            //List1();

//            //BrandIdList();

//            //ColorIdList();

//            //CarDailyPrice();

//            //AddNotCar();

//            //AddCar();

//            //CarList2();

//            //ColorList();

//            //BrandList();

            
//            CarManager carManager = new CarManager(new EfCarDal());
//            var result = carManager.GetCarDetails();
//            if (result.Success==true)
//            {       
//                foreach (var car in result.Data)
//                {
//                    Console.WriteLine(car.BrandName + " / " + car.DailyPrice + " - " + car.ColorName + " - " + car.Description);
//                }
//            }
//            else
//            {
//                Console.WriteLine(result.Message);
//            }
            
//                Console.ReadLine();
//        }

//        private static void BrandList()
//        {
//            BrandManager brandManager = new BrandManager(new EfBrandDal());
//            foreach (var brand in brandManager.GetAll())
//            {
//                Console.WriteLine(brand.BrandName);
//            }
//        }

//        private static void ColorList()
//        {
//            ColorManager colorManager = new ColorManager(new EfColorDal());
//            foreach (var color in colorManager.GetAll())
//            {
//                Console.WriteLine(color.ColorName);
//            }

//            Console.ReadLine();
//        }

//        private static void CarList2()
//        {
//            CarManager carManager = new CarManager(new EfCarDal());
//            foreach (var car in carManager.GetAll())
//            {
//                Console.WriteLine(car.DailyPrice + " - " + car.ModelYear + " - " + car.Description);
//            }
//        }

//        private static void AddCar()
//        {
//            CarManager carManager = new CarManager(new EfCarDal());
//            Console.WriteLine("\nGünlük Fiyatı O TL üstünde  olan araç ekleme: ");
//            carManager.Add(new Car
//            {

//                BrandId = 1,
//                ColorId = 2,
//                DailyPrice = 1000,
//                ModelYear = 2017,
//                Description = "Yeni Eklenen Araba"
//            });
//        }

//        private static void AddNotCar()
//        {
//            CarManager carManager = new CarManager(new EfCarDal());
//            Console.WriteLine("\nGünlük Fiyatı O TL altında  olan araç ekleme: ");
//            carManager.Add(new Car
//            {
//                BrandId = 1,
//                ColorId = 2,
//                DailyPrice = 0,
//                ModelYear = 2016,
//                Description = "Yeni Eklenen Araba"
//            });
//        }

//        private static void CarDailyPrice()
//        {
//            CarManager carManager = new CarManager(new EfCarDal());
//            Console.WriteLine("DailyPrice 0'dan büyük olan araçlar: ");
//            foreach (var car in carManager.GetByDailyPrice(0))
//            {
//                Console.WriteLine(car.Description + " -- " + car.DailyPrice);
//            }
//        }

//        private static void ColorIdList()
//        {
//            ColorManager colorManager = new ColorManager(new EfColorDal());
//            Console.WriteLine("ColorId'si 2 olan renk: ");
//            foreach (var color in colorManager.GetCarsByColorsId(2))
//            {
//                Console.WriteLine(color.ColorName);
//            }
//        }

//        private static void BrandIdList()
//        {
//            CarManager carManager = new CarManager(new EfCarDal());
//            Console.WriteLine("BrandId'si 1 olan araçlar: ");
//            foreach (var car in carManager.GetCarsByBrandId(1))
//            {
//                Console.WriteLine(car.Description + " -- " + car.BrandId);
//            }
//        }

//        private static void List1()
//        {
//            CarManager carManager = new CarManager(new EfCarDal());
//            foreach (var car in carManager.GetAll())
//            {
//                Console.WriteLine(car.Description + " / " + car.BrandId + " / " + car.ColorId + " - " + car.DailyPrice);
//            }
//        }

//        private static void CarDescription()
//        {
//            CarManager carManager = new CarManager(new EfCarDal());

//            foreach (var car in carManager.GetAll())
//            {
//                Console.WriteLine(car.Description);
//            }
       }
    }
}
