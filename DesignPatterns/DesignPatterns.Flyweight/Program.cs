using System;

namespace DesignPatterns.Flyweight
{
    internal class Program
    {
        private static void Main()
        {
            var library = new PictureLibrary();
            var jupiter = library.GetThumbnail("jupiter.jpg");
            var neptune = library.GetThumbnail("neptune.jpg");

            Console.WriteLine($"Jupiter thumbnail size is {jupiter.Size} bytes.");
            Console.WriteLine($"Neptune thumbnail size is {neptune.Size} bytes.");

            // Does the thumbnail gets created again?
            var neptune2 = library.GetThumbnail("neptune.jpg");
            Console.WriteLine($"Neptune thumbnail size is {neptune2.Size} bytes.");

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
