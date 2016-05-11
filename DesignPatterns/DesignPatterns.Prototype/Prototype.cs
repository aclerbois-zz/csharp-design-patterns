using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPatterns.Prototype
{
    [Serializable]
    internal class Prototype<T> : IPrototype<T>
    {
        public T ShallowCopy()
        {
            return (T)MemberwiseClone();
        }

        public T DeepCopy()
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();

                formatter.Serialize(ms, this);
                ms.Seek(0, SeekOrigin.Begin);

                return (T)formatter.Deserialize(ms);
            }
        }
    }
}