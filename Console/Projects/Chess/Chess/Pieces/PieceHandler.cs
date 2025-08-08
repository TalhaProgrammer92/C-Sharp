using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.MiscUtils;

namespace Chess.Pieces
{
    class PieceHandler
    {
        // Rule (Indexing): Even - White, Odd - Black
        // Attributes
        public List<Pawn> Pawns { get; set; }
        public List<Rook> Rooks { get; set; }
        public List<Knight> Knights { get; set; }
        public List<Bishop> Bishops { get; set; }
        public List<Queen> Queens { get; set; }
        public List<King> Kings { get; set; }

        // Constructor
        public PieceHandler()
        {
            Pawns = new List<Pawn>();
            Rooks = new List<Rook>();
            Knights = new List<Knight>();
            Bishops = new List<Bishop>();
            Queens = new List<Queen>();
            Kings = new List<King>();

            InitializeAllPieces();
        }

        // Method - Initialize the pieces
        void InitializeAllPieces()
        {
            // Pawns
            for (int i = 0; i < 8; i++)
            {
                // Create symbols for white and black pawns
                Symbol whitePawnSymbol = new Symbol(Pieces.Unicode.WhitePawn, Utils.GetAccentColor(0));
                Symbol blackPawnSymbol = new Symbol(Pieces.Unicode.BlackPawn, Utils.GetAccentColor(1));

                // Create pawns and add them to the list
                Pawns.Add(new Pawn(whitePawnSymbol, new Position(1, i)));
                Pawns.Add(new Pawn(blackPawnSymbol, new Position(6, i)));
            }

            // Rooks
            for (int i = 0; i < 2; i++)
            {
                // Create symbols for white and black rooks
                Symbol whiteRookSymbol = new Symbol(Pieces.Unicode.WhiteRook, Utils.GetAccentColor(0));
                Symbol blackRookSymbol = new Symbol(Pieces.Unicode.BlackRook, Utils.GetAccentColor(1));

                // Create rooks and add them to the list
                Rooks.Add(new Rook(whiteRookSymbol, new Position(0, i * 7)));
                Rooks.Add(new Rook(blackRookSymbol, new Position(7, i * 7)));
            }

            // Knights
            for (int i = 0; i < 2; i++)
            {
                // Create symbols for white and black knights
                Symbol whiteKnightSymbol = new Symbol(Pieces.Unicode.WhiteKnight, Utils.GetAccentColor(0));
                Symbol blackKnightSymbol = new Symbol(Pieces.Unicode.BlackKnight, Utils.GetAccentColor(1));

                // Create knights and add them to the list
                Knights.Add(new Knight(whiteKnightSymbol, new Position(0, 1 + i * 5)));
                Knights.Add(new Knight(blackKnightSymbol, new Position(7, 1 + i * 5)));
            }

            // Bishops
            for (int i = 0; i < 2; i++)
            {
                // Create symbols for white and black bishops
                Symbol whiteBishopSymbol = new Symbol(Pieces.Unicode.WhiteBishop, Utils.GetAccentColor(0));
                Symbol blackBishopSymbol = new Symbol(Pieces.Unicode.BlackBishop, Utils.GetAccentColor(1));

                // Create bishops and add them to the list
                Bishops.Add(new Bishop(whiteBishopSymbol, new Position(0, 2 + i * 3)));
                Bishops.Add(new Bishop(blackBishopSymbol, new Position(7, 2 + i * 3)));
            }

            // Queens

            // Create symbols for white and black queens
            Symbol whiteQueenSymbol = new Symbol(Pieces.Unicode.WhiteQueen, Utils.GetAccentColor(0));
            Symbol blackQueenSymbol = new Symbol(Pieces.Unicode.BlackQueen, Utils.GetAccentColor(1));

            // Create queens and add them to the list
            Queens.Add(new Queen(whiteQueenSymbol, new Position(0, 3)));
            Queens.Add(new Queen(blackQueenSymbol, new Position(7, 3)));

            // Kings

            // Create symbols for white and black kings
            Symbol whiteKingSymbol = new Symbol(Pieces.Unicode.WhiteKing, Utils.GetAccentColor(0));
            Symbol blackKingSymbol = new Symbol(Pieces.Unicode.BlackKing, Utils.GetAccentColor(1));

            // Create kings and add them to the list
            Kings.Add(new King(whiteKingSymbol, new Position(0, 4)));
            Kings.Add(new King(blackKingSymbol, new Position(7, 4)));
        }

        // Method - Move all pieces to their initial positions
        public void MoveAllPiecesToInitialPositions()
        {
            // Move pawns
            foreach (Pawn pawn in Pawns)
            {
                pawn.MoveToInitialPosition();
            }

            // Move rooks
            foreach (Rook rook in Rooks)
            {
                rook.MoveToInitialPosition();
            }

            // Move knights
            foreach (Knight knight in Knights)
            {
                knight.MoveToInitialPosition();
            }
            // Move bishops
            foreach (Bishop bishop in Bishops)
            {
                bishop.MoveToInitialPosition();
            }

            // Move queens
            foreach (Queen queen in Queens)
            {
                queen.MoveToInitialPosition();
            }

            // Move kings
            foreach (King king in Kings)
            {
                king.MoveToInitialPosition();
            }
        }
    }
}
