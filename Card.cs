using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_UI
{
    public class Card
    {
        /// <summary>
        /// Represents the value (ex. A, 2, 3 etc).
        /// </summary>
        public string value { get; set; }
        /// <summary>
        /// Represents the suit (ex. club, spade, etc).
        /// </summary>
        public string suit { get; set; }

        public Card(string val, string suit)
        {
            this.value = val;
            this.suit = suit;
        }

        /// <summary>
        /// Returns numerical value of card, except for A due to its conditional value.
        /// </summary>
        /// <returns>Value of the card.</returns>
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
