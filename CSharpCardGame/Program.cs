using System.Runtime.Intrinsics.Arm;

namespace CSharpCardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // card game project

            /*
            Things to represent in the project:

            - Deck (of cards)
                - Probability?
                - How many cards are left in the deck?
                - Initialize
                - Shuffle
                - Draw X Card

            - Game Loop
                - What game are we making? 
                - TODO: We will revist this later.
             */

            DeckBase test = new DeckBase(52);

            test.Shuffle();

            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine($"The top card of the deck is: {test.DrawCard()}");
            }

            Console.ReadLine();
        }
    }
}
