namespace Picture_Viewer
{
    partial class fclsViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fclsViewer));
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.picShowPicture = new System.Windows.Forms.PictureBox();
            this.ofdSelectPicture = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectPicture
            // 
            resources.ApplyResources(this.btnSelectPicture, "btnSelectPicture");
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.UseVisualStyleBackColor = true;
            this.btnSelectPicture.Click += new System.EventHandler(this.btnSelectPicture_Click);
            // 
            // btnQuit
            // 
            resources.ApplyResources(this.btnQuit, "btnQuit");
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // picShowPicture
            // 
            this.picShowPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.picShowPicture, "picShowPicture");
            this.picShowPicture.Name = "picShowPicture";
            this.picShowPicture.TabStop = false;
            // 
            // ofdSelectPicture
            // 
            this.ofdSelectPicture.FileName = "ofdSelectPicture";
            resources.ApplyResources(this.ofdSelectPicture, "ofdSelectPicture");
            // 
            // fclsViewer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picShowPicture);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSelectPicture);
            this.Name = "fclsViewer";
            ((System.ComponentModel.ISupportInitialize)(this.picShowPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectPicture;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.PictureBox picShowPicture;
        private System.Windows.Forms.OpenFileDialog ofdSelectPicture;
    }
}

