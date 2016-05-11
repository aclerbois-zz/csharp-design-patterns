using System;
using System.Threading;

namespace DesignPatterns.Proxy
{
    internal class FacebookClient : IFacebook
    {
        public FacebookClient()
        {
            // Simulation of a long running operation
            Console.Write("Initializing Facebook client... ");
            Thread.Sleep(1500);
            Console.WriteLine("Done.");
        }

        public void Poke(string someone)
        {
            Console.WriteLine($"You poked {someone}.");
        }
    }
}