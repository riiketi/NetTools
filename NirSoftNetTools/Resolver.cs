using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Net;

namespace NirSoftNetTools
{
    static class Resolver
    {
        public static List<KeyValuePair<string, IPAddress>> DomainToIP(string hostname)
        {
            var list = new List<KeyValuePair<string, IPAddress>>();
            IPAddress[] IPAddrList = Dns.GetHostAddresses(hostname);
            foreach (var ip in IPAddrList) 
                list.Add(new KeyValuePair<string, IPAddress>(hostname, ip));

            return list;
        }

        public static KeyValuePair<string, IPAddress> IPToDomain(string IP)
        {
            IPHostEntry IpToDomainName = Dns.GetHostEntry("173.194.38.138");
            string hostname = IpToDomainName.HostName;
            return new KeyValuePair<string, IPAddress>(hostname, IPAddress.Parse(IP));
        }
    }
}