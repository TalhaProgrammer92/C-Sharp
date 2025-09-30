using TicTacToe.Board;
using TicTacToe.Misc;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //var board = new GameBoard();
            //board.Display();

            Text text = new Text
            (
                text:"Welcome to Tic Tac Toe!",
                colorProperty:new ColorProperty
                (
                    fg:ConsoleColor.DarkMagenta,
                    bg:ConsoleColor.Yellow
                )
            );
            text.Display(lineBreak:true);
        }
    }
}
