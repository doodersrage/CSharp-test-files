using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Viewer
{
    public partial class fclsViewer : Form
    {
        public fclsViewer()
        {
            InitializeComponent();
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            // show open file dialog box
            if(ofdSelectPicture.ShowDialog() == DialogResult.OK){
                // load the picture into the picture box
                picShowPicture.Image = Image.FromFile(ofdSelectPicture.FileName);
                // show the name of the file in the forms caption
                this.Text = String.Concat("Picture Viewer ["+ofdSelectPicture.FileName+"]");
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
