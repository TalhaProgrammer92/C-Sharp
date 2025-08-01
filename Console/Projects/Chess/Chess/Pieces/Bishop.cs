using Chess.MiscUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Bishop : Piece
    {
        // Method - Get valid displacements
        public static List<Position> GetValidDisplacementPositions()
        {
            var displacementPositions = new List<Position>();

            for (int i = 0; i < 8; i++)
                displacementPositions.Add(new Position(i, i));

            return displacementPositions;
        }

        // Constructor
        public Bishop(Symbol symbol, Position position) : 
            base(symbol, position, Bishop.GetValidDisplacementPositions()) {}
    }
}
