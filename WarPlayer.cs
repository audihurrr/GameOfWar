using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfWar
{
    public class WarPlayer
    {

        private DeckOfCards cardPile = null;

        public WarPlayer()
        {
            cardPile = new DeckOfCards(false);
        }

        public void AddCardToDeck(PlayingCard c)
        {
            cardPile.AddCard(c);
        }

        internal PlayingCard DrawCard()
        {
            return cardPile.DealCard();
        }

        internal bool HasAllCards()
        {
            return cardPile.IsFull();
        }
    }
}
