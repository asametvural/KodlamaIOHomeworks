using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 01;
            customer1.Tc = "11111111111";
            customer1.Name = "Sezer";
            customer1.LastName = "Yılmaz";
            customer1.City = "Edirne";

            Customer customer2 = new Customer();
            customer2.Id = 02;
            customer2.Tc = "22222222222";
            customer2.Name = "Metin";
            customer2.LastName = "Yılmaz";
            customer2.City = "Trabzon";

            Customer customer3 = new Customer();
            customer3.Id = 03;
            customer3.Tc = "33333333333";
            customer3.Name = "Celal";
            customer3.LastName = "Güner";
            customer3.City = "Ankara";


            CustomerManager customerManager = new CustomerManager();

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.List(customer3);
            Console.WriteLine("");
            foreach (var c in customers)
            {
                Console.WriteLine(c.Id + " " + c.Name + " " + c.LastName + " " + c.City);
            }
        }
    }
}
