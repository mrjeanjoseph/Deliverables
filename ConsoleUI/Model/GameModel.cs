using Figgle;
using Pastel;
using System;
using static System.Console;

namespace ConsoleUI.Model
{
    class GameModel
    {
        private WorldClass myWorld;
        private PlayerModel currentPlayer;
        public void Start()
        {
            Title = "Welcome to the Maze";
            CursorVisible = false;

            string[,] grid = LevelParser.LevelParser.ParseFileToArray(@"LevelParser\Level1.txt");
            myWorld = new WorldClass(grid);

            currentPlayer = new PlayerModel(1, 2);
            RunGameLoop();
        }

        private void DisplayIntro()
        {
            WriteLine(FiggleFonts.Larry3d.Render("This is"));
            WriteLine(FiggleFonts.Larry3d.Render("The MAZE"));

            WriteLine("\nInstructions");
            WriteLine(">Use the arrow keys to move");
            Write("> Try to reach the goal, which looks like this: ");
            WriteLine("X".Pastel("#b3ffbf"));
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
                DrawFrame();
                HandlePlayerInput();
                string elementAtPlayerPos = myWorld.GetElementAt(currentPlayer.X, currentPlayer.Y);
                if (elementAtPlayerPos == "X")
                {
                    break;
                }
            }
            DisplayOutro();
        }

        private void HandlePlayerInput()
        {
            ConsoleKey key;

            do
            {
                ConsoleKeyInfo keyInfo = ReadKey(true);
                key = keyInfo.Key;

            } while (KeyAvailable);

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
