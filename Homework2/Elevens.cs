using System;
using System.Collections.Generic;
using System.Text;

// Sharna Hossain
// Professor Hao Tang
// CSC 350H
// Project 1

namespace Homework2
{
    class Elevens : Table
    {
        string[] values = new string[] { "King", "Queen", "Jack" };
        public Elevens()
        {
            checkVal = 11;
            cardsAmt = 10;
        }

        public override void Instructions()
        {
            Console.WriteLine("Elevens uses a 10-card board. " +
                "Pairs of cards whose point values add to 11 are selected and removed, as are " +
                "a combination of a king, queen, and jack.");
        }

        public override int GameLogic()
        {
            int value = 0;
            for (int i = 0; i < 3; i++)
            {
                // If user has selected two valid pairs of cards
                if (i == 2 && value == checkVal)
                    return value;

                Console.Write("Selected Card " + (i + 1) + ": ");
                selectedCards.Add(hand.GetCard(Convert.ToInt32(Console.ReadLine()) - 1));
                value += selectedCards[i].Value;
            }

            // Check if 1 King, 1 Queen, and 1 Jack in selectedCards
            bool K, Q, J;
            K = Q = J = false;
            foreach(Card c in selectedCards)
            {
                if (c.Rank == "King")
                    K = !K;
                if (c.Rank == "Queen")
                    Q = !Q;
                if (c.Rank == "Jack")
                    J = !J;
            }

            if (K && J && Q)
                return checkVal;

            return value;
        }
    }
}
