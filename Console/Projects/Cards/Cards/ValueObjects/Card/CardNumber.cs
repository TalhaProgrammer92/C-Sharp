namespace Cards.ValueObjects.Card
{
    public class CardNumber
    {
        // Attributes
        public string Value { get; }

        // Constructors
        public CardNumber()
        {
            Value = "A";
        }

        public CardNumber(string value)
        {
            if (IsValidCardNumber(value))
                Value = value;
            else
                throw new Exception("Invalid card number provided.");
        }

        // Method - Check if card number is valid or not
        public static bool IsValidCardNumber(string number)
        {
            string[] strings = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            return strings.Contains(number);
        }

        // Override ToString method
        public override string ToString()
        {
            return Value;
        }
    }
}
