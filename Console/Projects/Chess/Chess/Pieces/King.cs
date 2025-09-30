using Chess.MiscUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class King : Piece
    {
        // Method - Get valid displacements
        public static List<Position> GetValidDisplacementPositions()
        {
            var displacementPositions = new List<Position>();

            displacementPositions.Add(new Position(1, 1));
            displacementPositions.Add(new Position(1, 0));
            displacementPositions.Add(new Position(0, 1));

            return displacementPositions;
        }

        // Constructor
        public King(Symbol symbol, Position position) : 
            base(symbol, position, King.GetValidDisplacementPositions()) {}
    }
}
