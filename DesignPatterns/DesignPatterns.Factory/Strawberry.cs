namespace DesignPatterns.Factory
{
    internal class Strawberry : IFruit
    {
        public string Name { get; } = "Strawberry";

        public override string ToString()
        {
            return Name;
        }
    }
}