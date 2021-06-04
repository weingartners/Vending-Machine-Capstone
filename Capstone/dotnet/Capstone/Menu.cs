using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Menu
    {
        public string Option1 { get; set; }

        public string Option2 { get; set; }

        public string Option3 { get; set; }

        public Menu(string option1, string option2, string option3)
        {
            Option1 = option1;
            Option2 = option2;
            Option3 = option3;
        }

        public void OpenMenu()
        {

            Console.WriteLine($"1) Display Vending Machine Items \n2) Purchase \n3) Exit");

    
        }

        public void MenuOption1(Dictionary<string, Item> dictionary)
        {
            
            foreach (KeyValuePair<string, Item> item in dictionary)
            {
                Console.WriteLine($"{item.Value.Identifier} {item.Value.Name} {item.Value.Price} Stock: {item.Value.Stock}");
            }

        }

        public void MenuOption2()
        {
            
            //Console.WriteLine($"Your current balance is ${userMoney}");

            Console.WriteLine($"1) Add Money \n2) Select Your Desired Product \n3) Finish Transaction");

            //string userInput = Console.ReadLine();

            //ReadToArray loadInventory = new ReadToArray();

            //Dictionary<string, Item> inventory = loadInventory.LoadInventory();

            //double userMoney = 0;

            //while (userInput != "3")
            //{
            //    Console.WriteLine($"1) Add Money \n2) Select Your Desired Product \n3) Finish Transaction");
            //    userInput = Console.ReadLine();

            //    if (userInput == "1")
            //    {
            //        SubMenuOption1(userMoney);
            //    }
            //    else if (userInput == "2")
            //    {
            //        SubMenuOption2(inventory, userMoney);
            //    }
            //    else if (userInput == "3")
            //    {
            //        SubMenuOption3(userMoney);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter a valid entry");
            //    }
            //}
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
            Console.Clear();

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
            Console.Clear();
            Console.WriteLine($"Your change is ${userMoney}, have a wonderful day!");
        }

        public void MenuOption3()
        {
           
            Console.WriteLine("Thank you for shopping with us.");
        }
    }
}
