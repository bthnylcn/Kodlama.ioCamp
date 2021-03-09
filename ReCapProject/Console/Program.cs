using System;
using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
           CarDetailsTest();
            //CarAdd();
            //CarDelete();
            //CarUpdate();
            
        }

        private static void CarUpdate()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car {  Id=20, ModelName = "Range Rover", DailyPrice = 900, BrandId = 5, ColorId = 2 });
        }

        private static void CarDelete()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car { Id = 32 });
        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car {  ModelName = "Megane", ModelYear = 2012, DailyPrice = 120, Description = "Günlük", ColorId = 3,BrandId=1  });
            
           
        }
        private static void CarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails().Data)
            {
                
                Console.WriteLine(@"{0}-{1}-{2}-{3}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
            }
            Console.WriteLine(carManager.GetCarDetails().Message);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(@"{0}--{1}-----{2}---{3} TL", car.ModelName, car.ModelYear, car.Description, car.DailyPrice);
            }
        }
    }
}
