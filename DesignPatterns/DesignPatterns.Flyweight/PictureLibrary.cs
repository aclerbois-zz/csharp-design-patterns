using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace DesignPatterns.Flyweight
{
    internal class PictureLibrary : IThumbnailCreator
    {
        private readonly Dictionary<string, IFlyweight> _cache = new Dictionary<string, IFlyweight>();

        public Thumbnail GetThumbnail(string fileName)
        {
            if (fileName == null) throw new ArgumentNullException(nameof(fileName));

            IFlyweight thumbnail;
            if (_cache.TryGetValue(fileName, out thumbnail))
            {
                return (Thumbnail)thumbnail;
            }

            thumbnail = CreateThumbnail(fileName);
            _cache.Add(fileName, thumbnail);

            return (Thumbnail)thumbnail;
        }

        private Thumbnail CreateThumbnail(string fileName)
        {
            if (fileName == null) throw new ArgumentNullException(nameof(fileName));
            if (!File.Exists(fileName)) throw new ArgumentNullException(nameof(fileName), "File does not exists!");

            Console.WriteLine($"Creating thumbnail for file {fileName}.");

            var bitmap = new Bitmap(fileName);
            var thumbnailImage = bitmap.GetThumbnailImage(150, 150, () => false, IntPtr.Zero);

            using (var ms = new MemoryStream())
            {
                thumbnailImage.Save(ms, bitmap.RawFormat);

                return new Thumbnail(ms.ToArray());
            }
        }
    }
}