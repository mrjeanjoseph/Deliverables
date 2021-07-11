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
            Title = "Welcome to the Maze";
            CursorVisible = false;

            string[,] grid =
            {

                { "=", " ", "=", " ", " ", " ", "X"},
                { "=", " ", " ", " ", "=", " ", " "},
                { "O", " ", "=", " ", "=", " ", "="},
                { "=", " ", "=", " ", " ", " ", " "},
                { " ", " ", " ", "=", "=", " ", "="},
                { "=", "=", "=", "=", "=", "=", "="},

            };
            myWorld = new WorldClass(grid);

            currentPlayer = new PlayerModel(0, 1);
            RunGameLoop();

        }

        private void DisplayIntro()
        {
            WriteLine("Welcome to the Maze!");
            WriteLine("\nInstructions");
            WriteLine(">Use the arrow keys to move");
            Write("> Try to reach the goal, which looks like this: ");
            ForegroundColor = ConsoleColor.Green;
            WriteLine("X");
            ResetColor();
            WriteLine("> Press any key to start");
            ReadKey(true);
        }

        private void DisplayOutro()
        {
            Clear();
            WriteLine("You escaped");
            WriteLine("Thanks for playing");
            WriteLine("Press any key to exit");
            ReadKey(true);
        }


        private void DrawFrame()
        {
            Clear();
            myWorld.Draw();
            currentPlayer.Draw();
        }

        private void RunGameLoop()
        {
            DisplayIntro();
            while (true)
            {
                //Draw everything
                DrawFrame();

                //Check for player input from the keyboard and move the player
                HandlePlayerInput();
                string elementAtPlayerPos = myWorld.GetElementAt(currentPlayer.X, currentPlayer.Y);
                if (elementAtPlayerPos == "X")
                {
                    break;
                }

                //Check if the player has reached the exit and end the game if so.

                //Give the console a chance to render.
                System.Threading.Thread.Sleep(20);
            }
            DisplayOutro();
        }

        private void HandlePlayerInput()
        {
            ConsoleKeyInfo keyInfo = ReadKey(true);
            ConsoleKey key = keyInfo.Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (myWorld.IsPositionWalkable(currentPlayer.X, currentPlayer.Y - 1))
                    {
                        currentPlayer.Y -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (myWorld.IsPositionWalkable(currentPlayer.X, currentPlayer.Y + 1))
                    {
                        currentPlayer.Y += 1;
                    }

                    break;
                case ConsoleKey.LeftArrow:
                    if (myWorld.IsPositionWalkable(currentPlayer.X - 1, currentPlayer.Y))
                    {
                        currentPlayer.X -= 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (myWorld.IsPositionWalkable(currentPlayer.X + 1, currentPlayer.Y))
                    {
                        currentPlayer.X += 1;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
