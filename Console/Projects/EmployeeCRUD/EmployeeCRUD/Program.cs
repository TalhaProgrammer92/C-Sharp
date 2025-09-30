using EmployeeCRUD.UI;

namespace EmployeeCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text("Welcome to Employee CRUD Application", new Color(ConsoleColor.Yellow, ConsoleColor.DarkBlue));
            //text.Display(true);
            Cell cell = new Cell(text, 5, 5);
            //cell.Display();

            Box box = new Box(cell, new Decorator('*', new Color(ConsoleColor.Red)));
            box.Display(isConnected: true, isFilled: true);
        }
    }
}
