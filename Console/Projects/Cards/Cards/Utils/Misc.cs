using Cards.Enums;

namespace Cards.Utils
{
    public class Misc
    {
        // Method - Print a message with color
        public static void PrintColoredMessage(string message, ColorObject colorObject, bool lineBreak = true)
        {
            Console.ForegroundColor = colorObject.Color;
            
            if (lineBreak)
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.Write(message);
            }
            
            Console.ResetColor();
        }

        // Get a list of Card Ranks
        public static List<CardRank> GetCardRanks()
        {
            return new List<CardRank> { 
                CardRank.Ace,
                CardRank.Two,
                CardRank.Three,
                CardRank.Four,
                CardRank.Five,
                CardRank.Six,
                CardRank.Seven,
                CardRank.Nine,
                CardRank.Eight,
                CardRank.Nine,
                CardRank.Jack,
                CardRank.Queen,
                CardRank.King
            };
        }
    }
}
