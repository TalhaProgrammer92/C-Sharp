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
                //if (value < 0)
                //    throw new ArgumentException("Piece index cannot be negative.");

                // Pawn type
                if (IsPawn)
                {
                    // There can be 8 pawns for each group (0-7 for white, 8-15 for black)
                    if (value < 8 * 2)
                        pieceIndex = value;
                    //else
                    //    throw new ArgumentException("Pawn index must be between 0 and 15 (8 for each group).");
                }
                // King type
                else if (IsKing)
                {
                    // There can be only 1 king for each group (0 for white, 1 for black)
                    if (value < 2)
                        pieceIndex = value;
                    //else
                    //    throw new ArgumentException("King index must be either 0 or 1.");
                }
                // Other types (Bishop, Knight, Rook, Queen)
                else
                {
                    // There can be 2 bishops, 2 knights, 2 rooks, and 1 queen for each group
                    // There are 8 pawns for each group, so the indices are 0-7 for white and 8-15 for black.
                    // I'm using 18 indices in total due to pawn promotions.
                    if (value < 18)
                        pieceIndex = value;
                    //else
                    //    throw new ArgumentException("Index must be between 0 and 17 (including pawn promotions)");
                }
            }
        }

        public int PieceType
        {
            get { return pieceType; }
            set {
                //if (value < 0 || value > 5)
                //    throw new ArgumentException("Piece type must be between 0 and 5.");
                pieceType = value;
            }
        }

        public int GroupIndex
        {
            get { return groupIndex; }
            set {
                if (value == 0 || value == 1)
                    groupIndex = value;
                //else
                //    throw new ArgumentException("Group index must be either 0 (White) or 1 (Black).");
            }
        }

        // Method - Display the piece token information
        public void Display()
        {
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
