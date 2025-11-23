namespace Cards.ValueObjects.Player
{
    public class Word
    {
        // Attributes
        private readonly string _fixedWord;
        private string _mutableWord;
        public bool IsFilled => _fixedWord.Length == _mutableWord.Length;

        // Constructor
        public Word(string? word = null)
        {
            _fixedWord = word ?? Settings.GameSettings.DefaultWord;
            _mutableWord = string.Empty;
        }

        // Method - Fill the word with a character
        public void Fill()
        {
            if (IsFilled) return;

            /*
             !! LOGIC !!

            Fw: Fixed Word
            Mw: Mutable Word

            [CASE 1]
            Fw = "Donkey"
            Mw = "Do"

            IsFilled => false

            index = Mw.Length => 2
            Mw += Fw[index] => 'n'

            [CASE 2]
            Fw = "Donkey"
            Mw = "Donkey"

            IsFilled => true (Because both Fw and Mw have same length)
             */
            int index = _mutableWord.Length;
            _mutableWord += _fixedWord[index];
        }

        // Method - Clear the word
        public void Clear()
        {
            _mutableWord = string.Empty;
        }
    }
}
