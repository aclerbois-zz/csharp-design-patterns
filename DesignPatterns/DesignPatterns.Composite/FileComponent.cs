using System;

namespace DesignPatterns.Composite
{
    internal class FileComponent : IFileSystemComponent
    {
        public string Name { get; }

        public FileComponent(string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            Name = name;
        }

        public void Display(int depth = 0)
        {
            var identation = new string(' ', depth * 4);
            Console.WriteLine($"{identation} {Name}");
        }
    }
}