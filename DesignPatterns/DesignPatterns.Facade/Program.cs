using System;

namespace DesignPatterns.Facade
{
    internal class Program
    {
        private static void Main()
        {
            var amazon = new AmazonFacade();
            amazon.BuyOneClick("978-0321127426");

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
