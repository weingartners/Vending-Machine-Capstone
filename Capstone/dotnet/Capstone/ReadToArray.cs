using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class ReadToArray
    {
        public string FullPath { get; set; } = @"C:\Users\Student\workspace\module1-capstone-c-team-2\Capstone\dotnet\Capstone\bin\Debug\netcoreapp3.1\vendingmachine.txt";


        public Dictionary<string, Item> LoadInventory()
        {

            Dictionary<string, Item> dictionaryOfItems = new Dictionary<string, Item>();

            try
            {
                using (StreamReader sr = new StreamReader(FullPath))

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        string[] lineArray = line.Split("|");

                        if (lineArray[3].Contains("Gum"))
                        {
                            Gum gum = new Gum(lineArray[0], lineArray[1], double.Parse(lineArray[2]), lineArray[3], 5);
                            dictionaryOfItems[lineArray[0]] = gum;
                        }
                        else if (lineArray[3].Contains("Chip"))
                        {
                            Chip chip = new Chip(lineArray[0], lineArray[1], double.Parse(lineArray[2]), lineArray[3], 5);
                            dictionaryOfItems[lineArray[0]] = chip;
                        }
                        else if (lineArray[3].Contains("Drink"))
                        {
                            Drink drink = new Drink(lineArray[0], lineArray[1], double.Parse(lineArray[2]), lineArray[3], 5);
                            dictionaryOfItems[lineArray[0]] = drink;
                        }
                        else if (lineArray[3].Contains("Candy"))
                        {
                            Candy candy = new Candy(lineArray[0], lineArray[1], double.Parse(lineArray[2]), lineArray[3], 5);
                            dictionaryOfItems[lineArray[0]] = candy;
                        }
                    }
                return dictionaryOfItems;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); 
            }
            return dictionaryOfItems;
        }
    }
}
