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
                if (item.Value.Stock <= 0)
                {
                    Console.WriteLine($"{item.Value.Identifier} {item.Value.Name} {item.Value.Price} Stock: SOLD OUT");
                }
                else
                {
                    Console.WriteLine($"{item.Value.Identifier} {item.Value.Name} {item.Value.Price} Stock: {item.Value.Stock}");
                }
            }

        }

        public void MenuOption2()
        {

            Console.WriteLine($"1) Add Money \n2) Select Your Desired Product \n3) Finish Transaction");

        }
        public void MenuOption3()
        {

            Console.WriteLine("Thank you for shopping with us.");
        }

        public void SubMenuOption1(decimal userMoney)
        {

            Console.WriteLine("Please Enter A Desired Whole Dollar Amount of Money");

            
        }

        public void SubMenuOption2(Dictionary<string, Item> dictionary)
        {
            Console.Clear();

            foreach (KeyValuePair<string, Item> item in dictionary)
            {
                if (item.Value.Stock <= 0)
                {
                    Console.WriteLine($"{item.Value.Identifier} {item.Value.Name} {item.Value.Price} Stock: SOLD OUT");
                }
                else
                {
                    Console.WriteLine($"{item.Value.Identifier} {item.Value.Name} {item.Value.Price} Stock: {item.Value.Stock}");
                }
            }

            
        }

        public void SubMenuOption3(decimal userMoney)
        {
            Console.Clear();
            Console.WriteLine($"Your change is ${userMoney}, have a wonderful day!");
        }
    }
}
