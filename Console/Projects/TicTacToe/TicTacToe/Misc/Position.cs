using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Misc
{
    public class Position
    {
        // Attributes
        int row, column;

        // Constructor
        public Position()
        {
            row = 0; column = 0;
        }
        public Position(int row, int column)
        {
            this.row = row;
            this.column = column;
        }
        
        // Getters & Setters
        public int Row
        {
            get { return row; }
            set { row = (value >= 0 && value < 3) ? value : row; }
        }
        public int Column
        {
            get { return column; }
            set { column = (value >= 0 && value < 3) ? value : column; }
        }

        // Method - Convert single index (1-9) to position
        public static Position ConvertFromIndexToPosition(int index)
        {
            if (index < 1 || index > 9)
            {
                return new Position();
            }

            return new Position(Convert.ToInt32(index / 3), index % 3);
        }

        // Representation method
        public override string ToString()
        {
            return $"({Row}, {Column})";
        }
    }
}
