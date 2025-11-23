using Cards.Entities;
using System.Collections.ObjectModel;

namespace Cards.Logic
{
    public class Match
    {
        // Attributes
        public CardsDesk Desk { get; }
        public List<Player> Players { get; }
        public bool GameOver { get; private set; }
        public readonly string Word;
        private int playerTurn;

        // Constructor
        public Match(string? word = null)
        {
            Desk = new CardsDesk();
            Players = new List<Player>();
            GameOver = false;
            playerTurn = -1;    // Because there are no players at the beginning
            Word = word ?? Settings.GameSettings.DefaultWord;
        }

        // Method - Add player to the desk
        public void AddPlayer(Player player)
        {
            if (Players.Count == Settings.GameSettings.MaxPlayers)
                throw new InvalidOperationException($"Maximum number '{Settings.GameSettings.MaxPlayers}' of players reached.");

            Players.Add(player);
        }

        // Method - Remove player from the desk
        public void RemovePlayer(Player player, Collection<Card> cards)
        {
            Players.Remove(player);
            DistributeRemovedPlayerCards(cards);
        }

        // Method - Distribute cards of removed player to other players
        private void DistributeRemovedPlayerCards(Collection<Card> cards)
        {
            int playerIndex = -1;

            foreach (var card in cards)
            {
                playerIndex++;

                // Reset the player index to prevent out of range exception
                if (playerIndex >= Players.Count)
                    playerIndex = 0;

                // Because card can't be distributed to an already lost player
                if (Players[playerIndex].Word.IsFilled) continue;

                Players[playerIndex].Hand.Cards.Add(card);
            }
        }

        // Method - Reset the match
        public void ResetMatch()
        {
            // Refresh the cards desk
            Desk.RefreshDesk();

            // Remove cards from players' hands
            foreach (var player in Players)
            {
                player.Hand.ClearCards();
            }
            GameOver = false;

            // Distribute starter cards among players
            DistributeStarterCardsAmongPlayers();
        }

        // Method - Distribute starter cards to players
        private void DistributeStarterCardsAmongPlayers()
        {
            for (int i = 0; i < Settings.GameSettings.CardsPerPlayer; i++)
            {
                foreach (var player in Players)
                {
                    if (player.Word.IsFilled) continue;
                    
                    var card = Desk.Deck.DrawCard();

                    if (card != null)
                    {
                        player.Hand.AddCard(card);
                    }
                    else
                    {
                        throw new InvalidOperationException("Not enough cards in the deck to distribute to players.");
                    }
                }
            }
        }

        // Method - Check if there's only one player left who has cards
        private bool IsOnlyOnePlayerLeftWithCards()
        {
            if (!GameOver)
            {
                int playersWithCards = Players.Count(player => player.Hand.Cards.Count > 0);
                return playersWithCards == 1;
            }
            return false;
        }

        // Method - Get the lost player (the one who still has cards)
        public Player? GetLostPlayer()
        {
            // It might return a list of players, that's why I checked if game is over or not, just to make sure there's only 1 player left with cards
            return (GameOver) ? Players.FirstOrDefault(player => player.Hand.Cards.Count > 0) : null;
        }

        // Method - Update match status
        public void UpdateMatchStatus()
        {
            // Revolve the turn to the around players
            UpdateTurn();

            // Update game over status
            if (IsOnlyOnePlayerLeftWithCards())
            {
                GameOver = true;
                Players[playerTurn].Word.Fill();
            }
        }

        // Method - Update turn
        private void UpdateTurn()
        {
            if (GameOver) return;

            do
            {
                /*
                 !! LOGIC !!

                [CASE 1]
                Players = {1, 2, 3, 4, 5, 6} (MAX)
                ActivePlayers = {1, 2, 4, 6}
                NonActivePlayers = {3, 5}
                Turn = 1 (Player 2)

                UpdateTurn:
                    Turn = (Turn < Players.Count - 1) => (1 < 6 -1) => (1 < 5) => true
                        {true} Turn = Turn + 1 => 1 + 1 => 2 (Player 3) ✔
                        {false} Turn = 0

                Players[Turn].Word.IsFilled => Players[2].Word.IsFilled => true (Because player 3 is not active)
                    {true} GOTO UpdateTurn ✔
                    {false} return

                [CASE 2]
                Players = {1, 2, 3, 4, 5, 6} (MAX)
                ActivePlayers = {1, 2, 4, 6}
                NonActivePlayers = {3, 5}
                Turn = 0 (Player 1)

                UpdateTurn:
                    Turn = (Turn < Players.Count - 1) => (0 < 6 -1) => (0 < 5) => true
                        {true} Turn = Turn + 1 => 0 + 1 => 1 (Player 2) ✔
                        {false} Turn = 0

                Players[Turn].Word.IsFilled => Players[1].Word.IsFilled => false (Because player 2 is active)
                    {true} GOTO UpdateTurn
                    {false} return ✔
                 */
                playerTurn = (playerTurn < Players.Count - 1) ? playerTurn + 1 : 0;
            } while (Players[playerTurn].Word.IsFilled);    // Skips the player who already had lost the game
        }
    }
}
