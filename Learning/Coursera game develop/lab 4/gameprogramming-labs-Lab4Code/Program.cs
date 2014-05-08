using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new deck and print the contents of the deck
            Deck deck = new Deck();

            //deck.Print();
            Console.WriteLine();

            // shuffle the deck and print the contents of the deck

            deck.Shuffle();

           //deck.Print();
            // take the top card from the deck and print the card rank and suit
            Card card = deck.TakeTopCard();

            Console.WriteLine(card.Rank + " "+ card.Suit);

            // take the top card from the deck and print the card rank and suit
            card = deck.TakeTopCard();
            Console.WriteLine(card.Rank + " " + card.Suit);
        }
    }
}
