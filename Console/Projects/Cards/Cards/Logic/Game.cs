using Cards.GameObjects.Player;

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

        // Method - 

        // Method - Reset the game
        public void ResetGame()
        {
            Winner = null;
            GameOver = false;
            Match.ResetMatchTotally();
        }
    }
}
