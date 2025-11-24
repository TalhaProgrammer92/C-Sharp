namespace Cards.GameObjects.Player
{
    public class Name
    {
        // Attribute
        public string Value { get; }

        // Constructors
        public Name()
        {
            Value = "Unknown Player";
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
            return !string.IsNullOrWhiteSpace(name) && !string.IsNullOrEmpty(name);
        }

        // Override ToString method
        public override string ToString()
        {
            return Value;
        }
    }
}
