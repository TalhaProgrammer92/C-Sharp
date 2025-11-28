using Cards.Logic;
using Cards.GameObjects.Player;
using Cards.Utils.Menu.Menu;
using Cards.Utils.Text;

namespace Cards
{
    public class Program
    {
        public static void Main(String[] args)
        {
            //    // Creating objects
            //    Word word = new Word(Settings.GameSettings.DefaultWord);
            //    Match match = new Match(word.Value);

            //    // Adding players
            //    match.AddPlayer(new Player(
            //        new Name("Talha Ahmad"),
            //        word
            //    ));
            //    match.AddPlayer(new Player(
            //        new Name("Rayan Zulfiqar"),
            //        word
            //    ));
            //    match.AddPlayer(new Player(
            //        new Name("Muhammad Raza"),
            //        word
            //    ));

            //    // Distributing 5 starter cards to each player
            //    match.DistributeStarterCardsAmongPlayers();

            //    // Filling some words
            //    match.Players[0].Word.Fill();
            //    match.Players[0].Word.Fill();
            //    match.Players[1].Word.Fill();
            //    match.Players[2].Word.Fill();
            //    match.Players[1].Word.Fill();
            //    match.Players[1].Word.Fill();

            //    // Matches won
            //    match.Players[1].IncrementMatchesWon();
            //    match.Players[0].IncrementMatchesWon();
            //    match.Players[2].IncrementMatchesWon();
            //    match.Players[2].IncrementMatchesWon();

            //    // Display players' stats
            //    foreach (Player player in match.Players)
            //    {
            //        player.DisplayInfo();
            //        player.Hand.Display();
            //        Console.WriteLine($"Current Word: {player.Word.Current}");
            //        Console.WriteLine(new String('-', 75));
            //    }

            //foreach (var option in Misc.GetOptionsRangeList(5, new ColorObject(ConsoleColor.Yellow)))
            //{
            //    option.Display(true);
            //}

            //MainMenu mainMenu = new MainMenu();
            //int option = mainMenu.DisplayAndTakeInput();
            //Message.Info($"Action: {mainMenu.GetAction(option)}");

            Game game = new Game();
            game.StartGame();
        }
    }
}
