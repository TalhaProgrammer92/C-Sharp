using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.MiscUtils
{
    class KeyHandler
    {
        // Method - Read a key
        public static ConsoleKeyInfo Read()
        {
            return Console.ReadKey(true);
        }

        // Method to check if a numeric key is perssed
        public static bool IsNumericKey(ConsoleKeyInfo keyInfo)
        {
            // Check if the key is a digit
            return char.IsDigit(keyInfo.KeyChar);
        }

        // Method to convert pressed key to character
        public static char ConvertToChar(ConsoleKeyInfo keyInfo)
        {
            // Return the character representation of the key
            return keyInfo.KeyChar;
        }

        // Method to test key events in the console
        public static void Test()
        {
            Console.WriteLine("Press any key to test (press ESC to exit)...");

            while (true)
            {
                // Only run when a key is pressed
                if (Console.KeyAvailable)
                {
                    // Read the key without showing it on the console
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                    Console.WriteLine($"You pressed: {keyInfo.Key}");

                    // Exit on ESC
                    if (keyInfo.Key == ConsoleKey.Escape)
                        break;
                }
            }
        }
    }
}
