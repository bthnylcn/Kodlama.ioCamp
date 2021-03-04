using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : ICarDal
    {
        List<Car> _cars;
        /*Global bir _product adında liste tanımladık.Bu normalde veri tabanından gelicek
         Bunu bir constructor içinde tanımlayarak InMemoryProductDal referansı çağırıldığı an
        bu listenin oluşmasını sağlıyoruz*/
        public InMemoryProductDal()
        {
            _cars = new List<Car> {
               new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=100,ModelYear=2018,Description="Günlük kiralık Nissan Qasqai" },
               new Car{CarId=2,BrandId=2,ColorId=2,DailyPrice=200,ModelYear=2019,Description="Günlük kiralık Renault Clio" },
               new Car{CarId=3,BrandId=3,ColorId=1,DailyPrice=500,ModelYear=2020,Description="Günlük kiralık Seat Leon" }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete); ;
        }

        public Car Get(Expression<Func<Car, bool>> filter)
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

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

    }
}
