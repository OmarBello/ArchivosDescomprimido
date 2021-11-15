using System;
using System.IO;

namespace Charge_Off_Activity_Dist
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\LOANS\Charge_Off_Activity_Dist_Mock1_V1.txt"))
            {
                string file = sr.ReadToEnd();
                var eachLine = file.Split("DO00");
                string resultGerencialCharge_Off_Activity_Dist = "";
                int count = 0;

                foreach(var line in eachLine)
                {
                    if(line != "")
                    {
                        string completeLine = "DO00" + line;
                        string primero = completeLine.Substring(0, completeLine.Length);

                        resultGerencialCharge_Off_Activity_Dist += primero + "\n";
                        count++;
                    }
                    Console.WriteLine(count);
                }
                //Escribiendo archivo
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Loans\", "resultGerencialCharge_Off_Activity_Dist.txt")))
                {
                    outputFile.WriteLine(resultGerencialCharge_Off_Activity_Dist.Replace("||", ","));
                }

                Console.ReadKey();
            }
        }
    }
}
