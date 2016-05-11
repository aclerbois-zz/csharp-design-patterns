using System;

namespace DesignPatterns.Decorator
{
    internal class Program
    {
        private static void Main()
        {
            const string valueToDisplay = "Lorem ipsum dolor sit amet.";

            IConsoleWriter normalWriter = new ConsoleWriter();
            IConsoleWriter redOnWhiteWriter = new ColorConsoleWriter(normalWriter, ConsoleColor.White, ConsoleColor.Red);

            normalWriter.WriteLine(valueToDisplay);
            redOnWhiteWriter.WriteLine(valueToDisplay);

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
