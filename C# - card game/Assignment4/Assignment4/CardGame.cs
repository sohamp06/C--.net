/*
 Name: Soham Patel
 Date: 19 November, 2023
 Assignment 4
 Description: Creating a cards game by using C# inheritance and collection
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment4
{
    public partial class CardGame : Form
    {
        private readonly Deck deck; 
        private readonly CustomDeck customDeckInstance = new CustomDeck();
        public CardGame()
        {
            InitializeComponent();
            // set tooltips
            ToolTip toolTip = new ToolTip();

            // set the tooltips for each fields
            toolTip.SetToolTip(add_customButton, "Press this button to add custom cards.");
            toolTip.SetToolTip(view_deckButton, "Press this button to view the deck.");
            toolTip.SetToolTip(dealButton, "Press this button to deal cards.");
            toolTip.SetToolTip(shuffleButton, "Press this button to shuffle the list of cards in the list.");
            toolTip.SetToolTip(resetButton, "Press this button to reset the game.");
            toolTip.SetToolTip(exitButton, "Press this button to exit the game.");
            toolTip.SetToolTip(suitBox, "Add the suit.");
            toolTip.SetToolTip(rankBox, "Add the rank.");
            toolTip.SetToolTip(drawBox, "Write number of draws.");
            toolTip.SetToolTip(cards_dealtList, " Dealt list from the deck.");
            toolTip.SetToolTip(deckList, "List of the remaining cards from deck after dealting.");

            deck = new StandardDeck(); 
        }

       

        private void add_customButton_Click(object sender, EventArgs e)
        {
            // Add custom card to the deck
            string suit = suitBox.Text;
            string rank = rankBox.Text;

            if (!string.IsNullOrWhiteSpace(suit) && !string.IsNullOrWhiteSpace(rank))
            {
                Card customCard = new Card(suit, rank);
                deck.AddingCustomCard(customCard);

                // Call the AddCustomCard method from the CustomDeck class
                customDeckInstance.AddCustomCard(customCard);
            }
            else
                //Error message
            {
                MessageBox.Show("Error!", "Suit and Rank must be entered.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            // Deal cards from the deck
            if (int.TryParse(drawBox.Text, out int drawCount) && drawCount > 0)
            {
                var dealtCards = deck.Deal(drawCount);

                // Display dealt cards in the ListView
                cards_dealtList.Items.Clear();
                foreach (var card in dealtCards)
                {
                    cards_dealtList.Items.Add(card.ToString());
                }
            }
            else
                //Error message
            {
                MessageBox.Show( "Invalid Input", "Enter a valid positive (+) number.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void view_deckButton_Click(object sender, EventArgs e)
        {
            //DIsplay cards
            deckList.Items.Clear();
            foreach (var card in deck.GetCards())
            {
                deckList.Items.Add(card.ToString());
            }

            // Call the GetCards method from the CustomDeck class
            var customDeckCards = customDeckInstance.GetCards();
           
        
    }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            // Shuffle the deck
            deck.Shuffling();
            view_deckButton_Click(sender, e);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Reset the form
            suitBox.Text = string.Empty;
            rankBox.Text = string.Empty;
            drawBox.Text = string.Empty;
            cards_dealtList.Items.Clear();
            deckList.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

     
    }
}
