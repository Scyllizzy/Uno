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
        public static List<Card> CreateDeck()
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
                                    CardType = cardType,
                                    ShuffleNumber = rand.Next(1, 108)//Random is exclusive for upper bound
                                });
                                cards.Add(new Card()
                                {
                                    CardColor = color,
                                    CardType = cardType,
                                    ShuffleNumber = rand.Next(1, 108)//Random is exclusive for upper bound
                                });
                                break;
                            case Type.Zero:
                                cards.Add(new Card()
                                {
                                    CardColor = color,
                                    CardType = cardType,
                                    ShuffleNumber = rand.Next(1, 108)//Random is exclusive for upper bound
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
                            CardType = Type.Wild,
                            ShuffleNumber = rand.Next(1, 109)
                        });
                    }
                    for (int wild4 = 0; wild4 < count; wild4++)
                    {
                        cards.Add(new Card()
                        {
                            CardColor = Color.Black,
                            CardType = Type.WildDraw4,
                            ShuffleNumber = rand.Next(1, 109)
                        });
                    }
                }
            }
            return cards;
        }
    }
}
