using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(@"{0}--{1}-----{2}---{3} TL",car.ModelName,car.ModelYear,car.Description,car.DailyPrice);
            }
        }
    }
}
