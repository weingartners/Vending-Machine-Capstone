using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    class Gum : Item
    {
        public Gum(string identifier, string name, double price, string type, int stock) : base(identifier, name, price, type, stock)
        {

        }
        
        public override string Message()
        {
            return "Chew Chew, Yum!";
        }
    }
}
