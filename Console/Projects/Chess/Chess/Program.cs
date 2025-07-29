using Chess.GamePlayer;
using Chess.MenuUtils;

namespace Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Header header = new Header("Main Menu", 4, 4, new Decorator('*', ConsoleColor.Cyan), ConsoleColor.Yellow);
            //header.display();

            Menu menu = new Menu(
                header,
                new List<Text>
                {
                    new Text("Start Game", ConsoleColor.Green),
                    new Text("Load Game", ConsoleColor.Blue),
                    new Text("Settings", ConsoleColor.Magenta),
                    new Text("Exit", ConsoleColor.Red)
                }
            );

            menu.display();
        }
    }
}
