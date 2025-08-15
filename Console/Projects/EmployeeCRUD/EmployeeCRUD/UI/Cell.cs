using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUD.UI
{
    class Cell
    {
        // Attributes
        public Text Text { get; set; }
        public int PaddingLeft { get; set; }
        public int PaddingRight { get; set; }
        public int Size { get { return Text.Data.Length + PaddingLeft + PaddingRight; } }

        // Constructor
        public Cell(Text text, int paddingLeft, int paddingRight)
        {
            Text = text;
            PaddingLeft = paddingLeft;
            PaddingRight = paddingRight;
        }

        // Method - Display
        public void Display()
        {
            // Display padding on the left
            Console.Write(new string(' ', PaddingLeft));

            // Display the text
            Text.Display(false);
            
            // Display padding on the right
            Console.Write(new string(' ', PaddingRight));
        }

        // Method - Display filled
        public void DisplayFilled()
        {
            // Display padding on the left
            Text.Color.Set();
            Console.Write(new string(' ', PaddingLeft));

            // Display the text with padding
            Text.Display(false);

            // Display padding on the right
            Text.Color.Set();
            Console.Write(new string(' ', PaddingRight));
        }
    }
}
