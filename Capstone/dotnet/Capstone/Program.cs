using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {

            ReadToArray loadInventory = new ReadToArray();

            Dictionary<string, Item> inventory = loadInventory.LoadInventory();

            double userMoney = 0;

            //    ReadToArray loadInventory = new ReadToArray();

            //    Dictionary<string, Item> inventory = loadInventory.LoadInventory();

            //    double userMoney = 0;
            //    string display = $"1) Display Vending Machine Items \n2) Purchase \n3) Exit";

            //    while (true)
            //    {
            //        Console.WriteLine(display);
            //        string userInput = Console.ReadLine();

            //        while (userInput != "3")
            //        {
            //            if (userInput == "1")
            //            {
            //                Console.WriteLine();

            //                foreach (KeyValuePair<string, Item> item in inventory)
            //                {
            //                    Console.WriteLine($"{item.Value.Identifier} {item.Value.Name} {item.Value.Price} Stock: {item.Value.Stock}");
            //                }
            //                break;
            //            }
            //            else if (userInput == "2")
            //            {
            //                Console.WriteLine();
            //                Console.WriteLine($"Your current balance is ${userMoney}");
            //                Console.WriteLine();

            //                Console.WriteLine($"1) Add Money \n2) Select Your Desired Product \n3) Finish Transaction");
            //                Console.WriteLine();

            //                string userOptionInput = Console.ReadLine();

            //                while (true)
            //                {
            //                    if (userOptionInput == "1")
            //                    {
            //                        Console.WriteLine();
            //                        Console.WriteLine("Please Enter A Desired Whole Dollar Amount of Money");
            //                        Console.WriteLine();

            //                        userMoney += double.Parse(Console.ReadLine());

            //                        Console.WriteLine();
            //                        Console.WriteLine($"Your current balance is now ${userMoney}");
            //                        break;
            //                    }
            //                    else if (userOptionInput == "2")
            //                    {
            //                        Console.WriteLine();

            //                        foreach (KeyValuePair<string, Item> item in inventory)
            //                        {
            //                            Console.WriteLine($"{item.Value.Identifier} {item.Value.Name} {item.Value.Price} Stock: {item.Value.Stock}");
            //                        }

            //                        Console.WriteLine();
            //                        string userDesiredProduct = Console.ReadLine();
            //                        Console.WriteLine();

            //                        foreach (KeyValuePair<string, Item> item in inventory)
            //                        {
            //                            if (userDesiredProduct.ToLower() == item.Key.ToLower())
            //                            {
            //                                Console.WriteLine();
            //                                Console.WriteLine(item.Value.Message());

            //                                item.Value.Stock--;
            //                                userMoney -= item.Value.Price;
            //                            }
            //                        }
            //                        break;
            //                    }
            //                    else if (userOptionInput == "3")
            //                    {
            //                        Console.WriteLine($"Your change is ${userMoney}, have a wonderful day!");
            //                        break;
            //                    }
            //                }                    
            //            }
            //            else if (userInput == "4")
            //            {

            //            }
            //        }
            //    }

            Menu mainMenu = new Menu("1", "2", "3");
            SubMenu subMenu = new SubMenu("1", "2", "3");

            mainMenu.OpenMenu();
            string userInput = Console.ReadLine();

                if (mainMenu.Option1 == userInput)
                {
                    mainMenu.MenuOption1(inventory);
                }
                else if (mainMenu.Option2 == userInput)
                {
                while (true)
                {
                    mainMenu.MenuOption2();
                    string userSubInput = Console.ReadLine();

                    if (userSubInput == subMenu.Option1)
                    {
                        subMenu.SubMenuOption1(userMoney);

                    }
                    else if (userSubInput == subMenu.Option2)
                    {
                        if (userMoney > 0)
                        {
                            subMenu.SubMenuOption2(inventory, userMoney);      
                        }
                        else
                        {
                            Console.WriteLine("Please deposit more money.");
                        }

                    }
                    else if (userSubInput == subMenu.Option3)
                    {
                        subMenu.SubMenuOption3(userMoney);
                    }
                }
                }
                else if (mainMenu.Option3 == userInput)
                {
                    mainMenu.MenuOption3();
                }
        }
    }
}
