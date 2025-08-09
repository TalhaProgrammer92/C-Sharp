using Chess.MiscUtils;
using Chess.Pieces;
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

        // Method - Check position validity
        public bool IsValidPosition(Position position)
        {
            return position.Row >= 0 && position.Row < 8 && position.Column >= 0 && position.Column < 8;
        }

        // Method - Update the board with a new cell
        public void UpdateCell(Position position, Symbol symbol)
        {
            // Validate position
            if (!IsValidPosition(position))
                throw new ArgumentOutOfRangeException("Position is out of bounds.");

            // Update the cell at the specified position
            Grid[position.Row, position.Column].Symbol_ = symbol;
        }

        // Method - Update the piece token at a specific position
        public void UpdatePieceToken(Position position, PieceToken pieceToken)
        {
            // Validate position
            if (!IsValidPosition(position))
                throw new ArgumentOutOfRangeException("Position is out of bounds.");
            
            // Update the piece token at the specified position
            Grid[position.Row, position.Column].PieceToken_ = pieceToken;
        }

        // Method - Place pieces
        public void PlaceAllPieces(Pieces.PieceHandler handler)
        {
            // Pawns
            for (int i = 0; i < handler.Pawns.Count; i++)
            {
                var pawn = handler.Pawns[i];

                if (pawn.CurrentPosition is not null)
                {
                    Position position = pawn.CurrentPosition;

                    // Update the cell with the pawn's symbol
                    UpdateCell(position, pawn.Symbol_);

                    // Update the piece token for the pawn
                    UpdatePieceToken(position, new PieceToken(i, 1, i % 2));
                }
            }

            // Rooks
            for (int i = 0; i < handler.Rooks.Count; i++)
            {
                var rook = handler.Rooks[i];
                
                if (rook.CurrentPosition is not null)
                {
                    Position position = rook.CurrentPosition;
                    
                    // Update the cell with the rook's symbol
                    UpdateCell(position, rook.Symbol_);
                    
                    // Update the piece token for the rook
                    UpdatePieceToken(position, new PieceToken(i, 4, i % 2));
                }
            }

            // Knights
            for (int i = 0; i < handler.Knights.Count; i++)
            {
                var knight = handler.Knights[i];
                
                if (knight.CurrentPosition is not null)
                {
                    Position position = knight.CurrentPosition;
                    
                    // Update the cell with the knight's symbol
                    UpdateCell(position, knight.Symbol_);
                    
                    // Update the piece token for the knight
                    UpdatePieceToken(position, new PieceToken(i, 3, i % 2));
                }
            }

            // Bishops
            for (int i = 0; i < handler.Bishops.Count; i++)
            {
                var bishop = handler.Bishops[i];
                
                if (bishop.CurrentPosition is not null)
                {
                    Position position = bishop.CurrentPosition;
                    
                    // Update the cell with the bishop's symbol
                    UpdateCell(position, bishop.Symbol_);
                    
                    // Update the piece token for the bishop
                    UpdatePieceToken(position, new PieceToken(i, 2, i % 2));
                }
            }

            // Queens
            for (int i = 0; i < handler.Queens.Count; i++)
            {
                var queen = handler.Queens[i];
                
                if (queen.CurrentPosition is not null)
                {
                    Position position = queen.CurrentPosition;
                    
                    // Update the cell with the queen's symbol
                    UpdateCell(position, queen.Symbol_);
                    
                    // Update the piece token for the queen
                    UpdatePieceToken(position, new PieceToken(i, 5, i % 2));
                }
            }

            // Kings
            for (int i = 0; i < handler.Kings.Count; i++)
            {
                var king = handler.Kings[i];
                
                if (king.CurrentPosition is not null)
                {
                    Position position = king.CurrentPosition;
                    
                    // Update the cell with the king's symbol
                    UpdateCell(position, king.Symbol_);
                    
                    // Update the piece token for the king
                    UpdatePieceToken(position, new PieceToken(i, 0, i % 2));
                }
            }
        }
    }
}
