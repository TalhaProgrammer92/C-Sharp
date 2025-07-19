namespace DatatypeVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int x, y, sum;

            // Take Input
            Console.Write("Enter 1st number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            y = Convert.ToInt32(Console.ReadLine());

            // Calculate Sum
            sum = x + y;

            // Display Sum
            Console.WriteLine($"Sum is {sum}");
        }
    }
}
