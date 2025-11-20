namespace Cards.ValueObjects.Player
{
    public class Name
    {
        // Attribute
        public string Value { get; }

        // Constructors
        public Name()
        {
            Value = string.Empty;
        }
        public Name(string value)
        {
            if (IsValidName(value))
                Value = value;
            else
                throw new Exception("Invalid name provided. It can't be null or whitespace.");
        }

        // Method - Check if name is valid or not
        public static bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name);
        }

        // Override ToString method
        public override string ToString()
        {
            return Value;
        }
    }
}
