using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Net;

namespace NirSoftNetTools
{
    class TraceRoute
    {
        public static IEnumerable<KeyValuePair<long, IPAddress>> GetTraceRoute(string hostname)
        {
            const int timeout = 10000;
            const int maxTTL = 128;
            const int bufferSize = 32;

            byte[] buffer = new byte[bufferSize];
            Ping pinger = new Ping();


            for (int ttl = 1; ttl <= maxTTL; ttl++)
            {
                Stopwatch stopWatch = new Stopwatch();
                PingOptions options = new PingOptions(ttl, true);

                stopWatch.Start();
                PingReply reply = pinger.Send(hostname, timeout, buffer, options);
                stopWatch.Stop();
                
                switch (reply.Status)
                {
                    case IPStatus.TtlExpired:
                        yield return new KeyValuePair<long, IPAddress>(stopWatch.ElapsedMilliseconds, reply.Address);
                        continue;

                    case IPStatus.TimedOut:
                        continue;

                    case IPStatus.Success:
                        yield return new KeyValuePair<long, IPAddress>(stopWatch.ElapsedMilliseconds, reply.Address);
                        break;
                }

                break;
            }
        }

        public static string Traceroute(string hostname)
        {
            string result = string.Empty;
            int counter = 1;
            foreach (var ip in GetTraceRoute(hostname))
                result += string.Format("{0}\t{1} ms\t{2}\r\n", counter++, ip.Key, ip.Value);


            return result;
        }
    }
}
