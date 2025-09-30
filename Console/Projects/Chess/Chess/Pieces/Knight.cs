using Chess.MiscUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Knight : Piece
    {
        // Method - Get valid displacements
        public static List<Position> GetValidDisplacementPositions()
        {
            var displacementPositions = new List<Position>();

            displacementPositions.Add(new Position(2, 1));
            displacementPositions.Add(new Position(1, 2));

            return displacementPositions;
        }

        // Constructor
        public Knight(Symbol symbol, Position position) : 
            base(symbol, position, Knight.GetValidDisplacementPositions()) {}
    }
}
