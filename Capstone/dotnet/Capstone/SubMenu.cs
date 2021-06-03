using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    class SubMenu : Menu
    {
        public SubMenu(string option1, string option2, string option3) : base(option1, option2, option3)
        {
            Option1 = option1;
            Option2 = option2;
            Option3 = option3;
        }

        public void SubMenuOption1(double userMoney)
        {
            Console.WriteLine("Please Enter A Desired Whole Dollar Amount of Money");

            userMoney += double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Your current balance is now ${userMoney}");
        }

        public void SubMenuOption2(Dictionary<string, Item> dictionary, double userMoney)
        {
            Console.WriteLine();

            foreach (KeyValuePair<string, Item> item in dictionary)
            {
                Console.WriteLine($"{item.Value.Identifier} {item.Value.Name} {item.Value.Price} Stock: {item.Value.Stock}");
            }

            Console.WriteLine();
            string userDesiredProduct = Console.ReadLine();
            Console.WriteLine();

            foreach (KeyValuePair<string, Item> item in dictionary)
            {
                if (userDesiredProduct.ToLower() == item.Key.ToLower())
                {
                    Console.WriteLine();
                    Console.WriteLine(item.Value.Message());

                    item.Value.Stock--;
                    userMoney -= item.Value.Price;
                }
            }
        }

        public void SubMenuOption3(double userMoney)
        {
            Console.WriteLine($"Your change is ${userMoney}, have a wonderful day!");
        }
    }
}
