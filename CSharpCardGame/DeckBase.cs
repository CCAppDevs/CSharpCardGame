using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCardGame
{
    public class DeckBase
    {
        // properties
        private List<CardBase> _cards;
        private int _deckSize;

        // methods
        public DeckBase(int numOfCards)
        {
            this._deckSize = numOfCards;
            this._cards = new List<CardBase>();
            this.ConstructDeck();
        }

        private void ConstructDeck()
        {
            for (int i = 1; i <= 4; i++)
            {
                string suit = "";

                switch (i)
                {
                    case 1:
                        suit = "Hearts";
                        break;
                    case 2:
                        suit = "Diamonds";
                        break;
                    case 3:
                        suit = "Clubs";
                        break;
                    case 4:
                        suit = "Spades";
                        break;
                    default:
                        suit = "Undefined";
                        break;
                }

                for (int rank = 1; rank <= 13; rank++)
                {
                    this._cards.Add(new CardBase(rank, suit));
                }
            }
        }

        public CardBase DrawCard()
        {
            CardBase card = this._cards[0]; // TODO: this can throw an exception when the list is empty

            this._cards.RemoveAt(0);

            return card;
        }

        public void Shuffle()
        {
            this._cards = this._cards.OrderBy(_ => Random.Shared.Next()).ToList();
        }

        // get number of cards (check this._cards.count)
    }
}
