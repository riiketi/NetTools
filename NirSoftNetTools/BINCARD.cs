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
    class BINCARD
    {
        private static string LookupNumber(string BIN)
        {
            WebRequest req =
            WebRequest.Create("https://lookup.binlist.net/" + BIN);
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string s = sr.ReadToEnd();
            return s;
        }

        public static string BankByBIN(string BIN)
        {
            string Result = "";
            Result += BIN + "     " + LookupNumber(BIN) + "\n";
            return Result;
        }
    }
}
