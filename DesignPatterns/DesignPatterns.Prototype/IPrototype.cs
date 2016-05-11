namespace DesignPatterns.Prototype
{
    internal interface IPrototype<out T>
    {
        T ShallowCopy();
        T DeepCopy();
    }
}