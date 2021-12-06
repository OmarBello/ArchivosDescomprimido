using System;
using System.IO;

namespace Capture_Bill_Dist_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("MENU DE OPCIONES");
                Console.WriteLine("\n"+
                    "\n 1.- Sacar el resultado de la primera parte del archivo Capture_Bill_Dist_Mock1_V2.txt"+
                    "\n 2.- Sacar el resultado de la segunda parte del archivo Capture_Bill_Dist_Mock1_V2.txt"+
                    "\n 3.- Sacar el resultado de la tercera parte del archivo Capture_Bill_Dist_Mock1_V2.txt"+
                    "\n 4.- Sacar el resultado de la cuarta parte del archivo Capture_Bill_Dist_Mock1_V2.txt"+
                    "\n 5.- Salir \n");
                Console.Write("Digite una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        using (var sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\LOANS\Capture_Bill_Dist_Mock1_V2.txt"))
                        {
                            string file = sr.ReadToEnd();
                            var eachLine = file.Split("DO00");
                            string resultGerencial_Capture_Bill_Dist_Prope = "";
                            int count = 0;

                            foreach (var line in eachLine)
                            {
                                if (line != "")
                                {
                                    string completeLine = "DO00" + line; //NEW.PROP.AMT:2:2||
                                    string segundo = "";

                                    if (completeLine.Contains("NEW.PROP.AMT:1:1||")) //564
                                    {
                                        segundo = completeLine.Substring(completeLine.IndexOf("NEW.PROP.AMT:1:1||")).Replace("NEW.PROP.AMT:1:1||", " ");
                                    }

                                   

                                    resultGerencial_Capture_Bill_Dist_Prope += segundo;
                                    count++;
                                }
                                Console.WriteLine(count);
                            }
                            //Escribiendo archivo
                            using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Loans\Loans2", "resultGerencial_Capture_Bill_Dist_Property_parte1.txt")))
                            {
                                outputFile.WriteLine("BILL_REF_1_1, BILL_DATE_1_1, PAYMENT_DATE_1_1, BILL_TYPE_1_1, PAYMENT_TYPE_1_1, PAYMENT_METHOD_1_1, PROPERTY_1_1, NEW_PROP_AMT_1_1");
                                outputFile.WriteLine(resultGerencial_Capture_Bill_Dist_Prope.Replace("!!", ","));
                            }

                            Console.ReadKey();
                        }
                        break;

                    case 2:
                        using (var sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\LOANS\Capture_Bill_Dist_Mock1_V2.txt"))
                        {
                            string file = sr.ReadToEnd();
                            var eachLine = file.Split("DO00");
                            string resultGerencial_Capture_Bill_Dist_Prope = "";
                            int count = 0;

                            foreach (var line in eachLine)
                            {
                                if (line != "")
                                {
                                    string completeLine = "DO00" + line; //NEW.PROP.AMT:2:2||
                                    string segundo = "";



                                    if (completeLine.Contains("NEW.PROP.AMT:2:2||")) //103
                                    {
                                        segundo = completeLine.Substring(completeLine.IndexOf("NEW.PROP.AMT:2:2||")).Replace("NEW.PROP.AMT:2:2||", " ");
                                    }



                                    resultGerencial_Capture_Bill_Dist_Prope += segundo;
                                    count++;
                                }
                                Console.WriteLine(count);
                            }
                            //Escribiendo archivo
                            using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Loans\Loans2", "resultGerencial_Capture_Bill_Dist_Property_parte2.txt")))
                            {
                                outputFile.WriteLine("BILL_REF_1_1,BILL_REF_2_1,BILL_DATE_1_1,BILL_DATE_2_1,PAYMENT_DATE_1_1,PAYMENT_DATE_2_1,BILL_TYPE_1_1,BILL_TYPE_2_1,PAYMENT_TYPE_1_1,PAYMENT_TYPE_2_1,PAYMENT_METHOD_1_1,PAYMENT_METHOD_2_1,PROPERTY_1_1,PROPERTY_2_1,PROPERTY_2_2,NEW_PROP_AMT_1_1,NEW_PROP_AMT_2_1,NEW_PROP_AMT_2_2");
                                outputFile.WriteLine(resultGerencial_Capture_Bill_Dist_Prope.Replace("!!", ","));
                            }

                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        using (var sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\LOANS\Capture_Bill_Dist_Mock1_V2.txt"))
                        {
                            string file = sr.ReadToEnd();
                            var eachLine = file.Split("DO00");
                            string resultGerencial_Capture_Bill_Dist_Prope = "";
                            int count = 0;

                            foreach (var line in eachLine)
                            {
                                if (line != "")
                                {
                                    string completeLine = "DO00" + line; //NEW.PROP.AMT:2:2||
                                    string segundo = "";



                                    if (completeLine.Contains("NEW.PROP.AMT:1:2||")) //1233
                                    {
                                        segundo = completeLine.Substring(completeLine.IndexOf("NEW.PROP.AMT:1:2||")).Replace("NEW.PROP.AMT:1:2||", " ");
                                    }




                                    resultGerencial_Capture_Bill_Dist_Prope += segundo;
                                    count++;
                                }
                                Console.WriteLine(count);
                            }
                            //Escribiendo archivo
                            using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Loans\Loans2", "resultGerencial_Capture_Bill_Dist_Property_parte3.txt")))
                            {
                                outputFile.WriteLine("BILL_REF_1_1,BILL_DATE_1_1,PAYMENT_DATE_1_1,BILL_TYPE_1_1,PAYMENT_TYPE_1_1,PAYMENT_METHOD_1_1,PROPERTY_1_1,PROPERTY_1_2,NEW_PROP_AMT_1_1,NEW_PROP_AMT_1_2");
                                outputFile.WriteLine(resultGerencial_Capture_Bill_Dist_Prope.Replace("!!", ","));
                            }

                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        using (var sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\LOANS\Capture_Bill_Dist_Mock1_V2.txt"))
                        {
                            string file = sr.ReadToEnd();
                            var eachLine = file.Split("DO00");
                            string resultGerencial_Capture_Bill_Dist_Prope = "";
                            int count = 0;

                            foreach (var line in eachLine)
                            {
                                if (line != "")
                                {
                                    string completeLine = "DO00" + line; //NEW.PROP.AMT:2:2||
                                    string segundo = "";



                                    if (completeLine.Contains("NEW.PROP.AMT:2:1||")) //1623
                                    {
                                        segundo = completeLine.Substring(completeLine.IndexOf("NEW.PROP.AMT:2:1||")).Replace("NEW.PROP.AMT:2:1||", " ");
                                    }


                                    resultGerencial_Capture_Bill_Dist_Prope += segundo;
                                    count++;
                                }
                                Console.WriteLine(count);
                            }
                            //Escribiendo archivo
                            using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Loans\Loans2", "resultGerencial_Capture_Bill_Dist_Property_parte4.txt")))
                            {
                                outputFile.WriteLine("BILL_REF_1_1, BILL_DATE_1_1, PAYMENT_DATE_1_1, BILL_TYPE_1_1, PAYMENT_TYPE_1_1, PAYMENT_METHOD_1_1, PROPERTY_1_1, NEW_PROP_AMT_1_1");
                                outputFile.WriteLine(resultGerencial_Capture_Bill_Dist_Prope.Replace("!!", ","));
                            }

                            Console.ReadKey();
                        }
                        break;

                    default:
                        Console.WriteLine("Digite una opcion valida");
                        break;

                    case 5:
                        Console.WriteLine("Salio de la aplicacion, bye...");
                        break;

                }

            } while (opcion != 5);

            Console.ReadKey();
            
        }
    }
}
