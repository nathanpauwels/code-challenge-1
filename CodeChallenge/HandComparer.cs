using System;
using System.Collections.Generic;
using System.IO;

namespace CodeChallenge
{
    class HandComparer
    {
        static Dictionary<char, int> Values = new Dictionary<char, int>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int winsA = 0;
            int winsB = 0;

            int[] cards = new int[10];
            string[] suits = new string[10];

            string fileLocation = @"C:\Users\Nate\code-challenge-1\hands.txt";
            using (var reader = new StreamReader(fileLocation))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] newCards = line.Split(" ");
                    for (int i = 0; i < newCards.Length; i++)
                    {
                        cards[i] = Values[newCards[i][0]];
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
