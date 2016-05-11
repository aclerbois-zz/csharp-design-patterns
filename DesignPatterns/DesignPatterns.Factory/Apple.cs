namespace DesignPatterns.Factory
{
    internal class Apple : IFruit
    {
        public string Name { get; } = "Apple";

        public override string ToString()
        {
            return Name;
        }
    }
}