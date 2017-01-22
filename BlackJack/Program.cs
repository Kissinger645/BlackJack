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
            int dealerValue = 0;
            var playerHand = new List<Cards>();
            int playerValue = 0;
            
            Deck gameDeck = new Deck();
            gameDeck.Shuffle();

            Console.WriteLine("What happens in The Iron Yard, stays in The Iron Yard");
            Console.WriteLine("Welcome to BlackJack");
            playerHand.Add(gameDeck.GetCard());
            dealerHand.Add(gameDeck.GetCard());
            playerHand.Add(gameDeck.GetCard());
            dealerHand.Add(gameDeck.GetCard());
            Console.WriteLine($"Player has {playerValue}");
            playerHand.ForEach(Console.WriteLine);
            Console.WriteLine($"Dealer has {dealerValue}");
            dealerHand.ForEach(Console.WriteLine);

            if (dealerValue == 21)
            {
                Console.WriteLine("BLACKJACK - dealer wins");
            }
            else if (playerValue == 21)
            {
                Console.WriteLine("BLACKJACK - YOU WIN!!"); 
            }
            else
            {
                Console.WriteLine("Enter H for HIT or S for STAND");                
            }

            var input = Console.ReadLine();
            if (input.ToUpper() == "H")
            {
                playerHand.Add(gameDeck.GetCard());
                //check for bust
                Console.WriteLine("Enter H for HIT or S for STAND");
            }

            else //player stands
            {
                while (dealerValue < 16)
                {
                    dealerHand.Add(gameDeck.GetCard());
                }
            }
            //Player Stands, Dealer >= 17
            if (dealerValue > playerValue)
            {
                Console.WriteLine("Dealer wins...");
            }
            else
            {
                Console.WriteLine("Congrats you win!");
            }


            //if cardValue > 21, player busts
            //Dealer = if cardValue < 16, must hit until cardValue >= 17
            //when both states are stand, determine winner



            Console.ReadKey();
        }
    }
}
