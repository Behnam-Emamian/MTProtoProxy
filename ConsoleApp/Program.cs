using MTProtoProxy;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mtprotoProxy = new MTProtoProxyServer("secret", 666);
            mtprotoProxy.Start();
            Console.ReadLine();
        }
    }
}
