using Cards.GameObjects.Player;
using Cards.Utils;
using Cards.Utils.Text;
using System.Text.RegularExpressions;

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
            // Get all players for the game
            GetAllPlayers();

            // For debugging
            foreach (var player in Match.Players)
            {
                player.DisplayInfo();
            }
        }

        // Method - Get all players
        private void GetAllPlayers()
        {
            if (Match.Players.Count == 0)
            {
                string name;

                Heading heading = new("Players Data Entry", 20);
                heading.Display(true);
                Misc.LineBreak();

                for (int i = 0; i < Settings.GameSettings.MaxPlayers; i++)
                {
                    try
                    {
                        // Print prompt
                        Misc.PrintColoredMessage(
                            $"Enter name for player {i + 1} - (\"Enter\" to break): ", 
                            Settings.TextSettings.Prompt, 
                            false);

                        // Take input
                        name = Console.ReadLine() ?? $"Player {i + 1}";

                        // If user pressed "Enter"
                        if (name is null || name.Length == 0)
                        {
                            if (Match.Players.Count < Settings.GameSettings.MinPlayers)
                            {
                                Message.Warning($"You need to enter at least {Settings.GameSettings.MinPlayers} players.");
                                i--;
                                continue;
                            }

                            break;
                        }

                        // Check if the name is unique
                        if (Player.IsNameUnique(name, Match.Players))
                        {
                            // Create player and add to match
                            Match.AddPlayer(new Player(new Name(name), new Word(Match.Word)));
                        }
                        else
                        {
                            Message.Warning("Name already taken. Please enter a unique name.");
                            i--; // Decrement to retry
                        }
                    }
                    catch (Exception e)
                    {
                        Message.Error($"Invalid name entry: {e.Message}");
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
