using Chess.GamePlayer;
using Chess.MenuUtils;
using Chess.Pieces;
using Chess.MiscUtils;
using Chess.GameBoard;

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

            //MiscUtils.Utils.SetUTF8Encoding();

            //Console.WriteLine(Pieces.Unicode.WhiteKing);
            //Console.WriteLine(Pieces.Unicode.BlackKing);

            //Pawn pawn = new Pawn(Unicode.WhitePawn, new Position(1, 2));
            //pawn.Print();

            //Position destination = new Position(2, 2);
            //bool isValidDestination = pawn.IsValidDestination(destination);
            //Console.WriteLine($"Is the destination {Position.GetString(destination)} valid: {isValidDestination}");

            //if (isValidDestination) pawn.UpdatePosition(destination); 
            //pawn.Print();

            //Board board = new Board();
            //board.Display();

            PawnPromotionMenu promotionMenu = new PawnPromotionMenu();
            promotionMenu.Display();
            promotionMenu.TakeInput();
        }
    }
}
