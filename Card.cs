using System;
namespace Blackjack
{
  class Card
  {
      public string value {get; set;}
      public string suit {get; set;}

      public Card(string val, string suit)
      {
        this.value=val;
        this.suit=suit;
      }

      public int NumberValue()
      {
        switch (this.value)
        {
            case "A": //Ace is dealt with separately, this is placeholder
              return 1;
            case "J": 
            case "Q": 
            case "K":
              return 10;
            default:
              return (Int32.Parse(this.value));
        }
      }
  }
}