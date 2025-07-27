using Chess.GamePlayer;
using Chess.Menu;

namespace Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Header header = new Header("Chess Game", 4, 4, new Decorator('*', ConsoleColor.Cyan), ConsoleColor.Yellow);
            header.display();
        }
    }
}
