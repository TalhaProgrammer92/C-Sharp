namespace Cards.GameObjects.Card
{
    public class Table
    {
        // Attributes
        public CardsDeck Deck { get; }
        public TableHand TableHand { get; }

        // Constructor
        public Table()
        {
            Deck = new CardsDeck();
            TableHand = new TableHand(Deck.DrawCard()!);
        }

        // Method - Refresh the desk
        public void RefreshDesk()
        {
            // Reset the deck
            Deck.ResetDeck();

            // Set a new card on the table
            TableHand.ResetTable(Deck.DrawCard()!);
        }
    }
}
