using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentsDemo3
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
            double minGpa = Convert.ToDouble(gpaTextBox.Text);
            this.tblStudentsTableAdapter.Fill
              (this.cartmanCollegeDataSet.tblStudents);
            var goodStudents =
                from s in this.cartmanCollegeDataSet.tblStudents
                where s.GradePointAverage > minGpa
                select s;
            foreach (var s in goodStudents)
                listBox1.Items.Add(s.LastName + ", " + s.FirstName);
        }
    }
}
