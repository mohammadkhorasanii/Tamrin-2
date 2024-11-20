// See https://aka.ms/new-console-template for more information
using System;

namespace ProductPriceChecker 
{
    class Kala
    {
        public int Price { get; set; }

        
        public void GetProductsCount()
        {
            Console.Write("Enter the number of products: ");
            int productsCount = int.Parse(Console.ReadLine());
            ProcessProducts(productsCount);
        }

        
        private void ProcessProducts(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter the price of product {i + 1}: ");
                Price = int.Parse(Console.ReadLine());

                string category = GetPriceCategory();
                Console.WriteLine($"Product {i + 1} is: {category}");
            }
        }

        
        private string GetPriceCategory()
        {
            if (Price >= 1000)
                return "Very Expensive";
            else if (Price >= 900)
                return "Expensive";
            else if (Price >= 700)
                return "Good";
            else if (Price >= 600)
                return "Very Good";
            else if (Price >= 500)
                return "Cheap";
            else 
                return "Very Cheap";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Kala kala = new Kala();
            
           
            kala.GetProductsCount();
            
            
            
        }
    }
}
