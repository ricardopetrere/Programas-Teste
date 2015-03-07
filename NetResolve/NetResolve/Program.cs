using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace NetResolve
{
    class Program
    {
        static void Main(string[] args)
        {
            //http://stackoverflow.com/questions/11411486/get-ipv4-and-ipv6-address-of-local-machine-c-sharp
            //http://stackoverflow.com/questions/1059526/get-ipv4-addresses-from-dns-gethostentry?rq=1
            Console.WriteLine(GetIP());
            Console.WriteLine(GetMACAddress());
            Console.Write("\nHost:\n" + Dns.GetHostName());
            Console.Read();
        }
        static string GetIP()
        {
            string retorno = "IPs:";
            IPAddress[] a = Dns.GetHostAddresses(Dns.GetHostName());
            for (int n = 0; n < a.Length; n++)
                if (a[n].AddressFamily == AddressFamily.InterNetwork)//InterNetwork for v4, InterNetworkV6 for v6
                    retorno += "\n" + a[n].ToString();
            return retorno;
        }
        static string GetMACAddress()
        {
            var macAddr =
                (
                    from nic in NetworkInterface.GetAllNetworkInterfaces()
                    where nic.OperationalStatus == OperationalStatus.Up
                    select nic.GetPhysicalAddress().ToString()
                ).FirstOrDefault();
            string retorno = "\nMAC Adress:\n";
            for (int n = 0; n < macAddr.Length; n++)
            {
                retorno += macAddr[n];
                if ((n + 1) % 2 == 0 && n + 1 < macAddr.Length)
                    retorno += ":";
            }
            return retorno.ToString();
        }
    }
}
