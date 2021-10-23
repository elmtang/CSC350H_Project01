using System;
using System.Collections.Generic;
using System.Text;

// Sharna Hossain
// Professor Hao Tang
// CSC 350H
// Project 1

namespace Homework2
{
    class Thirteens : Table
    {
        public Thirteens()
        {
            checkVal = 13;
            cardsAmt = 10;
        }

        public override void Instructions()
        {
            Console.WriteLine("A game related to Elevens, called Thirteens, uses a 10-card board. " +
                "Ace, 2, … , 10, jack, queen correspond to the point values of 1, 2, …, 10, 11, 12. " +
                "Pairs of cards whose point values add up to 13 are selected and removed. Kings are selected and removed singly.");
        }

        public override int GameLogic()
        {
            int value = 0;
            for (int i = 0; i < 2; i++)
            {
                // If user has selected a King on the first card choice, they won the won round
                if (value == checkVal)
                    break;
                Console.Write("Selected Card " + (i + 1) + ": ");
                selectedCards.Add(hand.GetCard(Convert.ToInt32(Console.ReadLine()) - 1));
                value += selectedCards[i].Value;
            }
            return value;
        }
    }
}
