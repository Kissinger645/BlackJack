using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            var dealerHand = new List<Cards>();
            var playerHand = new List<Cards>();
            Deck gameDeck = new Deck();
            gameDeck.Shuffle();

            Console.WriteLine("What happens in The Iron Yard, stays in The Iron Yard");
            playerHand.Add(gameDeck.GetCard());
            dealerHand.Add(gameDeck.GetCard());
            playerHand.Add(gameDeck.GetCard());
            dealerHand.Add(gameDeck.GetCard());
            Console.WriteLine("Player has:");
            playerHand.ForEach(Console.WriteLine);
            Console.WriteLine("Dealer has:");
            dealerHand.ForEach(Console.WriteLine);
            //check for blackjack
            //ask player to hit or stand
            //if cardValue > 21, player busts
            //Dealer = if cardValue < 16, must hit until cardValue >= 17
            //when both states are stand, determine winner



            Console.ReadKey();
        }
    }
}
