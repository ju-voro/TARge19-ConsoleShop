using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop
{
    enum Category
    {
        PASTRY,
        DAIRY,
        CONFECTIONERY,
        CANNED_FOOD,
        MEAT,
        FISH,
        FRUIT,
        VEGGIE,
        TOILETRIES,
        BEVERAGES

    }
    class Article
    {
        string name;
        Category category;
        double price;

        public Article(string _name, Category _category, double _price)
        {
            name = _name;
            category = _category;
            price = _price;
        }

        public string Name
        {
            get { return name; }
        }

        public string Category
        {
            get { return category.ToString(); }
        }

        public double Price
        {
            get { return price; }
        }

    }
}
