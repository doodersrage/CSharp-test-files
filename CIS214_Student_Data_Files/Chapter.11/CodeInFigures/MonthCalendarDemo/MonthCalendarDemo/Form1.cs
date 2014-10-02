using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MonthCalendarDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            const int DAYS_TO_ADD = 10;
            string newDate = "You selected " +
                calendar.SelectionStart.ToShortDateString();
            messageLabel.Text = newDate + "\nTen days from now is " +
               calendar.SelectionStart.AddDays(DAYS_TO_ADD).ToShortDateString();
        }
    }
}
