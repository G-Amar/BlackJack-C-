using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_UI
{
    public class Hand
    {
        /// <summary>
        /// Represents the cards in the hand.
        /// </summary>
        public List<Card> hand { get; set; } = new List<Card>();

        /// <summary>
        /// Adds a card to the hand from the deck.
        /// </summary>
        /// <param name="deck">
        /// The deck from which the card will be drawn.
        /// </param>
        public void Add(Deck deck)
        {
            Card card = deck.Draw();
            hand.Add(card);
        }
        /// <summary>
        /// Returns the total value of the hand.
        /// </summary>
        /// <returns>Value of the hand.</returns>
        public int Value()
        {
            int value = 0, numOfA = 0;
            foreach (Card card in hand)
            {
                if (card.value == "A")
                {
                    numOfA++;
                    continue;
                }
                value += card.NumberValue();
            }
            if (numOfA == 0)
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
        /// <summary>
        /// Prints the cards in the hand with a comma in between.
        /// </summary>
        public string Print()
        {
            string str = "";
            foreach (Card card in hand)
                str += $"{card.value} of {card.suit}s, ";
            return str;
        }
    }
}