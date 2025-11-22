using Cards.Enums;
using System.Collections.ObjectModel;

namespace Cards.Entities
{
    public class Hand
    {
        // Attributes
        public Collection<Card> Cards { get; private set; }

        // Constructor
        public Hand()
        {
            Cards = new Collection<Card>();
        }

        // Method - Add card to hand
        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        // Method - Remove card from hand
        public void RemoveCard(Card card)
        {
            Cards.Remove(card);
        }

        // Method - Clear hand
        public void ClearCards()
        {
            Cards.Clear();
        }

        // Method - Get specific cards by type from hand
        public Collection<Card>? GetByCardType(CardType cardType)
        {
            // Check if hand has the specified card type
            if (!HasCardType(cardType))
                return null;

            // Filter cards by specified type
            Collection<Card> filteredCards = new Collection<Card>();

            foreach (var card in Cards)
            {
                if (card.CardType == cardType)
                {
                    filteredCards.Add(card);
                }
            }

            return filteredCards;
        }

        // Method - Check if hand has specific type of card
        public bool HasCardType(CardType cardType)
        {
            foreach (var card in Cards)
            {
                if (card.CardType == cardType)
                    return true;
            }
            return false;
        }

        // Method - Display cards in hand
        public void Display()
        {
            foreach (var card in Cards)
            {
                card.Display();
            }
        }
    }

    // To handle table hand
    public class TableHand : Hand
    {
        // Attributes
        public CardType CardType { get; private set; }

        // Constructor
        public TableHand(Card card) : base()
        {
            InitializeTableHand(card);
        }

        // Method - Initialize table hand with a card
        private void InitializeTableHand(Card card)
        {
            CardType = card.CardType;
            AddCard(card);
        }

        // Method - Check if the player card is valid for the table hand
        public bool IsValidPlayerCard(Card playerCard)
        {
            return playerCard.CardType == CardType;
        }

        // Method - Get top card of the table hand
        public Card? GetTopCard()
        {
            if (Cards.Count == 0)
                return null;
            
            return Cards[Cards.Count - 1];
        }

        // Method - Change table hand card type
        public void ChangeCardType(Card playerCard, CardType newCardType)
        {
            if (!CanChangeCardType(playerCard))
                throw new InvalidOperationException("Player cannot change the card type. It must have either same rank or a rank of 'J'");

            CardType = newCardType;
        }

        // Method - Check if player can change the card type
        public bool CanChangeCardType(Card playerCard)
        {
            /*
             RULES:
                1. Player can change the card type if the rank of the player card is 'J'
                2. Player can change the card type if the rank of the player card is same as the top card of the table hand
             */
            return playerCard.CardRank.Value == "J" || playerCard.CardRank == GetTopCard()!.CardRank;
        }

        public void ResetTable(Card card)
        {
            ClearCards();
            InitializeTableHand(card);
        }
    }
}
