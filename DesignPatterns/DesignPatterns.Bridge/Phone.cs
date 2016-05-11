using System;

namespace DesignPatterns.Bridge
{
    internal class Phone : IDevice
    {
        public string Description => "a phone";

        public void Greet(string name)
        {
            Console.WriteLine($"{name} says hello using {Description}.");
        }
    }
}