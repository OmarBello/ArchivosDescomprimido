using System;
using System.IO;

namespace ADJUST_BILL_DIST
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\LOANS\ADJUST_BILL_DIST_Mock1_V1.txt"))
            {
                string file = sr.ReadToEnd();
                var eachLine = file.Split("DO00");
                string resultGerencial_ADJUST_BILL_DIST = "";
                int count = 0;

                foreach (var line in eachLine)
                {
                    if (line != "")
                    {
                        string completeLine = "DO00" + line;
                        string primero = completeLine.Substring(0);

                        resultGerencial_ADJUST_BILL_DIST += primero + "\n";
                        count++;
                    }
                    Console.WriteLine(count);
                }
                //Escribiendo archivo
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Loans\", "resultGerencial_ADJUST_BILL_DIST.txt")))
                {
                    outputFile.WriteLine(resultGerencial_ADJUST_BILL_DIST.Replace("||", ","));
                }
                Console.ReadKey();
            }
        }
    }
}
