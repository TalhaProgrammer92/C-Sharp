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
        List<Player> players = new List<Player>();
        Board board = new Board();
        PieceHandler pieceHandler = new PieceHandler();
        bool isGameOver = false;
        int movesCount = 0;

        // Constructor
        public Match()
        {
        }
        public Match(List<Player> players, PieceHandler pieceHandler, int movesCount, bool isGameOver = false)
        {
            this.players = players;
            this.pieceHandler = pieceHandler;
            this.movesCount = movesCount;
            this.isGameOver = isGameOver;

            // Initializing the board
            board.PlaceAllPieces(pieceHandler);
        }

        // Method - Initialize the match
        void InitializePlayers()
        {
            // Adding players
            players.Add(Player.GetPlayerViaInput());
            players.Add(Player.GetPlayerViaInput(players[0].Name_));
        }

        // Method - Reset the match
        public void ResetMatch()
        {
            foreach (Player player in players)
                player.Reset();

            board = new Board();
            pieceHandler = new PieceHandler();
            movesCount = 0;
            isGameOver = false;
            InitializePlayers();

            // Initializing the board
            board.PlaceAllPieces(pieceHandler);
        }
    }
}
