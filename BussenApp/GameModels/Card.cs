using BussenApp.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussenApp.GameModels
{
    public class Card
    {
        public int Value { get; set; }
        public CardSuit Suit { get; set; }

        public Card(int value, CardSuit cardSuit)
        {
            Value = value;
            Suit = cardSuit;
        }

        public string Name { 
            get {
                string cardSuit = Suit switch
                {
                    CardSuit.Clubs => AppRes.Clubs,
                    CardSuit.Diamonds => AppRes.Diamonds,
                    CardSuit.Spades => AppRes.Spades,
                    CardSuit.Hearts => AppRes.Hearts
                };

                string cardname = Value switch
                {
                    1 => AppRes.Ace,
                    10 => AppRes.Jack,
                    11 => AppRes.Queen,
                    12 => AppRes.King,
                    _ => Value.ToString()
                };

                return $"{cardSuit} {cardname}";
            }
        }
    }

}
