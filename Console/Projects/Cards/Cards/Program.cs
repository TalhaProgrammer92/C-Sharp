using Cards.Entities;
using Cards.Enums;
using Cards.ValueObjects.Card;
using Cards.ValueObjects.Player;

//Player player = new Player(new Name("Talha Ahmad"));
//player.AddPointsToScore(10);
//Console.WriteLine(player);

Card card = new Card(
    new CardNumber("K"),
    CardType.Spade
);
Console.WriteLine(card);
