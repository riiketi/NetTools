using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Net;

namespace NirSoftNetTools
{
    class RouteInfo
    {
        private long elapsedTime;
        private IPAddress ip;
        private string domain;

        public RouteInfo(long _elapsedTime, IPAddress _ip, string _domain)
        {
            this.elapsedTime = _elapsedTime;
            this.ip = _ip;
            this.domain = _domain;
        }

        public long ElapsedTime
        {
            get { return elapsedTime; }
        }

        public IPAddress IP
        {
            get { return ip; }
        }

        public string Domain
        {
            get { return domain; }
        }
    }

    class TraceRoute
    {
        public static IEnumerable<RouteInfo> GetTraceRoute(string hostname)
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

                IPHostEntry entry = Dns.GetHostEntry(reply.Address);

                switch (reply.Status)
                {
                    case IPStatus.TtlExpired:
                        yield return new RouteInfo(stopWatch.ElapsedMilliseconds, reply.Address, entry.HostName);
                        continue;

                    case IPStatus.TimedOut:
                        continue;

                    case IPStatus.Success:
                        yield return new RouteInfo(stopWatch.ElapsedMilliseconds, reply.Address, entry.HostName);
                        break;
                }

                break;
            }
        }

        public static string Traceroute(string hostname)
        {
            string result = string.Empty;
            int counter = 1;
            foreach (var route in GetTraceRoute(hostname))
                result += string.Format("{0}\t{1} ms\t{2}\r\n", counter++, route.ElapsedTime, route.Domain, route.IP);

            return result;
        }
    }
}
