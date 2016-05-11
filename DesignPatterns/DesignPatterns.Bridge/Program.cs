using System;
using System.Configuration;

namespace DesignPatterns.Bridge
{
    internal class Program
    {
        private static void Main()
        {
            var greeter = new Greeter(CreateDevice());

            greeter.SayHello();

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }

        private static IDevice CreateDevice()
        {
            if (ConfigurationManager.AppSettings["legacy"] == "true")
            {
                return new Phone();
            }

            return new MobilePhone();
        }
    }
}
