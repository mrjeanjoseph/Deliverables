using System;
using System.Linq;

namespace JoiningDataOOP
{
    public static class DataTableFormatter
    {
        private const int tableWidth = 115;
        public static void LineSeparator()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        public static void PrintRow(params string[] columns)
        {
            int columnWidth = (tableWidth - columns.Length) / columns.Length;
            const string emptySpaces = " ";

            string row = columns.Aggregate(emptySpaces, (separator, columnText) => separator + PadRightAllText(columnText, columnWidth) + emptySpaces);
            Console.WriteLine(row);
        }

        private static string PadRightAllText(string columnText, int columnWidth)
        {
            //Found this piece of text online. Let's see what it does!
            columnText = columnText.Length > columnWidth ? columnText.Substring(0, columnWidth - 1) + "..." : columnText;
            //the "?" declares an if sentence representing a boolean condition for columnWidth

            return string.IsNullOrEmpty(columnText)
                ? new string(' ', columnWidth)
                : columnText.PadRight(columnWidth);
            //: columnText.PadRight(columnWidth - ((columnWidth - columnText.Length) / 2)).PadLeft(columnWidth);
        }
    }
}
