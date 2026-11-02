
namespace CSharpCardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // game of hi/low

            // One player is a dealer, one is the caller.
            // before the flip, the caller calls hi or low. 
            // the dealer then flips
            // if the card is higher than the last card and the
            //  caller called that then continue to the next round
            // otherwise game over.

            bool isPlaying = true;
            DeckBase deck = new DeckBase(52);

            deck.Shuffle();

            CardBase current = deck.DrawCard();

            while (isPlaying)
            {
                if (deck.GetCardsRemaining() < 1)
                {
                    // stop playing
                    isPlaying = false;
                    break;
                }

                Console.WriteLine($"The current card is: {current}");
                CardBase newCard = deck.DrawCard();

                Console.WriteLine("Is the next card (H)igh or (L)ow?");
                string choice = Console.ReadLine().ToUpper();

                // TODO: if we give bad input, it breaks. Validate This

                Console.WriteLine($"The dealer flips the following card: {newCard}");
                
                if (choice == "H")
                {
                    // call is higher
                    // only true if new > prev
                    if (newCard.Rank > current.Rank)
                    {

                    }
                }
                else if (choice == "L")
                {
                    // call is lower
                    // only true if new < prev
                }
                else
                {
                    // bad call
                    throw new Exception("User made bad input and the program did not catch it.");
                }

                // if we continue
                //      set prev card to our current card
                // if we lost
                //      end the game


                // TODO: EDGE CASE: what if the card is the same
            }
            
        }
    }
}
