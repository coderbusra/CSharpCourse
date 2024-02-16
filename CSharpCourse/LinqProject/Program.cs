using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Catagory> categories = new List<Catagory>
            {
                new Catagory{CategoryId= 1, CatagoryName="Bilgisayar" },
            };

            List<Product> products = new List<Product> {
                new Product
                {
                    ProductId= 1,
                    CategoryId=1,
                    ProductName = "Acer Laptop",
                    QuantityPerUnit="32 GB Ram",
                    UnitPrice   =10000,
                    UnitsInStock=5,
                } ,
                new Product
                {
                    ProductId= 1,
                    CategoryId=2,
                    ProductName = "HP Laptop",
                    QuantityPerUnit="32 GB Ram",
                    UnitPrice   =5000,
                    UnitsInStock=5,
                } ,
                new Product
                {
                    ProductId= 1,
                    CategoryId=3,
                    ProductName = "Monster Laptop",
                    QuantityPerUnit="4 GB Ram",
                    UnitPrice   =1000,
                    UnitsInStock=5,
                } ,
                new Product
                {
                    ProductId= 1,
                    CategoryId=4,
                    ProductName = "Apple Laptop",
                    QuantityPerUnit="8 GB Ram",
                    UnitPrice   =20000,
                    UnitsInStock=15,
                } ,
                new Product
                {
                    ProductId= 1,
                    CategoryId=5,
                    ProductName = "Asus Laptop",
                    QuantityPerUnit="16 GB Ram",
                    UnitPrice   =15000,
                    UnitsInStock=50,
                } 
            };

            Console.WriteLine("Algoritmik-----------");
            foreach(var product in products)
            {
                if(product.UnitPrice > 5000 && product.UnitsInStock>5) 
                {
                    Console.WriteLine(product.ProductName);
                }
            }

            Console.WriteLine("Linq------------");

            var result = products.Where(product=> product.UnitPrice>5000 && product.UnitsInStock>5);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            Getproducts(products);
            Console.ReadLine();
        }

        //Linq olmadan
        static List<Product> Getproducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 5)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            return filteredProducts;
        }

        //Linq Olursa
        static List<Product> GetProducts(List<Product> products)
        {
            return products.Where(product => product.UnitPrice > 5000 && product.UnitsInStock > 3).ToList();
        }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Catagory
    {
        public int CategoryId { get; set; }
        public string CatagoryName { get; set; }
    }
}
