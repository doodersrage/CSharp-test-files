using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugEleven2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("We meet on the second\n" +
                   "Thursday of each month at 1 pm.");
                checkBox1.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                MessageBox.Show("Dues are $5 a month\n" +
                   "Or $52 if you pay for\n" +
                   "the year.");
                checkBox2.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                MessageBox.Show("Our officer are:\n" +
                   "President: Elmo Harris\n" +
                   "Secretary: Larry Thompson\n" +
                   "Treasurer: Katrina Wren");
                checkBox3.Checked = false;
            }
        }
    }
}