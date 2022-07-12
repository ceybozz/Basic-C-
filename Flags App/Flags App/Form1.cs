using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void francePictureBox_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "France";
        }

        private void germanPictureBox_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "Germany";
        }

        private void finlandPictureBox_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "Finland";
        }
    }
}
