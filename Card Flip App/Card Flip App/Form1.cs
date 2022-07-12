using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Flip_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showBackButton_Click(object sender, EventArgs e)
        {
            pictureBoxBack.Visible = true;
            pictureBoxFront.Visible = false;
        }

        private void showFrontButton_Click(object sender, EventArgs e)
        {
            pictureBoxBack.Visible = false;
            pictureBoxFront.Visible = true;
        }
    }
}
