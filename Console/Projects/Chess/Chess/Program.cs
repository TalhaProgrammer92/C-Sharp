using Chess.GamePlayer;

namespace Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            bool valid = Name.isValid("DON");
            Console.WriteLine($"Valid: {valid}");

            bool equal = Name.areEqual("DON", "dan");
            Console.WriteLine($"Equal: {equal}");
        }
    }
}
