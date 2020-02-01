using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    /// <summary>
    /// Represents a single card in a basic Uno deck
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Represents the type for a card
        /// </summary>
        public enum Type
        {
            Zero = 0, One = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, 
            Seven = 7, Eight = 8, Nine = 9, Skip = 10, Reverse = 11, Draw2 = 12, Wild = 13, WildDraw4 = 14
        }

        /// <summary>
        /// Represents the color of a card
        /// </summary>
        public enum Color
        {
            Black, Green, Orange, Purple, Red
        }

        /// <summary>
        /// What the card does when played.
        /// Ex. (Skip, Wild Draw 4, Four...)
        /// </summary>
        public Type CardType { get; set; }

        /// <summary>
        /// What color the card is.
        /// Ex (Green, Purple, Orange...)
        /// </summary>
        public Color CardColor { get; set; }

        /// <summary>
        /// The number that will be given when the card needs to be shuffled
        /// </summary>
        public int ShuffleNumber { get; set; }

    }
}
