using System;
using System.IO;

namespace capture_balance
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\LOANS\capture_balance_Mock1_V1.txt"))
            {
                string file = sr.ReadToEnd();
                var eachLine = file.Split("DO00");
                string resultGerencial_capture_balance = "";
                int count = 0;

                foreach (var line in eachLine)
                {
                    if (line != "")
                    {
                        string completeLine = "DO00" + line;
                        string primero = completeLine.Substring(0, completeLine.IndexOf("||BALANCE.MAINTENANCE||"));

                        resultGerencial_capture_balance += primero + "\n";
                        count++;
                    }
                    Console.WriteLine(count);
                   
                }

                //Escribiendo archivo
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Loans\", "resultGerencial_capture_balance.txt")))
                {
                    outputFile.WriteLine("UPLOAD.COMPANY,AAA_ID,ARRANGEMENT,ACTIVITY,EFFECTIVE_DATE,PRODUCT");
                    outputFile.WriteLine(resultGerencial_capture_balance.Replace("||", ","));
                }
                Console.ReadKey();
            }
        }
    }
}
