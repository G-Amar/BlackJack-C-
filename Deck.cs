using System;

namespace Blackjack
{
  class Deck
  {
    public List<Card> deck {get; set;} = new List<Card>();

    //create a new deck
    public Deck()
    {
      string[] num = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
      string[] suit = {"Spade", "Club", "Heart", "Diamond"};

      foreach (string val in num)
      {
        foreach (string type in suit)
          deck.Add(new Card(val, type));
      }
    }

    public Card Draw()
    {
      Random rand = new Random();
      int num = rand.Next(0, deck.Count);
      Card card = deck[num];
      deck.RemoveAt(num);
      return card;
    }
    
    /*
    public void Print()
    {
      foreach(Card card in deck)
        Console.WriteLine($"{card.value} of {card.suit}s");
    }
    */
  }
}
