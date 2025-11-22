namespace Cards.ValueObjects.Player
{
    public class Word
    {
        // Attributes
        private readonly string _fixedWord;
        private string _mutableWord;
        public bool IsCompletlyFilled => _fixedWord.Length == _mutableWord.Length;

        // Constructor
        public Word(string? word = null)
        {
            _fixedWord = word ?? Settings.GameSettings.DefaultWord;
            _mutableWord = string.Empty;
        }

        // Method - Fill the word with a character
        public void Fill()
        {
            if (IsCompletlyFilled) return;

            _mutableWord += _fixedWord[_mutableWord.Length];
        }

        // Method - Clear the word
        public void Clear()
        {
            _mutableWord = string.Empty;
        }
    }
}
