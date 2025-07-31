using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.MiscUtils
{
    class Position
    {
        // Attributes
        public int Row { get; set; }
        public int Column { get; set; }

        // Constructors
        public Position()
        {
            Row = 0;
            Column = 0;
        }

        public Position(Position position)
        {
            Row = position.Row;
            Column = position.Column;
        }

        public Position(string labeledPosition)
        {
            Position pos = FromLabeledPosition(labeledPosition);
            Row = pos.Row;
            Column = pos.Column;
        }

        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }

        // Method - Print the position
        public void Print()
        {
            Console.WriteLine($"Position: Row = {Row}, Column = {Column}");
        }

        // Method - Convert labeled position to numeric position
        public static Position FromLabeledPosition(string labeledPosition)
        {
            if (labeledPosition.Length != 2)
            {
                throw new ArgumentException("Invalid labeled position format. Expected format: 'A1', 'B2', etc.");
            }

            char columnChar = labeledPosition[0];
            int row = int.Parse(labeledPosition[1].ToString());
            // Convert column character to numeric index (A=1, B=2, ..., H=8)
            int column = char.ToUpper(columnChar) - 'A' + 1;
            return new Position(row, column);
        }

        // Methods - Check if two positions' equality
        public static bool operator ==(Position pos1, Position pos2)
        {
            return pos1.Row == pos2.Row && pos1.Column == pos2.Column;
        }

        public static bool operator !=(Position pos1, Position pos2)
        {
            return pos1.Row != pos2.Row || pos1.Column != pos2.Column;
        }

        // Method - Calculate the difference between two positions
        public static Position operator -(Position pos1, Position pos2)
        {
            return new Position(pos1.Row - pos2.Row, pos1.Column - pos2.Column);
        }

        // Method - Check if position is valid
        public bool IsValid()
        {
            return Row >= 1 && Row <= 8 && Column >= 1 && Column <= 8;
        }

        // Methos - Get absolute difference between two positions
        public static Position GetAbsoluteDifference(Position pos1, Position pos2)
        {
            return new Position(Math.Abs(pos1.Row - pos2.Row), Math.Abs(pos1.Column - pos2.Column));
        }
    }
}
