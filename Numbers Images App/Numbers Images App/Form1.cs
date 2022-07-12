using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers_Images_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("One");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Two");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Three");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Four");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Five");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
