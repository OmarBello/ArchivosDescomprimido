using System;
using System.IO;

namespace COLLATERALRIGHT
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\COLLATERAL\COLLATERAL.RIGHT.MOCK1.V1.TXT"))
            {
                string file = sr.ReadToEnd();
                var eachLine = file.Split("DO00");
                string resultGerencial_COLLATERAL_RIGHT = "";
                int count = 0;

                foreach(var line in eachLine)
                {
                    if(line != "")
                    {
                        string completeLine = "DO00" + line;
                        string primero = completeLine.Substring(0);

                        resultGerencial_COLLATERAL_RIGHT += primero + "\n";
                        count++;
                    }
                    Console.WriteLine(count);
                }

                //Escribiendo archivo
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Collateral\", "resultGerencial_COLLATERAL_RIGHT.txt")))
                {
                    outputFile.WriteLine(resultGerencial_COLLATERAL_RIGHT.Replace("||", ","));
                }
                Console.ReadKey();
            }
        }
    }
}
