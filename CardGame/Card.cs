using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CardGame
{
    class Card
    {
        public string Suit { get; private set; }//масть
        public int Nominal { get; private set; }//номинал
        public bool IsShirt { get; private set; }//рубашкой или лицом
        public Bitmap Front { get; private set; }
        public Bitmap Back { get; private set; }

        public Card(string suit,int nominal,Bitmap front,Bitmap back)
        {
            Suit = suit;
            Nominal = nominal;
            Front = front;
            Back = back;
            IsShirt = false;
        }
        public void Reverse()
        {
            IsShirt = !IsShirt;
        }
    }
}
