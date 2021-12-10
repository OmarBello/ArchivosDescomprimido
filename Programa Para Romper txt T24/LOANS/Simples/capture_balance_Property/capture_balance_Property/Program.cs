using System;
using System.IO;

namespace capture_balance_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\LOANS\capture_balance_Mock1_V1.txt"))
            {
                string file = sr.ReadToEnd();
                var eachLine = file.Split("DO00");
                string resultGerencial_capture_balance_Property = "";
                int count = 0;

                foreach (var line in eachLine)
                {

                    if (line != "")
                    {
                        string completeLine = "DO00" + line;
                        string segundo = "";

                        if (completeLine.Contains("ACCOUNT!!"))
                        {
                            segundo = completeLine.Substring(completeLine.IndexOf("ACCOUNT!!")).Replace("ACCOUNT!!", "ACCOUNT!!");
                        }
                        resultGerencial_capture_balance_Property += segundo + "\n";
                        count++;
                    }


                    Console.WriteLine(count);
                }
                //Escribiendo archivo
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Loans\", "resultGerencial_capture_balance_Property.txt")))
                {
                    outputFile.WriteLine("ADJUST_PROP_1_1,ADJUST_PROP_2_1,ADJ_BAL_TYPE_1_1,ADJ_BAL_TYPE_2_1,NEW_BAL_AMT_1_1,NEW_BAL_AMT_2_1");
                    outputFile.WriteLine(resultGerencial_capture_balance_Property.Replace("!!", ","));
                }
                Console.ReadKey();
            }
        }
    }
}
