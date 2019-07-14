using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfWar
{
    public class PlayingCard
    {
        public enum SUITE
        {
            DIAMONDS = 0,
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

        public override String ToString()
        {
            return (Rank + " of " + Suite);
        }

        internal void CompareTo(PlayingCard p2_card)
        {
            throw new NotImplementedException();
        }
    }
}
