using System;
using System.IO;

namespace Take_Over
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\LOANS\Take_Over_Mock1_V3.txt"))
            {
                string file = sr.ReadToEnd();
                var eachLine = file.Split("DO00");
                string resultGerencialTake_Over = "";
                int count = 0;

                foreach(var line in eachLine)
                {
                    if (line != "")
                    {
                        string completeLine = "DO00" + line;
                        string primero = completeLine.Substring(0, completeLine.IndexOf("||||"));

                        resultGerencialTake_Over += primero + "\n";
                        count++;
                    }
                    Console.WriteLine(count);
                   
                }
                //Escribiendo archivo
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Loans\", "resultGerencialTake_Over.csv")))
                {
                    outputFile.WriteLine("UPLOAD_COMPANY,AAA_ID,ARRANGEMENT,ACTIVITY,EFFECTIVE_DATE,CUSTOMER,CUSTOMER_ROLE,PRODUCT,CURRENCY,ORIG_CONTRACT_DATE");
                    outputFile.WriteLine(resultGerencialTake_Over.Replace("||", ","));
                }
                Console.ReadKey();
            }
        }
    }
}
