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
            bool stand = false;
            Deck gameDeck = new Deck();
            gameDeck.Shuffle();

            Console.WriteLine("Welcome to BlackJack");
            playerHand.Add(gameDeck.GetCard());
            dealerHand.Add(gameDeck.GetCard());
            playerHand.Add(gameDeck.GetCard());
            dealerHand.Add(gameDeck.GetCard());
            int playerValue = playerHand.Sum(x => x.cardValue);
            Console.WriteLine($"Player has {playerValue}");
            playerHand.ForEach(Console.WriteLine);
            int dealerValue = dealerHand.Sum(x => x.cardValue);
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
                        
            while (stand == false)
            {
                Console.WriteLine("Enter H for HIT or S for STAND");
                var input = Console.ReadLine();
                if (input.ToUpper() == "H")
                {
                    playerHand.Add(gameDeck.GetCard());
                    playerValue = playerHand.Sum(x => x.cardValue);
                    Console.WriteLine($"Player has {playerValue}");
                    playerHand.ForEach(Console.WriteLine);
                    //check for bust
                }
                else
                {
                    stand = true;
                }
            }

            //player stands
            {
                while (dealerValue < 16)
                {
                    dealerHand.Add(gameDeck.GetCard());
                    dealerValue = dealerHand.Sum(x => x.cardValue);
                    Console.WriteLine($"Dealer has {dealerValue}");
                    dealerHand.ForEach(Console.WriteLine);
                    //check for bust
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

            Console.ReadKey();
        }
    }
}
