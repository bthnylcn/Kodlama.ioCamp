using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

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
               new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=1000,ModelYear=2015,Description="Öğretmenden satılık temiz 2.El Corolla" },
               new Car{CarId=2,BrandId=2,ColorId=1,DailyPrice=2000,ModelYear=2020,Description="Doktordan satılık temiz 2.El Avensis" },
               new Car{CarId=3,BrandId=1,ColorId=2,DailyPrice=5000,ModelYear=2021,Description="Galeriden satılık sıfır 3008" }
            };
        }
        
        public void Add(Car car)
        {/*Add fonksiyonu bizim global olan _product listemize bu fonksiyona verilen product
          objesini ekleyecek*/
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> Getall()
        {
            return _cars;//herhangi bi parametre verilmicek.Direkt return edicek bize
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)//liste dönücek
        {
            return _cars.Where(p => p.CarId == Id).ToList();/*where metodu IEnumarable döner
            onu da ToList ile listeye çevirip return ettik*/
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            /*Burada _product listesindeki Id ile parametrenin Id si eşit olunca
             adresini pdoductToUpdateye atıyoruz ardırdan güncelliyoruz*/
        }

        
    }
}
