using Cards.Enums;
using Cards.Utils.Text;

namespace Cards.Utils
{
    public class Misc
    {
        // Method - Print a message with color
        public static void PrintColoredMessage(string message, ColorObject colorObject, bool lineBreak = true)
        {
            Console.ForegroundColor = colorObject.ForegroundColor;
            Console.BackgroundColor = colorObject.BackgroundColor ?? ConsoleColor.Black;
            
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

        // Method - Print colored info message
        public static void PrintColoredMessage(string info, string message, ColorObject colorObject, bool lineBreak = true)
        {
            PrintColoredMessage($"{info}: ", colorObject, false);
            Console.Write(message);

            if (lineBreak) Console.WriteLine();
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
        public static List<Text.Text> GetOptionsRangeList(int range, ColorObject colorObject)
        {
            if (range <= 0)
                throw new ArgumentOutOfRangeException("Range must be greater than 0");

            // Generate options
            List<Text.Text> options = new List<Text.Text>();
            for (int i = 1; i <= range; i++)
            {
                options.Add(new Text.Text($"[{i}]", colorObject));
            }

            return options;
        }

        // Do a line break
        public static void LineBreak(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine();
            }
        }

        // Get number of digits of a number
        public static int GetDigitsCount(int number)
        {
            if (number < 0) number *= -1;   // Make negative number positive

            int digits = 0;

            do
            {
                number /= 10;
                digits++;
            }
            while (number > 0);

            return digits;
        }

        // Get padding for menu title
        public static Padding GetMenuTitlePadding(int longestOptionLength, int noOfOptions)
        {
            Padding padding = new Padding();
            int brackets = 2,
                gap = 1,
                totalLength = longestOptionLength + brackets + GetDigitsCount(noOfOptions) + gap;

            // Calculate left padding
            padding.Left = totalLength / 2;
            padding.Right = totalLength / 2;
            if (totalLength % 2 == 1) padding.Right++;

            return padding;
        }
    }
}
