namespace DesignPatterns.Bridge
{
    internal interface IDevice
    {
        string Description { get; }

        void Greet(string name);
    }
}