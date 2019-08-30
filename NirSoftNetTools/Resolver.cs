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
        public static IPAddress[] DomainToIP(string hostname)
        {
            return Dns.GetHostAddresses(hostname);
        }

        public static string IPToDomain(string IP)
        {
            try {
                return Dns.GetHostEntry(IP).HostName;
            }
            catch (Exception e) {
                return string.Empty;
            }
        }

        public static string IPToDomain(IPAddress IP)
        {
            try {
                return Dns.GetHostEntry(IP).HostName;
            }
            catch (Exception e) {
                return string.Empty;
            }
        }
    }

}