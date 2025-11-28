using Cards.GameObjects.Card;
using Cards.GameObjects.Player;
using System.Collections.ObjectModel;

namespace Cards.Logic
{
    public class Match
    {
        // Attributes
        private readonly Table cardsDesk;
        public List<Player> Players { get; }
        public bool GameOver { get; private set; }
        public readonly string Word;
        public int PlayerTurn { get; private set; }
        public int MatchesPlayed { get; private set; }
        public Card? TragetCard => cardsDesk.TableHand.GetTopCard();

        // Constructor
        public Match(string? word = null)
        {
            cardsDesk = new Table();
            Players = new List<Player>();
            GameOver = false;
            PlayerTurn = -1;    // Because there are no players at the beginning
            Word = word ?? Settings.GameSettings.DefaultWord;
        }

        // Method - Add player to the desk
        public void AddPlayer(Player player)
        {
            if (Players.Count == Settings.GameSettings.MaxPlayers)
                throw new InvalidOperationException($"Maximum number '{Settings.GameSettings.MaxPlayers}' of players reached.");

            Players.Add(player);
        }

        // Method - Remove player from the desk
        public void RemovePlayer(Player player, Collection<Card> cards)
        {
            Players.Remove(player);
            DistributeRemovedPlayerCards(cards);
        }

        // Method - Distribute cards of removed player to other players
        private void DistributeRemovedPlayerCards(Collection<Card> cards)
        {
            // If game is over
            if (GameOver) return;

            int playerIndex = 0;
            var activePlayers = Players.Where(p => !p.Word.IsFilled).ToList();

            foreach (var card in cards)
            {
                // Reset the player index to prevent out of range exception
                if (playerIndex >= activePlayers.Count)
                    playerIndex = 0;

                // Distribute the card to only an active player
                activePlayers[playerIndex++].Hand.Cards.Add(card);
            }
        }

        // Method - Reset the match
        public void ResetMatch()
        {
            // Refresh the cards desk
            cardsDesk.RefreshDesk();

            // Remove cards from players' hands
            foreach (var player in Players)
            {
                player.Hand.ClearCards();
            }
            GameOver = false;

            // Distribute starter cards among players
            DistributeStarterCardsAmongPlayers();

            // Increment matches played
            MatchesPlayed++;
        }

        // Method - Totally reset the match
        public void ResetMatchTotally()
        {
            // Refresh the cards desk
            cardsDesk.RefreshDesk();
            
            // Remove cards from players' hands and reset their words
            foreach (var player in Players)
            {
                player.Hand.ClearCards();
                player.Word.Clear();
            }
            GameOver = false;

            // Distribute starter cards among players
            DistributeStarterCardsAmongPlayers();

            // Reset matches played
            MatchesPlayed = 0;
        }

        // Method - Distribute starter cards to players
        public void DistributeStarterCardsAmongPlayers()
        {
            // Check minimum players count
            if (Players.Count < Settings.GameSettings.MinPlayers)
                throw new InvalidOperationException($"Not enough players to start cards distribution. Minimum required players are {Settings.GameSettings.MinPlayers}.");

            for (int i = 0; i < Settings.GameSettings.CardsPerPlayer; i++)
            {
                foreach (var player in Players)
                {
                    // Skips in-active player
                    if (player.Word.IsFilled) continue;
                    
                    var card = cardsDesk.Deck.DrawCard();

                    if (card is not null)
                    {
                        player.Hand.AddCard(card);
                    }
                    else
                    {
                        throw new InvalidOperationException("Not enough cards in the deck to distribute to players.");
                    }
                }
            }
        }

        // Method - Check if there's only one player left who has cards
        private bool IsOnlyOnePlayerLeftWithCards()
        {
            if (!GameOver)
            {
                int playersWithCards = Players.Count(player => player.Hand.Cards.Count > 0);
                return playersWithCards == 1;
            }
            return false;
        }

        // Method - Check if there's only one player left wo is not eliminated
        public bool IsOnlyOneNonEliminatedPlayerLeft()
        {
            return Players.Count(p => !p.Word.IsFilled) == 1;
        }

        // Method - Update match status
        public void UpdateMatchStatus()
        {
            // Revolve the turn to the around players
            UpdateTurn();

            // Update game over status
            if (IsOnlyOnePlayerLeftWithCards())
            {
                GameOver = true;
                Players[PlayerTurn].Word.Fill();    // Fill the word of lost player
            }
        }

        // Method - Update turn
        private void UpdateTurn()
        {
            if (GameOver) return;

            do
            {
                /*
                 !! LOGIC !!

                [CASE 1]
                Players = {1, 2, 3, 4, 5, 6} (MAX)
                ActivePlayers = {1, 2, 4, 6}
                InActivePlayers = {3, 5}
                Turn = 1 (Player 2)

                UpdateTurn:
                    Turn = (Turn < Players.Count - 1) => (1 < 6 -1) => (1 < 5) => true
                        {true} Turn = Turn + 1 => 1 + 1 => 2 (Player 3) ✔
                        {false} Turn = 0

                Players[Turn].Word.IsFilled => Players[2].Word.IsFilled => true (Because player 3 is not active)
                    {true} GOTO UpdateTurn ✔
                    {false} return

                [CASE 2]
                Players = {1, 2, 3, 4, 5, 6} (MAX)
                ActivePlayers = {1, 2, 4, 6}
                InActivePlayers = {3, 5}
                Turn = 0 (Player 1)

                UpdateTurn:
                    Turn = (Turn < Players.Count - 1) => (0 < 6 -1) => (0 < 5) => true
                        {true} Turn = Turn + 1 => 0 + 1 => 1 (Player 2) ✔
                        {false} Turn = 0

                Players[Turn].Word.IsFilled => Players[1].Word.IsFilled => false (Because player 2 is active)
                    {true} GOTO UpdateTurn
                    {false} return ✔
                 */
                PlayerTurn = (PlayerTurn < Players.Count - 1) ? PlayerTurn + 1 : 0;
            } while (Players[PlayerTurn].Word.IsFilled);    // Skips the player who already had lost the game
        }
    }
}
