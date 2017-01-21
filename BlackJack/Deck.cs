using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {

        private int cardID;
        public int cardValue;
        private string cardSuit;
        private string cardType;
        private Cards[] newDeck;
        Random rng = new Random();


        public Deck()
        {
            string[] cardSuit = { "Hearts", "Diamonds", "Spades", "Clubs" };
            string[] cardType = { "A", "K", "Q", "J", "10", "9", "8", "7", "6", "5", "4", "3", "2" };
            int[] cardValue = {11, 10, 10, 10, 10, 9, 8, 7, 6, 5, 4, 3, 2};
            newDeck = new Cards[52];
            for (int i = 0; i < 52; i++)
            {
                newDeck[i] = new Cards(cardSuit[i / 13], cardType[i % 13], cardValue[i % 13]);
            }

        }

        //Shuffle method from:
        //http://stackoverflow.com/questions/1150646/card-shuffling-in-c-sharp
        //based on Fisher-Yates shuffle

        public void Shuffle()
        {
            for (int n = newDeck.Length - 1; n > 0; --n)
            {
                int k = rng.Next(n + 1);
                Cards temp = newDeck[n];
                newDeck[n] = newDeck[k];
                newDeck[k] = temp;
            }

        }

        public Cards GetCard()
        {
            
            return newDeck[cardID++];

        }


    }

}

