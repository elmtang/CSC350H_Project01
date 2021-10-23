using System;
using System.Collections.Generic;
using System.Text;

// Sharna Hossain
// Professor Hao Tang
// CSC 350H
// Project 1

namespace Homework2
{
    public class Card
    {
        public string Rank { get; }
        public string Suit { get; }
        bool faceUp;

        public Card(string rank, string suit)
        {
            Rank = rank;
            Suit = suit;
            faceUp = false;
        }

        public bool FaceUp
        {
            get { return faceUp; }
        }

        public void FlipOver()
        {
            faceUp = !faceUp;
        }

        public int Value
        {
            get { return (int)System.Enum.Parse(typeof(Rank), this.Rank) + 1; }
        }

        public static int operator +(Card a, Card b)
        {
            return a.Value + b.Value;
        }
    }
}
