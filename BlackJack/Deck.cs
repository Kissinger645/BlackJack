using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {

        private string cardNumber;
        public int cardValue;
        private string cardSuit;
        private string cardType;
        private int[] deck = new int[52];        

        public Deck()
        {
            string[] cardSuit = {"Hearts", "Diamonds", "Spades", "Clubs"};
            string[] cardType = {"A", "K", "Q", "J", "10", "9", "8", "7", "6", "5", "4", "3", "2"};


        }


        //Shuffle method from:
        //http://stackoverflow.com/questions/1150646/card-shuffling-in-c-sharp
        //based on Fisher-Yates shuffle

        static public void Shuffle(int[] deck)
        {
            for (int n = deck.Length - 1; n > 0; --n)
            {
                int k = rng.Next(n+1);
                int temp = deck[n];
                deck[n] = deck[k];
                deck[k] = temp;
            }

        }

        



      
    }
}
