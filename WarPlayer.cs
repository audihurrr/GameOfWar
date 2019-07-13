using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfWar
{
    public class WarPlayer
    {
        public DeckOfCards Deck { get; set; }

        public WarPlayer() {

            Deck = new DeckOfCards();

        }

    }
}
