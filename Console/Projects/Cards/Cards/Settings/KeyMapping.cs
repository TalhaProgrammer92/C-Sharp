namespace Cards.Settings
{
    public class KeyMapping
    {
        public static readonly Dictionary<Enums.Action, ConsoleKey> Actions = new ()
        {
            { Enums.Action.ClearConsole, ConsoleKey.C },
            { Enums.Action.SaveGame, ConsoleKey.S },
            { Enums.Action.LoadGame, ConsoleKey.L }
        };
    }
}
