using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Candy : Item
    {
        public Candy(string identifier, string name, decimal price, string type, int stock) : base(identifier, name, price, type, stock)
        {

        }

        public override string Message()
        {
            return "Munch Munch, Yum!";
        }
    }
}
