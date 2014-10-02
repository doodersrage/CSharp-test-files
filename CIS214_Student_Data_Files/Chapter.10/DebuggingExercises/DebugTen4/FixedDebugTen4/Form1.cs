using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugTen4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private voad button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button1.Visible = true;
        }

        private void button2_Clock(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = false;
        }
    }
}