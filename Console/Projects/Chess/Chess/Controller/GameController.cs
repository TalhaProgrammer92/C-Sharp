using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.MiscUtils;

namespace Chess.Controller
{
    class GameController
    {
        // Attributes
        ConsoleKeyInfo key;

        // Method - Get the key pressed by the user
        public void TakeInput()
        {
            key = KeyHandler.Read();
        }

        // Methods - check which key is pressed
        public bool IsUpArrowPressed()
        {
            return key.Key == ConsoleKey.UpArrow;
        }

        public bool IsDownArrowPressed()
        {
            return key.Key == ConsoleKey.DownArrow;
        }

        public bool IsLeftArrowPressed()
        {
            return key.Key == ConsoleKey.LeftArrow;
        }

        public bool IsRightArrowPressed()
        {
            return key.Key == ConsoleKey.RightArrow;
        }

        public bool IsEnterPressed()
        {
            return key.Key == ConsoleKey.Enter;
        }

        public bool IsCheatActivationKeyPressed()
        {
            return key.Key == ConsoleKey.C;
        }

        public bool IsUndoKeyPressed()
        {
            return key.Key == ConsoleKey.Z;
        }

        public bool IsResetKeyPressed()
        {
            return key.Key == ConsoleKey.R;
        }

        public bool IsTurnSkipKeyPressed()
        {
            return key.Key == ConsoleKey.T;
        }
    }
}
