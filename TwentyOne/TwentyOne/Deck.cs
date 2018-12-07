using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
                "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };
            
            foreach(var face in Faces)
            {
                foreach(var suit in Suits)
                {
                    Card card = new Card { Suit = suit, Face = face };
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }
    }
}
