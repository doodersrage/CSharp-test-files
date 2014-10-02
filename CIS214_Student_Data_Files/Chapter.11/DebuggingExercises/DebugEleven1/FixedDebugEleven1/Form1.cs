using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugEleven1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            label1.ForeColor = ColorRed;
            label2.ForeColor = Color.BlueViolet;
            label3.ForeColor = Color.Green
            label4.ForeColor = Color.Green;
            label4.Visible = truue;
        }
    }
}