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
            WebRequest req =
            WebRequest.Create("http://www.megafon.ru/api/mfn/info?msisdn=" + Number);
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string s = sr.ReadToEnd();
            return s;
        }
        private static string LookupNotMobileNumber(string Number)  // 8 (код города) (номер)
        {
            WebRequest req =
            WebRequest.Create("https://www.kody.su/api/v2.1/search.xml?q=" + Number + "&key=90c8df3e97273dca8800f89261d3538e");
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string s = sr.ReadToEnd();
            return s;
        }
        public static string OpMobNUM(string Number)    // Оператор сотового номера (возвращает только оператор)
        {
            string Result = "Ошибка";    // оператор
            string Result_raw = "";
            Result_raw += Number + "     " + LookupMobileNumber(Number) + "\n";
            if (Result_raw.Contains("operator"))
            {
                int start_index = Result_raw.IndexOf(":") + 2;
                int end_index = Result_raw.IndexOf('"', start_index);
                int length = end_index - start_index;
                Result = Result_raw.Substring(start_index, length);
            }
            return Result;
        }
        public static string OpMobNUM_raw(string Number)    // Оператор сотового номера (без обработки результата)
        {
            string Result = "";
            Result += Number + "     " + LookupMobileNumber(Number) + "\n";
            return Result;
        }
        public static string OpNUM(string Number)   // Оператор стационарного номера (возвращает только оператор)
        {
            string Result = "";    // оператор
            string Result_raw = "";
            Result_raw += Number + "     " + LookupNotMobileNumber(Number) + "\n";
            
            if (Result_raw.Contains("operator"))
            {
                int ind = Result_raw.IndexOf("operator");
                int start_index = Result_raw.IndexOf(">", ind) + 1;
                int end_index = Result_raw.IndexOf('<', start_index);
                int length = end_index - start_index;
                Result = Result_raw.Substring(start_index, length);
            }
            return Result;
        }
        public static string[] OpNUM_raw(string Number)   // Оператор стационарного номера (без обработки результата)
        {
            string[] Result = new string[2];
            string Result1 = "";
            Result1 += Number + "     " + LookupNotMobileNumber(Number) + "\n";
            return Result;
        }
    }
}
