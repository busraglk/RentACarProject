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
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
             
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName + " / " + car.ColorId + " / " + car.ColorId + " - " + car.DailyPrice);
            }
           
            Console.WriteLine("\n*********************");
            Console.WriteLine("BrandId'si 1 olan araçlar: ");
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.CarName + " -- " + car.BrandId); 
            }

            Console.WriteLine("\n*********************");
            Console.WriteLine("ColorId'si 2 olan renk: ");
            foreach (var color in colorManager.GetCarsByColorsId(2))
            {
                Console.WriteLine(color.ColorName);
            }

            Console.WriteLine("\n*********************");
            Console.WriteLine("DailyPrice 0'dan büyük olan araçlar: ");
            foreach (var car in carManager.GetByDailyPrice(0))
            {
                Console.WriteLine(car.CarName + " -- " + car.DailyPrice);
            }

            Console.WriteLine("\nGünlük Fiyatı O TL altında  olan araç ekleme: ");
            carManager.Add(new Car
            {
                BrandId = 1,
                ColorId = 2,
                CarName = "C200",
                DailyPrice = 0,
                ModelYear= 2016,
                Description ="Yeni Eklenen Araba"
            });

            Console.WriteLine("\nGünlük Fiyatı O TL üstünde  olan araç ekleme: ");
            carManager.Add(new Car
            {
                CarId=11,
                BrandId = 1,
                ColorId = 2,
                CarName = "C200",
                DailyPrice = 1000,
                ModelYear = 2017,
                Description = "Yeni Eklenen Araba"
            });

            Console.ReadLine();
        }
    }
}
