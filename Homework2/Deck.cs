using System;
using System.Collections.Generic;
using System.Text;


// Sharna Hossain
// Professor Hao Tang
// CSC 350H
// Project 1

namespace Homework2
{
    // Deck class is the parent class of Hand class
    public class Deck
    {
        public List<Card> cards { get; set; }

        public Deck()
        {
            cards = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    cards.Add(new Card(rank.ToString(), suit.ToString()));
                }
            }
        }

        public bool Empty
        {
            get { return cards.Count == 0; }
        }

        public int Count
        {
            get { return cards.Count; }
        }

        public Card TakeTopCard()
        {
            if (!Empty)
            {
                Card topCard = cards[cards.Count - 1];
                cards.RemoveAt(cards.Count - 1);
                return topCard;
            }
            else
                return null;
        }

        // You need to implement the following methods Shuffle, Cut, and Print in Deck class

        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int swap = rand.Next(cards.Count - 1);
                Card temp = cards[i];

                cards[i] = cards[swap];
                cards[swap] = temp;
            }
            Cut(rand.Next(1, cards.Count - 1));
        }

        public void Cut(int cutPos)
        {
            int range = cards.Count - cutPos;
            List<Card> temp = cards.GetRange(cutPos, range);
            cards.RemoveRange(cutPos, range);
            cards.InsertRange(0, temp);
        }

        public void Print()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                Console.Write((i + 1) + ":\t" + cards[i].Rank + " of " + cards[i].Suit);
                // for testing
                Console.Write(" = " + cards[i].Value);

                Console.Write("\n");
            }
        }

        public bool Check(int num)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                for (int j = i + 1; j < cards.Count; j++)
                {
                    if (((cards[i] + cards[j]) == num))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
