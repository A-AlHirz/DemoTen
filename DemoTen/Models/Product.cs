using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//class  product  3  functions Name of products/ price and name/ name price quantity of the product & total
namespace DemoTen.Models
{
    public class Product
    {

        public void GetInfo(string name)
        {

            Console.WriteLine($"Product Name: {name}");
        }

        public void GetInfo(string name, double price)
        {
            Console.WriteLine(($"Product Name: {name}, Price: {price}"));
        }

        public void GetInfo(string name, double price, int qty)
        {
            Console.WriteLine(($"Product Name: {name}, Price: {price}, Qty: {qty} , Total: {CalcTotal(qty,price)}"));
        }
        public int CalcTotal(int qty, double price)
        {
            return (int)(qty * price);
        }

        

        //Add List of Products
        public string Name { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public bool InStock { get; set; }

        //Declare List of products
        List<Product> products = new List<Product>();

        public void AddProduct(string name, double price, int qty, bool inStock)
        {
            products.Add(new Product { Name = name, Price = price, Qty = qty, InStock = inStock });
        }

        public void DisplayProducts()
        {
            int countIn=0;

            Console.WriteLine("-----------------Products-----------------");
            foreach (Product item in products)
            {
                if (item.InStock)
                {
                    countIn++;
                    Console.WriteLine($"Product Name: {item.Name}, Price: {item.Price}, Qty: {item.Qty}, Total: {CalcTotal(item.Qty, item.Price)}, In Stock ");

                }
                else
                {
                    Console.WriteLine($"Product Name: {item.Name}, Price: {item.Price}, Qty: {item.Qty}, Total: {CalcTotal(item.Qty, item.Price)}, Out of Stock ");
                }
            }

            Console.WriteLine("Total items: " + products.Count+"and in stock "+countIn + "out of stock " +(products.Count - countIn));
        } 

    }

}
