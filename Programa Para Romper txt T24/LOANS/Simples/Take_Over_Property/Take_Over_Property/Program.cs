using System;
using System.IO;

namespace Take_Over_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("MENU DE OPCIONES");
                Console.WriteLine("\n "+
                    "\n 1.- Sacar el resultado de la primera parte del archivo Take_Over_Mock1_V3.txt"+
                    "\n 2.- Sacar el resultado de la segunda parte del archivo Take_Over_Mock1_V3.txt"+
                    "\n 5.- Salir \n");
                Console.Write("Digite una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        using (StreamReader sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\LOANS\Take_Over_Mock1_V3.txt"))
                        {
                            string file = sr.ReadToEnd();
                            var eachLine = file.Split("DO00");
                            int count = 0;
                            string resultGerencialTake_Over_Property = "";

                            foreach (var line in eachLine)
                            {
                                if (line != "")
                                {
                                    string completeLine = "DO00" + line;
                                    string segundo = "";

                                    if (completeLine.Contains("YEAR.PENALTY||"))
                                    {
                                        segundo = completeLine.Substring(completeLine.IndexOf("YEAR.PENALTY||")).Replace("YEAR.PENALTY||", "");
                                    }
                                   
                                    resultGerencialTake_Over_Property += segundo + "\n";
                                    count++;
                                }
                                Console.WriteLine(count);
                            }

                            using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Loans\", "resultGerencialTake_Over_Property_parte1.csv")))
                            {
                                outputFile.WriteLine("ALT_ID,ACCOUNT_REFERENCE,AMOUNT,MATURITY_DATE,PAYMENT_TYPE_2_1,PAYMENT_METHOD_2_1,PAYMENT_FREQ_2_1,PROPERTY_2_1,PROPERTY_2_2,ACTUAL_AMT_2_1,START_DATE_2_1,END_DATE_2_1,FIXED_RATE,MARGIN_RATE,PERIODIC_RATE,PERIODIC_INDEX,PERIODIC_PERIOD_TYPE,FLOATING_INDEX,MARGIN_OPER,PERIODIC_RESET,INITIAL_RESET_DATE,PERIODIC_PERIOD,DAY_BASIS,PAYIN_SETTLEMENT,PAYIN_ACCOUNT,PAYOUT_SETTLEMENT,PAYOUT_ACCOUNT,LT_DISB_ACCT,LT_AA_PAY_IN,STATUS_TIDOM,NO_TIDOM,CIIU_ID,ECONOMIC_GROUP,PROVINCE,MUNICIPALITY,MUN_DISTRICT,PROD_SECTOR,APPROACH_ID,SOURCE_FUNDS,RESOL_YEAR,ORIGIN_VALUE,FACILITY_SIB,SOLD_LOAN,STATUS_NEW,RESTRUCT_DATE,CLASIF_REST,REASONS_RESTRUCT,PRODUCTS_CANCEL,BALANCE_CANCEL,EXTENDED_STATUS,YEAR_PENALTY");
                                outputFile.WriteLine(resultGerencialTake_Over_Property.Replace("!!", ",").Replace("::", ","));
                            }

                            Console.ReadKey();
                        }
                        break;

                    case 2:
                        using (StreamReader sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\LOANS\Take_Over_Mock1_V3.txt"))
                        {
                            string file = sr.ReadToEnd();
                            var eachLine = file.Split("DO00");
                            int count = 0;
                            string resultGerencialTake_Over_Property = "";

                            foreach (var line in eachLine)
                            {
                                if (line != "")
                                {
                                    string completeLine = "DO00" + line;
                                    string segundo = "";

                                   
                                    if(completeLine.Contains("FACILITY.SIB||"))
                                    {
                                        segundo = completeLine.Substring(completeLine.IndexOf("FACILITY.SIB||")).Replace("FACILITY.SIB||", "");
                                    }
                                    resultGerencialTake_Over_Property += segundo + "\n";
                                    count++;
                                }
                                Console.WriteLine(count);
                            }

                            using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Loans\", "resultGerencialTake_Over_Property_Parte2.csv")))
                            {
                                outputFile.WriteLine("ALT_ID,ACCOUNT_REFERENCE,AMOUNT,MATURITY_DATE,PAYMENT_TYPE_2_1,PAYMENT_METHOD_2_1,PAYMENT_FREQ_2_1,PROPERTY_2_1,PROPERTY_2_2,ACTUAL_AMT_2_1,START_DATE_2_1,END_DATE_2_1,FIXED_RATE,MARGIN_RATE,PERIODIC_RATE,PERIODIC_INDEX,PERIODIC_PERIOD_TYPE,FLOATING_INDEX,MARGIN_OPER,PERIODIC_RESET,INITIAL_RESET_DATE,PERIODIC_PERIOD,DAY_BASIS,PAYIN_SETTLEMENT,PAYIN_ACCOUNT,PAYOUT_SETTLEMENT,PAYOUT_ACCOUNT,LT_DISB_ACCT,LT_AA_PAY_IN,STATUS_TIDOM,NO_TIDOM,CIIU_ID,ECONOMIC_GROUP,PROVINCE,MUNICIPALITY,MUN_DISTRICT,PROD_SECTOR,APPROACH_ID,SOURCE_FUNDS,RESOL_YEAR,ORIGIN_VALUE,FACILITY_SIB");
                                outputFile.WriteLine(resultGerencialTake_Over_Property.Replace("!!", ",").Replace("::", ","));
                            }

                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        Console.WriteLine("Bye...");
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Elija una opcion correcta.");
                        Console.WriteLine();
                        break;
                }
            } while (opcion != 3);


            Console.ReadKey();
        }
    }
}
