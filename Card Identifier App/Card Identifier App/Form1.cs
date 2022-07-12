using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Identifier_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "Ten of Diamonds";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "King of Clubs";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "Joker";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "Queen of Spades";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "Seven of Hearts";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
