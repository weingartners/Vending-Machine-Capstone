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
            double currentBalance = 0;

            VendingMachine vendingMachine = new VendingMachine(currentBalance);

            Menu mainMenu = new Menu("1", "2", "3");

            string keepMenuOpen = "";

            while (keepMenuOpen != "3")
            {
                mainMenu.OpenMenu();
                Console.WriteLine();
                keepMenuOpen = Console.ReadLine();

                if (keepMenuOpen == "1")
                {
                    mainMenu.MenuOption1(vendingMachine.Inventory);
                }

                if (keepMenuOpen == "2")
                {
                    mainMenu.MenuOption2(); // method with while loop
                    string userInput = Console.ReadLine();
                    

                    while (userInput != "3")
                    {
                        Console.WriteLine($"1) Add Money \n2) Select Your Desired Product \n3) Finish Transaction");
                        userInput = Console.ReadLine();

                        if (userInput == "1")
                        {
                            mainMenu.SubMenuOption1(currentBalance);
                        }
                        else if (userInput == "2")
                        {
                            mainMenu.SubMenuOption2(vendingMachine.Inventory, currentBalance);
                        }
                        else if (userInput == "3")
                        {
                            mainMenu.SubMenuOption3(currentBalance);
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid entry");
                        }
                    }

                }
                
            }
            

        }
    }
}

















































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



//            mainMenu.OpenMenu();
//            string userInput = Console.ReadLine();

//            //if (mainMenu.Option1 == userInput)
//            switch (userInput)
//            {





//                {
//                mainMenu.MenuOption1(inventory);


//                else if (mainMenu.Option2 == userInput)
//                {
//                    while (true)
//                    {
//                        mainMenu.MenuOption2();
//                        string userSubInput = Console.ReadLine();

//                        if (userSubInput == subMenu.Option1)
//                        {
//                            subMenu.SubMenuOption1(userMoney);

//                        }
//                        else if (userSubInput == subMenu.Option2)
//                        {
//                            if (userMoney > 0)
//                            {
//                                subMenu.SubMenuOption2(inventory, userMoney);
//                            }
//                            else
//                            {
//                                Console.WriteLine("Please deposit more money.");
//                            }

//                        }
//                        else if (userSubInput == subMenu.Option3)
//                        {
//                            subMenu.SubMenuOption3(userMoney);
//                        }
//                    }

//                    case "3":
//                return false;

//                } 
//    }
//}
