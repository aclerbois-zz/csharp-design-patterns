namespace DesignPatterns.Flyweight
{
    internal interface IThumbnailCreator
    {
        Thumbnail GetThumbnail(string fileName);
    }
}