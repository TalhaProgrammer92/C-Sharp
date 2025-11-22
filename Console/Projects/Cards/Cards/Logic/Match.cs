using Cards.Entities;

namespace Cards.Logic
{
    public class Match
    {
        // Attributes
        public CardsDesk Desk { get; }
        public List<Player> Players { get; }

        // Constructor
        public Match()
        {
            Desk = new CardsDesk();
            Players = new List<Player>();
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
            int playerCount = Players.Count;
            int cardIndex = 0;

            foreach (var card in removedPlayer.Hand.Cards)
            {
                Players[cardIndex++ % playerCount].Hand.AddCard(card);
            }
        }

        // Method - Reset the match
        public void ResetMatch()
        {
            Desk.RefreshDesk();
            
            // Remove cards from players' hands
            foreach (var player in Players)
            {
                player.Hand.ClearCards();
            }
            
            DistributeStarterCards();
        }

        // Method - Distribute starter cards to players
        public void DistributeStarterCards()
        {
            for (int i = 0; i < Settings.GameSettings.CardsPerPlayer; i++)
            {
                foreach (var player in Players)
                {
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
    }
}
