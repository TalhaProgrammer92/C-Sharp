using Cards.Enums;
using Cards.Utils;
using System.Collections.ObjectModel;

namespace Cards.GameObjects.Card
{
    public class CardsDeck
    {
        // Attributes
        public Collection<Card> Cards { get; }
        private Random random;

        // Constructor
        public CardsDeck()
        {
            Cards = new Collection<Card>();
            Initialize();
            random = new Random();
            Shuffle();
        }

        // Method - Initialize deck with 52 cards
        private void Initialize()
        {
            var ranks = Misc.GetCardRanks();
            Array cardTypes = Enum.GetValues(typeof(CardType));

            foreach (var rank in ranks)
            {
                foreach (CardType type in cardTypes)
                {
                    Cards.Add(new Card(rank, type));
                }
            }
        }

        // Method - Shuffle the deck
        public void Shuffle()
        {
            int n = Cards.Count;

            while (n > 1)
            {
                int k = random.Next(n--);

                // Swap
                Card temp = Cards[n];
                Cards[n] = Cards[k];
                Cards[k] = temp;
            }
        }

        // Method - Display cards
        public void Display()
        {
            foreach (var card in Cards)
            {
                card.Display();
            }
        }

        // Method - Get a card from the deck
        public Card? DrawCard()
        {
            if (Cards.Count == 0)
                return null;

            Card card = Cards[0];
            Cards.RemoveAt(0);

            return card;
        }

        // Method - Reset the deck
        public void ResetDeck()
        {
            Cards.Clear();
            Initialize();
            Shuffle();
        }
    }
}
