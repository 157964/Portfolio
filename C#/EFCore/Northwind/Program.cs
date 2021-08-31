using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Data;

namespace Northwind
{
    class Program
    {
        private readonly static string _connectionstring = @"Server=(localdb)\MSSQLLocalDB;Database=Northwind";

        private readonly static string[] _Opdrachten = {"ToonCategories", "ToonProducts", "ToonGekozenProducten", "ToonProductenGebaseertOpCategoryName", "ToonSuppliers","ToonItemsVanSupplier"};

        static void Main(string[] args)
        {
            HaalVolledigeOrderOp();
            //KiesActie();
            //ToonCategories();
            //ToonProducts();
            //ToonGekozenProducten();
            //ToonProductenGebaseertOpCategoryName();
            //ToonSuppliers();
            //ToonItemsVanSupplier();
        }

        private static void KiesActie()
        {
            Console.WriteLine("Type -H for a list of commands");
            try
            {
                string keuze = Console.ReadLine();

                if (keuze == "-H")
                {
                    var i = 1;
                    foreach(string opdracht in _Opdrachten)
                    {
                        Console.WriteLine(String.Format("{0, -2}: {1, -20}", i, opdracht));
                        i++;
                    }
                    Console.WriteLine("0 : Exit");
                    KiesActie();
                }
                else
                {
                    var parseKeuze = int.Parse(keuze);
                    switch (parseKeuze)
                    {
                        case 1:
                            ToonCategories();
                            KiesActie();
                            break;
                        case 2:
                            ToonProducts();
                            KiesActie();
                            break;
                        case 3:
                            ToonGekozenProducten();
                            KiesActie();
                            break;
                        case 4:
                            ToonProductenGebaseertOpCategoryName();
                            KiesActie();
                            break;
                        case 5:
                            ToonSuppliers();
                            KiesActie();
                            break;
                        case 6:
                            ToonItemsVanSupplier();
                            KiesActie();
                            break;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Kies een geldig getal");
                KiesActie();
            }
        }

        private static void ToonCategories()
        {
            var db = new NorthwindDBContext(_connectionstring);
            var categories = db.Categories.ToList();

            foreach(var category in categories)
            {
                Console.WriteLine("{0}: {1}", category.CategoryID, category.CategoryName);
            }
        }

        private static void ToonProducts()
        {
            var dbProducts = new NorthwindDBContext(_connectionstring);
            var producten = dbProducts.Products.ToList();

            foreach(var product in producten)
            {
                Console.WriteLine(String.Format("Naam: {0,-35} | Id: {1, -2}", product.ProductName, product.ProductID));
            }
        }

        private static void ToonGekozenProducten()
        {
            Console.WriteLine("Voer een ProductID in (getal)");
            try
            {
                var keuze = Console.ReadLine();
                var Pkeuze = int.Parse(keuze);

                var dbProducts = new NorthwindDBContext(_connectionstring);
                var GekozenProduct = dbProducts.Products.Where(ID => ID.ProductID == Pkeuze);

                foreach(var item in GekozenProduct)
                {
                    Console.WriteLine(item.ProductName);
                }
            }
            catch
            {
                Console.WriteLine("Voer een geldig getal in");
                ToonGekozenProducten();
            }
        }
        
        private static void ToonProductenGebaseertOpCategoryName()
        {
            var dbProducts = new NorthwindDBContext(_connectionstring);
            var CategoryWithProducts = dbProducts.Products
                .Include(category1 => category1.Category)
                .ToList();

            foreach (var product in CategoryWithProducts)
            {
                Console.WriteLine(String.Format("|Naam: {0, -35} |Id: {1, -2} |Category: {2, -20}|", product.ProductName, product.ProductID, product.Category.CategoryName));
            }
        }

        private static void ToonSuppliers()
        {
            var dbSuppliers = new NorthwindDBContext(_connectionstring);
            var suppliers = dbSuppliers.Suppliers
                .Include(product => product.Products)
                .ToList();
            var i = 1;
            foreach(var supplier in suppliers)
            {
                Console.WriteLine(String.Format("{0, -2}: |Supplier: {1, -40}|",i ,supplier.CompanyName));
                foreach(var product in supplier.Products)
                {
                    Console.WriteLine(String.Format("    |Product: {0, -25}", product.ProductName));
                }
                i++;
            }
        }
        
        private static void ToonItemsVanSupplier()
        {
            Console.WriteLine("Zoek op ID: ");
            try
            {
                var keuze = int.Parse(Console.ReadLine());
                var dbSuppliers = new NorthwindDBContext(_connectionstring);
                var suppliers = dbSuppliers.Suppliers
                    .Include(product => product.Products)
                    .Where(ID => ID.SupplierID == keuze)
                    .ToList();

                foreach(var item in suppliers)
                {
                    Console.WriteLine("Companyname: {0}", item.CompanyName);
                    foreach(var product in item.Products)
                    {
                        Console.WriteLine("Product: {0}", product.ProductName);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Geef een geldig getal op");
                ToonItemsVanSupplier();
            }
        }

        private static void ToonOrder(int orderID)
        {
            Console.Clear();
            OrderHeader(orderID);
            OrderDetails(orderID);
        }

        private static void OrderHeader(int orderID)
        {
            var orderDb = new NorthwindDBContext(_connectionstring);
            var gekozenOrder = orderDb.Orders
                .Include(customer => customer.Customer)
                .Where(order => order.OrderID == orderID)
                .ToList();
            
            foreach(var item in gekozenOrder)
            {
                object[] query = {item.Customer.CompanyName, 
                                  item.Customer.ContactName, 
                                  item.Customer.Address, 
                                  item.Customer.City, 
                                  item.OrderID, 
                                  item.OrderDate}; 

                foreach(var Iquery in query)
                {
                    Console.WriteLine(Iquery);
                }
            }

            Console.WriteLine();

        }

        private static void OrderDetails(int orderID)
        {
            var orderDB = new NorthwindDBContext(_connectionstring);
            var gekozenOrder = orderDB.OrderDetails
                .Include(order => order.Product)
                .Where(order => order.OrderID == orderID)
                .ToList();
            
            foreach(var item in gekozenOrder)
            {
                var prijs = Decimal.Round(item.UnitPrice, 2);
                var total = item.Quantity * prijs;

                Console.WriteLine(String.Format($"Naam: {item.Product.ProductName, -50}|Aantal: {item.Quantity, -10}|Prijs: {prijs, -10}|Totaal: {total}"));
            }
        }

        private static int HaalOrderID()
        {
            Console.WriteLine("Geef een ID op (tussen 10248 en 11077)");
            try
            {
                var OrderID = Console.ReadLine();
                int parseOrderID = int.Parse(OrderID);

                return parseOrderID;
            }
            catch
            {
                Console.WriteLine("Geef een geldig getal op");
                HaalOrderID();
                return 0;
            }
        }

        private static void HaalVolledigeOrderOp()
        {
            int orderID = HaalOrderID();
            ToonOrder(orderID);
        }
    }
}
