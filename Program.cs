using System;
using System.Security.Cryptography;

namespace GameOfWar
{
    class Program
    {
        static void Main(string[] args)
        {      
            
            Console.WriteLine("Welcome to The Game of WAR!");

            Console.WriteLine("Would you like to play? Press Y/N...");

            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();


            while (consoleKeyInfo.Key != ConsoleKey.N || consoleKeyInfo.Key != ConsoleKey.Y)
            {
                if (consoleKeyInfo.Key == ConsoleKey.N)
                {
                    Console.WriteLine("Fine then, 52 card pickup.");

                    // create a deck of cards, shuffle them, and then print them all to screen in anger and exit game.

                }
                else if (consoleKeyInfo.Key == ConsoleKey.Y)
                {
                    Console.WriteLine("Ah Ha!  Now it's time");

                }
                else
                {
                    Console.WriteLine("Please enter a valid option");
                }

            }

            const int STANDARD_DECK_SIZE = 52;

            PlayingCard [] deck = new PlayingCard[STANDARD_DECK_SIZE];

            //***************************************************************************
            // Filling the deck of cards.
            int cardIndex = 0;

            foreach (PlayingCard.SUITE s in Enum.GetValues(typeof(PlayingCard.SUITE))) {
                foreach (PlayingCard.RANK r in Enum.GetValues(typeof(PlayingCard.RANK))) {
                    deck[cardIndex] = new PlayingCard() { Suite = s, Rank = r };
                    cardIndex++;
                }
            }
            //***************************************************************************



            //***************************************************************************
            // What about shuffling the deck of cards now, ay?!
            // Found something online about the Fisher-Yates Shuffle.
            Random rng = new Random();
            int n = deck.Length;

            while (n > 1) {
                n--;
                int k = rng.Next(n + 1);
                PlayingCard tmp = deck[k];
                deck[k] = deck[n];
                deck[n] = tmp;
            }
            //***************************************************************************
            
            Console.ReadKey();

        }
    }
}
