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

        // Get a list of Menu's option labels of a specific range
        public static List<Text> GetOptionsRangeList(int range, ColorObject colorObject)
        {
            if (range <= 0)
                throw new ArgumentOutOfRangeException("Range must be greater than 0");

            // Generate options
            List<Text> options = new List<Text>();
            for (int i = 1; i <= range; i++)
            {
                options.Add(new Text($"[{i}]", colorObject));
            }

            return options;
        }
    }
}
