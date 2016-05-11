namespace DesignPatterns.Composite
{
    internal interface IFileSystemComponent
    {
        string Name { get; }

        void Display(int depth = 0);
    }
}