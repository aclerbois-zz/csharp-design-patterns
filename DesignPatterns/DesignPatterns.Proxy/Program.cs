using System;

namespace DesignPatterns.Proxy
{
    internal class Program
    {
        private static void Main()
        {
            IFacebook proxy = new FacebookProxy();

            Console.WriteLine("Proxy is loaded.");

            proxy.Poke("Mark Zuckerberg");
            proxy.Poke("Bill Gates");

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
