using Chess.MiscUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.GameBoard
{
    class Board
    {
        // Attributes
        public Cell[,] Grid { get; set; }

        // Constructor
        public Board()
        {
            Grid = new Cell[8, 8];
            InitializeBoard();
        }

        // Method - Initialize the board
        private void InitializeBoard()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    // Create a cell with a default symbol
                    Position position = new Position(row, col);
                    Grid[row, col] = new Cell(Cell.GetEmptyCellSymbol(position), position);
                }
            }
        }

        // Method - Display the board
        public void Display()
        {
            Console.Clear();
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Grid[row, col].Display();
                    Console.Write(" "); // Add space between cells
                }
                Console.WriteLine(); // New line after each row
            }
        }
    }
}
