namespace Kimbrary.Printing
{
    public static class Print
    {
        public static void AsGreen(string text, bool endLine = true, ConsoleColor resetColor = ConsoleColor.Gray)
        {
            WithColor(ConsoleColor.Green, text, endLine, resetColor);
        }

        public static void AsDarkGreen(string text, bool endLine = true, ConsoleColor resetColor = ConsoleColor.Gray)
        {
            WithColor(ConsoleColor.DarkGreen, text, endLine, resetColor);
        }

        public static void AsYellow(string text, bool endLine = true, ConsoleColor resetColor = ConsoleColor.Gray)
        {
            WithColor(ConsoleColor.Yellow, text, endLine, resetColor);
        }

        public static void AsDarkYellow(string text, bool endLine = true, ConsoleColor resetColor = ConsoleColor.Gray)
        {
            WithColor(ConsoleColor.DarkYellow, text, endLine, resetColor);
        }

        public static void AsRed(string text, bool endLine = true, ConsoleColor resetColor = ConsoleColor.Gray)
        {
            WithColor(ConsoleColor.Red, text, endLine, resetColor);
        }

        public static void AsDarkRed(string text, bool endLine = true, ConsoleColor resetColor = ConsoleColor.Gray)
        {
            WithColor(ConsoleColor.DarkRed, text, endLine, resetColor);
        }

        public static void AsBlue(string text, bool endLine = true, ConsoleColor resetColor = ConsoleColor.Gray)
        {
            WithColor(ConsoleColor.Blue, text, endLine, resetColor);
        }

        public static void AsDarkBlue(string text, bool endLine = true, ConsoleColor resetColor = ConsoleColor.Gray)
        {
            WithColor(ConsoleColor.DarkBlue, text, endLine, resetColor);
        }

        public static void AsCyan(string text, bool endLine = true, ConsoleColor resetColor = ConsoleColor.Gray)
        {
            WithColor(ConsoleColor.Cyan, text, endLine, resetColor);
        }

        public static void AsDarkCyan(string text, bool endLine = true, ConsoleColor resetColor = ConsoleColor.Gray)
        {
            WithColor(ConsoleColor.DarkCyan, text, endLine, resetColor);
        }

        public static void AsMagenta(string text, bool endLine = true, ConsoleColor resetColor = ConsoleColor.Gray)
        {
            WithColor(ConsoleColor.Magenta, text, endLine, resetColor);
        }

        public static void AsDarkMagenta(string text, bool endLine = true, ConsoleColor resetColor = ConsoleColor.Gray)
        {
            WithColor(ConsoleColor.DarkMagenta, text, endLine, resetColor);
        }

        public static void AsWhite(string text, bool endLine = true, ConsoleColor resetColor = ConsoleColor.Gray)
        {
            WithColor(ConsoleColor.White, text, endLine, resetColor);
        }

        public static void AsGray(string text, bool endLine = true, ConsoleColor resetColor = ConsoleColor.Gray)
        {
            WithColor(ConsoleColor.Gray, text, endLine, resetColor);
        }

        private static void WithColor(ConsoleColor color, string text, bool endLine = true, ConsoleColor resetColor = ConsoleColor.Gray)
        {
            Console.ForegroundColor = color;
            Console.Write(text + (endLine ? "\n" : ""));
            Console.ForegroundColor = resetColor;
        }
    }
}
