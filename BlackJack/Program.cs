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
            Deck newDeck = new Deck();
            newDeck.Shuffle();

            Console.WriteLine("What happens in The Iron Yard, stays in The Iron Yard");
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine(newDeck.GetCard());
            }
            
            

            Console.ReadKey();
        }
    }
}
