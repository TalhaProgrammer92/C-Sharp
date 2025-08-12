using Chess.GameBoard;
using Chess.GamePlayer;
using Chess.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Logic
{
    class Match
    {
        // Attributes
        List<Player> players;
        Board board;
        PieceHandler pieceHandler;
        bool isGameOver;
        int movesCount;

        // Constructor
        public Match()
        {
            players = new List<Player>();
            board = new Board();
            pieceHandler = new PieceHandler();
            isGameOver = false;
            movesCount = 0;
        }
        public Match(List<Player> players, Board board, PieceHandler pieceHandler, int movesCount, bool isGameOver = false)
        {
            this.players = players;
            this.board = board;
            this.pieceHandler = pieceHandler;
            this.movesCount = movesCount;
            this.isGameOver = isGameOver;
        }

        // Method - Initialize the match
        void InitializeMatch()
        {
            
        }
    }
}
