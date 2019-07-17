using System;
using System.Collections.Generic;

namespace GameOfWar
{
    public class WarGame
    {
        // Number of cards to deal when players draw matching rank.
        private const int BurnPileSize = 1;

        // Each game contains two players.
        private WarPlayer player1 = null;
        private WarPlayer player2 = null;

        public WarGame()
        {
            player1 = new WarPlayer();
            player2 = new WarPlayer();
        }

        // Create a deck of cards, shuffle them and distribute the deck evenly to each player.
        public void DealCards()
        {
            DeckOfCards tmpDeck = new DeckOfCards(true);
            tmpDeck.Shuffle();

            for (int i = 0; i < DeckOfCards.StandardDeckSize; ++i)
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

        // Each player draws a card and rank is compared. Winner gets the cards.
        // In case of matching rank, we go to 'war' -- deal card(s) face down, and then draw
        // another card for comparison, repeat until winner or one of the player's piles is empty.
        public void Battle()
        {
            Stack<PlayingCard> dealtCardPile = new Stack<PlayingCard>();
            bool isBattleWon = false;

            do
            {
                PlayingCard p1_card = null;
                PlayingCard p2_card = null;

                // Check each player's pile size before drawing a card.
                if (DoPlayersHaveEnoughCards(1))
                {
                    p1_card = player1.DrawCard();
                    p2_card = player2.DrawCard();

                    Console.Write("{0}  <--->  {1}", p1_card.ToString(), p2_card.ToString());

                }
                else
                {
                    Console.WriteLine("Not enough cards to battle, game is over.");
                    return;
                }

                // Compare drawn card rank.
                int value = p1_card.Rank.CompareTo(p2_card.Rank);

                // Add drawn cards to the pile.
                dealtCardPile.Push(p1_card);
                dealtCardPile.Push(p2_card);

                // Player 2 Wins -- Player 1 rank is less than player 2 rank.
                if (value < 0)
                {
                    Console.WriteLine(" -- Player 2 wins this round");

                    foreach (PlayingCard card in dealtCardPile)
                    {
                        player2.AddCardToDeck(card);
                    }

                    isBattleWon = true;
                }
                // Player 1 Wins -- Player 1 rank is greater than player 2 rank.
                else if (value > 0)
                {
                    Console.WriteLine(" -- Player 1 wins this round");

                    foreach (PlayingCard card in dealtCardPile)
                    {
                        player1.AddCardToDeck(card);
                    }

                    isBattleWon = true;
                }
                else // Ranks are equal, it is time for war!
                {
                    // Check if each player has enough cards for 'war'. 
                    if (DoPlayersHaveEnoughCards(BurnPileSize))
                    {
                        Console.WriteLine(" -- Now is the time for war");

                        for (int i = 0; i < BurnPileSize; ++i)
                        {
                            dealtCardPile.Push(player1.DrawCard());
                            dealtCardPile.Push(player2.DrawCard());
                        }

                        // Draw another card face-up to continue the battle.
                        isBattleWon = false;
                    }
                    else
                    {
                        Console.WriteLine(" -- Not enough cards for war, game is over");
                        return;
                    }
                }

            } while (!isBattleWon);
        }

        private bool DoPlayersHaveEnoughCards(int numCards)
        {
            return (player1.DeckSize >= numCards && player2.DeckSize >= numCards);
        }

        public bool HasWinner()
        {
            return (player1.DeckSize == 0) || (player2.DeckSize == 0);
        }

        public String NameWinner()
        {
            return (player1.DeckSize > player2.DeckSize) ? "Player 1 is the ultimate Warrior!" : "Player 2 is the ultimate Warrior!";
        }
    }
}