using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class Card
    {
        public enum Type
        {
            Zero = 0, One = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, 
            Seven = 7, Eight = 8, Nine = 9, Skip = 10, Reverse = 11, Draw2 = 12, Wild = 13, WildDraw4 = 14
        }

        public enum Color
        {
            Black, Green, Orange, Purple, Red
        }

        public Type CardType { get; set; }

        public Color CardColor { get; set; }

        public int ShuffleNumber { get; set; }

    }
}
