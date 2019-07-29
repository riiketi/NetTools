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
        public static string Traceroute(string ipAddressOrHostName)
        {
            IPAddress ipAddress = Dns.GetHostEntry(ipAddressOrHostName).AddressList[0];
            StringBuilder traceResults = new StringBuilder();
            using (Ping pingSender = new Ping())
            {
                PingOptions pingOptions = new PingOptions();
                Stopwatch stopWatch = new Stopwatch();
                byte[] bytes = new byte[32];
                pingOptions.DontFragment = true;
                pingOptions.Ttl = 1;
                int maxHops = 30;
                Console.WriteLine(string.Format("Tracing route to {0} over a maximum of {1} hops:", ipAddress, maxHops));
                for (int i = 1; i < maxHops + 1; i++)
                {
                    stopWatch.Reset();
                    stopWatch.Start();
                    PingReply pingReply = pingSender.Send(ipAddress, 1000, new byte[32], pingOptions);
                    stopWatch.Stop();
                    traceResults.AppendLine(string.Format("{0}\t{1} ms\t{2}", i, stopWatch.ElapsedMilliseconds, pingReply.Address));

                    if (pingReply.Status == IPStatus.Success)
                    {
                        traceResults.AppendLine();
                        traceResults.AppendLine("Trace complete.");
                        //Console.WriteLine(traceResults.ToString());
                        break;
                    }
                    pingOptions.Ttl++;
                }
                //Console.ReadKey(true);
            }
            return traceResults.ToString();
        }
    }
}
