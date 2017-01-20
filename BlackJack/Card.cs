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
      private int cardSet;
                
            public void getCard()
            {

            }
            
            public void cardType()
            {
                if (cardSet == '0' || '13' || '26' || '39' )
                {
                    cardType = "A";
                }
                else if (cardSet == '1' || '14' || '27' || '40' )
                {
                    cardType = "2";
                }
                else if (cardSet == '2' || '15' || '28' || '41' )
                {
                    cardType = "3";
                }
                else if (cardSet == '3' || '16' || '29' || '42' )
                {
                    cardType = "4";
                }
                else if (cardSet == '4' || '17' || '30' || '43' )
                {
                    cardType = "5";
                }
                else if (cardSet == '5' || '18' || '31' || '44' )
                {
                    cardType = "6";
                }
                else if (cardSet == '6' || '19' || '32' || '45' )
                {
                    cardType = "7";
                }
                else if (cardSet == '7' || '20' || '33' || '46' )
                {
                    cardType = "8";
                }
                else if (cardSet == '8' || '21' || '34' || '47' )
                {
                    cardType = "9";
                }
                else if (cardSet == '9' || '22' || '35' || '48' )
                {
                    cardType = "10";
                }
                else if (cardSet == '10' || '23' || '36' || '49' )
                {
                    cardType = "J";
                }
                else if (cardSet == '11' || '24' || '37' || '50' )
                {
                    cardType = "Q";
                }
                else (cardSet == '12' || '25' || '38' || '51' )
                {
                    cardType = "K";
                }

            }

            public void cardValue()
            {
                if (cardType == "2" || "3" || "4" || "5" || "6" || "7" || "8" || "9" || "10")
                {
                    cardValue = cardType;
                }
                else if (cardType == "K" || "Q" || "J")
                {
                    cardValue = 10;
                }
                cardValue = 11;
            }

            public void cardSuit()
            {
                if (cardSet <= 12)
                {
                    cardSuit = "Hearts";
                }
                
                else if (cardSet >= 13 && cardSet <= 25)
                {
                    cardSuit = "Diamonds";
                }

                else if (cardSet >= 26 && cardSet <= 38)
                {
                    cardSuit = "Spades";
                }
                else  
                 {
                     cardSuit = "Clubs";
                 }
            }


        }
    }
}
