using Cards.Enums;
using Cards.Utils;
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

        // Method - Display card information
        public void Display()
        {
            Misc.PrintColoredMessage($"{CardRank} of {CardType}", Settings.TextColor.CardTypeColors[CardType]);
        }
    }
}
