using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.MiscUtils;

namespace Chess.Controller
{
    class MenuController
    {
        // Method - Get option from user input
        public int GetOption(int startRange, int endRange)
        {
            int option = startRange - 1;

            do
            {
                ConsoleKeyInfo key = KeyHandler.Read();

                if (KeyHandler.IsNumericKey(key))
                {
                    option = int.Parse(KeyHandler.ConvertToChar(key).ToString());
                }

            } while (option < startRange || option > endRange);

            return option;
        }
    }
}
