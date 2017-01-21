using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Dealer
    {
        int dealerValue = 0;
        bool hitStand;
        List<string> dealerHand = new List<string>();

        public Dealer()
        {

        }

        public void GetCard()
        {
            //dealerHand.Add(newDeck.GetCard());
        }
    }
}
//
//Dealer = if cardValue < 16, must hit until cardValue >= 17
//