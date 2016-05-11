namespace DesignPatterns.Factory
{
    internal class Pineapple : IFruit
    {
        public string Name { get; } = "Pineapple";

        public override string ToString()
        {
            return Name;
        }
    }
}