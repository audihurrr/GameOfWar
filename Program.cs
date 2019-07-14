using System;
using System.Security.Cryptography;

namespace GameOfWar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Game Of War!");

            do
            {
                WarGame war = new WarGame();
                war.DealCards();

                while (!war.HasWinner())
                {

                    war.Battle();

                    //Console.ReadKey(true);
                }

                Console.WriteLine(war.NameWinner());

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
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


    }
}

