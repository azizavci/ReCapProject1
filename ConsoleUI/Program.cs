using Business.Concrete;
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
            CarManager carManager = new CarManager(new InMemoryCarDAL());

            List<Car> cars = carManager.GetAll();

            Car car1 = new Car
            {
                Id = 1,
                BrandId=1,
                ColorId=1,
                DailyPrice=50,
                ModelYear=2016,
                Description="HONDA"
            };

            Car car2 = new Car
            {
                Id = 2,
                BrandId = 1,
                ColorId = 1,
                DailyPrice = 60,
                ModelYear = 2018,
                Description = "TOYOTA"
            };

            Car car3 = new Car
            {
                Id = 3,
                BrandId = 1,
                ColorId = 1,
                DailyPrice = 100,
                ModelYear = 2018,
                Description = "MERCEDES"
            };


            carManager.Add(car1);
            carManager.Add(car2);
            
            foreach (var car in cars)
            {
                Console.WriteLine("ID : "+car.Id);
                Console.WriteLine("MARKA ID : "+car.BrandId);
                Console.WriteLine("RENK ID : "+car.ColorId);
                Console.WriteLine("GÜNLÜK ÜCRET : "+car.DailyPrice);
                Console.WriteLine("MODEL YILI : "+car.ModelYear);
                Console.WriteLine("AÇIKLAMA : "+car.Description);
                Console.WriteLine("------------------------------------------");
            }

            carManager.Delete(car1);

            foreach (var car in cars)
            {
                Console.WriteLine("ID : " + car.Id);
                Console.WriteLine("MARKA ID : " + car.BrandId);
                Console.WriteLine("RENK ID : " + car.ColorId);
                Console.WriteLine("GÜNLÜK ÜCRET : " + car.DailyPrice);
                Console.WriteLine("MODEL YILI : " + car.ModelYear);
                Console.WriteLine("AÇIKLAMA : " + car.Description);
                Console.WriteLine("------------------------------------------");
            }
            car2.DailyPrice = 120;
            carManager.Update(car2);
            foreach (var car in cars)
            {
                Console.WriteLine("ID : " + car.Id);
                Console.WriteLine("MARKA ID : " + car.BrandId);
                Console.WriteLine("RENK ID : " + car.ColorId);
                Console.WriteLine("GÜNLÜK ÜCRET : " + car.DailyPrice);
                Console.WriteLine("MODEL YILI : " + car.ModelYear);
                Console.WriteLine("AÇIKLAMA : " + car.Description);
                Console.WriteLine("------------------------------------------");
            }


            Console.ReadLine();
        }
    }
}
