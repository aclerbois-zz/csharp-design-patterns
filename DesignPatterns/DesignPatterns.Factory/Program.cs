using System;

namespace DesignPatterns.Factory
{
    internal class Program
    {
        private static void Main()
        {
            var factory = new FruitCreator();
            Console.WriteLine($"The best fruit for current season is {factory.CreateFruitForSeason()}.");

            var winterFactory = new FruitCreator(new DateTime(2016, 2, 1));
            Console.WriteLine($"The best fruit for winter season is {winterFactory.CreateFruitForSeason()}.");

            var springFactory = new FruitCreator(new DateTime(2016, 5, 1));
            Console.WriteLine($"The best fruit for spring season is {springFactory.CreateFruitForSeason()}.");

            var summerFactory = new FruitCreator(new DateTime(2016, 8, 1));
            Console.WriteLine($"The best fruit for summer season is {summerFactory.CreateFruitForSeason()}.");

            var autumnFactory = new FruitCreator(new DateTime(2016, 11, 1));
            Console.WriteLine($"The best fruit for autumn season is {autumnFactory.CreateFruitForSeason()}.");

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
