using System;
using System.IO;

namespace Capture_Bill
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\LOANS\Capture_Bill_V2_Mock1.txt"))
            {
                string file = sr.ReadToEnd();
                var eachLine = file.Split("DO00");
                string resultGerencial_Capture_Bill = "";
                int count = 0;

                foreach (var line in eachLine)
                {
                    if (line != "")
                    {
                        string completeLine = "DO00" + line;
                        string primero = completeLine.Substring(0, completeLine.IndexOf("||BALANCE.MAINTENANCE||")).Replace("||BALANCE.MAINTENANCE||", " ");
                        resultGerencial_Capture_Bill += primero + "\n";
                        count++;
                    }
                    Console.WriteLine(count);


                }
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Loans\", "resultGerencial_Capture_Bill.txt")))
                {
                    outputFile.WriteLine("dbum,AAA_ID,ARRANGEMENT,ACTIVITY,EFFECTIVE.DATE,PRODUCT,");
                    outputFile.WriteLine(resultGerencial_Capture_Bill.Replace("||", ","));
                }
                Console.ReadKey();


            }

        }
    }
}