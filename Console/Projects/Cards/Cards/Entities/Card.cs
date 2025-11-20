using Cards.Enums;
using Cards.ValueObjects.Card;

namespace Cards.Entities
{
    public class Card
    {
        // Attributes
        public CardNumber CardNumber { get; }
        public CardType CardType { get; }
        public bool IsShown { get; set; }

        // Constructors
        public Card()
        {
            CardNumber = new CardNumber();
            CardType = CardType.Heart;
            IsShown = false;
        }

        public Card(CardNumber cardNumber, CardType cardType)
        {
            CardNumber = cardNumber;
            CardType = cardType;
            IsShown = false;
        }

        // Override ToString method
        public override string ToString()
        {
            return $"{CardNumber} of {CardType}";
        }
    }
}
