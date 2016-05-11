using System;

namespace DesignPatterns.Composite
{
    internal class Program
    {
        private static void Main()
        {
            var root = new DirectoryComponent("C:");
            var users = new DirectoryComponent("Users");
            var guest = new DirectoryComponent("Guest");
            var fabian = new DirectoryComponent("Fabian");
            var readme = new FileComponent("README.md");

            fabian.Add(readme);
            users.Add(fabian);
            users.Add(guest);
            root.Add(users);

            root.Display();

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
