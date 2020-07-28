namespace SubnetCalculator
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBoxCIDR = new System.Windows.Forms.ComboBox();
            this.btCalculate = new System.Windows.Forms.Button();
            this.lbFinalIP = new System.Windows.Forms.Label();
            this.IpAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(63, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(106, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(62, 24);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox2_KeyDown);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(190, 52);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(62, 24);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox3_KeyDown);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(274, 52);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(62, 24);
            this.comboBox4.TabIndex = 3;
            this.comboBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox4_KeyDown);
            // 
            // comboBoxCIDR
            // 
            this.comboBoxCIDR.FormattingEnabled = true;
            this.comboBoxCIDR.Location = new System.Drawing.Point(274, 97);
            this.comboBoxCIDR.Name = "comboBoxCIDR";
            this.comboBoxCIDR.Size = new System.Drawing.Size(62, 24);
            this.comboBoxCIDR.TabIndex = 4;
            this.comboBoxCIDR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxCIDR_KeyDown);
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(140, 144);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(75, 23);
            this.btCalculate.TabIndex = 5;
            this.btCalculate.Text = "Calculate";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            this.btCalculate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btCalculate_KeyDown);
            // 
            // lbFinalIP
            // 
            this.lbFinalIP.AutoSize = true;
            this.lbFinalIP.Location = new System.Drawing.Point(85, 180);
            this.lbFinalIP.Name = "lbFinalIP";
            this.lbFinalIP.Size = new System.Drawing.Size(195, 17);
            this.lbFinalIP.TabIndex = 6;
            this.lbFinalIP.Text = "IP Subnet Address Calculated";
            // 
            // IpAddress
            // 
            this.IpAddress.AutoSize = true;
            this.IpAddress.Location = new System.Drawing.Point(137, 21);
            this.IpAddress.Name = "IpAddress";
            this.IpAddress.Size = new System.Drawing.Size(75, 17);
            this.IpAddress.TabIndex = 7;
            this.IpAddress.Text = "Ip Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "CIDR/SubnetMask";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 216);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IpAddress);
            this.Controls.Add(this.lbFinalIP);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.comboBoxCIDR);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "SubnetCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBoxCIDR;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Label lbFinalIP;
        private System.Windows.Forms.Label IpAddress;
        private System.Windows.Forms.Label label1;
    }
}

