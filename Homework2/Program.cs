using System;

// Sharna Hossain
// Professor Hao Tang
// CSC 350H
// Project 1

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tens tens = new Tens();
            Elevens elevens = new Elevens();
            Thirteens thirteens = new Thirteens();

            int input;
            Console.WriteLine("Choose which game of cards you would like to play");
            Console.WriteLine("1:\tTens\n2:\tElevens\n3:\tThirteens");
            Console.Write("Enter your selection:\t");
            input = Convert.ToInt32(Console.ReadLine());
            
            switch(input)
            {
                case 1:
                    tens.Game();
                    break;
                case 2:
                    elevens.Game();
                    break;
                case 3:
                    thirteens.Game();
                    break;
                default:
                    break;
            }
        }
    }
}
