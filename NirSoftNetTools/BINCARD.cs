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
            WebRequest req = WebRequest.Create("https://lookup.binlist.net/" + BIN);
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);

            return sr.ReadToEnd();
        }

        public static string[] BankByBIN(string BIN)     // платёжная система, страна, банк
        {
            string Result_raw = "";
            Result_raw += BIN + "     " + LookupNumber(BIN) + "\n";
            string[] Result = new string[3];

            // Платёжная система
            Result[2] = "";
            if (Result_raw.Contains("scheme"))
            {
                int ind1 = Result_raw.IndexOf("scheme");
                int start_index = Result_raw.IndexOf(":", ind1) + 2;
                int end_index = Result_raw.IndexOf('"', start_index);
                int length = end_index - start_index;
                Result[0] = Result_raw.Substring(start_index, length);

                if ((Result[0] == "mastercard") & (Result_raw.Contains("maestro")))
                {
                    Result[0] = "maestro";
                }
            }

            // Страна
            Result[2] = "";
            if (Result_raw.Contains("country"))
            {
                int ind1 = Result_raw.IndexOf("country");
                int ind2 = Result_raw.IndexOf("name", ind1);
                if (ind2 > 0)
                {
                    int start_index = Result_raw.IndexOf(":", ind2) + 2;
                    int end_index = Result_raw.IndexOf('"', start_index);
                    int length = end_index - start_index;
                    Result[1] = Result_raw.Substring(start_index, length);
                }
            }

            // Банк
            Result[2] = "";
            if (Result_raw.Contains("bank"))
            {
                int ind1 = Result_raw.IndexOf("bank");
                int ind2 = Result_raw.IndexOf("name", ind1);
                if (ind2 > 0)
                {
                    int start_index = Result_raw.IndexOf(":", ind2) + 2;
                    int end_index = Result_raw.IndexOf('"', start_index);
                    int length = end_index - start_index;
                    Result[2] = Result_raw.Substring(start_index, length);
                }
            }

            return Result;
        }
        public static string BankByBIN_raw(string BIN)
        {
            string Result = "";
            Result += BIN + "     " + LookupNumber(BIN) + "\n";
            return Result;
        }
    }
}
