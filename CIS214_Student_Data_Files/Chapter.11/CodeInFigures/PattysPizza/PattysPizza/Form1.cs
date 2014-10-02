using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PattysPizza
{
    public partial class Form1 : Form
    {
        private const double BASE_PRICE = 12.00;
        private const double TOPPING_PRICE = 1.25;
        private double price = BASE_PRICE;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void sausageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sausageCheckBox.Checked)
                price += TOPPING_PRICE;
            else
                price -= TOPPING_PRICE;
            totalLabel.Text = "Total is " + price.ToString("C");
        }

        private void pepperoniCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pepperoniCheckBox.Checked)
                price += TOPPING_PRICE;
            else
                price -= TOPPING_PRICE;
            totalLabel.Text = "Total is " + price.ToString("C");
        }

        private void onionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (onionCheckBox.Checked)
                price += TOPPING_PRICE;
            else
                price -= TOPPING_PRICE;
            totalLabel.Text = "Total is " + price.ToString("C");
        }

        private void oliveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (oliveCheckBox.Checked)
                price += TOPPING_PRICE;
            else
                price -= TOPPING_PRICE;
            totalLabel.Text = "Total is " + price.ToString("C");
        }

        private void deliverRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            const double DELIVERY_CHARGE = 2.00;
            if (deliverRadioButton.Checked)
                price += DELIVERY_CHARGE;
            else
                price -= DELIVERY_CHARGE;
            totalLabel.Text = "Total is " + price.ToString("C");
        }
    }
}
