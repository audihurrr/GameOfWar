using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfWar
{
    public class WarPlayer
    {
        // Each war player has a pile of cards.
        private DeckOfCards cardPile = null;

        
        public WarPlayer()
        {
            // Create a new pile of cards, but keep it empty.
            cardPile = new DeckOfCards(false);
        }

        public int DeckSize
        {
            get
            {
                return cardPile.Count;
            }
        }

        public void AddCardToDeck(PlayingCard c)
        {
            cardPile.AddCard(c);
        }

        public PlayingCard DrawCard()
        {
            return cardPile.DealCard();
        }
    }
}
