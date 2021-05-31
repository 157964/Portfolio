using System;
using System.Linq;
using Northwind.Data;

namespace Test
{
    class Program
    {
        private readonly static string _connectionstring = @"Server=(localdb)\MSSQLLocalDB;Database=Northwind";

        static void Main(string[] args)
        {
            ToonProducts();
        }

        private static void ToonProducts()
        {
            var dbProducts = new NorthwindDBContext(_connectionstring);
            var producten = dbProducts.Products.ToList();

            foreach (var product in producten)
            {
                Console.WriteLine(String.Format("Naam: {0,-35} | Id: {1, -2}", product.ProductName, product.ProductID));
            }
        }
    }
}
