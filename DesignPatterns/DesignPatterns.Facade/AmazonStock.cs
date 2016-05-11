using System;

namespace DesignPatterns.Facade
{
    internal class AmazonStock
    {
        public Fulfilment Fulfil(Order order)
        {
            if (order == null) throw new ArgumentNullException(nameof(order));

            Console.WriteLine($"Fulfilling order '{order.Id}'.");
            return new Fulfilment(order);
        }
    }
}