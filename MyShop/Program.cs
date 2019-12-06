using System;

namespace MyShop
{
    class Program
    {
        static void Main(string[] args)
        {

            Warehouse currentlyInStock = new Warehouse();
            ShoppingCart shoppingCart = new ShoppingCart();
            currentlyInStock.PrintInStock();

            Console.WriteLine("Enter the id of the product to add it to the shopping cart: ");
            int productID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of items to add to the shopping cart: ");
            int quantity = int.Parse(Console.ReadLine());

            Article articleToAdd = currentlyInStock.GetFromStock(productID);
            shoppingCart.AddToShoppingCart(articleToAdd, quantity);
            shoppingCart.PrintShoppingCart();


            Console.ReadLine();
        }
    }
}
