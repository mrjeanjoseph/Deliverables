using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleUI.Model
{
    class WorldClass
    {
        public string[,] Grid;
        private int Rows;
        private int Cols;

        public WorldClass(string[,] grid)
        {
            Grid = grid;
            //calculate the number of rows and cols
            Rows = Grid.GetLength(0);
            Cols = Grid.GetLength(1);

        }

        public void Draw()
        {
            for(int y = 0; y < Rows; y++)
            {
                for(int x = 0; x < Cols; x++)
                {
                    string element = Grid[y, x];
                    SetCursorPosition(x, y);
                    Write(element);
                }
            }
        }
    }
}
