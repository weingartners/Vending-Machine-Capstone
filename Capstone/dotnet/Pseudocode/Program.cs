//using System;

//namespace Pseudocode
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Four types of items in machine: candy, chips, bevs, gum -- name and price for each

//            On bootup:
//                1) Display Vending Machine Items -- display all items and stock amount -- stock starts at 5 on open -- if stock 0, display sold out

//                2) Purchase -- also display sold out if stock 0

//                    (1) Feed Money -- input in whole dollars - display current money provided 
//                    (2) Select Product -- display all products, select product #, if # not valid or sold out, print message and try again -- if valid #, dispense -- print name, cost, money remaining -- stock update, return to purchase menu 
//                                chips prints "Crunch Crunch, Yum!", candy prints "Munch Munch, Yum!", drink prints "Glug Glug, Yum!", gum prints "Chew Chew, Yum!"
//                    step 3) Finish Transaction -- return change using nickles, dimes, quarters using smallest number of coins possible -- current money to 0 -- return to main menu

//                3) Exit 

//                4) (hidden) writes to log file, prints file - purchase history -- 2 log files, one to overwrite, one to append (overall)
//                    file requirements: date, time

//            To stock machine:
//                //C:\Users\Student\workspace\module1-capstone-c-team-2\Capstone\dotnet\vendingmachine.csv
//                reading from vendingmachine.csv

//                Log -- any time money in machine changes, write to log.txt


//        }
//    }
//}
