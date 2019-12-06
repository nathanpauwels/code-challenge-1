using System;
using System.Collections.Generic;
using System.IO;

namespace CodeChallenge
{
    class HandComparer
    {
        static Dictionary<char, int> Values = new Dictionary<char, int>()
        {
            {'2', 0},
            {'3', 1},
            {'4', 2},
            {'5', 3},
            {'6', 4},
            {'7', 5},
            {'8', 6},
            {'9', 7},
            {'T', 8},
            {'J', 9},
            {'Q', 10},
            {'K', 11},
            {'A', 12},
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int winsA = 0;
            int winsB = 0;

            int[] cardsA = new int[5];
            string[] suitsA = new string[5];
            int[] cardsB = new int[5];
            string[] suitsB = new string[5];

            string fileLocation = @"C:\Users\Nate\code-challenge-1\hands.txt";
            using (var reader = new StreamReader(fileLocation))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // parse
                    string[] newCards = line.Split(" ");
                    for (int i = 0; i < 5; i++)
                    {
                        cardsA[i] = Values[newCards[i][0]];
                        suitsA[i] = newCards[i][1].ToString();
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        cardsB[i] = Values[newCards[i+5][0]];
                        suitsB[i] = newCards[i+5][1].ToString();
                    }

                    Console.WriteLine(CalculateHandValue(cardsA, suitsA) + " " + CalculateHandValue(cardsB, suitsB));
                }
            }

            Console.ReadLine();
        }

        static int CalculateHandValue(int[] cards, string[] suits)
        {  
            int high = 0;
            foreach (var card in cards)
                if (card > high) high = card;

            return high;
        }
    }
}
