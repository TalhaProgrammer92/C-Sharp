using Chess.GameBoard;
using Chess.GamePlayer;
using Chess.Pieces;
using Chess.MiscUtils;
using Chess.Controller;
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
        GameTimer gameTimer;
        Position pointerPosition;
        bool isGameOver = false;
        int movesCount = 0, turn = 0;

        // Constructor
        public Match()
        {
            players = new List<Player>();
            board = new Board();
            pieceHandler = new PieceHandler();
            gameTimer = new GameTimer();
            pointerPosition = new Position(0, 0);

            board.PlaceAllPieces(pieceHandler);
        }
        public Match(List<Player> players, PieceHandler pieceHandler, Position pointerPosition, GameTimer gameTimer, int movesCount, bool isGameOver = false)
        {
            this.players = players;
            this.pieceHandler = pieceHandler;
            this.movesCount = movesCount;
            this.isGameOver = isGameOver;
            this.gameTimer = gameTimer;
            this.pointerPosition = pointerPosition;

            // Initializing the board
            board = new Board();
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

        // Method - Update the match
        void UpdateMatch()
        {
            // Update the game timer
            gameTimer.Update();

            // Increment moves count
            movesCount++;

            // Update the turn
            turn ^= 1; // Toggle between 0 and 1
        }

        // Method - Player input controller
        void ControlPlayerInput()
        {
            GameController gameController = new GameController();

            while (true)
            {
                gameController.TakeInput();
                bool isPointerMoved = false;

                if (gameController.IsUpArrowPressed())
                {
                    board.HighlightCell(pointerPosition, false);
                    
                    if (pointerPosition.Row > 0){
                        pointerPosition.Row--;
                        isPointerMoved = true;
                    }

                    board.HighlightCell(pointerPosition);
                }
                else if (gameController.IsDownArrowPressed())
                {
                    board.HighlightCell(pointerPosition, false);

                    if (pointerPosition.Row < 7){
                        pointerPosition.Row++;
                        isPointerMoved = true;
                    }

                    board.HighlightCell(pointerPosition);
                }
                else if (gameController.IsLeftArrowPressed())
                {
                    board.HighlightCell(pointerPosition, false);
                    
                    if (pointerPosition.Column > 0){
                        pointerPosition.Column--;
                        isPointerMoved = true;
                    }
                    
                    board.HighlightCell(pointerPosition);
                }
                else if (gameController.IsRightArrowPressed())
                {
                    board.HighlightCell(pointerPosition, false);
                    
                    if (pointerPosition.Column < 7){
                        pointerPosition.Column++;
                        isPointerMoved = true;
                    }

                    board.HighlightCell(pointerPosition);
                }
                else if (gameController.IsEnterPressed())
                {
                    if (board.IsCellEmpty(pointerPosition))
                    {
                        Message.Warning("The selected cell is empty!");
                    }
                    else
                    {
                        if (!board.IsCellOccupiedByGroup(pointerPosition, turn))
                        {
                            Message.Warning("You cannot select a piece of the opponent!");
                        }
                    }
                }
                else if (gameController.IsTurnSkipKeyPressed())
                {
                    turn ^= 1;
                }

                if (isPointerMoved)
                {
                    // Display the board after moving the pointer
                    board.Display();
                    PieceToken token = board.Grid[pointerPosition.Row, pointerPosition.Column].PieceToken_;
                    string message = $"{Position.ToLabeledPosition(pointerPosition)} - ";

                    if (token.HoldsPiece)
                    {
                        message += $"{token.GetPieceType()} - {token.GetPieceGroup()}";

                        if (!board.IsCellOccupiedByGroup(pointerPosition, turn))
                            message += " [Opponent Piece]";
                    }
                    else
                        message += "Empty Cell!";

                    Message.Info(message);
                }
            }
        }

        // Method - Start the match
        public void Start()
        {
            while (!isGameOver)
            {
                // Display the board
                board.Display();

                // Control player input
                ControlPlayerInput();

                // Update the match state
                UpdateMatch();
            }
        }
    }
}
