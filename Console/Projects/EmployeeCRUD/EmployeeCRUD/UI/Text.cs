using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUD.UI
{
    class Text
    {
        // Attributes
        public string Data { get; set; }
        public Color Color { get; set; }

        // Constructor
        public Text(string data, Color color)
        {
            Data = data;
            Color = color;
        }

        // Method - Display
        public void Display(bool lineBreak = false)
        {
            Color.Set();

            if (lineBreak)
                Console.WriteLine(Data);
            else
                Console.Write(Data);
            
            Color.Reset();
        }
    }
}
