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

        //Declare List of products
        List<Product> products = new List<Product>();

        public void AddProduct(string name, double price, int qty)
        {
            products.Add(new Product { Name = name, Price = price, Qty = qty });
        }

        public void DisplayProducts()
        {
            Console.WriteLine("-----------------Products-----------------");
            foreach (Product item in products)
            {
                Console.WriteLine($"Product Name: {item.Name}, Price: {item.Price}, Qty: {item.Qty}, Total: {CalcTotal(item.Qty, item.Price)}");
            }
        }



    }

}
