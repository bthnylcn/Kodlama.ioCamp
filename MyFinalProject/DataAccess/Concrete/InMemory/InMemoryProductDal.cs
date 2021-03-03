using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            //Oracle,Sql server,Postgres,MongoDb
            _products = new List<Product>
                 {
                     new Product{ProductId=1,CategoryId=1,ProductName="Mouse",UnitPrice=15,UnitsInStock=15},
                     new Product{ProductId=2,CategoryId=1,ProductName="Keyboard",UnitPrice=500,UnitsInStock=3},
                     new Product { ProductId = 3, CategoryId = 2, ProductName = "Chair", UnitPrice = 1500, UnitsInStock = 2 },
                     new Product { ProductId = 4, CategoryId = 2, ProductName = "Table", UnitPrice = 150, UnitsInStock = 65 },
                     new Product { ProductId = 5, CategoryId = 2, ProductName = "Book", UnitPrice = 85, UnitsInStock = 1 },

                 };
        }
        public void Add(Product product)
        {
            _products.Add(product);
            
        }

        public void Delete(Product product)
        {
            
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

      

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

      

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _products;
        }
    }
}
