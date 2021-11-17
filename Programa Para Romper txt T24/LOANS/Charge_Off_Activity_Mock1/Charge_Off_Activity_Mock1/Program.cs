using System;
using System.IO;

namespace Charge_Off_Activity_Mock1
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\LOANS\Charge_Off_Activity_Mock1_V1.txt"))
            {
                string file = sr.ReadToEnd();
                var eachLine = file.Split("DO00");
                string resultadoGerenciaCharge_Off_Activicty = "";
                int count = 0;

                foreach(var line in eachLine)
                {
                    if(line != "")
                    {
                        string completeLine = "DO00" + line;
                        //string primero = completeLine.Substring(0, completeLine.Length);

                        resultadoGerenciaCharge_Off_Activicty += completeLine + "\n";
                        count++;
                    }
                    Console.WriteLine(count);
                }
                //Escribiendo archivo
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Loans\", "resultadoGerenciaCharge_Off_Activicty.txt")))
                {
                    outputFile.WriteLine(resultadoGerenciaCharge_Off_Activicty.Replace("||", ","));
                }
                Console.ReadKey();
            }
        }
    }
}
