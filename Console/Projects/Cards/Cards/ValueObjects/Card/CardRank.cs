namespace Cards.ValueObjects.Card
{
    public class CardRank
    {
        // Attributes
        public string Value { get; }

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
            return new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
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
