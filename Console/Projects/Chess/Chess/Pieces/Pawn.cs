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
        // Constructor
        public Pawn(string symbol) : base(symbol)
        {
            isSymbolChangeable = true; // Pawns can change their symbol when they promote
        }
        
        // Method - Is valid destination
        public bool IsValidDestination(Position destination)
        {
            // Logic to check if the destination is valid for a pawn
            // For simplicity, let's assume pawns can only move one step forward
            // and can capture diagonally.
            Position absDifference = Position.GetAbsoluteDifference(CurrentPosition, destination);

            return  (absDifference.Row == 1 && absDifference.Column == 0) ||    // Move forward (Top to Bottom)
                    (absDifference.Row == 0 && absDifference.Column == 1) ||    // Move forword (Bottom to Top)
                    (absDifference.Row == 1 && absDifference.Column == 1);      // Capture diagonally
        }
    }
}
