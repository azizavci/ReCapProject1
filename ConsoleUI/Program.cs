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
            
            CarManager carManager = new CarManager(new EfCarDAL());
            List<Car> cars = carManager.GetAll();

            foreach (var car in cars)
            {
                Console.WriteLine("ID : "+car.Id);
                Console.WriteLine("MARKA ID : "+car.BrandId);
                Console.WriteLine("RENK ID : " + car.ColorId);
                Console.WriteLine("GÜNLÜK ÜCRET : " + car.DailyPrice);
                Console.WriteLine("MODEL YILI : " + car.ModelYear);
                Console.WriteLine("AÇIKLAMA : " + car.Information);
                Console.WriteLine("------------------------------------------");
            }
            
            Console.ReadLine();
        }
    }
}
