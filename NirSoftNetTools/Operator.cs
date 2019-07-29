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
        public static string OpMobNUM(string Number)    // Оператор сотового номера
        {
            string Result = "";
            Result += Number + "     " + LookupMobileNumber(Number) + "\n";
            return Result;
        }
        public static string OpNUM(string Number)   // Оператор стационарного номера
        {
            string Result = "";
            Result += Number + "     " + LookupNotMobileNumber(Number) + "\n";
            return Result;
        }
    }
}
