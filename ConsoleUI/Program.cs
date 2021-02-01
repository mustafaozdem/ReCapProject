using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarProductManager carProductManager = new CarProductManager(new InMemoryCarProductDal());

            foreach (var car in carProductManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
