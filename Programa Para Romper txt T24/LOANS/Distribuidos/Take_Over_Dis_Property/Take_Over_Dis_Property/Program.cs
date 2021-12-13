using System;
using System.IO;

namespace Take_Over_Dis_Property
{
    class Program
    {
        //Omar recuerda que para este archivo hay prestamos que no traen su detalle y terminan con esto ||||||||
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("MENU DE OPCIONES");
                Console.WriteLine("\n " +
                    "\n 1.- Sacar el resultado de la primera parte del archivo Take_Over_Dist_Mock1_V4.txt" +
                    "\n 2.- Sacar el resultado de la segunda parte del archivo Take_Over_Dist_Mock1_V4.txt" +
                    "\n 5.- Salir \n");
                Console.Write("Digite una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        using (StreamReader sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\LOANS\Take_Over_Dist_Mock1_V4.txt"))
                        {
                            string file = sr.ReadToEnd();
                            var eachLine = file.Split("DO00");
                            int count = 0;
                            string resultGerencialTake_Over_Dist_Pro = "";

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
                                   


                                    resultGerencialTake_Over_Dist_Pro += segundo + "\n";

                                    count++;
                                }
                                //Console.WriteLine(count);
                                Console.WriteLine(count);
                            }
                            using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Loans\", "resultGerencialTake_Over_Dist_Property.txt")))
                            {
                                outputFile.WriteLine("ALT_ID,ACCOUNT_REFERENCE,AMOUNT,MATURITY_DATE,PAYMENT_TYPE_2_1,PAYMENT_TYPE_3_1,PAYMENT_TYPE_4_1,PAYMENT_TYPE_5_1,PAYMENT_TYPE_6_1,PAYMENT_TYPE_7_1,PAYMENT_METHOD_2_1,PAYMENT_METHOD_3_1,PAYMENT_METHOD_4_1,PAYMENT_METHOD_5_1,PAYMENT_METHOD_6_1,PAYMENT_METHOD_7_1,PAYMENT_FREQ_2_1,PAYMENT_FREQ_3_1,PAYMENT_FREQ_4_1,PAYMENT_FREQ_5_1,PAYMENT_FREQ_6_1,PAYMENT_FREQ_7_1,PROPERTY_2_1,PROPERTY_2_2,PROPERTY_3_1,PROPERTY_4_1,PROPERTY_5_1,PROPERTY_6_1,PROPERTY_7_1,ACTUAL_AMT_2_1,ACTUAL_AMT_3_1,ACTUAL_AMT_4_1,ACTUAL_AMT_5_1,ACTUAL_AMT_6_1,ACTUAL_AMT_7_1,START_DATE_2_1,START_DATE_3_1,START_DATE_4_1,START_DATE_5_1,START_DATE_6_1,START_DATE_7_1,END_DATE_2_1,END_DATE_3_1,END_DATE_4_1,END_DATE_5_1,END_DATE_6_1,END_DATE_7_1,FIXED_RATE,MARGIN_RATE,PERIODIC_RATE,PERIODIC_INDEX,PERIODIC_PERIOD_TYPE,FLOATING_INDEX,MARGIN_OPER,PERIODIC_RESET,INITIAL_RESET_DATE,PERIODIC_PERIOD,DAY_BASIS,PAYIN_SETTLEMENT,PAYIN_ACCOUNT,PAYOUT_SETTLEMENT,PAYOUT_ACCOUNT,LT_DISB_ACCT,LT_AA_PAY_IN,STATUS_TIDOM,NO_TIDOM,CIIU_ID,ECONOMIC_GROUP,PROVINCE,MUNICIPALITY,MUN_DISTRICT,PROD_SECTOR,APPROACH_ID,SOURCE_FUNDS,RESOL_YEAR,ORIGIN_VALUE,FACILITY_SIB,SOLD_LOAN,STATUS_NEW,RESTRUCT_DATE,CLASIF_REST,REASONS_RESTRUCT,PRODUCTS_CANCEL,BALANCE_CANCEL,EXTENDED_STATUS,YEAR_PENALTY");
                                outputFile.WriteLine(resultGerencialTake_Over_Dist_Pro.Replace("!!", ",").Replace("::", ","));

                            }

                            Console.ReadKey();
                        }
                        break;

                    case 2:
                        using (StreamReader sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\LOANS\Take_Over_Dist_Mock1_V4.txt"))
                        {
                            string file = sr.ReadToEnd();
                            var eachLine = file.Split("DO00");
                            int count = 0;
                            string resultGerencialTake_Over_Dist_Pro = "";

                            foreach (var line in eachLine)
                            {
                                if (line != "")
                                {
                                    string completeLine = "DO00" + line;

                                    string segundo = "";



                                    if (completeLine.Contains("FACILITY.SIB||"))
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
                                outputFile.WriteLine("ALT_ID,ACCOUNT_REFERENCE,AMOUNT,MATURITY_DATE,PAYMENT_TYPE_2_1,PAYMENT_TYPE_3_1,PAYMENT_TYPE_4_1,PAYMENT_TYPE_5_1,PAYMENT_TYPE_6_1,PAYMENT_TYPE_7_1,PAYMENT_METHOD_2_1,PAYMENT_METHOD_3_1,PAYMENT_METHOD_4_1,PAYMENT_METHOD_5_1,PAYMENT_METHOD_6_1,PAYMENT_METHOD_7_1,PAYMENT_FREQ_2_1,PAYMENT_FREQ_3_1,PAYMENT_FREQ_4_1,PAYMENT_FREQ_5_1,PAYMENT_FREQ_6_1,PAYMENT_FREQ_7_1,PROPERTY_2_1,PROPERTY_2_2,PROPERTY_3_1,PROPERTY_4_1,PROPERTY_5_1,PROPERTY_6_1,PROPERTY_7_1,ACTUAL_AMT_2_1,ACTUAL_AMT_3_1,ACTUAL_AMT_4_1,ACTUAL_AMT_5_1,ACTUAL_AMT_6_1,ACTUAL_AMT_7_1,START_DATE_2_1,START_DATE_3_1,START_DATE_4_1,START_DATE_5_1,START_DATE_6_1,START_DATE_7_1,END_DATE_2_1,END_DATE_3_1,END_DATE_4_1,END_DATE_5_1,END_DATE_6_1,END_DATE_7_1,FIXED_RATE,MARGIN_RATE,PERIODIC_RATE,PERIODIC_INDEX,PERIODIC_PERIOD_TYPE,FLOATING_INDEX,MARGIN_OPER,PERIODIC_RESET,INITIAL_RESET_DATE,PERIODIC_PERIOD,DAY_BASIS,PAYIN_SETTLEMENT,PAYIN_ACCOUNT,PAYOUT_SETTLEMENT,PAYOUT_ACCOUNT,LT_DISB_ACCT,LT_AA_PAY_IN,STATUS_TIDOM,NO_TIDOM,CIIU_ID,ECONOMIC_GROUP,PROVINCE,MUNICIPALITY,MUN_DISTRICT,PROD_SECTOR,APPROACH_ID,SOURCE_FUNDS,RESOL_YEAR,ORIGIN_VALUE,FACILITY_SIB");
                                outputFile.WriteLine(resultGerencialTake_Over_Dist_Pro.Replace("!!", ",").Replace("::",","));

                            }

                            Console.ReadKey();
                        }
                        break;
                }
            } while (true);


           
        }
    }
}
