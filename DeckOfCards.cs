using System;
using System.Collections.Generic;

namespace GameOfWar
{
    public class DeckOfCards
    { 
        public const int STANDARD_DECK_SIZE = 52;

        private List<PlayingCard> deck = null;

        public int Count
        {
            get
            {
                return deck.Count;
            }
        }

        public DeckOfCards(bool fillDeck)
        {
            deck = new List<PlayingCard>();
            if (fillDeck)
            {
                InitializeDeck();
            }
        }

        private void InitializeDeck()
        {
            foreach (PlayingCard.SUITE s in Enum.GetValues(typeof(PlayingCard.SUITE)))
            {
                foreach (PlayingCard.RANK r in Enum.GetValues(typeof(PlayingCard.RANK)))
                {
                    deck.Add(new PlayingCard() { Suite = s, Rank = r });      
                }
            }
        }

        internal bool IsFull()
        {
            return (deck.Count == STANDARD_DECK_SIZE);
        }

        public void Shuffle()
        {
            Random rng = new Random();
            int n = deck.Count;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                PlayingCard tmp = deck[k];
                deck[k] = deck[n];
                deck[n] = tmp;
            }
        }

        public void AddCard(PlayingCard newCard)
        {
            deck.Add(newCard);
        }

        public PlayingCard DealCard()
        {
            PlayingCard dealtCard = null;
            if (deck.Count > 0)
            {
                dealtCard = deck[0];
                deck.RemoveAt(0);
            }
            return dealtCard;
        }

    }

}
