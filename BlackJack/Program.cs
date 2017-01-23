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
            bool gameOver = false;
            bool playerBust = false;
            bool dealerBust = false;
            int cash = 100;

            while (gameOver == false)
            {
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
                    Console.WriteLine("***BLACKJACK - dealer wins***");
                    gameOver = true;
                    cash -= 10;
                }
                else if (playerValue == 21)
                {
                    Console.WriteLine("***BLACKJACK - YOU WIN!!***");
                    gameOver = true;
                    cash += 10;
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
                        if (playerValue > 21)
                        {
                            cash -= 10;
                            Console.WriteLine("***BUST - You lose***");
                            gameOver = true;
                        }
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
                        if (dealerValue > 21)
                        {                            
                            cash += 10;
                            Console.WriteLine("***Dealer bust. YOU WIN!***");
                            gameOver = true;
                        }
                    }
                }

                //Player Stands, Dealer >= 17
                if (dealerValue > playerValue)
                {
                    Console.WriteLine("Dealer wins...");
                    gameOver = true;
                    cash -= 10;
                }
                else
                {
                    Console.WriteLine("Congrats you win!");
                    gameOver = true;
                    cash += 10;
                }
            }
            Console.WriteLine("GAME OVER");
            Console.ReadKey();
        }
    }
}
