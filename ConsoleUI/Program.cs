using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddCar();
            CarProductManager carProductManager = new CarProductManager(new EfCarDal());
             
            
            Console.WriteLine("-----İsimler-----");

            
            var result = carProductManager.GetAll();
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName);
            }


            Console.WriteLine("-----Renkler-----");

            
            carProductManager.GetAll();
            foreach (var car in carProductManager.GetAll().Data)
            {
                Console.WriteLine(car.ColorId);
            }

            
            var result1 = carProductManager.GetCarDetails();
            foreach (var car3 in result1)
            {
                Console.WriteLine(car3.CarName + "/" + car3.BrandName +" /" + car3.CarName );

            }

            


            Console.WriteLine("Hello World!");
        }

        private static void AddCar()
        {
            CarProductManager car1 = new CarProductManager(new EfCarDal());
            car1.Add(new Car { Id = 5, BrandId = 2, ColorId = 3, DailyPrice = 100, Description = "cok guzel", ModelYear = 1996, CarName = "Kia",  });

            CarProductManager car2 = new CarProductManager(new EfCarDal());
            car2.Add(new Car { Id = 6, ColorId = 5, DailyPrice = 300, Description = "fena", ModelYear = 2005, CarName = "Opel" , BrandId = 2});


        }



    }
}
