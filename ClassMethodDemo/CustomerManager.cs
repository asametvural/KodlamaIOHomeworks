using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi. " + customer.Name + " " + customer.LastName);
        }

        public void List(Customer customer)
        {
            Console.WriteLine("Müşteri listelendi. " + customer.Name + " " + customer.LastName);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri silindi. " + customer.Name + " " + customer.LastName);
        }
    }
}
