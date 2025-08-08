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

            // Debugging Purpose
            //Grid[0, 0].Symbol_.Unicode = Pieces.Unicode.WhiteRook;
        }

        // Display - Column Labels
        void DisplayColumnLabels()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("  ");
            for (char label = 'a'; label <= 'h'; label++)
                Console.Write($"{label} ");
            Console.ResetColor();
            Console.WriteLine();
        }

        // Display - Row Label
        void DisplayRowLabel(int row, bool extraSpace = true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            if (extraSpace)    // Left Side
                Console.Write($"{row + 1} ");
            else    // Right Side
                Console.Write($"{row + 1}");
            
            Console.ResetColor();
        }

        // Display - Board Grid
        void DisplayGrid()
        {
            for (int row = 0; row < 8; row++)
            {
                // Labels - Row
                DisplayRowLabel(row);

                // Cells
                for (int col = 0; col < 8; col++)
                {
                    Grid[row, col].Display();
                    Console.Write(" "); // Add space between cells
                }

                // Labels - Row
                DisplayRowLabel(row, false);

                Console.WriteLine(); // New line after each row
            }
        }

        // Method - Display the board
        public void Display()
        {
            Console.Clear();

            // Labels - Column
            DisplayColumnLabels();

            // Grid
            DisplayGrid();

            DisplayColumnLabels();
        }

        // Method - Place pieces
        public void PlaceAllPieces(Pieces.PieceHandler handler)
        {
            // Pawns
            foreach (var pawn in handler.Pawns)
            {
                if (pawn.CurrentPosition is not null)
                {
                    Position position = pawn.CurrentPosition;
                    Grid[position.Row, position.Column].Symbol_ = pawn.Symbol_;
                }
            }

            // Rooks
            foreach (var rook in handler.Rooks)
            {
                if (rook.CurrentPosition is not null)
                {
                    Position position = rook.CurrentPosition;
                    Grid[position.Row, position.Column].Symbol_ = rook.Symbol_;
                }
            }

            // Knights
            foreach (var knight in handler.Knights)
            {
                if (knight.CurrentPosition is not null)
                {
                    Position position = knight.CurrentPosition;
                    Grid[position.Row, position.Column].Symbol_ = knight.Symbol_;
                }
            }

            // Bishops
            foreach (var bishop in handler.Bishops)
            {
                if (bishop.CurrentPosition is not null)
                {
                    Position position = bishop.CurrentPosition;
                    Grid[position.Row, position.Column].Symbol_ = bishop.Symbol_;
                }
            }

            // Queens
            foreach (var queen in handler.Queens)
            {
                if (queen.CurrentPosition is not null)
                {
                    Position position = queen.CurrentPosition;
                    Grid[position.Row, position.Column].Symbol_ = queen.Symbol_;
                }
            }

            // Kings
            foreach (var king in handler.Kings)
            {
                if (king.CurrentPosition is not null)
                {
                    Position position = king.CurrentPosition;
                    Grid[position.Row, position.Column].Symbol_ = king.Symbol_;
                }
            }
        }
    }
}
