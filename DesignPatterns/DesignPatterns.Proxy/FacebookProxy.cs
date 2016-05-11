namespace DesignPatterns.Proxy
{
    internal class FacebookProxy : IFacebook
    {
        private FacebookClient _client;

        public void Poke(string someone)
        {
            if (_client == null)
            {
                _client = new FacebookClient();
            }

            _client.Poke(someone);
        }
    }
}