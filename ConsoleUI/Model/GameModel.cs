using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleUI.Model
{
    public class GameModel
    {
        public void Start()
        {
            string[,] grid =
            {
                { "=", "=", "=", "=", "=", "=", "="},
                { "=", " ", "=", " ", " ", " ", "X"},
                { "O", " ", "=", " ", "=", " ", "="},
                { "=", " ", "=", " ", "=", " ", "="},
                { " ", " ", " ", "=", "=", " ", "="},
                { "=", "=", "=", "=", "=", "=", "="},

            };
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);

            // y = row and x = col
            for(int y = 0; y < rows; y++)
            {
                for(int x = 0; x < cols; x++)
                {
                    string element = grid[y, x];
                    SetCursorPosition(x, y);
                    Write(element);
                }
            }

            //WriteLine("Press any key to exit");

        }
        public void Quit()
        {
            Environment.Exit(0);
        }
    }
}
