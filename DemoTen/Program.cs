using DemoTen.Models;
#region Declaration
//Object class

Product product = new Product();

string name;
double price;
int qty;
#endregion

#region AddProducts
//Input
Console.WriteLine("Enter product name");
name = Console.ReadLine();

Console.WriteLine("Enter product price");
price = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter product quantity");
qty = Convert.ToInt32(Console.ReadLine());
#endregion

#region Printing
//Use Functions
//Print name
product.GetInfo(name);

//Print name and price
product.GetInfo(name, price);

//Print name, price and quantity
product.GetInfo(name, price, qty);

#endregion


#region Loop to display products
Console.WriteLine("No. products: ");
int count = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <=count; i++)
{
    Console.WriteLine("Enter product name");
    string ProductName = Console.ReadLine();

    Console.WriteLine("Enter product price");
    double Price = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter product quantity");
    int Qty = Convert.ToInt32(Console.ReadLine());

    product.AddProduct(ProductName, Price, Qty);
}
product.DisplayProducts();

#endregion