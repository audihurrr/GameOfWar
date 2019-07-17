using System;

namespace GameOfWar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Game Of War!");
            Console.WriteLine("===========================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Player 1 Card  <--->  Player 2 Card");
            Console.WriteLine("==================================");

            // Play the game until one of the players wins all 52 cards.
            do
            {
                WarGame war = new WarGame();

                // Deal the shuffled cards to each player.
                war.DealCards();

                // Battle until the death!
                while (!war.HasWinner())
                {
                    war.Battle();

                    // Press any button to continue.
                    //Console.ReadKey(true);
                }

                Console.WriteLine(war.NameWinner());

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}

