namespace Cards.Utils.Text
{
    public class Heading : Text
    {
        // Constructor
        public Heading(string text, int decorSize = 5) : base(text, Settings.TextSettings.Heading)
        {
            string decor = new String(Settings.TextSettings.HeadingDecorator, Math.Max(5, decorSize));
            Value = decor + $" {text} " + decor;
        }
    }
}
