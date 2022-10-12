using System;

namespace Blackjack
{
  class Hand
  {
    public List<Card> hand {get; set;} = new List<Card>();

    public void Add(Deck deck)
    {
      Card card = deck.Draw();
      hand.Add(card);
    }
    public int Value()
    {
      int value = 0, numOfA = 0;
      foreach (Card card in hand)
      {
        if(card.value == "A")
        {
          numOfA++;
          continue;
        }
        value += card.NumberValue();
      }
      if(numOfA == 0)
        return value;
      
      //only a single Ace can have value 11
      if (value <= (21 - 11 - (numOfA - 1)))
      {
        value += 11;
        numOfA--;
      }

      //rest will have value of 1
      value += numOfA;

      return value;
    }
    public void Print()
    {
      foreach(Card card in hand)
        Console.Write($"{card.value} of {card.suit}s, ");
      Console.WriteLine();
    }
  }
}