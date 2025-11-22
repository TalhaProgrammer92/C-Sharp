using Cards.Enums;

namespace Cards.ValueObjects.Card
{
    public class CardsDeck
    {
        // Attributes
        public List<Entities.Card> Cards { get; }

        // Constructor
        public CardsDeck()
        {
            Cards = new List<Entities.Card>();
            InitializeDeck();
        }

        // Method - Initialize deck with 52 cards
        private void InitializeDeck()
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
            Random random = new Random();
            int n = Cards.Count;
            
            while (n > 1)
            {
                int k = random.Next(n--);
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
                Console.WriteLine(card);
            }
        }
    }
}
