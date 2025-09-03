using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Board
{
    public class Board
    {
        // Attributes
        public char[,] Grid { get; set; }

        // Constructor
        public Board()
        {
            Grid = new char[3, 3]
            {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };
        }
    }
}
