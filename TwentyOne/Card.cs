using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    class Card
    {
        public Card()
        {
            Suit = "Spades";
            Face = "two";
        }
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
