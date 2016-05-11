using System;

namespace DesignPatterns.Bridge
{
    internal class Greeter
    {
        private readonly IDevice _device;

        public Greeter(IDevice device)
        {
            if (device == null) throw new ArgumentNullException(nameof(device));
            _device = device;
        }

        public void SayHello()
        {
            _device.Greet("Fabian");
        }
    }
}