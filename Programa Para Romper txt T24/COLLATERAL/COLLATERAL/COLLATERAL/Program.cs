using System;
using System.IO;

namespace COLLATERAL
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\COLLATERAL\COLLATERAL.MOCK1.1.V2.TXT"))
            {
                string file = sr.ReadToEnd();
                var eachLine = file.Split("DO00");
                string resultGerencial_COLLATERAL = "";
                int count = 0;

                foreach (var line in eachLine)
                {
                    if (line != "")
                    {
                        string completeLine = "DO00" + line;
                        string primero = completeLine.Substring(0);

                        resultGerencial_COLLATERAL += primero + "\n";
                        count++;
                    }
                    Console.WriteLine(count);
                }

                //Escribiendo archivo
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Collateral\", "resultGerencial_COLLATERAL.txt")))
                {
                    outputFile.WriteLine(resultGerencial_COLLATERAL.Replace("||", ","));
                }
                Console.ReadKey();
            }
        }
    }
}
