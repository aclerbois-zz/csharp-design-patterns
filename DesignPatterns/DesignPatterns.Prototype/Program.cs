using System;

namespace DesignPatterns.Prototype
{
    internal class Program
    {
        private static void Main()
        {
            var someone = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Company = new Company
                {
                    Name = "ACME, inc."
                }
            };

            var shallowCopy = someone.ShallowCopy();
            var deepCopy = someone.DeepCopy();

            Console.WriteLine($"Original: {someone}, working for {someone.Company}.");
            Console.WriteLine($"Shallow copy: {shallowCopy}, working for {shallowCopy.Company}.");
            Console.WriteLine($"Deep copy: {deepCopy}, working for {deepCopy.Company}.");

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
