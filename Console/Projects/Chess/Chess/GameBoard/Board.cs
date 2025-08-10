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

        // Method - Place pieces on the board
        private void PlacePieces<PieceType>(List<PieceType> pieces, int pieceId) where PieceType : Piece    // Includes every child classes as well
        {
            for (int i = 0; i < pieces.Count; i++)
            {
                var piece = pieces[i];
                if (piece.CurrentPosition is not null)
                {
                    Position position = piece.CurrentPosition;

                    // Update cell with the piece's symbol
                    UpdateCell(position, piece.Symbol_);

                    // Update the piece token
                    UpdatePieceToken(position, new PieceToken(i, pieceId, i % 2));
                }
            }
        }

        // Method - Place pieces
        public void PlaceAllPieces(Pieces.PieceHandler handler)
        {
            PlacePieces(handler.Pawns, PieceToken.PawnId);
            PlacePieces(handler.Rooks, PieceToken.RookId);
            PlacePieces(handler.Knights, PieceToken.KnightId);
            PlacePieces(handler.Bishops, PieceToken.BishopId);
            PlacePieces(handler.Queens, PieceToken.QueenId);
            PlacePieces(handler.Kings, PieceToken.KingId);
        }
    }
}
