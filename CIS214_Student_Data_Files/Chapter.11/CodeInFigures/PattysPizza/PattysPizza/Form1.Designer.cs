namespace PattysPizza
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sausageCheckBox = new System.Windows.Forms.CheckBox();
            this.pepperoniCheckBox = new System.Windows.Forms.CheckBox();
            this.onionCheckBox = new System.Windows.Forms.CheckBox();
            this.oliveCheckBox = new System.Windows.Forms.CheckBox();
            this.deliverRadioButton = new System.Windows.Forms.RadioButton();
            this.pickupRadioButton = new System.Windows.Forms.RadioButton();
            this.dineInButton = new System.Windows.Forms.RadioButton();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patty\'s Pizzas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toppings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Delivery method";
            // 
            // sausageCheckBox
            // 
            this.sausageCheckBox.AutoSize = true;
            this.sausageCheckBox.Location = new System.Drawing.Point(36, 127);
            this.sausageCheckBox.Name = "sausageCheckBox";
            this.sausageCheckBox.Size = new System.Drawing.Size(68, 17);
            this.sausageCheckBox.TabIndex = 3;
            this.sausageCheckBox.Text = "Sausage";
            this.sausageCheckBox.UseVisualStyleBackColor = true;
            this.sausageCheckBox.CheckedChanged += new System.EventHandler(this.sausageCheckBox_CheckedChanged);
            // 
            // pepperoniCheckBox
            // 
            this.pepperoniCheckBox.AutoSize = true;
            this.pepperoniCheckBox.Location = new System.Drawing.Point(36, 150);
            this.pepperoniCheckBox.Name = "pepperoniCheckBox";
            this.pepperoniCheckBox.Size = new System.Drawing.Size(74, 17);
            this.pepperoniCheckBox.TabIndex = 4;
            this.pepperoniCheckBox.Text = "Pepperoni";
            this.pepperoniCheckBox.UseVisualStyleBackColor = true;
            this.pepperoniCheckBox.CheckedChanged += new System.EventHandler(this.pepperoniCheckBox_CheckedChanged);
            // 
            // onionCheckBox
            // 
            this.onionCheckBox.AutoSize = true;
            this.onionCheckBox.Location = new System.Drawing.Point(36, 173);
            this.onionCheckBox.Name = "onionCheckBox";
            this.onionCheckBox.Size = new System.Drawing.Size(59, 17);
            this.onionCheckBox.TabIndex = 5;
            this.onionCheckBox.Text = "Onions";
            this.onionCheckBox.UseVisualStyleBackColor = true;
            this.onionCheckBox.CheckedChanged += new System.EventHandler(this.onionCheckBox_CheckedChanged);
            // 
            // oliveCheckBox
            // 
            this.oliveCheckBox.AutoSize = true;
            this.oliveCheckBox.Location = new System.Drawing.Point(36, 196);
            this.oliveCheckBox.Name = "oliveCheckBox";
            this.oliveCheckBox.Size = new System.Drawing.Size(55, 17);
            this.oliveCheckBox.TabIndex = 6;
            this.oliveCheckBox.Text = "Olives";
            this.oliveCheckBox.UseVisualStyleBackColor = true;
            this.oliveCheckBox.CheckedChanged += new System.EventHandler(this.oliveCheckBox_CheckedChanged);
            // 
            // deliverRadioButton
            // 
            this.deliverRadioButton.AutoSize = true;
            this.deliverRadioButton.Location = new System.Drawing.Point(141, 127);
            this.deliverRadioButton.Name = "deliverRadioButton";
            this.deliverRadioButton.Size = new System.Drawing.Size(63, 17);
            this.deliverRadioButton.TabIndex = 7;
            this.deliverRadioButton.Text = "Delivery";
            this.deliverRadioButton.UseVisualStyleBackColor = true;
            this.deliverRadioButton.CheckedChanged += new System.EventHandler(this.deliverRadioButton_CheckedChanged);
            // 
            // pickupRadioButton
            // 
            this.pickupRadioButton.AutoSize = true;
            this.pickupRadioButton.Location = new System.Drawing.Point(141, 150);
            this.pickupRadioButton.Name = "pickupRadioButton";
            this.pickupRadioButton.Size = new System.Drawing.Size(58, 17);
            this.pickupRadioButton.TabIndex = 8;
            this.pickupRadioButton.TabStop = true;
            this.pickupRadioButton.Text = "Pickup";
            this.pickupRadioButton.UseVisualStyleBackColor = true;
            // 
            // dineInButton
            // 
            this.dineInButton.AutoSize = true;
            this.dineInButton.Location = new System.Drawing.Point(141, 173);
            this.dineInButton.Name = "dineInButton";
            this.dineInButton.Size = new System.Drawing.Size(58, 17);
            this.dineInButton.TabIndex = 9;
            this.dineInButton.TabStop = true;
            this.dineInButton.Text = "Dine in";
            this.dineInButton.UseVisualStyleBackColor = true;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(138, 215);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(0, 20);
            this.totalLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.dineInButton);
            this.Controls.Add(this.pickupRadioButton);
            this.Controls.Add(this.deliverRadioButton);
            this.Controls.Add(this.oliveCheckBox);
            this.Controls.Add(this.onionCheckBox);
            this.Controls.Add(this.pepperoniCheckBox);
            this.Controls.Add(this.sausageCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Patty\'s Pizzas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox sausageCheckBox;
        private System.Windows.Forms.CheckBox pepperoniCheckBox;
        private System.Windows.Forms.CheckBox onionCheckBox;
        private System.Windows.Forms.CheckBox oliveCheckBox;
        private System.Windows.Forms.RadioButton deliverRadioButton;
        private System.Windows.Forms.RadioButton pickupRadioButton;
        private System.Windows.Forms.RadioButton dineInButton;
        private System.Windows.Forms.Label totalLabel;
    }
}

