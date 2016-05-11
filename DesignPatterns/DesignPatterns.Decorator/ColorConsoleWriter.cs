using System;

namespace DesignPatterns.Decorator
{
    internal class ColorConsoleWriter : IConsoleWriter
    {
        private readonly IConsoleWriter _writer;
        private readonly ConsoleColor _backgroundColor;
        private readonly ConsoleColor _foregroundColor;

        public ColorConsoleWriter(IConsoleWriter writer, ConsoleColor backgroundColor, ConsoleColor foregroundColor)
        {
            if (writer == null) throw new ArgumentNullException(nameof(writer));
            if (!Enum.IsDefined(typeof(ConsoleColor), backgroundColor)) throw new ArgumentOutOfRangeException(nameof(backgroundColor));
            if (!Enum.IsDefined(typeof(ConsoleColor), foregroundColor)) throw new ArgumentOutOfRangeException(nameof(foregroundColor));
            _writer = writer;
            _backgroundColor = backgroundColor;
            _foregroundColor = foregroundColor;
        }

        public void WriteLine(string value)
        {
            var previousBackgroundColor = Console.BackgroundColor;
            var previousForegroundColor = Console.ForegroundColor;

            Console.BackgroundColor = _backgroundColor;
            Console.ForegroundColor = _foregroundColor;

            _writer.WriteLine(value);

            Console.BackgroundColor = previousBackgroundColor;
            Console.ForegroundColor = previousForegroundColor;
        }
    }
}