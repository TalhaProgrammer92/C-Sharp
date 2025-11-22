namespace Cards.ValueObjects.Player
{
    public class Score
    {
        // Attribute
        public int Value { get; }

        // Constructors
        public Score()
        {
            Value = 0;
        }
        public Score(int value)
        {
            if (value < 0)
                throw new Exception("Score cannot be negative.");
            
            Value = value;
        }

        // Method - Add points to the score
        public Score AddPoints(int points = 1)
        {
            if (points < 0)
                throw new Exception("Points to add cannot be negative.");
            return new Score(Value + points);
        }

        // Method - Override ToString
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
