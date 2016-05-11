using System;

namespace DesignPatterns.Prototype
{
    [Serializable]
    internal class Company
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name} ({GetHashCode()})";
        }
    }
}