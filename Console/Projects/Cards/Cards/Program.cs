using Cards.Logic;
using Cards.GameObjects.Player;

namespace Cards
{
    public class Program
    {
        public static void Main(String[] args)
        {
            // Creating objects
            Word word = new Word(Settings.GameSettings.DefaultWord);
            Match match = new Match(word.Value);
            
            // Adding players
            match.AddPlayer(new Player(
                new Name("Talha Ahmad"),
                word
            ));
            match.AddPlayer(new Player(
                new Name("Rayan Zulfiqar"),
                word
            ));

            // Distributing 5 starter cards to each player
            match.DistributeStarterCardsAmongPlayers();

            // Display players' stats
            foreach (Player player in match.Players)
            {
                player.DisplayInfo();
                player.Hand.Display();
                Console.WriteLine(new String('-', 50));
            }
        }
    }
}
