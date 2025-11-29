using Cards.Enums;
using Cards.Utils;

namespace Cards.GameObjects.Card
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
            if (ReferenceEquals(left, right)) return true;
            
            if (left is null || right is null) return false;

            return left.CardRank == right.CardRank && left.CardType == right.CardType;
        }
        public static bool operator !=(Card left, Card right)
        {
            return !(left == right);
        }

        // Method - ToString
        public override string ToString()
        {
            return $"{CardRank} of {CardType}";
        }

        // Method - Display card information
        public void Display()
        {
            Misc.PrintColoredMessage(ToString(), Settings.TextSettings.CardTypeColors[CardType]);
        }
    }
}
