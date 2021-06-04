using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    class VendingMachine
    {
        public double Balance { get; set; }

        public Dictionary<string, Item> Inventory { get; private set; }

        public VendingMachine(double balance)
        {
            ReadToArray readToArray = new ReadToArray();
            Inventory = readToArray.LoadInventory();
            Balance = balance;

        }
    }
}
