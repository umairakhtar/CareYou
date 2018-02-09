namespace CareYou
{
    partial class Password
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcpass = new System.Windows.Forms.TextBox();
            this.txtupass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnchangepas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(131, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "CHANGE PASSWORD";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcpass);
            this.groupBox1.Controls.Add(this.txtupass);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnchangepas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(104, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 209);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            // 
            // txtcpass
            // 
            this.txtcpass.BackColor = System.Drawing.Color.Honeydew;
            this.txtcpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtcpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtcpass.Location = new System.Drawing.Point(182, 87);
            this.txtcpass.Name = "txtcpass";
            this.txtcpass.Size = new System.Drawing.Size(154, 23);
            this.txtcpass.TabIndex = 3;
            this.txtcpass.UseSystemPasswordChar = true;
            // 
            // txtupass
            // 
            this.txtupass.BackColor = System.Drawing.Color.Honeydew;
            this.txtupass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtupass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtupass.Location = new System.Drawing.Point(182, 48);
            this.txtupass.Name = "txtupass";
            this.txtupass.Size = new System.Drawing.Size(154, 23);
            this.txtupass.TabIndex = 2;
            this.txtupass.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(42, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "New Password :";
            // 
            // btnchangepas
            // 
            this.btnchangepas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnchangepas.ForeColor = System.Drawing.Color.White;
            this.btnchangepas.Location = new System.Drawing.Point(182, 132);
            this.btnchangepas.Name = "btnchangepas";
            this.btnchangepas.Size = new System.Drawing.Size(134, 40);
            this.btnchangepas.TabIndex = 6;
            this.btnchangepas.Text = "CHANGE";
            this.btnchangepas.UseVisualStyleBackColor = false;
            this.btnchangepas.Click += new System.EventHandler(this.btnchangepas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(42, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm - Pass :";
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(583, 374);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password";
            this.Load += new System.EventHandler(this.Password_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnchangepas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcpass;
        private System.Windows.Forms.TextBox txtupass;
        private System.Windows.Forms.Label label8;
    }
}