using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    class Drink : Item
    {
        public Drink(string identifier, string name, decimal price, string type, int stock) : base(identifier, name, price, type, stock)
        {

        }

        public override string Message()
        {
            return "Glug Glug, Yum!";
        }
    }
}
