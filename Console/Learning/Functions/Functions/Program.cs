using System.ComponentModel;

namespace Functions
{
    internal class Program
    {
        // Addition
        static int add(int x, int y) { return x + y; }

        // Subtraction
        static int sub(int x, int y) { return x - y; }

        // Multiplication
        static int mul(int x, int y) { return x * y; }

        // Division
        static int div(int x, int y) { return x / y; }

        static void Main(string[] args)
        {
            // Variables
            int a = 3, b = 5;

            // Display
            Console.WriteLine($"Addition: {add(a, b)}");
            Console.WriteLine($"Subtraction: {sub(a, b)}");
            Console.WriteLine($"Multiplication: {mul(a, b)}");
            Console.WriteLine($"Division: {div(a, b)}");
        }
    }
}
