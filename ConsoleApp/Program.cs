using MTProtoProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = "127.0.0.1";
            var port = 666;
            //var secret = GenerateRandomSecret();
            var secret = "656f293cb1234d3b89be35225b9a36a4";

            Console.WriteLine("https://t.me/proxy?server=" + host + "&port=" + port + "&secret=" + secret);

            var mtprotoProxy = new MTProtoProxyServer(secret, port, host);
            mtprotoProxy.Start();
            Console.ReadLine();
        }

        public static string GenerateRandomSecret()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }
    }
}
