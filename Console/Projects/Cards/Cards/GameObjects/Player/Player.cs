using Cards.Utils;
using Cards.ValueObjects.Card;

namespace Cards.ValueObjects.Player
{
    public class Player
    {
        // Attributes
        public Name Name { get; }
        public Hand Hand { get; }
        public Word Word { get; }
        public int MatchesWon { get; private set; } = 0;

        // Constructors
        public Player(Name name, Word word)
        {
            Name = name;
            Hand = new Hand();
            Word = word;
        }

        public Player(Name name, Word word, Hand hand)
        {
            Name = name;
            Hand = hand;
            Word = word;
        }

        // Method - Increment matches won
        public void IncrementMatchesWon()
        {
            MatchesWon++;
        }

        // Method - Reset player stats
        public void Reset()
        {
            MatchesWon = 0;
            Word.Clear();
        }

        // Method - Display the player's information
        public void DisplayInfo()
        {
            Message.Info($"Player: {Name.ToString()}, Matches Won: {MatchesWon}, Cards in Hand: {Hand.Cards.Count}");
        }
    }
}
