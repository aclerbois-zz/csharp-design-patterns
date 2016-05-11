using System;
using System.Collections.Generic;

namespace DesignPatterns.Facade
{
    internal class Order
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string User { get; }
        public bool IsConfirmed { get; private set; }
        public ISet<string> Products { get; } = new HashSet<string>();

        public Order(string user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));
            User = user;
        }

        public void AddProduct(string product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));

            Console.WriteLine($"Adding product '{product}' to order '{Id}'.");
            Products.Add(product);
        }

        public void Confirm()
        {
            Console.WriteLine($"Confirming order '{Id}'.");
            IsConfirmed = true;
        }
    }
}