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
        private static string LookupNumber(string Number)
        {
            WebRequest req =
            WebRequest.Create("http://www.megafon.ru/api/mfn/info?msisdn=" + Number);
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string s = sr.ReadToEnd();
            return s;
        }

        public static string OpNUM(string Number)
        {
            string Result = "";
            Result += Number + "     " + LookupNumber(Number) + "\n";
            return Result;
        }
    }
}
