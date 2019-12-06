using System;

namespace MyShop
{
    class Program
    {
        static void Main(string[] args)
        {

            Warehouse currentlyInStock = new Warehouse();
            currentlyInStock.PrintInStock();

            Console.ReadLine();
        }
    }
}
