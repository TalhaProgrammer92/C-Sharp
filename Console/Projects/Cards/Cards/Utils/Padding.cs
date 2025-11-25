namespace Cards.Utils
{
    public class Padding
    {
        // Attributes
        private int left, right;

        // Getters & Setters
        public int Left
        {
            get => left;
            set
            {
                if (value >= 0)
                    left = value;
                else
                    throw new Exception("Value can't be negative");
            }
        }
        public int Right
        {
            get => right;
            set
            {
                if (value >= 0)
                    right = value;
                else
                    throw new Exception("Value can't be negative");
            }
        }

        // Constructor
        public Padding(int left = 0, int right = 0)
        {
            Left = left;
            Right = right;
        }
    }
}
