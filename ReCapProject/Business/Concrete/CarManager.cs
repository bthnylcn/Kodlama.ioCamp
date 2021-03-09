using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {
            if ((car.ModelName.Length < 2) && (car.DailyPrice <= 100))
            {
                return new ErrorResult(Messages.ProductNameInvalid);
                
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.ProductAdded);

        }
        public IResult Update(Car car)
        {
            if ((car.ModelName.Length < 2) && (car.DailyPrice <= 0))
            {
                return new ErrorResult(Messages.ProductNameInvalid);

            }
            _carDal.Update(car);
            return new SuccessResult(Messages.ProductUpdated);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult< List < Car >> (_carDal.GetAll());
        }

        public IDataResult<List<Car>> GetById(int carId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.Id == carId));
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult < List < CarDetailDto >> (_carDal.GetCarDetails());
        }

        public IResult Delete(Car car)
        {
            if (DateTime.Now.Hour == 18)
            {
                return new ErrorResult(Messages.MaintenanceTime);

            }
            _carDal.Delete(car);
            return new SuccessResult(Messages.ProductDeleted);

        }
    }
}
