using System;

namespace DesignPatterns.Adapter
{
    internal class CalculatorAdapter : Calculator, IRoundOperations
    {
        public int DivideAndRound(double dividend, double divisor)
        {
            return (int)Math.Round(Divide(dividend, divisor));
        }
    }
}