using System;

namespace DesignPatterns.Decorator
{
    internal class AsciiFrameConsoleWriter : IConsoleWriter
    {
        private readonly IConsoleWriter _writer;

        private const string BORDERLEFTTOPCHARACTER = "╔";
        private const string BORDERRIGHTTOPCHARACTER = "╗";
        private const string BORDERLEFTBOTTOMCHARACTER = "╚";
        private const string BORDERRIGHTBOTTOMCHARACTER = "╝";
        private const string BORDERTOPANDBOTTOMCHARACTER = "═";
        private const string BORDERLEFTRIGHTCHARACTER = "║";

        public AsciiFrameConsoleWriter(IConsoleWriter writer)
        {
            if (writer == null) throw new ArgumentNullException(nameof(writer));
            _writer = writer;
        }

        public void WriteLine(string value)
        {
            string lineTop = BORDERLEFTTOPCHARACTER;
            
            for (int i = 0; i < value.Length + 2; i++)
                lineTop += BORDERTOPANDBOTTOMCHARACTER;

            lineTop += BORDERRIGHTTOPCHARACTER;

            _writer.WriteLine(lineTop);

            _writer.WriteLine($"{BORDERLEFTRIGHTCHARACTER} {value} {BORDERLEFTRIGHTCHARACTER}");

            string lineBottom = BORDERLEFTBOTTOMCHARACTER;

            for (int i = 0; i < value.Length + 2; i++)
                lineBottom += BORDERTOPANDBOTTOMCHARACTER;

            lineBottom += BORDERRIGHTBOTTOMCHARACTER;

            _writer.WriteLine(lineBottom);
        }

    }
}
