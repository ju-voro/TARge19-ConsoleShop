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

        public void RemoveFromShoppingCart(int id)
        {
            for(int i = 0; i<shoppingCart.Count; i++)
            {
                if(shoppingCart[i].Article.Id == id)
                {
                    Console.WriteLine($"{shoppingCart[i].Article.Name} has been removed.");
                    shoppingCart.Remove(shoppingCart[i]);
                }
            }
            PrintShoppingCart();
        }
        public void PrintShoppingCart()
        {
            if(shoppingCart.Count == 0)
            {
                Console.WriteLine("Shopping Cart is empty");
            } else
            {
                foreach (Item item in shoppingCart)
                {
                    item.PrintItem();
                }
            }
            
        }

       
    }
}
