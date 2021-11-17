using System;
using System.IO;

namespace Capture_Bill_Dist_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\LOANS\Capture_Bill_Dist_Mock1_V2.txt"))
            {
                string file = sr.ReadToEnd();
                var eachLine = file.Split("DO00");
                string resultGerencial_Capture_Bill_Dist_Prope = "";
                int count = 0;

                foreach(var line in eachLine)
                {
                    if(line != "")
                    {
                        string completeLine = "DO00" + line;
                        string segundo = "";

                        if (completeLine.Contains("NEW!!"))
                        {
                            segundo = completeLine.Substring(completeLine.IndexOf("NEW!!")).Replace("NEW!!", "NEW!!");
                        }

                        resultGerencial_Capture_Bill_Dist_Prope += segundo + "\n";
                        count++;
                    }
                    Console.WriteLine(count);
                }
                //Escribiendo archivo
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Loans\", "resultGerencial_Capture_Bill_Dist_Property.txt")))
                {
                    outputFile.WriteLine(resultGerencial_Capture_Bill_Dist_Prope.Replace("!!", ","));
                }

                Console.ReadKey();
            }
        }
    }
}
