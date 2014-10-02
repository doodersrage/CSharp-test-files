using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentsDemo4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tblStudentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblStudentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cartmanCollegeDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cartmanCollegeDataSet.tblStudents' table. You can move, or remove it, as needed.
            this.tblStudentsTableAdapter.Fill(this.cartmanCollegeDataSet.tblStudents);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gpas =
              from s in this.cartmanCollegeDataSet.tblStudents
              select s.GradePointAverage;
            countLabel.Text = "Count is " + gpas.Count();
            minLabel.Text = "Lowest GPA is " + gpas.Min();
            maxLabel.Text = "Highest GPA is " + gpas.Max();
            avgLabel.Text = "Average of all GPAs is " + gpas.Average(); 

        }
    }
}
