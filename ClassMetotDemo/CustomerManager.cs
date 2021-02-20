using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        List<Customer> customers = new List<Customer>();
        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
        public void List()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id + "-) Customer : " + customer.Name + " " + customer.Surname);
            }
        }
        public void Delete(Customer customer)
        {
            customers.Remove(customer);
        }
    }
}
