using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uno.GameManager;

namespace Uno.Play_Cards
{
    class PlayCards
    {
        /// <summary>
        /// Draw cards from 1 to 4.
        /// </summary>
        /// <param name="count">The draw cards draw amount or default 1 to just draw</param>
        /// <param name="drawPile">The pile that has stored the cards that have not been used.</param>
        public List<Card> Draw(int count, List<Card> drawPile)
        {
            List<Card> cards = new List<Card>();
            for(int i = 0; i < count; i++)
            {
                //Remains zero because if i remove element zero te next element becomes zero.
                cards.Add(drawPile[0]);
                drawPile.RemoveAt(0);
            }

            return cards;
        }

        public Card PlayCard(List<Card> cardHand, Card card, Card prevCardPlayed)
        {
            if (card.CardColor == prevCardPlayed.CardColor || card.CardType == prevCardPlayed.CardType)
            {
                GameManager.GameManager.AddToDiscard(card);
                cardHand.Remove(card);
            }
            return card;
        }

        
    }
}
