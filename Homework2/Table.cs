using System;
using System.Collections.Generic;
using System.Text;

// Sharna Hossain
// Professor Hao Tang
// CSC 350H
// Project 1

namespace Homework2
{
    abstract class Table
    {
        Deck deck;
        Hand hand;
        public int checkVal;
        public int cardsAmt;

        public Table()
        {

        }

        public void Init()
        {
            do
            {
                // 1) Create a deck object
                deck = new Deck();

                // 2) Shuffle the deck
                deck.Shuffle();

                // 3) Create a new card list
                hand = new Hand();

                // 4) Deal 10 cards from the deck and add them into the card list
                for (int i = 0; i < cardsAmt; i++)
                    hand.AddCard(deck.TakeTopCard());

                // Repeat if hand does not contain a combination for the game
            } while (!hand.Check(checkVal));
        }

        public void Game()
        {
            bool start;
            do
            {
                Init();
                Play();
                Console.Write("Would you like to play again? (Y/N):\t");
                char input = Console.ReadKey().KeyChar;
                if (input == 'Y' || input == 'y')
                    start = true;
                else
                    start = false;
            } while (start);
            Console.WriteLine("Program is terminating! Goodbye!");
        }

        public void Play()
        {
            Card[] selectedCards = new Card[2];
            do
            {
                Console.WriteLine(deck.Count + " cards remain.");
                Console.WriteLine("There are valid combinations of " + checkVal + " in the hand:");
                // 5) Print cards in the card list and ask user to select two cards from the list from the command line
                hand.Print();
                Console.WriteLine("Select two cards by their index from the list");
                for (int i = 0; i < 2; i++)
                {
                    Console.Write("Selected Card " + (i + 1) + ": ");
                    selectedCards[i] = hand.GetCard(Convert.ToInt32(Console.ReadLine()) - 1);
                }

                // 6) Remove the two card from the list if the total value of the two cards equals to 10,
                int value = selectedCards[0] + selectedCards[1];
                Console.WriteLine("Total Value is " + value);
                if (value == checkVal)
                {
                    Console.WriteLine("The total value of the cards you selected is " + checkVal + "!");

                    // and then deal two more cards from the deck and fill the empty slots
                    Console.WriteLine("Replacing cards from the list!");
                    for (int i = 0; i < 2; i++)
                    {
                        int pos = hand.IndexOf(selectedCards[i]);
                        hand.ReplaceCard(pos, deck.TakeTopCard());
                    }
                }
                else
                    Console.WriteLine("That was not a total value of " + checkVal + "...");
                // 7) Repeat this task until user are not able to find two cards in the card list with toal equals 10
            } while (hand.Check(checkVal));

            // 8) Print the cards in the card list and the number of cards in the deck
            Console.WriteLine("END: There are NO more valid combinations of " + checkVal + " in the hand:");
            hand.Print();
            Console.WriteLine("Remaining number of cards in deck:\t" + deck.Count);

        }
    }
}
