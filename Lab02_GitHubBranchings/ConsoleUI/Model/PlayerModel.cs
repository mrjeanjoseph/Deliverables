using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleUI.Model
{
    class PlayerModel
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string PlayerMarker;
        private ConsoleColor PlayerColor;

        public PlayerModel(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;

            PlayerMarker = "0";
            PlayerColor = ConsoleColor.Red;
        }

        public void Draw()
        {
            ForegroundColor = PlayerColor;
            SetCursorPosition(X, Y);
            Write(PlayerMarker);
            ResetColor();
        }

    }
}
