using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class BlackJack
    {
        Deck deck;//колода
        public List<Card> Table { get; set; }//карты, кот лежат перед нами на столе
        public int Score { get; private set; }//счет
        public BlackJack()
        {
            deck = new Deck();
            Table = new List<Card>();
            Score = 0;
            deck.Shuffle();
        }
    }
}
