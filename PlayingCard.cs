using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfWar
{
    class PlayingCard
    {
        public enum SUITE
        {
            DIAMONDS,
            SPADES,
            CLUBS,
            HEARTS
        };

        public enum RANK {
            
            TWO = 2,
            THREE,
            FOUR,
            FIVE,
            SIX,
            SEVEN,
            EIGHT,
            NINE,
            TEN,
            JACK,
            QUEEN,
            KING,
            ACE
        };

        public SUITE Suite { get; set; }
        public RANK Rank { get; set; }

    }
}
