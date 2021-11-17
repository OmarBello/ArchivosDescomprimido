using System;
using System.IO;

namespace Capture_Bill_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\LOANS\Capture_Bill_V2_Mock1.txt"))
            {
                string file = sr.ReadToEnd();
                var eachLine = file.Split("DO00");
                string resultGerencial_Capture_Bill_Property = "";
                int count = 0;

                foreach (var line in eachLine)
                {
                    if (line != "")
                    {
                        string completeLine = "DO00" + line;
                        string segundo = "";

                        if (completeLine.Contains("NEW!!"))
                        {
                            segundo = completeLine.Substring(completeLine.IndexOf("NEW!!"));
                        }
                        resultGerencial_Capture_Bill_Property += segundo + "\n";
                        count++;
                    }



                }
                Console.WriteLine(count);
                //Escribiendo archivo
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Loans\", "resultGerencial_Capture_Bill_Property.txt")))
                {
                    outputFile.WriteLine(resultGerencial_Capture_Bill_Property.Replace("!!", ","));
                }
                Console.ReadKey();

            }
        }
    }
}
