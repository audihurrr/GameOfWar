using System;
using System.Collections.Generic;

namespace GameOfWar
{
    public class WarGame
    {

        private const int BURN_PILE_SIZE = 3;

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

        public void Battle()
        {
            Stack<PlayingCard> dealt_cards = new Stack<PlayingCard>();
            bool battleWon = false;

            do
            {
                //TODO, need to handle the case where there are no more cards to draw for either player.  program crashes 
                // Each player draws a card
                PlayingCard p1_card = player1.DrawCard();
                PlayingCard p2_card = player2.DrawCard();

                Console.Write("p1: " + p1_card.ToString() + ", p2: " + p2_card.ToString());

                // Compare Rank
                int value = p1_card.Rank.CompareTo(p2_card.Rank);

                // Add cards to dealt_list
                dealt_cards.Push(p1_card);
                dealt_cards.Push(p2_card);

                // Player1 Rank is less than Player2 Rank
                if (value < 0)
                {
                    Console.WriteLine("...Player 2 Wins!");
                    foreach (PlayingCard card in dealt_cards)
                    {
                        player2.AddCardToDeck(card);
                    }
                    battleWon = true;
                }
                else if (value > 0) // Player 1 Rank is greater than Player2 Rank
                {
                    Console.WriteLine("...Player 1 Wins!");

                    foreach (PlayingCard card in dealt_cards)
                    {
                        player1.AddCardToDeck(card);
                    }
                    battleWon = true;
                }
                else // Ranks are equal, it is time for war!
                {
                    Console.Write("...it's a war! ");

                    for (int i = 0; i < BURN_PILE_SIZE; ++i)
                    {
                        dealt_cards.Push(player1.DrawCard());
                        dealt_cards.Push(player2.DrawCard());
                    }

                    battleWon = false;
                }

            } while (!battleWon);
        }

        public bool HasWinner()
        {
            return (player1.HasAllCards() || player2.HasAllCards()); 
        }

        public String NameWinner()
        {
            String winner = String.Empty;

            if (HasWinner())
            {
                if (player1.HasAllCards()) { winner = "Player 1 is the ultimate Warrior!"; }
                else { winner = "Player 2 is the ultimate Warrior!"; }
            }
            return winner;
        }
    }
}