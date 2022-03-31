using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    public partial class Form1 : Form
    {
        Deck deck;
        Card card;
        public Form1()
        {
            InitializeComponent();
            deck = new Deck();
            deck.Shuffle();
        }
        void ShowCard()
        {
            if(card!=null)
            {
                pictureBox1.Image = !card.IsShirt ? card.Back : card.Front;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            card = deck.GetCard();
            ShowCard();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            card?.Reverse();//if(card!=null)
            ShowCard();
        }
    }
}
