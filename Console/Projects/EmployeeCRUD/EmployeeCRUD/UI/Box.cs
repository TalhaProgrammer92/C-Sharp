using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUD.UI
{
    class Box
    {
        // Attributes
        public Cell Cell { get; set; }
        public Decorator Decorator { get; set; }

        // Constructor
        public Box(Cell cell, Decorator decorator)
        {
            Cell = cell;
            Decorator = decorator;
        }

        // Method - Display decorator
        void DisplayDecorator(int size)
        {
            for (int i = 0; i < size; i++)
                Decorator.Display();
            Console.WriteLine();
        }

        // Method - Display
        /*
         ------
         - Hi -
         ------
         */
        public void Display(bool isConnected = false, bool isFilled = false)
        {
            int decoratorSize = isConnected ? Cell.Size + 2 : Cell.Size;
            DisplayDecorator(decoratorSize);

            if (isConnected)
                Decorator.Display();

            if (isFilled)
                Cell.DisplayFilled();
            else
                Cell.Display();

            if (isConnected)
                Decorator.Display();

            Console.WriteLine();

            DisplayDecorator(decoratorSize);
        }
    }
}
