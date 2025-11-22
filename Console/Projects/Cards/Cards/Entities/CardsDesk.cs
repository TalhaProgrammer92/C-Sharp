using Cards.ValueObjects.Card;

namespace Cards.Entities
{
    public class CardsDesk
    {
        // Attributes
        public List<Player> Players { get; }
        public CardsDeck Deck { get; }
        public TableHand TableHand { get; }

        // Constructor
        public CardsDesk()
        {
            Players = new List<Player>();
            Deck = new CardsDeck();
            TableHand = new TableHand(Deck.DrawCard()!);
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

        // Method - Refresh the desk
        public void RefreshDesk()
        {
            // Remove cards from players' hands
            foreach (var player in Players)
            {
                player.Hand.ClearCards();
            }

            // Reset the deck
            Deck.ResetDeck();

            // Set a new card on the table
            TableHand.ResetTable(Deck.DrawCard()!);

            // Distribute starter cards to players
            DistributeStarterCards();
        }

        // Method - Distribute starter cards to players
        public void DistributeStarterCards()
        {
            for (int i = 0; i < Settings.GameSettings.CardsPerPlayer; i++)
            {
                foreach (var player in Players)
                {
                    var card = Deck.DrawCard();

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
