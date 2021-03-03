using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(40,50))
            {
                //console output == x-----y
                Console.WriteLine("{0}----{1}",product.ProductName,product.UnitPrice);
            }
            
        }
    }
}
