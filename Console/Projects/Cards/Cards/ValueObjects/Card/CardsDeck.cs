using Cards.Enums;
using System.Collections.ObjectModel;

namespace Cards.ValueObjects.Card
{
    public class CardsDeck
    {
        // Attributes
        public Collection<Entities.Card> Cards { get; }
        private Random random;

        // Constructor
        public CardsDeck()
        {
            Cards = new Collection<Entities.Card>();
            Initialize();
            random = new Random();
            Shuffle();
        }

        // Method - Initialize deck with 52 cards
        private void Initialize()
        {
            string[] ranks = CardRank.GetCardRanks();
            Array cardTypes = Enum.GetValues(typeof(CardType));

            foreach (string rank in ranks)
            {
                foreach (CardType type in cardTypes)
                {
                    Cards.Add(new Entities.Card(new CardRank(rank), type));
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
                Entities.Card temp = Cards[n];
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
        public Entities.Card? DrawCard()
        {
            if (Cards.Count == 0)
                return null;

            Entities.Card card = Cards[0];
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
