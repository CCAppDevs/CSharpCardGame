
namespace CSharpCardGame
{
    internal class Program
    {
        static bool isPlaying = true;

        static void EndGame()
        {
            isPlaying = false;
            Console.WriteLine("Game Over!");
        }

        static void Main(string[] args)
        {
            // game of hi/low

            // One player is a dealer, one is the caller.
            // before the flip, the caller calls hi or low. 
            // the dealer then flips
            // if the card is higher than the last card and the
            //  caller called that then continue to the next round
            // otherwise game over.


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

                // validate
                if (choice != "H" && choice != "L")
                {
                    // bad call
                    throw new Exception("User made bad input and the program did not catch it.");
                }

                Console.WriteLine($"The dealer flips the following card: {newCard}");

                int comparison = newCard.CompareTo(current);
                string status = "";
                string result = "";

                if (comparison == 0)
                {
                    status = "the same";
                    result = "This is a push";
                    current = newCard;
                    break;
                }

                if (comparison == 1)
                {
                    status = "Higher";
                }
                else
                {
                    status = "Lower";
                }


                if ((choice == "H" && comparison == 1) || (choice == "L" && comparison == -1))
                {
                    // we are correct (win)
                    result = "You Win";
                }
                else
                {
                    result = "You Lose";
                }

                string message = $"The card was {status}! {result}.";

                Console.WriteLine(message);

                current = newCard;
            }
            
        }
    }
}
