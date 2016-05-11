namespace DesignPatterns.Factory
{
    internal class Banana : IFruit
    {
        public string Name { get; } = "Banana";

        public override string ToString()
        {
            return Name;
        }
    }
}