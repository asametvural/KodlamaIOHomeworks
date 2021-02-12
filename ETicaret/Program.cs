using System;

namespace ETicaret
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Apple";
            product1.ProductPrice = 11000;

            Product product2 = new Product();
            product2.Id = 2;
            product2.ProductName = "Samsung";
            product2.ProductPrice = 8000;

            Product product3 = new Product();
            product3.Id = 3;
            product3.ProductName = "Apple";
            product3.ProductPrice = 5000;

            Product[] products = new Product[] { product1, product2, product3 };

            //Foreach
            foreach (var product in products)
            {
                Console.WriteLine(product.Id + ". " + product.ProductName + " " + product.ProductPrice + " TL.");
            }
            Console.WriteLine("------------------------------");

            //For
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Id + ". " + products[i].ProductName + " " + products[i].ProductPrice + " TL.");
            }
            Console.WriteLine("------------------------------");

            //While
            int j = 0;
            while (j < products.Length)
            {
                Console.WriteLine(products[j].Id + ". " + products[j].ProductName + " " + products[j].ProductPrice + " TL.");
                j++;
            }
        }
    }
}
