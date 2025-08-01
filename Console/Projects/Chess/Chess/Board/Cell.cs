using Chess.MiscUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Board
{
    class Cell
    {
        // Attributes
        public Symbol symbol {  get; set; }

        // Cpmstructpr
        public Cell(Symbol symbol)
        {
            this.symbol = symbol;
        }
    }
}
