using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Player
    {
        public string player;
        public int handValue = 0;
        bool hitStand;
        int cash = 100;
        int bet = 10;
        List<string> hand = new List<string>();

        public Player(int _handValue, int _cash)
        {
            handValue = _handValue;
            cash = _cash;

        }
    }
}
