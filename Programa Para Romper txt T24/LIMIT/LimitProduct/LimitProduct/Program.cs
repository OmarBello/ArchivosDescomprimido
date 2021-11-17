using System;
using System.IO;

namespace LimitProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\LIMIT\LIMIT.PRODUCTO.Mock1.V1.txt"))
            {
                string file = sr.ReadToEnd();
                var eachLine = file.Split("DO00");
                string resultGerencial_LIMIT_PRODUCTO = "";
                int count = 0;

                foreach (var line in eachLine)
                {
                    if (line != "")
                    {
                        string completeLine = "DO00" + line;
                        string primero = completeLine.Substring(0);

                        resultGerencial_LIMIT_PRODUCTO += primero + "\n";
                        count++;
                    }
                    Console.WriteLine(count);
                }
                //Escribiendo archivo
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Limit\", "resultGerencial_LIMIT_PRODUCTO.txt")))
                {
                    outputFile.WriteLine(resultGerencial_LIMIT_PRODUCTO.Replace("||", ","));
                }
                Console.ReadKey();
            }
        }
    }
}
