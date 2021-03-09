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
            //you can use any function
        }



        //FUNCTION FOR CAR
        public static void GetAllTestForCar()
        {
            CarManager carManager = new CarManager(new EfCarDAL());
            List<Car> cars = carManager.GetAll();

            foreach (var car in cars)
            {
                Console.WriteLine("ID : " + car.Id);
                Console.WriteLine("MARKA ID : " + car.BrandId);
                Console.WriteLine("RENK ID : " + car.ColorId);
                Console.WriteLine("GÜNLÜK ÜCRET : " + car.DailyPrice);
                Console.WriteLine("MODEL YILI : " + car.ModelYear);
                Console.WriteLine("AÇIKLAMA : " + car.Information);
                Console.WriteLine("------------------------------------------");
            }
        }

        public static void GetDetailTestForCar()
        {
            CarManager carManager = new CarManager(new EfCarDAL());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("ID : " + car.Id);
                Console.WriteLine("MARKA : "+ car.BrandName);
                Console.WriteLine("RENK ADI : " + car.ColorName);
                Console.WriteLine("MODEL YILI : " + car.ModelYear);
                Console.WriteLine("AÇIKLAMA : " + car.Information);
                Console.WriteLine("------------------------------------------");
            }
        }

        public static void AddingForCar(Car car)
        {
            CarManager carManager = new CarManager(new EfCarDAL());
            carManager.Add(car);
           
        }

        public static void DeleteForCar(Car car)
        {
            CarManager carManager = new CarManager(new EfCarDAL());
            carManager.Delete(car);

        }

        public static void UpdatingForCar(Car car)
        {
            CarManager carManager = new CarManager(new EfCarDAL());
            carManager.Update(car);

        }

        public static void GetByIdForCar(int carId)
        {
            CarManager carManager = new CarManager(new EfCarDAL());
            Car car=carManager.GetById(carId);
            Console.WriteLine("ID : " + car.Id);
            Console.WriteLine("MARKA ID : " + car.BrandId);
            Console.WriteLine("RENK ID : " + car.ColorId);
            Console.WriteLine("GÜNLÜK ÜCRET : " + car.DailyPrice);
            Console.WriteLine("MODEL YILI : " + car.ModelYear);
            Console.WriteLine("AÇIKLAMA : " + car.Information);
            Console.WriteLine("------------------------------------------");

        }

        
    }
}
