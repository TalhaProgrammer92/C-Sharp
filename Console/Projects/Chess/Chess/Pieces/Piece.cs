using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.MiscUtils;

namespace Chess.Pieces
{
    abstract class Piece
    {
        // Attributes
        protected Symbol symbol;

        protected Position? currentPosition = null;
        protected Position? recentPosition = null;
        protected List<Position> allowedDisplacementPositions;

        // Constructor
        public Piece(Symbol symbol, Position position, List<Position> allowedDisplacementPositions)
        {
            this.symbol = symbol;
            this.allowedDisplacementPositions = allowedDisplacementPositions;
            currentPosition = position;
            recentPosition = null;
        }

        // Getters
        public Position? CurrentPosition
        {
            get { return currentPosition; }
        }
        public Position? RecentPosition
        {
            get { return recentPosition; }
        }

        // Method - Print the piece
        public void Print()
        {
            Console.WriteLine($"Piece: {symbol.Unicode}, Current Position: {Position.GetString(currentPosition)}, Recent Position: {Position.GetString(recentPosition)}");
        }

        // Method - Update the piece position to a new position
        public void UpdatePosition(Position position)
        {
            recentPosition = (CurrentPosition is null) ? null : CurrentPosition;
            
            currentPosition = new Position(position);
        }

        // Method - Check if the displacement is valid
        public bool IsValidDisplacementPosition(Position displacementPosition)
        {
            foreach (Position position in allowedDisplacementPositions)
                if (position == displacementPosition) return true;

            return false;
        }

        // Method - Is valid destination
        public bool IsValidDestination(Position destination)
        {
            // If the current position is null
            if (CurrentPosition is null) return false;

            // If the current position is not null
            return IsValidDisplacementPosition(
                Position.
                    GetAbsoluteDifference(CurrentPosition, destination));
        }
    }
}
