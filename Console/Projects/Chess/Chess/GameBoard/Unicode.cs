using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.GameBoard
{
    class Unicode
    {
        public static readonly string WhiteCell = "o";
        public static readonly string BlackCell = "x";

        public static readonly List<string> RowLabels = new List<string>
        {
            "1", "2", "3", "4", "5", "6", "7", "8"
        };
        public static readonly List<string> ColumnLabels = new List<string>
        {
            "a", "b", "c", "d", "e", "f", "g", "h"
        };
    }
}
