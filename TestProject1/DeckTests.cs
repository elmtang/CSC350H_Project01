using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Homework2;

// Sharna Hossain
// Professor Hao Tang
// CSC 350H
// Project 1

namespace TestProject1
{
    [TestClass]
    public class Deck_Tests
    {
        [TestMethod]
        public void DeckTest()
        {
            Deck testDeck = new Deck();
            // All Deck objects should be initialized with 52 Card elements
            if (testDeck.Empty || testDeck.Count != 52)
            {
                Assert.Fail("Not initialized");
            }
        }

        [TestMethod]
        public void ShuffleTest()
        {
            // Initialize deck and shuffle
            Deck shuffledDeck = new Deck();
            shuffledDeck.Shuffle();

            // Initialize unshuffled deck
            Deck defaultDeck = new Deck();

            // Compare the sequence of elements for the two decks
            if (Enumerable.SequenceEqual(shuffledDeck.cards, defaultDeck.cards))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void CheckTest()
        {
            // Using a Hand object for the test because Hand inherits from Deck class
            Hand testHand = new Hand();

            // Adding two cards and calculating their value
            Card card1 = new Card("Seven", "Spades");
            Card card2 = new Card("Three", "Spades");
            testHand.AddCard(card1);
            testHand.AddCard(card2);

            int sum = card1 + card2;

            // Check method should return true
            if (!testHand.Check(sum))
            {
                Assert.Fail();
            }
        }
    }
}
