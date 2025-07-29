using Chess.GamePlayer;
using Chess.MenuUtils;

namespace Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Header header = new Header("Welcome to Chess Game!", 4, 4, new Decorator('*', ConsoleColor.Cyan), ConsoleColor.Yellow);
            ////header.display();

            //Menu menu = new Menu(
            //    header,
            //    new List<Text>
            //    {
            //        new Text("Start Game", ConsoleColor.Green),
            //        new Text("Load Game", ConsoleColor.Blue),
            //        new Text("Leaderboard", ConsoleColor.DarkYellow),
            //        new Text("Settings", ConsoleColor.Magenta),
            //        new Text("Exit", ConsoleColor.Red)
            //    }
            //);
            //MainMenu menu = new MainMenu();

            //// Display
            //menu.display();

            //// Take input
            //Console.WriteLine(menu.TakeInput());

            MiscUtils.Utils.SetUTF8Encoding();

            Console.WriteLine(Pieces.Unicode.WhiteKing);
            Console.WriteLine(Pieces.Unicode.BlackKing);
        }
    }
}
