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
        BlackJack blackJack;
        List<PictureBox> myCards;
        public Form1()
        {
            InitializeComponent();
            blackJack = new BlackJack();
            myCards = new List<PictureBox>()
            {
                pictureBox1,
                pictureBox2,
                pictureBox3,
                pictureBox4,
                pictureBox5,
                pictureBox6,
                pictureBox7,
            };
        }
        void ShowTable()
        {
            for (int i = 0; i < blackJack.Table.Count; i++)
            {
                if (i < myCards.Count)
                    myCards[i].Image = blackJack.Table[i].Front;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            blackJack.GetCard();
            ShowTable();
            label1.Text = "Счет: " + blackJack.Score.ToString();
            if(blackJack.Score==21)
            {
                MessageBox.Show("Вы выиграли");
                button3.PerformClick();
                 
            }else if (blackJack.Score > 21)
            {
                MessageBox.Show("Вы проиграли");
                button3.PerformClick();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            blackJack = new BlackJack();
            for (int i = 0; i < myCards.Count; i++)
            {
                myCards[i].Image = null;
            }
            label1.Text = "Счет: ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Вы закончили игру с {blackJack.Score} очков");
            button3.PerformClick();
        }
    }
}
