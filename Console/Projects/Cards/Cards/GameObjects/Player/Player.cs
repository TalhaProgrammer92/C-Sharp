using Cards.GameObjects.Card;
using Cards.Utils.Text;

namespace Cards.GameObjects.Player
{
    public class Player
    {
        // Attributes
        public Name Name { get; }
        public Hand Hand { get; }
        public Word Word { get; }
        public int MatchesWon { get; private set; } = 0;

        // Constructors
        public Player(Name name, Word? word)
        {
            Name = name;
            Hand = new Hand();
            Word = new Word(word);
        }

        public Player(Name name, Word? word, Hand hand)
        {
            Name = name;
            Hand = hand;
            Word = new Word(word);
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

        // Method - Check player's name uniqueness
        public static bool IsNameUnique(string name, List<Player> players)
        {
            return !players.Any(p => p.Name.ToString().Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        // Method - Display the player's information
        public void DisplayInfo()
        {
            Message.Info($"Player: {Name.ToString()}, Matches Won: {MatchesWon}, Cards in Hand: {Hand.Cards.Count}");
        }
    }
}
