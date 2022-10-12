using System;

//can try making a basic blackjack program
namespace Blackjack
{
  class Program
  {
    public static void PrintGame(Hand userHand, Hand dealerHand, int bid)
    {
      Console.Clear();
      Console.WriteLine($"Your bid: ${bid} \n");
      Console.Write("Dealer: ");
      dealerHand.Print();
      Console.WriteLine($"Value: {dealerHand.Value()} \n");
      Console.Write("Your Hand: ");
      userHand.Print();
      Console.WriteLine($"Value: {userHand.Value()} \n");
    }
    public static bool CheckWin(int dealerValue, int userValue)
    {
      if(dealerValue > 21)
        return true;        
      if(dealerValue > userValue)
        return false;
      return true;
    }
    static void Main(string[] args)
    {
      int money = 1000;
      
      Console.Clear();
      Console.WriteLine("Welcome to BlackJack!\n");
      Console.WriteLine($"Your Balance: ${money}\n");
      Console.WriteLine("Press Enter to Play!");
      Console.ReadLine();
      
      while (true)
      {
        //playing with new deck each time
        int bid;
        string input;

        Console.Clear();
        Console.WriteLine($"Your Balance: ${money}\n");
        Console.Write("Enter a Bid amount (q to quit): ");

        input = Console.ReadLine();
        while ((!int.TryParse(input, out bid)) || (bid<0 || bid>money))
        {
          if(input == "q") return;
          Console.WriteLine("Invalid input, Try again: ");
          input = Console.ReadLine();
        }

        Deck deck = new Deck();
        Hand userHand = new Hand();
        Hand dealerHand = new Hand();

        userHand.Add(deck);
        dealerHand.Add(deck);
        userHand.Add(deck);
        
        while (true)
        {
          string action;

          PrintGame(userHand, dealerHand, bid);
          Console.Write("Pick action(Hit/Stand)[h/s]: ");

          action = Console.ReadLine();
          action = action.ToLower();

          if(action == "hit" || action == "h")
          {
            userHand.Add(deck);
            if(userHand.Value() > 21){
              PrintGame(userHand, dealerHand, bid);
              Console.WriteLine("BUST!");
              money -= bid;
              Console.ReadLine();
              break; //end round
            }
          }
          else if (action == "stand" || action == "s")
          {
            int dealerValue = dealerHand.Value();
            int userValue = userHand.Value();
            while(dealerValue < 17 && (dealerValue < userValue)) //dealer has to stand if 17 or more
            {
              dealerHand.Add(deck);
              dealerValue = dealerHand.Value();
            }

            if(dealerValue == userValue)
            {
              PrintGame(userHand, dealerHand, bid);
              Console.WriteLine("Tie!");
              Console.ReadLine();
            }
            else if(CheckWin(dealerValue, userValue))
            {
              PrintGame(userHand, dealerHand, bid);
              Console.WriteLine("You Win!");
              money += bid;
              Console.ReadLine();
            }
            else
            {
              PrintGame(userHand, dealerHand, bid);
              Console.WriteLine("You Lose!");
              money -= bid;
              Console.ReadLine();
            }
            break; //end the round
            
          }
          else
          {
            Console.WriteLine("Invalid input! Press Enter to try again");
            Console.ReadLine();
          }
        }
      }
    }
  }
}

