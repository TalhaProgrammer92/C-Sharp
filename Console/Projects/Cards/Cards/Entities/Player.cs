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
        public string Word { get; private set; } = string.Empty;
        public bool HasCompletedWord { get; private set; } = false;

        // Constructors
        public Player()
        {
            Name = new Name();
            Score = new Score();
            Hand = new Hand();
        }

        public Player(Name name)
        {
            Name = name;
            Score = new Score();
            Hand = new Hand();
        }

        public Player(Name name, Hand hand)
        {
            Name = name;
            Score = new Score();
            Hand = hand;
        }

        // Method - Add points to the player's score
        public void AddPointsToScore(int points = 1)
        {
            Score = Score.AddPoints(points);
        }

        // Method - Add word's letter to the player
        public void AddWordLetter(string word)
        {
            if (HasCompletedWord)
                throw new InvalidOperationException("All letters of the word have already been added.");

            Word += word[Word.Length];

            HasCompletedWord = Word.Length == word.Length;
        }

        // Method - Display the player's information
        public void DisplayInfo()
        {
            Message.Info($"Player: {Name.ToString()}, Score: {Score.ToString()}, Cards in Hand: {Hand.Cards.Count}");
        }
    }
}
