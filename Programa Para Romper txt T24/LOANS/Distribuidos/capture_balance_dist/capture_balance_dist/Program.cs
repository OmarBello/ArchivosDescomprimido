using System;
using System.IO;

namespace capture_balance_dist
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\LOANS\capture_balance_dist_Mock1_V1.TXT"))
            {
                string file = sr.ReadToEnd();
                var eachLine = file.Split("DO00");
                string resultGerencial_capture_balance_dist = "";
                int count = 0;

                foreach(var line in eachLine)
                {
                    if(line != "")
                    {
                        string completeLine = "DO00" + line;
                        string primero = completeLine.Substring(0, completeLine.IndexOf("||BALANCE.MAINTENANCE||"));

                        resultGerencial_capture_balance_dist += primero + "\n";
                        count++;
                    }
                    Console.WriteLine(count);
                }
                //Escribiendo archivo
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Loans\", "resultGerencial_capture_balance_dist.txt")))
                {
                    outputFile.WriteLine("UPLOAD_COMPANY,AAA ID,ARRANGEMENT,ACTIVITY,EFFECTIVE_DATE,PRODUCT");
                    outputFile.WriteLine(resultGerencial_capture_balance_dist.Replace("||", ","));
                }

                Console.ReadKey();
            }
        }
    }
}
