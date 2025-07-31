using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.MiscUtils;

namespace Chess.Pieces
{
    abstract class Piece
    {
        // Attributes
        protected string symbol;
        protected bool isSymbolChangeable = false;

        public Position CurrentPosition { get; set; }
        public Position RecentPosition { get; set; }

        // Constructor
        public Piece(string symbol)
        {
            this.symbol = symbol;
        }

        // Getter and Setter - Symbol
        public string Symbol
        {
            get { return symbol; }
            set { if (isSymbolChangeable) symbol = value; }
        }

        // Method - Print the piece
        public void Print()
        {
            Console.WriteLine($"Piece: {symbol}, Current Position: {CurrentPosition.Row}{CurrentPosition.Column}, Recent Position: {RecentPosition.Row}{RecentPosition.Column}");
        }

        // Method - Update the piece position to a new position
        protected void UpdatePosition(Position newPosition)
        {
            RecentPosition = new Position(CurrentPosition);
            CurrentPosition = new Position(newPosition);
        }
    }
}
