using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManyButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void whiteButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
    }
}
