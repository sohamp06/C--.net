/*
 Name: Soham Patel
 Date: 19 November, 2023
 Assignment 4
 Description: Creating a cards game by using C# inheritance and collection
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Card
    {
        //Suit & rank properties
        public string Suit { get; set; }
        public string Rank { get; set; }

        //constructors to start a card
        public Card(string suit, string rank)
        {
            Suit = suit;
            Rank = rank;
        }

        //override ToString method
        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }
}
