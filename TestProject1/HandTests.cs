using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework2;

// Sharna Hossain
// Professor Hao Tang
// CSC 350H
// Project 1

namespace TestProject1
{
    [TestClass]
    public class Hand_Tests
    {

        // Test the handtest method that we implemented in class
        [TestMethod]
        public void HandTest()
        {
            Hand testHand = new Hand();
            if (testHand.cards == null)
            {
                Assert.Fail("Not initialized");
            }

        }

        // Implement unit tests to check Constructor and Empty and Count Properties. This test case simply checks that the object is created properly and that the Empty and Count propertieswork properly when the hand is empty.

        [TestMethod]
        public void Count_Test()
        {
            Hand testHand = new Hand();
            Assert.AreEqual(testHand.Count, testHand.cards.Count);
        }

        [TestMethod]
        public void Empty_Test()
        {
            Hand testHand = new Hand();
            if (!testHand.Empty)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void GetCardTest()
        {
            Hand testHand = new Hand();
            if (testHand.GetCard(0) != null)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void AddCardTest()
        {
            Hand testHand = new Hand();
            testHand.AddCard(new Card("Ace","Spades"));
            testHand.AddCard(new Card("Queen", "Hearts"));
            if (testHand.Empty)
            {
                Assert.Fail();
            }
            if (testHand.Count < 2 || testHand.Count > 2)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void RmCardTest()
        {
            Hand testHand = new Hand();
            testHand.AddCard(new Card("Ace", "Spades"));
            testHand.AddCard(new Card("Queen", "Hearts"));
            testHand.AddCard(new Card("Jack", "Clubs"));
            testHand.RmCard(2);
            testHand.RmCard(0);
            testHand.RmCard(0);
            if(!testHand.Empty)
            {
                Assert.Fail();
            }
        }

    }
}
