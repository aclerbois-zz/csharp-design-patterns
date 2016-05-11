using System;

namespace DesignPatterns.Facade
{
    internal class Fulfilment
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Order Order { get; }

        public Fulfilment(Order order)
        {
            if (order == null) throw new ArgumentNullException(nameof(order));
            Order = order;
        }

        public bool Success => true;
    }
}