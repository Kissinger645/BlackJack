using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Cards
    {
        private int cardValue;
        private string cardSuit;
        private string cardType;
        
        public Cards(string _cardSuit, string _cardType, int _cardValue)
        {
            cardSuit = _cardSuit;
            cardType = _cardType;
            cardValue = _cardValue;
        }

        public override string ToString()
        {
            return ($"{cardType} of {cardSuit}");
        }

        public string GetCardSuit()
        {
            return cardSuit;
        }

        public string GetCardType()
        {
            return cardType;
        }

        public int GetCardValue()
        {
            return cardValue;
        }

    }

}
