using System;

namespace DesignPatterns.Facade
{
    internal class AmazonDelivery
    {
        public void Deliver(Fulfilment fulfillment)
        {
            if (fulfillment == null) throw new ArgumentNullException(nameof(fulfillment));

            Console.WriteLine($"Delivering fulfillment '{fulfillment.Id}' with order '{fulfillment.Order.Id}'.");
        }
    }
}