using Chess.MenuUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.MenuUtils
{
    class MainMenu : Menu
    {
        // Constructor
        public MainMenu() : base(
            new Header("Main Menu", 4, 4, new Decorator('*', ConsoleColor.Cyan), ConsoleColor.Yellow),
            new List<Text>
            {
                    new Text("Start Game", ConsoleColor.Green),
                    new Text("Load Game", ConsoleColor.Blue),
                    new Text("Leaderboard", ConsoleColor.DarkYellow),
                    new Text("Settings", ConsoleColor.Magenta),
                    new Text("Exit", ConsoleColor.Red)
            }
        ) {}
    }
}
