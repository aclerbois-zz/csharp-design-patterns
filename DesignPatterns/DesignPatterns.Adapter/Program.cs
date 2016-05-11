using System;

namespace DesignPatterns.Adapter
{
    internal class Program
    {
        private static void Main()
        {
            var calculator = new Calculator();
            var roundCalculator = new CalculatorAdapter();

            Console.WriteLine(calculator.Divide(10, 3));
            Console.WriteLine(roundCalculator.DivideAndRound(10, 3));

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
