using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace NirSoftNetTools
{
    public static class WhoisService
    {
        static string whoisServer = "whois.verisign-grs.com";

        public static string WhoIs(string domain)
        {

            Func<string, string> formatDomainName = delegate (string name) {
                return name.ToLower().Any(v => !"abcdefghijklmnopqrstuvdxyz0123456789.-".Contains(v)) ? new IdnMapping().GetAscii(name) : name;
            };

            StringBuilder result = new StringBuilder();
            result.AppendLine("По данным " + whoisServer + ":  ------------------------------------------");
            using (TcpClient tcpClient = new TcpClient()) {
                tcpClient.Connect(whoisServer, 43);
                byte[] domainQueryBytes = Encoding.ASCII.GetBytes(formatDomainName(domain) + "\r\n");
                using (Stream stream = tcpClient.GetStream()) {
                    stream.Write(domainQueryBytes, 0, domainQueryBytes.Length);
                    using (StreamReader sr = new StreamReader(tcpClient.GetStream(), Encoding.UTF8)) {
                        string row;
                        while ((row = sr.ReadLine()) != null)
                            result.AppendLine(row);
                    }
                }
            }
            result.AppendLine("---------------------------------------------------------------------\r\n");

            return result.ToString();
        }
    }
}
