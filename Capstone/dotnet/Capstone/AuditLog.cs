using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class AuditLog
    {
        public List<string> Transactions { get; set; } = new List<string>();

        public List<string> PurchaseHistory { get; set; } = new List<string>();

        public void WriteToAuditFile(List<string> transactions)
        {
            string fullPath = @"C:\Users\LJ\Desktop\Workspace\module1-capstone-c-team-2\Capstone\dotnet\Capstone\bin\Debug\netcoreapp3.1\Log.txt";

            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath))
                {
                    foreach (string item in transactions)
                    {
                        sw.WriteLine(item);
                    }
                } 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void WriteToSalesLog(List<string> purchaseHistory)
        {
            string fullPath = @"C:\Users\LJ\Desktop\Workspace\module1-capstone-c-team-2\Capstone\dotnet\Capstone\bin\Debug\netcoreapp3.1\Saleslog.txt";

            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath))
                {
                    foreach (string item in purchaseHistory)
                    {
                        sw.WriteLine(item);
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
