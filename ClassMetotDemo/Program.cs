using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Kobe";
            customer1.Surname = "Bryant";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Lebron";
            customer2.Surname = "James";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Allen";
            customer3.Surname = "Iverson";

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.Name = "Shaquille";
            customer4.Surname = "O'Neal";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
            customerManager.List();
            Console.WriteLine("--------------");
            customerManager.Delete(customer1);
            customerManager.List();
        }
    }
}
