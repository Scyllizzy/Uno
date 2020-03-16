using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno.GameManager
{
    class GameManager
    {
        public static List<Card> DiscardPile { get; set; }

        public static List<Player> ChangePlayer { get; set; }

        public static Deck DrawPile { get; set; }



        public static void AddToDiscard(Card card)
        {
            DiscardPile.Add(card);
        }
    }
}
