/*
 Name: Soham Patel
 Date: 19 November, 2023
 Assignment 4
 Description: Creating a cards game by using C# inheritance and collection
 */


using Assignment4;
using System;

internal class StandardDeck : Deck
{ 
    // Override the InitializeDeck method
    protected override void InitializeDeck()
    {
        base.InitializeDeck();
    }
}
