using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop
{
    class ShoppingCart
    {
        List<Item> shoppingCart;

        public ShoppingCart()
        {
            shoppingCart = new List<Item>();
        }

        public void AddToShoppingCart(Article article, int quantity)
        {
            Item newItem = new Item(article, quantity);
            shoppingCart.Add(newItem);
        }

        public void PrintShoppingCart()
        {
            foreach(Item item in shoppingCart)
            {
                Console.WriteLine($"{item.Article}");
            }
        }
    }
}
