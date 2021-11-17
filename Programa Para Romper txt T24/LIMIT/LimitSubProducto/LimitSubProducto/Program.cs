using System;
using System.IO;

namespace LimitSubProducto
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\LIMIT\LIMIT.SUBPRODUCTO.2.Mock1.V2.TXT"))
            {
                string file = sr.ReadToEnd();
                var eachLine = file.Split("DO00");
                string resultGerencial_LIMIT_SUBPRODUCTO = "";
                int count = 0;

                foreach (var line in eachLine)
                {
                    if (line != "")
                    {
                        string completeLine = "DO00" + line;
                        string primero = completeLine.Substring(0);

                        resultGerencial_LIMIT_SUBPRODUCTO += primero + "\n";
                        count++;
                    }
                    Console.WriteLine(count);
                }
                //Escribiendo archivo
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Limit\", "resultGerencial_LIMIT_SUBPRODUCTO.txt")))
                {
                    outputFile.WriteLine(resultGerencial_LIMIT_SUBPRODUCTO.Replace("||", ","));
                }
                Console.ReadKey();
            }
        }
    }
}
