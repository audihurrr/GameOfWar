using System;
using System.Security.Cryptography;

namespace GameOfWar
{
    class Program
    {
        static void Main(string[] args)
        {

            WarGame war = new WarGame();

            war.DealCards();




            //bool wantsToPlay = false;

            //// Say hello!
            //Console.WriteLine("Welcome to The Game of WAR!");

            //// get a valid yes or no response.
            //ConsoleKey response;
            //do
            //{
            //    Console.Write("Would you like to play a round? [y/n] ");
            //    response = Console.ReadKey(false).Key;
            //    Console.WriteLine();

            //} while (response != ConsoleKey.Y && response != ConsoleKey.N);

            //// User responded with a yes or no.

            //wantsToPlay = (response == ConsoleKey.Y);

            //while (wantsToPlay)
            //{

            //    Console.WriteLine("\nTime to play war!");
            //    WarGame war = new WarGame();
            //    war.DealCards();
            //    ConsoleKey nextTurn;
            //    do
            //    {
            //        Console.WriteLine("Playing a single turn");
            //        war.PlaySingleTurn();

            //        nextTurn = Console.ReadKey(false).Key;

            //    } while (nextTurn == ConsoleKey.Spacebar);
            //}

            //if (wantsToPlay)
            //{
               
                
            //}
            //else
            //{
            //    Console.WriteLine("\nFine then, 52 card pickup.");
            //    DeckOfCards tmpDeck = new DeckOfCards();
            //    tmpDeck.InitializeDeck(true);
                
            //    for  (int i = 0; i < tmpDeck.Deck.Length; ++i)
            //    {
            //        Console.WriteLine(tmpDeck.Deck[i].ToString());
            //    }
            //}







            //if (consoleKeyInfo.Key == ConsoleKey.N)
            //{
            //    Console.WriteLine("\nFine then, 52 card pickup.");

            //    // create a deck of cards, shuffle them, and then print them all to screen in anger and exit game.

            //}
            //else if (consoleKeyInfo.Key == ConsoleKey.Y)
            //{
            //    Console.WriteLine("\nAh Ha!  Now it's time to play");

            //    // play game
            //    WarGame war = new WarGame();
            //    war.Play();

            //}
            //else
            //{
            //    Console.WriteLine("\nPlease enter a valid option...");
            //    consoleKeyInfo = Console.ReadKey();
            //}



            //const int STANDARD_DECK_SIZE = 52;

            //PlayingCard[] deck = new PlayingCard[STANDARD_DECK_SIZE];

            ////***************************************************************************
            //// Filling the deck of cards.
            //int cardIndex = 0;

            //foreach (PlayingCard.SUITE s in Enum.GetValues(typeof(PlayingCard.SUITE)))
            //{
            //    foreach (PlayingCard.RANK r in Enum.GetValues(typeof(PlayingCard.RANK)))
            //    {
            //        deck[cardIndex] = new PlayingCard() { Suite = s, Rank = r };
            //        cardIndex++;
            //    }
            //}
            ////***************************************************************************



            ////***************************************************************************
            //// What about shuffling the deck of cards now, ay?!
            //// Found something online about the Fisher-Yates Shuffle.
            //Random rng = new Random();
            //int n = deck.Length;

            //while (n > 1)
            //{
            //    n--;
            //    int k = rng.Next(n + 1);
            //    PlayingCard tmp = deck[k];
            //    deck[k] = deck[n];
            //    deck[n] = tmp;
            //}
            //***************************************************************************

            //Console.ReadKey();

        }
    }
}
