﻿using System;
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

            Rows = Grid.GetLength(0);
            Cols = Grid.GetLength(1);

        }
        public void Draw()
        {
            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Cols; x++)
                {
                    string element = Grid[y, x];
                    SetCursorPosition(x, y);

                    if (element == "X")
                    {
                        ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        ForegroundColor = ConsoleColor.White;
                    }
                    Write(element);
                }
            }
        }

        public string GetElementAt(int x, int y)
        {
            return Grid[y, x];
        }

        public bool IsPositionWalkable(int x, int y)
        {
            if (x < 0 || y < 0 || x >= Cols || y > Rows)
            {
                return false;
            }
            return Grid[y, x] == " " || Grid[y, x] == "X";
        }
    }
}
