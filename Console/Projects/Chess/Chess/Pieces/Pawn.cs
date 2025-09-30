using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.MiscUtils;

namespace Chess.Pieces
{
    class Pawn : Piece
    {
        // Attributes
        bool IsEnPassantPossible;

        // Method - Get valid displacements
        public static List<Position> GetValidDisplacementPositions()
        {
            var displacementPositions = new List<Position>();
            
            displacementPositions.Add(new Position(1, 0));
            displacementPositions.Add(new Position(1, 1));
            displacementPositions.Add(new Position(2, 0));

            return displacementPositions;
        }

        // Constructor
        public Pawn(Symbol symbol, Position position) : 
            base(symbol, position, Pawn.GetValidDisplacementPositions()) {}

        // Method - Update position
        public new void UpdatePosition(Position position)
        {
            // Update the position
            base.UpdatePosition(position);

            // Remove the (2, 0) position
            Position doubleJump = new Position(2, 0);
            if (allowedDisplacementPositions.Contains(doubleJump))
                allowedDisplacementPositions.Remove(doubleJump);
        }

        // Method - Check if en passant allowed
        public bool CanEnPassant(Position destination)
        {
            return (IsValidDestination(destination) && IsEnPassantPossible);
        }

        // Method - Check if the pawn can be promoted
        public bool CanBePromoted()
        {
            if (CurrentPosition is null)
                return false;

            // Check if the pawn is on the last row
            return (CurrentPosition.Row == 0 || CurrentPosition.Row == 7);
        }

        // Method - Promote pawn to queen
        public Queen PromoteToQueen()
        {
            // Create a new queen piece
            string unicode = (symbol.Unicode == Unicode.WhitePawn) ? Unicode.WhiteQueen : Unicode.BlackQueen;
            Queen queen = new Queen(new Symbol(unicode, symbol.Color), CurrentPosition!);

            // Return the new queen piece
            return queen;
        }

        // Method - Promote pawn to rook
        public Rook PromoteToRook()
        {
            // Create a new rook piece
            string unicode = (symbol.Unicode == Unicode.WhitePawn) ? Unicode.WhiteRook : Unicode.BlackRook;
            Rook rook = new Rook(new Symbol(unicode, symbol.Color), CurrentPosition!);

            // Return the new rook piece
            return rook;
        }

        // Method - Promote pawn to bishop
        public Bishop PromoteToBishop()
        {
            // Create a new bishop piece
            string unicode = (symbol.Unicode == Unicode.WhitePawn) ? Unicode.WhiteBishop : Unicode.BlackBishop;
            Bishop bishop = new Bishop(new Symbol(unicode, symbol.Color), CurrentPosition!);

            // Return the new bishop piece
            return bishop;
        }

        // Method - Promote pawn to knight
        public Knight PromoteToKnight()
        {
            // Create a new knight piece
            string unicode = (symbol.Unicode == Unicode.WhitePawn) ? Unicode.WhiteKnight : Unicode.BlackKnight;
            Knight knight = new Knight(new Symbol(unicode, symbol.Color), CurrentPosition!);

            // Return the new knight piece
            return knight;
        }
    }
}
