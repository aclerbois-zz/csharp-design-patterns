using System;

namespace DesignPatterns.Prototype
{
    [Serializable]
    internal class Person : Prototype<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Company Company { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({GetHashCode()})";
        }
    }
}