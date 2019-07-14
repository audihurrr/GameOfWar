using System;
using System.Collections.Generic;

namespace GameOfWar
{
    public class WarGame
    {
        WarPlayer player1 = null;
        WarPlayer player2 = null;
        
        public WarGame()
        {
            player1 = new WarPlayer();
            player2 = new WarPlayer();
        }

        public void DealCards()
        {
            DeckOfCards tmpDeck = new DeckOfCards(true);
            tmpDeck.Shuffle();

            for (int i = 0; i < DeckOfCards.STANDARD_DECK_SIZE; ++i)
            {
                if (i % 2 == 0)
                {
                    player1.AddCardToDeck(tmpDeck.DealCard());
                }
                else
                {
                    player2.AddCardToDeck(tmpDeck.DealCard());
                }
            }
        }


    }
}