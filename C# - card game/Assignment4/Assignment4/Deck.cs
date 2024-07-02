/*
 Name: Soham Patel
 Date: 19 November, 2023
 Assignment 4
 Description: Creating a cards game by using C# inheritance and collection
 */


using Assignment4;
using System;
using System.Collections.Generic;

internal class Deck
{

    //List for storing cards
    protected List<Card> cards;


    //method to add cutom card
    public void AddingCustomCard(Card customCard)
    {
        cards.Add(customCard);
    }

    public Deck()
    {
        cards = new List<Card>();
        InitializeDeck();
    }

    protected virtual void InitializeDeck()
    {
        //All the 52 Cards initialzation
        string[] suits = { "Heart", "Diamond", "Club", "Spade" };
        string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

        foreach (var suit in suits)
        {
            foreach (var rank in ranks)
            {
                cards.Add(new Card(suit, rank));
            }
        }
    }

    //Randomise the cards inside the list
    public void Shuffling()
    {
        Random random = new Random();
        int n = cards.Count;

        for (int i = n - 1; i > 0; i--)
        {
            int j = random.Next(0, i + 1);
            (cards[i], cards[j]) = (cards[j], cards[i]); 
        }
    }

    //Method to show whole deck
    public void ShowDeck()
    {
        foreach (var card in cards)
        {
            Console.WriteLine(card);
        }
    }
    public List<Card> GetCards()
    {
        return cards;
    }

    public List<Card> Deal(int count)
    {
        List<Card> dealtCards = new List<Card>();

        if (count <= cards.Count)
        {
            for (int i = 0; i < count; i++)
            {
                Card dealtCard = cards[0];
                cards.RemoveAt(0);
                dealtCards.Add(dealtCard);
            }
        }
        else
        {
            Console.WriteLine("Cards are not enough to deal.");
        }

        return dealtCards;
    }

}
