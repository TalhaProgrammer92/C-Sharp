using Cards.Utils;
using Cards.ValueObjects.Player;

namespace Cards.Entities
{
    public class Player
    {
        // Attributes
        public Name Name { get; }
        public Score Score { get; private set; }
        public Hand Hand { get; }
        public Word Word { get; }

        // Constructors
        public Player(Name name, Word word)
        {
            Name = name;
            Score = new Score();
            Hand = new Hand();
            Word = word;
        }

        public Player(Name name, Word word, Hand hand)
        {
            Name = name;
            Score = new Score();
            Hand = hand;
            Word = word;
        }

        // Method - Add points to the player's score
        public void AddPointsToScore(int points = 1)
        {
            Score = Score.AddPoints(points);
        }

        // Method - Display the player's information
        public void DisplayInfo()
        {
            Message.Info($"Player: {Name.ToString()}, Score: {Score.ToString()}, Cards in Hand: {Hand.Cards.Count}");
        }
    }
}
