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

            // Filling some words
            match.Players[0].Word.Fill();
            match.Players[1].Word.Fill();
            match.Players[1].Word.Fill();

            // Display players' stats
            foreach (Player player in match.Players)
            {
                player.DisplayInfo();
                player.Hand.Display();
                Console.WriteLine($"Current Word: {player.Word.Current}");
                Console.WriteLine(new String('-', 50));
            }
        }
    }
}
