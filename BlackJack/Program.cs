using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Deal first card to player
second card to dealer
third to player
fourth to dealer
check for blackjack
ask player to hit or stand
Dealer = if cardValue < 16, must hit until cardValue >= 17
when both states are stand, determine winner
*/
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

            dealerHand.ForEach(Console.WriteLine);
            dealerHand.ForEach(Console.WriteLine);
            

            Console.ReadKey();
        }
    }
}
