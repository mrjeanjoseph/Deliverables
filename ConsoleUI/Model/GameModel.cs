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
        private WorldClass myWorld;
        private PlayerModel currentPlayer;
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
            myWorld = new WorldClass(grid);

            currentPlayer = new PlayerModel(0, 2);
            RunGameLoop();

        }

        private void DrawFrame()
        {
            Clear();
            myWorld.Draw();
            currentPlayer.Draw();
        }

        private void RunGameLoop()
        {
            while (true)
            {
                //Draw everything
                DrawFrame();

                //Check for player input from the keyboard and move the player
                HandlePlayerInput();

                //Check if the player has reached the exit and end the game if so.
                System.Threading.Thread.Sleep(20);

                //Give the console a chance to render.
            }
        }

        private void HandlePlayerInput()
        {
            ConsoleKeyInfo keyInfo = ReadKey(true);
            ConsoleKey key = keyInfo.Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    currentPlayer.Y -= 1;
                    break;
                case ConsoleKey.DownArrow:
                    currentPlayer.Y += 1;
                    break;
                case ConsoleKey.LeftArrow:
                    currentPlayer.X -= 1;
                    break;
                case ConsoleKey.RightArrow:
                    currentPlayer.X += 1;
                    break;
                default:
                    break;
            }
        }
    }
}
