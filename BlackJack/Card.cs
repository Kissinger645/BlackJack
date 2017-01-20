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
      private int cardID;
        private 
      Random rng = new Random();
                
      public void getCard(int _cardValue, string _cardSuit, string _cardType)
            {
            cardValue = _cardValue;
            cardSuit = _cardSuit;
            cardType = _cardType;
            }

        
            /*
            public void getSuit()
            {
                if (cardID <= 12)
                {
                    cardSuit = "Hearts";
                }
                
                else if (cardID >= 13 && cardID <= 25)
                {
                    cardSuit = "Diamonds";
                }

                else if (cardID >= 26 && cardID <= 38)
                {
                    cardSuit = "Spades";
                }
                else  
                 {
                     cardSuit = "Clubs";
                 }
            }
        public void getValue()
        {
            if (cardID == "0" || "13" || "26" || "39")
            {
                cardType = "A";
                cardValue = 11;
            }
            else if (cardID == "1" || '14' || '27' || '40')
            {
                cardType = "2";
                cardValue = 2;
            }
            else if (cardID == 2 || 15 || 28 || 41)
            {
                cardType = "3";
                cardValue = 3;
            }
            else if (cardID == '3' || '16' || '29' || '42')
            {
                cardType = "4";
                cardValue = 4;
            }
            else if (cardID == '4' || '17' || '30' || '43')
            {
                cardType = "5";
                cardValue = 5;
            }
            else if (cardID == '5' || '18' || '31' || '44')
            {
                cardType = "6";
                cardValue = 6;
            }
            else if (cardID == '6' || '19' || '32' || '45')
            {
                cardType = "7";
                cardValue = 7;
            }
            else if (cardID == '7' || '20' || '33' || '46')
            {
                cardType = "8";
                cardValue = 8;
            }
            else if (cardID == '8' || '21' || '34' || '47')
            {
                cardType = "9";
                cardValue = 9;
            }
            else if (cardID == '9' || '22' || '35' || '48')
            {
                cardType = "10";
                cardValue = 10;
            }
            else if (cardID == '10' || '23' || '36' || '49')
            {
                cardType = "J";
                cardValue = 10;
            }
            else if (cardID == '11' || '24' || '37' || '50')
            {
                cardType = "Q";
                cardValue = 10;
            }
            else (cardID == '12' || '25' || '38' || '51')
                {
                cardType = "K";
                cardValue = 10;
            }

        }
        */

    }
    }
}
