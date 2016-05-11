using System;
using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    internal class DirectoryComponent : IFileSystemComponent
    {
        public string Name { get; }

        private readonly ISet<IFileSystemComponent> _components = new HashSet<IFileSystemComponent>();

        public DirectoryComponent(string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            Name = name;
        }

        public void Add(IFileSystemComponent component)
        {
            if (component == null) throw new ArgumentNullException(nameof(component));
            _components.Add(component);
        }

        public void Display(int depth = 0)
        {
            var identation = new string(' ', depth * 4);
            Console.WriteLine($"{identation} {Name}");

            foreach (var component in _components)
            {
                component.Display(depth + 1);
            }
        }
    }
}