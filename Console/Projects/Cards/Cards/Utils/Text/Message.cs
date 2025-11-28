using Cards.Settings;

namespace Cards.Utils.Text
{
    public class Message : Text
    {
        // Attribute
        public Text header;

        // Constructor
        public Message(Text header, string value, ColorObject colorObject) : base(value, colorObject)
        {
            this.header = header;
        }

        // Method - Display message with header
        public void Display(bool lineBreak = true)
        {
            header.Display();
            Console.Write(" ");
            base.Display(lineBreak);
        }

        // Static Methods - Predefined messages
        public static void Info(string text)
        {
            Message message = new Message(
                new Text("[Info]", TextSettings.Info),
                text, TextSettings.Default);
            message.Display();
        }

        public static void Warning(string text)
        {
            Message message = new Message(
                new Text("[Warning]", TextSettings.Warning),
                text, TextSettings.Default);
            message.Display();
        }

        public static void Error(string text)
        {
            Message message = new Message(
                new Text("[Error]", TextSettings.Error),
                text, TextSettings.Default);
            message.Display();
        }

        public static void Success(string text)
        {
            Message message = new Message(
                new Text("[Success]", TextSettings.Success),
                text, TextSettings.Default);
            message.Display();
        }
    }
}
