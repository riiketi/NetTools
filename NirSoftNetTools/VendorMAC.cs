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
            //foreach (var mac in new string[] { "88:53:2E:67:07:BE", "FC:FB:FB:01:FA:21", "D4:F4:6F:C9:EF:8D" })
                //Console.WriteLine(mac + "\t" + LookupMac(mac).Result);
            Result += mac + "     " + LookupMac(mac) + "\n";
            //Console.ReadLine();
            return Result;
        }
    }
}
