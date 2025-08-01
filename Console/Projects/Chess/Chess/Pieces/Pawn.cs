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
    }
}
