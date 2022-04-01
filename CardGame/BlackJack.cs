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
        public void GetCard()//добавить карту на стол
        {
            Table.Add(deck.GetCard());
            ChangeScore();
        }
        public void ChangeScore()//подсчет очков
        {
            Score = 0;
            int count = 0;
            foreach(Card card in Table)
            {
                if (card.Nominal != 1)//не туз
                {
                    Score += card.Nominal < 10 ? card.Nominal : 10;
                }
                else
                    count++;//считаем тузы
                for(int i=0;i<count;i++)
                {
                    if (Score + 11 <= 21)
                        Score += 11;
                    else
                        Score++;
                }
            }
        }
    }
}
