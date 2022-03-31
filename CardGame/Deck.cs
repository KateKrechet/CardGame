using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CardGame
{
    class Deck//колода
    {
        List<Card> cards;
        string[] names;
        public int Count { get; private set; }//смотреть сколько осталось
        public Deck()//52 или 36?
        {
            cards = new List<Card>();
            names = new string[4] { "♥", "♦", "♣", "♠" };
            GenerateDeck();
            Count = cards.Count();

        }
        void GenerateDeck()
        {
            int count = 1;//переменная для счета карт
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    string path = "d:\\cards\\image_part_0";
                    if (count < 10)
                        path += "0";
                    path += count.ToString() + ".jpg";
                    cards.Add(new Card(
                        names[j],
                        i + 1,
                        new Bitmap(path),
                        new Bitmap("d:\\cards\\back.jpg")//сзади все карты одинаковые
                        ));
                    count++;
                }
            }

        }

        public void Shuffle()//перетасовать
        {
            //12345
            //45312

            Random rnd = new Random();
            for (int i = 0; i < Count; i++)
            {
                int index = rnd.Next(Count);
                Card tmp = cards[i];
                cards[i] = cards[index];
                cards[index] = tmp;
            }
        }

        public void AddCard(Card card)//добавление карты
        {
            cards.Add(card);
            Count = cards.Count;
        }
        public Card GetCard()//сверху колоды берем карту, стек, сверху лежит последняя
        {
            if (Count - 1 >= 0)
            {
                Card tmp = cards[Count - 1];
                cards.RemoveAt(Count - 1);
                Count = cards.Count;
                return tmp;
            }
            else
                return null;
        }
    }
}
