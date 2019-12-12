using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop
{
    class Item
    {
        Article article;
        int quantity;

        public Item(Article _article, int _quantity) {
            article = _article;
            quantity = _quantity;
        }

        public string Article {
            get { return $"ID: {article.Id} \n Name: {article.Name} \n Category: {article.Category} " +
                    $"\n Price: {article.Price}\n Quantity: {quantity}"; }
        }

        public double CalculateItemTotal()
        {
            return article.Price * quantity;
        }

    }
}
