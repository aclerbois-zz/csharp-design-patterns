using System;

namespace DesignPatterns.Flyweight
{
    internal class Thumbnail : IFlyweight
    {
        private readonly byte[] _bytes;

        public Thumbnail(byte[] bytes)
        {
            if (bytes == null) throw new ArgumentNullException(nameof(bytes));
            _bytes = bytes;
        }

        public int Size => _bytes.Length;
    }
}