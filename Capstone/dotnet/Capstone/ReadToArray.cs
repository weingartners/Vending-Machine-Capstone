using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class ReadToArray
    {
        public string FullPath { get; private set; } = @"C:\Users\Student\workspace\module1-capstone-c-team-2\Capstone\dotnet\vendingmachine.csv";

        public void ReadToArrayMethod()
        {
            try
            {
                List<string> lineList = new List<string>();

                using (StreamReader sr = new StreamReader(FullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        string[] lineArray = line.Split("|");

                        string lineItem = lineArray.ToString();

                        lineList.Add(lineItem);

                        lineItem = lineItem;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); 
            }
        }
    }
}
