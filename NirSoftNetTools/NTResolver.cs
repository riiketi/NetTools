using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Net;

namespace NirSoftNetTools
{
    static class NTResolver
    {
        public static IPAddress[] DomainToIP(string hostname)
        {
            try { 
                return Dns.GetHostAddresses(hostname);
            } 
            catch (Exception e) {
                return null;
            }

        }

        public static string IPToDomain(string IP)
        {
            try {
                return Dns.GetHostEntry(IP).HostName;
            }
            catch (Exception e) {
                return null;
            }
        }

        public static string IPToDomain(IPAddress IP)
        {
            try {
                return Dns.GetHostEntry(IP).HostName;
            }
            catch (Exception e) {
                return null;
            }
        }
    }

}