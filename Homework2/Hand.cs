using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    // Because Hand class require some identical functions and properties as the Deck class,
    // I had Hand class inherit from the Deck class and overrided the default constructor
    public class Hand : Deck
    {

        public Hand()
        {
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public void ReplaceCard(int pos, Card card)
        {
            cards[pos] = card;
        }

        public void RmCard(int pos)
        {
            if (Empty || pos > cards.Count || pos < 0)
            {
                Console.Error.WriteLine("Card at index does not exist");
                return;
            }
            cards.RemoveAt(pos);
        }
        
        public int IndexOf(Card card)
        {
            return cards.IndexOf(card);
        }

        public void RmCard(Card card)
        {
            if (!cards.Contains(card))
            {
                Console.Error.WriteLine("Card does not exist");
                return;
            }
            cards.Remove(card);
        }

        public Card GetCard(int pos)
        {
            if (Empty)
                return null;
            return cards[pos];
        }
    }
}
