namespace DesignPatterns.Facade
{
    internal class AmazonAuthentication
    {
        public bool IsLoggedIn => true;

        public string GetCurrentUser()
        {
            return "fvilers";
        }
    }
}