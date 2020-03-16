using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno.GameManager
{
    class GameManager
    {
        public List<Card> DiscardPile { get; set; }

        public List<Player> ChangePlayer { get; set; }

        public Deck DrawPile { get; set; }



        public List<Card> AddToDiscard(List<Card> DiscardPile, Card card)
        {
            
            return DiscardPile.Add(card);

        }
    }
}
