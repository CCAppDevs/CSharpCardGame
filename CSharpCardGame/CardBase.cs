using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCardGame
{

    public class CardBase : IComparable<CardBase>
    {
        // what a card knows
        private int _rank { get; }

        public string Rank
        {
            get
            {
                if (_rank == 1)
                {
                    return "A";
                }
                else if (_rank == 11)
                {
                    return "J";
                }
                else if (_rank == 12)
                {
                    return "Q";
                }
                else if (_rank == 13)
                {
                    return "K";
                }
                else
                {
                    return _rank.ToString();
                }
            }
        }

        public string Suit { get; }

        // card's behaviors
        public CardBase(int rank, string suit)
        {
            _rank = rank;
            Suit = suit;
        }

        public override string? ToString()
        {
            return $"{Rank} of {Suit}";
        }

        // simple helper function (getter)
        public int GetRank()
        {
            return this._rank;
        }

        public int CompareTo(CardBase? other)
        {
            if (other == null)
            {
                return 0;
            }

            if (this._rank > other.GetRank())
            {
                return 1;
            }
            else if (this._rank < other.GetRank())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
