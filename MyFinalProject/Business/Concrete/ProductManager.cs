using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _ProductDal;

        public ProductManager(IProductDal iProductDal)
        {
            _ProductDal = iProductDal;
        }

        public List<Product> GetAll()
        {
            //Business codes
            return _ProductDal.GetAll();
        }
    }
}
