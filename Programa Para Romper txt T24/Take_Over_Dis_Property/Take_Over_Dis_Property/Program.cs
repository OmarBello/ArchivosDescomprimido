using System;
using System.IO;

namespace Take_Over_Dis_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\LOANS\Take_Over_Dist_Mock1_V4.txt"))
            {
                string file = sr.ReadToEnd();
                var eachLine = file.Split("DO00");
                int count = 0;
                string resultGerencialTake_Over_Dist_Pro = "";
        
                foreach (var line in eachLine)
                {
                    if(line != "")
                    {
                        string completeLine = "DO00" + line;
                     
                        string segundo = "";
                        

                        if (completeLine.Contains("YEAR.PENALTY||"))
                        {
                            segundo = completeLine.Substring(completeLine.IndexOf("YEAR.PENALTY||")).Replace("YEAR.PENALTY||", "");
                        }
                        else
                        {
                            segundo = completeLine.Substring(completeLine.IndexOf("FACILITY.SIB||")).Replace("FACILITY.SIB||", "");
                        }
                     

                        resultGerencialTake_Over_Dist_Pro += segundo + "\n";
                        
                        count++;
                    }
                    //Console.WriteLine(count);
                    Console.WriteLine(count);
                }
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Loans\", "resultGerencialTake_Over_Dist_Property.txt")))
                {
                    outputFile.WriteLine(resultGerencialTake_Over_Dist_Pro.Replace("!!", ","));
                    
                }
               
                Console.ReadKey();
            }
        }
    }
}
