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

            CardBase test = new CardBase(111, "Spades");

            Console.WriteLine(test);
        }
    }
}
