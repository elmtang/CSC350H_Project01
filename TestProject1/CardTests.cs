using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework2;
using System;

// Sharna Hossain
// Professor Hao Tang
// CSC 350H
// Project 1

namespace TestProject1
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void RankTest()
        {
            // Testing Card with invalid Rank
            Card invalidCard = new Card("Roomba", "Spades");
            if (Enum.IsDefined(typeof(Rank), invalidCard.Rank))
            {
                Assert.Fail("Not a valid rank!");
            }
        }

        [TestMethod]
        public void SuitTest()
        {
            // Testing Card with invalid Suit
            Card invalidCard = new Card("Five", "Roomba");
            if (Enum.IsDefined(typeof(Suit), invalidCard.Suit))
            {
                Assert.Fail("Not a valid suit!");
            }
        }

        [TestMethod]
        public void ValueTest()
        {
            Card testCard = new Card("Three", "Spades");
            if (testCard.Value != 3)
            {
                Assert.Fail();
            }
        }
    }
}