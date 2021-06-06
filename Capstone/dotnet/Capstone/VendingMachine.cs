using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {
        public decimal Balance { get; set; }

        public Dictionary<string, Item> Inventory { get; private set; }

        public AuditLog auditLog { get; set; }

        public VendingMachine()
        {
            auditLog = new AuditLog();
            ReadToArray readToArray = new ReadToArray();
            Inventory = readToArray.LoadInventory();
        }

        public decimal DispenseChange(decimal balance)
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
            auditLog.Transactions.Add($"{DateTime.Now} GIVE CHANGE: ${Balance} $0.00");
            Console.WriteLine($"Dispensing {quarters} quarters, {dimes} dimes, and {nickles} nickles");
            Balance = 0;
            return balance;
        }

        public void AddMoney() 
        {
            try
            {
                decimal moneyInput = decimal.Parse(Console.ReadLine());

                if (moneyInput > 1000)
                {
                    Console.WriteLine("Stop trying to break me, Joe! $1,000 TOPS!");
                }
                else if (moneyInput % 1 == 0 && moneyInput > 0)
                {
                    Console.Clear();
                    Balance += moneyInput;
                    Console.WriteLine();
                    Console.WriteLine($"Your current balance is now ${Balance}");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid amount entered");
                    Console.WriteLine($"Your current balance is {Balance}");
                }
                Console.WriteLine("ENTER to continue...");
                Console.ReadLine();

                auditLog.Transactions.Add($"{DateTime.Now} FEED MONEY: ${moneyInput} ${Balance}");
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid dollar amount. \nENTER to continue...");
                Console.ReadLine();
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
                    if (item.Value.Price <= Balance)
                    {
                        Console.WriteLine();

                        item.Value.Stock--;
                        auditLog.Transactions.Add($"{DateTime.Now} {item.Value.Name.ToUpper()} {item.Key} ${Balance} ${Balance - item.Value.Price}");
                        auditLog.PurchaseHistory.Add($"{item.Value.Name} | {5 - item.Value.Stock} \n**TOTAL SALES** ${item.Value.Price}");
                        Balance -= item.Value.Price;

                        Console.Clear();
                        Console.WriteLine(item.Value.Message());
                        Console.WriteLine($"Your remaining balance is {Balance}");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"YOU'RE BROKE, TRY AGAIN!");
                        Console.ReadLine();
                        break;
                    }
                }
            }
        }
    }
}
