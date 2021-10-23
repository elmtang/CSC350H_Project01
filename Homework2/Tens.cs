using System;
using System.Collections.Generic;
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
        public Tens()
        {
            checkVal = 10;
            cardsAmt = 13;
        }
    }
}
