using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if ((car.ModelName.Length >= 2) && (car.DailyPrice > 0))
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Araba modeli kayıt kurallarına uymuyor!\n" +
                    "-Araba modeli 2 harftan fazla olmalı.\n" +
                    "-Günlük fiyat 0'dan büyük olmalı.");
            }
        }
        public void Update(Car car)
        {
            if ((car.Description.Length >= 2) && (car.DailyPrice > 0))
            {
                _carDal.Update(car);
            }
            else
            {
                Console.WriteLine("Araba modeli kayıt kurallarına uymuyor!\n" +
                    "-Araba modeli 2 harftan fazla olmalı.\n" +
                    "-Günlük fiyat 0'dan büyük olmalı.");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int carId)
        {
            return _carDal.GetAll(c => c.CarId == carId);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
