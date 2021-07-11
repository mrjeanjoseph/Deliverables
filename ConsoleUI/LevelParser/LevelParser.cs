using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.LevelParser
{
    class LevelParser
    {
        public static string[,] ParseFileToArray(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            string firstLine = lines[0];

            int rows = lines.Length;
            int cols = firstLine.Length;
            string[,] grid = new string[rows, cols];
            for (int y = 0; y < rows; y++)
            {
                string line = lines[y];

                for (int x = 0; x < cols; x++)
                {
                    char currentChar = line[x];
                    grid[y, x] = currentChar.ToString();
                }
            }
            return grid;
        }
    }
}
