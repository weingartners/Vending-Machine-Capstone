using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    class Item
    {
        public string Identifier { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Type { get; set; }

        public Item(string identifier, string name, double price, string type)
        {
            Identifier = identifier;
            Name = name;
            Price = price;
            Type = type;


        }



    }
}
