using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class PieceToken
    {
        // Attributes
        int pieceIndex;     // Index of the piece in a list of piece handler object
        int pieceType;      // Type of the piece [0-King, 1-Pawn, 2-Bishop, 3-Knight, 4-Rook, 5-Queen]
        int groupIndex;     // Index of the group the piece belongs to [0-White, 1-Black]
        public bool HoldsPiece { get; set; }    // Indicates if the piece is currently held by a (board) cell

        // Constructor
        public PieceToken(int pieceIndex, int pieceType, int groupIndex, bool holdsPiece = true)
        {
            PieceIndex = pieceIndex;    // Validate and set piece index
            PieceType = pieceType;      // Validate and set piece type
            GroupIndex = groupIndex;    // Validate and set group index
            HoldsPiece = holdsPiece;    // Default to true, indicating the piece is held by a cell
        }
        public PieceToken(PieceToken other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other), "PieceToken cannot be null.");
            
            pieceIndex = other.pieceIndex;
            pieceType = other.pieceType;
            groupIndex = other.groupIndex;
            HoldsPiece = other.HoldsPiece;
        }
        public PieceToken() { HoldsPiece = false; }

        // Getters and Setters
        public int PieceIndex
        {
            get { return pieceIndex; }
            set {
                if (value >= 0)
                {
                    pieceIndex = value;
                }
            }
        }

        public int PieceType
        {
            get { return pieceType; }
            set {
                if (value >= 0 && value <= 5)
                    pieceType = value;
            }
        }

        public int GroupIndex
        {
            get { return groupIndex; }
            set {
                if (value == 0 || value == 1)
                    groupIndex = value;
            }
        }

        // Method - Display the piece token information
        public void Display()
        {
            // If the piece is not held by a cell
            if (!HoldsPiece)
            {
                Console.WriteLine("The cell is empty.");
                return;
            }

            // Determine the group name based on the group index
            string group = groupIndex == 0 ? "White" : "Black";

            // Determine the piece type name based on the piece type index
            string type = pieceType switch
            {
                0 => "King",
                1 => "Pawn",
                2 => "Bishop",
                3 => "Knight",
                4 => "Rook",
                5 => "Queen",
                _ => "Unknown"
            };

            Console.WriteLine($"Group: {group}, Type: {type}, Index: {pieceIndex}");
        }

        // Properties - Get piece types
        public static int KingId { get { return 0; } }
        public static int PawnId { get { return 1; } }
        public static int BishopId { get { return 2; } }
        public static int KnightId { get { return 3; } }
        public static int RookId { get { return 4; } }
        public static int QueenId { get { return 5; } }


        // Properties - Check piece types
        public bool IsKing { get { return pieceType == KingId; } }
        public bool IsPawn { get { return pieceType == PawnId; } }
        public bool IsBishop { get { return pieceType == BishopId; } }
        public bool IsKnight { get { return pieceType == KnightId; } }
        public bool IsRook { get { return pieceType == RookId; } }
        public bool IsQueen { get { return pieceType == QueenId; } }

        // Properties - Get group types
        public static int WhiteGroupId { get { return 0; } }
        public static int BlackGroupId { get { return 1; } }

        // Properties - Check group types
        public bool IsWhite { get { return groupIndex == WhiteGroupId; } }
        public bool IsBlack { get { return groupIndex == BlackGroupId; } }
    }
}
