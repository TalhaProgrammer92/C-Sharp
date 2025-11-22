using Cards.Entities;
using Cards.Enums;
using Cards.Utils;
using Cards.ValueObjects.Card;
using Cards.ValueObjects.Player;

//Player player = new Player(new Name("Talha Ahmad"));
//player.AddPointsToScore(10);
//Console.WriteLine(player);

//Card card = new Card(
//    new CardNumber("K"),
//    CardType.Spade
//);
//Console.WriteLine(card);

//Message.Info("This is an informational message.");
//Message.Warning("This is a warning message.");
//Message.Error("This is an error message.");
//Message.Success("This is a success message.");

CardsDeck deck = new CardsDeck();
deck.Shuffle();
deck.Display();
