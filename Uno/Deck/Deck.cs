using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Uno.Card;
using Type = Uno.Card.Type;

namespace Uno
{
    public class Deck
    {
        public static List<Card> GetCreateDeck()
        {
            var cards = new List<Card>();
            Random rand = new Random();
            const int count = 4;

            foreach (Color color in Enum.GetValues(typeof(Color)))
            {
                if (color != Color.Black) //Wild Cards are Black
                {
                    foreach (Type cardType in Enum.GetValues(typeof(Type)))
                    {
                        switch (cardType)
                        {
                            case Type.One:
                            case Type.Two:
                            case Type.Three:
                            case Type.Four:
                            case Type.Five:
                            case Type.Six:
                            case Type.Seven:
                            case Type.Eight:
                            case Type.Nine:
                            case Type.Draw2:
                            case Type.Reverse:
                            case Type.Skip:
                                //Add two copies of every card type
                                cards.Add(new Card()
                                {
                                    CardColor = color,
                                    CardType = cardType
                                });
                                cards.Add(new Card()
                                {
                                    CardColor = color,
                                    CardType = cardType
                                });
                                break;
                            case Type.Zero:
                                cards.Add(new Card()
                                {
                                    CardColor = color,
                                    CardType = cardType
                                });
                                break;
                        }
                    }
                }
                else
                {
                    for (int wild = 0; wild < count; wild++)
                    {
                        cards.Add(new Card()
                        {
                            CardColor = Color.Black,
                            CardType = Type.Wild
                        });
                    }
                    for (int wild4 = 0; wild4 < count; wild4++)
                    {
                        cards.Add(new Card()
                        {
                            CardColor = Color.Black,
                            CardType = Type.WildDraw4
                        });
                    }
                }
            }
            return cards;
        }

        /// <summary>
        /// Shuffles the list of cards passed in and returns that list of cards.
        /// </summary>
        /// <param name="cards">The list of cards to be shuffled.</param>
        public static List<Card> Shuffle(List<Card> cards)
        {
            Random rand = new Random();

            foreach (Card card in cards)
            {
                card.ShuffleNumber = rand.Next(1, 108);
            }

            cards = cards.OrderBy(c => c.ShuffleNumber).ToList();

            return cards;
        }
    }
}
