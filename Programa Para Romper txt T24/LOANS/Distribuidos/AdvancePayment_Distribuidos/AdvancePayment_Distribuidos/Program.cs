using System;
using System.IO;

namespace AdvancePayment_Distribuidos
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\LOANS\AdvancePayment_Distribuidos_Mock1_V1.txt"))
            {

                string file = sr.ReadToEnd();
                var eachLine = file.Split("L");
                string resultGerencial_AdvancePayment_Distribuidos = "";
                int count = 0;

                foreach (var line in eachLine)
                {
                    if (line != "")
                    {
                        string completeLine = "L" + line;
                        string primero = completeLine.Substring(0);

                        resultGerencial_AdvancePayment_Distribuidos += primero + "\n";
                        count++;
                    }
                    Console.WriteLine(count);
                }

                //Escribiendo archivo
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Loans\", "resultGerencial_AdvancePayment_Distribuidos.txt")))
                {
                    outputFile.WriteLine("CREDIT_ACCOUNT,DEBIT_CCY,DEBIT_VALUE_DATE,PAYMENT_CURRENCY,PAYMENT_AMOUNT,PAYMENT_EXECUTION_DATE,ADDITIONAL_INFO,ORDERING_PAYMENT_TRESUARY_RATE");
                    outputFile.WriteLine(resultGerencial_AdvancePayment_Distribuidos.Replace("||", ","));
                }
                Console.ReadKey();
            }

        }
    }
}
