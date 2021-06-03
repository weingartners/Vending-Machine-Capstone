using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Chip : Item
    {
        public Chip(string identifier, string name, double price, string type, int stock) : base(identifier, name, price, type, stock)
        {

        }

        public override string Message()
        {
            return "Crunch Crunch, Yum!";
        }
    }
}
