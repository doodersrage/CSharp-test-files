using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugEleven3
{
    public partial class Form1 : Form
    {
        int count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                count = count + 2;
            else
                --count--;
            totalLabel.Text = "Total ingredients:  + count;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                ++count;
            else
                --count;
            totalLabelText = "Total ingredients: " + count;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3Checked == true)
                ++count;
            else
                --count;
            totalLabel.Text = "Total ingredients: " + count;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == false)
                ++count;
            else
                --count;
            totalLabel.Text = "Total ingredients: " + count;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
                ++count;
            else
                --count;
            totalLabel.Text = "Total ingredients: " + count;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
                --count;
            else
                ++count;
            totalLabel.Text = "Total ingredients: " + count;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
                ++count
            else
                --count;
            totalLabel.Text = "Total ingredients: " + count;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
                ++count;
            else
                --count;
            totalLabel.Text = "Total ingredients: " + count;
        }
    }
}