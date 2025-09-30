using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.MenuUtils;

namespace Chess.MiscUtils
{
    class Message
    {
        // Error message
        public static void Error(string message)
        {
            Text errorText = new Text(message, ConsoleColor.Red);
            errorText.Display(true);
        }

        // Prompt message
        public static void Prompt(string message, bool lineBreak = false)
        {
            Text promptText = new Text(message, ConsoleColor.Yellow);
            promptText.Display(lineBreak);
        }

        // Warning message
        public static void Warning(string message)
        {
            Text warningText = new Text(message, ConsoleColor.DarkYellow);
            warningText.Display(true);
        }

        // Success message
        public static void Success(string message)
        {
            Text successText = new Text(message, ConsoleColor.Green);
            successText.Display(true);
        }

        // Information message
        public static void Info(string message)
        {
            Text infoText = new Text(message, ConsoleColor.Cyan);
            infoText.Display(true);
        }

        // Hold message
        public static void Hold()
        {
            Prompt("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
