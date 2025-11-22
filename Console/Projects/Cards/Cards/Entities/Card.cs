using Cards.Enums;
using Cards.ValueObjects.Card;

namespace Cards.Entities
{
    public class Card
    {
        // Attributes
        public CardRank CardRank { get; }
        public CardType CardType { get; }

        // Constructors
        public Card(CardRank cardRank, CardType cardType)
        {
            CardRank = cardRank;
            CardType = cardType;
        }

        // Override ToString method
        public override string ToString()
        {
            return $"{CardRank} of {CardType}";
        }
    }
}
