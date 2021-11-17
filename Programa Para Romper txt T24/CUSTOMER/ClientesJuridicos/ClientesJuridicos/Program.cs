using System;
using System.IO;

namespace ClientesJuridicos
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sr = new StreamReader(@"C:\Users\OB319895\Documents\Resultado Mock1\CUSTOMER\CLIENTE.JURIDICOS.MOCK01.V14.txt"))
            {
                string file = sr.ReadToEnd();
                var eachLine = file.Split("CUSTOMER_CODE||MNEMONIC||SHORT_NAME||NAME_2||NAME_1||GENDER||NATIONALITY||RESIDENCE||SECTOR||ACCOUNT_OFFICER||TARGET||INDUSTRY||CUSTOMER_STATUS||COMPANY_BOOK||LEGAL_ID||LEGAL_DOC_NAME||LEGAL_ISS_DATE||LEGAL_EXP_DATE||MARITAL_STATUS||DATE_OF_BIRTH||PHONE_1||EMAIL_1||STREET||ADDRESS_1||TOWN_COUNTRY||POST_CODE||PREF_CHANNEL||RESIDENCE_TYPE||OCCUPATION||EMPLOYERS_NAME||EMPLOYMENT_START||OFF_PHONE||EMPLOYERS_ADD||SALARY||CUSTOMER_CURRENCY||EXTERN_SYS_ID||EXTERN_CUS_ID_1||KYC_COMPLETE||RISK_FROM_DATE||CALC_RISK_CLASS||CUSTOMER_RATING||RELATION_CODE||REL_CUSTOMER||BIRTH_INCORP_DATE||LANGUAGE||SMS_1||LT_ST_CUS_TYPE||LT_ST_LINK_TYPE||COUNTRY_SUBDIVISION||LT_ST_RISKGROUP");
                string resultGerencial_Clientes_Juridicos = "";
                int count = 0;

                foreach (var line in eachLine)
                {
                    if(line != "")
                    {

                        string completeLine = line;


                        string primero = completeLine.Substring(0);

                        resultGerencial_Clientes_Juridicos += primero + "\n";

                        count++;
                    }
                    
                    Console.WriteLine(count);

                }


                //Escribiendo archivo
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\OB319895\Documents\Resultado_ArchivoTXT24\Customer\", "resultGerencial_Clientes_Juridicos.txt")))
                {
                    outputFile.WriteLine(resultGerencial_Clientes_Juridicos.Replace("||", ","));
                }
                Console.ReadKey();
            }
        }
    }
}
