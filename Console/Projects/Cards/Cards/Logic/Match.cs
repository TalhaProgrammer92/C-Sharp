using Cards.Entities;

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
        public void RemovePlayer(Player player)
        {
            DistributeRemovedPlayerCards(player);
            Players.Remove(player);
        }

        // Method - Distribute cards of removed player to other players
        private void DistributeRemovedPlayerCards(Player removedPlayer)
        {
            var cards = removedPlayer.Hand.Cards;
            int playerIndex = 0;

            foreach (var card in cards)
            {
                // Reset the player index to prevent out of range exception
                if (playerIndex >= Players.Count)
                    playerIndex = 0;

                // Because card can't be distributed to an already lost player
                if (Players[playerIndex++].Word.IsCompletlyFilled) continue;

                Players[playerIndex++].Hand.Cards.Add(card);
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

            // Distribute starter cards among players
            DistributeStarterCardsAmongPlayers();
        }

        // Method - Distribute starter cards to players
        public void DistributeStarterCardsAmongPlayers()
        {
            for (int i = 0; i < Settings.GameSettings.CardsPerPlayer; i++)
            {
                foreach (var player in Players)
                {
                    if (player.Word.IsCompletlyFilled) continue;
                    
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
        public bool IsOnlyOnePlayerLeftWithCards()
        {
            int playersWithCards = Players.Count(player => player.Hand.Cards.Count > 0);
            return playersWithCards == 1;
        }

        // Method - Get loser player (the one who still has cards)
        public Player? GetLoserPlayer()
        {
            return (GameOver) ? Players.FirstOrDefault(player => player.Hand.Cards.Count > 0) : null;
        }

        // Method - Update match status
        public void UpdateMatchStatus()
        {
            // Revolve the turn to the around players
            UpdateTurn();

            // Update game over status
            GameOver = IsOnlyOnePlayerLeftWithCards();
        }

        // Method - Update turn
        private void UpdateTurn()
        {
            if (GameOver) return;

            do
            {
                playerTurn = (playerTurn < Players.Count - 1) ? playerTurn + 1 : 0;
            } while (Players[playerTurn].Word.IsCompletlyFilled);
        }
    }
}
