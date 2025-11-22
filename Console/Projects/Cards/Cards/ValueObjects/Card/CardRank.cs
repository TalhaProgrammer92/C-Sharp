namespace Cards.ValueObjects.Card
{
    public class CardRank
    {
        // Attributes
        public string Value { get; }

        // Static readonly fields for card ranks
        public static readonly string Ace = "A";
        public static readonly string Two = "2";
        public static readonly string Three = "3";
        public static readonly string Four = "4";
        public static readonly string Five = "5";
        public static readonly string Six = "6";
        public static readonly string Seven = "7";
        public static readonly string Eight = "8";
        public static readonly string Nine = "9";
        public static readonly string Ten = "10";
        public static readonly string Jack = "J";
        public static readonly string Queen = "Q";
        public static readonly string King = "K";

        // Constructors
        public CardRank()
        {
            Value = "A";
        }

        public CardRank(string value)
        {
            if (IsValidCardNumber(value))
                Value = value;
            else
                throw new Exception("Invalid card number provided.");
        }

        // Method - Get card ranks list
        public static string[] GetCardRanks()
        {
            return new string[] {
                Ace,
                Two,
                Three,
                Four,
                Five,
                Six,
                Seven,
                Eight,
                Nine,
                Ten,
                Jack,
                Queen,
                King,
            };
        }

        // Method - Check if card number is valid or not
        public static bool IsValidCardNumber(string rank)
        {
            string[] ranks = GetCardRanks();
            return ranks.Contains(rank);
        }

        // Override ToString method
        public override string ToString()
        {
            return Value;
        }
    }
}
