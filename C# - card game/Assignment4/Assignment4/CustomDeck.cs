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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Assignment4
{
    internal class CustomDeck:Deck
    {
        //Method to add a custom card
        public void AddCustomCard(Card customCard)
        {
           
            base.AddingCustomCard(customCard);
        }
        //Method to get the list of cards
        public List<Card> GetCards()
        {
            return cards;
        }
    }
}
