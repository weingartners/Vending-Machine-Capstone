using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public abstract class Item
    {
        public string Identifier { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Type { get; set; }

        public int Stock { get; set; } = 5;

        public Item(string identifier, string name, decimal price, string type, int stock)
        {
            Identifier = identifier;
            Name = name;
            Price = price;
            Type = type;
            Stock = stock;
        }

        public abstract string Message();

    }
}
