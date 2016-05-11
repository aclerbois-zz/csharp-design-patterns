using System;

namespace DesignPatterns.Bridge
{
    internal class MobilePhone : IDevice
    {
        public string Description => "a mobile phone";

        public void Greet(string name)
        {
            Console.WriteLine($"{name} says hello using {Description}.");
        }
    }
}