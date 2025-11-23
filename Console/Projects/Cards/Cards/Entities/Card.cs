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

        // Method - Check if cards are equal
        public static bool operator==(Card left, Card right)
        {
            if (object.ReferenceEquals(left, right)) return true;
            
            if (left is null || right is null) return false;

            return left.Equals(right);
        }
        public static bool operator !=(Card left, Card right)
        {
            return !(left == right);
        }

        // Method - Display card information
        public void Display()
        {
            Misc.PrintColoredMessage($"{CardRank} of {CardType}", Settings.TextColor.CardTypeColors[CardType]);
        }
    }
}
