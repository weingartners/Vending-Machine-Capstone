using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    class VendingMachine
    {
        public decimal Balance { get; set; }

       

        public Dictionary<string, Item> Inventory { get; private set; }

        public VendingMachine()
        {
            ReadToArray readToArray = new ReadToArray();
            Inventory = readToArray.LoadInventory();
        }

        public void DispenseChange(decimal balance)
        {
            int quarters = 0;
            int dimes = 0;
            int nickles = 0;


            while (balance > 0)
            {
                if (balance >= 0.25M)
                {
                    balance -= 0.25M;
                    quarters++;
                }
                else if (balance >= 0.10M)
                {
                    balance -= 0.10M;
                    dimes++;
                }
                else if (balance >= 0.05M)
                {
                    balance -= 0.05M;
                    nickles++;
                }
            }
            Console.WriteLine($"Dispensing {quarters} quarters, {dimes} dimes, and {nickles} nickles");
        }

        public void AddMoney()
        {
            
            decimal moneyInput = decimal.Parse(Console.ReadLine());
            if (moneyInput % 1 == 0)
            {
                Balance += moneyInput;
                Console.WriteLine();
                Console.WriteLine($"Your current balance is now ${Balance}");
            }
            else
            {
                Console.WriteLine("Invalid amount entered");
                Console.WriteLine($"Your current balance is {Balance}");
            }
        }

        public void VendAndSubtract()
        {
            Console.WriteLine();
            string userDesiredProduct = Console.ReadLine();
            Console.WriteLine();

            foreach (KeyValuePair<string, Item> item in Inventory)
            {
                if (userDesiredProduct.ToLower() == item.Key.ToLower())
                {
                    Console.WriteLine();
                    Console.WriteLine(item.Value.Message());

                    item.Value.Stock--;
                    Balance -= item.Value.Price;
                    Console.WriteLine($"Your remaining balance is {Balance}");
                }
                else
                {
                    Console.WriteLine("Please enter valid item ID");
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}
