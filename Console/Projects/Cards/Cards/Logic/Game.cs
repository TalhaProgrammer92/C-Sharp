using Cards.GameObjects.Player;
using Cards.Utils;
using Cards.Utils.Text;

namespace Cards.Logic
{
    public class Game
    {
        // Attributes
        public Match Match { get; }
        public Player? Winner { get; private set; }
        public bool GameOver { get; private set; }

        // Constructor
        public Game(Match? match = null)
        {
            Match = match ?? new Match();
            Winner = null;
            GameOver = false;
        }

        // Method - Start Game
        public void StartGame()
        {
            
        }

        // Method - Get all players
        public void GetAllPlayers()
        {
            if (Match.Players.Count == 0)
            {
                string name;

                for (int i = 0; i < Settings.GameSettings.MaxPlayers; i++)
                {
                    // Print prompt
                    Misc.PrintColoredMessage(
                        $"Enter name for player {i + 1}: ", 
                        Settings.TextColor.Prompt, 
                        false);

                    // Take input
                    name = Console.ReadLine() ?? $"Player {i + 1}";

                    // Check if the name is unique
                    if (Player.IsNameUnique(name, Match.Players))
                    {
                        // Create player and add to match
                        Match.AddPlayer(new Player(new Name(name), new Word(Match.Word)));
                    }
                    else
                    {
                        Message.Error("Name already taken. Please enter a unique name.");
                        i--; // Decrement to retry
                    }
                }
            }
        }

        // Method - Reset the game
        public void ResetGame()
        {
            Winner = null;
            GameOver = false;
            Match.ResetMatchTotally();
        }
    }
}
