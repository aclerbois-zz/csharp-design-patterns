using System;

namespace DesignPatterns.Facade
{
    internal class AmazonFacade
    {
        private readonly AmazonAuthentication _authentication = new AmazonAuthentication();
        private readonly AmazonOrdering _ordering = new AmazonOrdering();
        private readonly AmazonStock _stock = new AmazonStock();
        private readonly AmazonDelivery _delivery = new AmazonDelivery();

        public void BuyOneClick(string product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));

            Console.WriteLine("Checking if a user is currently logged in.");
            if (!_authentication.IsLoggedIn)
            {
                throw new InvalidOperationException("User is not logged in!");
            }

            var order = _ordering.CreateOrder(_authentication.GetCurrentUser());
            order.AddProduct(product);
            order.Confirm();

            var fulfillment = _stock.Fulfil(order);
            if (fulfillment.Success)
            {
                _delivery.Deliver(fulfillment);
            }
        }
    }
}