using System;

namespace DesignPatterns.Facade
{
    internal class AmazonOrdering
    {
        public Order CreateOrder(string user)
        {
            Console.WriteLine($"Creating order for user {user}.");

            return new Order(user);
        }
    }
}