using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Sharna Hossain
// Professor Hao Tang
// CSC 350H
// Project 1

/// Another relative of Elevens, called Tens, uses a 13-card board. 
/// Pairs of cards whose point values add to 10 are selected and removed, 
/// as are quartets of kings, queens, jacks, and tens, all of the same rank 
/// (for example, K♠, K♥, K♦, and K♣). 


namespace Homework2
{
    class Tens : Table
    {
        string[] values = new string[]{"King","Queen","Jack","Ten"};
        public Tens()
        {
            checkVal = 10;
            cardsAmt = 13;
        }

        protected override void Instructions()
        {
            Console.WriteLine("Another relative of Elevens, called Tens, uses a 13-card board. " +
                "Pairs of cards whose point values add to 10 are selected and removed, as are " +
                "quartets of kings, queens, jacks, and tens, all of the same rank (for example, K♠, K♥, K♦, and K♣).");
        }

        protected override int GameLogic()
        {
            int value = 0;
            for (int i = 0; i < 4; i++)
            {
                // If the user has selected two valid pairs of card
                if (i == 2 && value == checkVal)
                    return value;

                Console.Write("Selected Card " + (i + 1) + ": ");
                selectedCards.Add(hand.GetCard(Convert.ToInt32(Console.ReadLine()) - 1));
                value += selectedCards[i].Value;
            }

            // If user has successfully selected a valid quartet, return correct value
            if (selectedCards.Any(c => c.Rank == selectedCards[0].Rank) && (values.Contains(selectedCards[0].Rank)))
                return checkVal;

            // Otherwise, return incorrect value for error handling
            return value;
        }
    }
}
