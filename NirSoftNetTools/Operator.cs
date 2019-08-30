using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.IO;

namespace NirSoftNetTools
{
    class Operator
    {
        private static string LookupMobileNumber(string Number)
        {
            WebRequest req = WebRequest.Create("http://www.megafon.ru/api/mfn/info?msisdn=" + Number);
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);

            return sr.ReadToEnd();
        }

        private static string LookupNotMobileNumber(string Number)  // 8 (код города) (номер)
        {
            WebRequest req = WebRequest.Create("https://www.kody.su/api/v2.1/search.xml?q=" + Number + "&key=90c8df3e97273dca8800f89261d3538e");
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);

            return sr.ReadToEnd();
        }

        public static string OpMobNUM(string Number)    // Оператор сотового номера (возвращает только оператор)
        {
            string result = Number + "\t" + LookupMobileNumber(Number) + "\n";
            if (result.Contains("operator")) {
                int start_index = result.IndexOf(":") + 2;
                int end_index   = result.IndexOf('"', start_index);
                int length      = end_index - start_index;
                return result.Substring(start_index, length);
            }

            return "Ошибка";
        }

        public static string OpMobNUM_raw(string Number)    // Оператор сотового номера (без обработки результата)
        {
            return Number + "\t" + LookupMobileNumber(Number) + "\n";
        }
        public static string OpNUM(string Number)   // Оператор стационарного номера (возвращает только оператор)
        {
            string result = Number + "\t" + LookupNotMobileNumber(Number) + "\n";
            
            if (result.Contains("operator")) {
                int ind         = result.IndexOf("operator");
                int start_index = result.IndexOf(">", ind) + 1;
                int end_index   = result.IndexOf('<', start_index);

                return  result.Substring(start_index, end_index - start_index);
            } 

            return "Ошибка";
        }

        public static string OpNUM_raw(string Number)   // Оператор стационарного номера (без обработки результата)
        {
            return Number + "\t" + LookupNotMobileNumber(Number) + "\n";
        }
    }
}
