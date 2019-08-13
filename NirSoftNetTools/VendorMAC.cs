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
    class VendorMAC
    {
        private static string LookupMac(string MacAddress)
        {
            //var uri = new Uri("http://api.macvendors.com/" + WebUtility.UrlEncode(MacAddress));
            //using (var wc = new HttpClient())
                //return wc.GetStringAsync(uri);

            WebRequest req =  
            WebRequest.Create("http://api.macvendors.com/" + MacAddress);
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string s = sr.ReadToEnd();
            return s;
        }

        public static string VendMAC(string mac)
        {
            string Result = "";
            //Result += mac + "     " + LookupMac(mac) + "\n";
            Result = LookupMac(mac) + "\n";
            return Result;
        }
    }
}
