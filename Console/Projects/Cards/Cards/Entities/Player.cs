using Cards.ValueObjects.Player;

namespace Cards.Entities
{
    public class Player
    {
        // Attributes
        public Name Name { get; }
        public Score Score { get; private set; }

        // Constructors
        public Player()
        {
            Name = new Name();
            Score = new Score();
        }

        public Player(Name name)
        {
            Name = name;
            Score = new Score();
        }

        // Method - Add points to the player's score
        public void AddPointsToScore(int points = 1)
        {
            Score = Score.AddPoints(points);
        }

        // Override ToString method
        public override string ToString()
        {
            return $"Player: {Name} | Score: {Score.Value}";
        }
    }
}
