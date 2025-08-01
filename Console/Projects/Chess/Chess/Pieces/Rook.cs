using Chess.MiscUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Rook : Piece
    {
        // Method - Get valid displacements
        public static List<Position> GetValidDisplacementPositions()
        {
            var displacementPositions = new List<Position>();

            for (int i = 0; i < 8; i++)
            {
                displacementPositions.Add(new Position(i, 0));
                displacementPositions.Add(new Position(0, i));
            }

            return displacementPositions;
        }

        // Constructor
        public Rook(Symbol symbol, Position position) : 
            base(symbol, position, Rook.GetValidDisplacementPositions()) {}
    }
}
