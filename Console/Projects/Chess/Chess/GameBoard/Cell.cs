using Chess.MiscUtils;
using Chess.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.GameBoard
{
    class Cell
    {
        // Attributes
        public Symbol Symbol_ {  get; set; }
        public Position Position_ { get; }
        public bool IsOccupied { get { return Symbol_.Unicode != Unicode.WhiteCell && Symbol_.Unicode != Unicode.BlackCell; } }
        public PieceToken PieceToken_ { get; set; } // Token to hold the piece (ID) information for piece handler
        public bool IsHighlighted { get; set; }

        // Cpmstructpr
        public Cell(Symbol symbol, Position position)
        {
            this.Symbol_ = symbol;
            this.Position_ = position;
            PieceToken_ = new PieceToken();
        }

        // Method - Display the cell
        public void Display()
        {
            //Console.SetCursorPosition(position.Column * 2, position.Row);
            if (IsHighlighted)
                Console.BackgroundColor = ConsoleColor.DarkGray;
            
            Symbol_.Display();
        }

        // Method - Get empty cell
        public static Symbol GetEmptyCellSymbol(Position position)
        {
            int index = (position.Row + position.Column) % 2;
            ConsoleColor color = Utils.GetAccentColor(index);

            return (index == 0) ? new Symbol(Unicode.WhiteCell, color) : new Symbol(Unicode.BlackCell, color);
        }
    }
}
