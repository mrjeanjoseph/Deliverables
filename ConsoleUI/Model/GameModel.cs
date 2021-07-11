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
            WorldClass gameWorld = new WorldClass(grid);
            gameWorld.Draw();

            WriteLine(gameWorld.IsPositionWalkable(0, 0));
            WriteLine(gameWorld.IsPositionWalkable(1, 1));
            WriteLine(gameWorld.IsPositionWalkable(6, 1));

        }
        public void Quit()
        {
            Environment.Exit(0);
        }
    }
}
