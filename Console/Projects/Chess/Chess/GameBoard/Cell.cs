using Chess.MiscUtils;
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
        public Symbol symbol {  get; set; }
        public Position position { get; }
        public bool IsOccupied { get { return symbol.Unicode != Unicode.WhiteCell && symbol.Unicode != Unicode.BlackCell; } }

        // Cpmstructpr
        public Cell(Symbol symbol, Position position)
        {
            this.symbol = symbol;
            this.position = position;
        }

        // Method - Display the cell
        public void Display()
        {
            //Console.SetCursorPosition(position.Column * 2, position.Row);
            symbol.Display();
        }

        // Method - Get empty cell
        public static Symbol GetEmptyCellSymbol(Position position)
        {
            return ((position.Row + position.Column) % 2 == 0) ? new Symbol(Unicode.WhiteCell, ConsoleColor.Cyan) 
                : new Symbol(Unicode.BlackCell, ConsoleColor.Red);
        }
    }
}
