namespace CareYou
{
    partial class Expense
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcarttons = new System.Windows.Forms.TextBox();
            this.txtitems = new System.Windows.Forms.TextBox();
            this.txtbillamt = new System.Windows.Forms.TextBox();
            this.btnadddetail = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpaidamt = new System.Windows.Forms.TextBox();
            this.chkpaid = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.caldate = new System.Windows.Forms.DateTimePicker();
            this.drpcompnay = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbillno = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbillno);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.drpcompnay);
            this.groupBox1.Controls.Add(this.caldate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.chkpaid);
            this.groupBox1.Controls.Add(this.txtpaidamt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnadddetail);
            this.groupBox1.Controls.Add(this.txtbillamt);
            this.groupBox1.Controls.Add(this.txtitems);
            this.groupBox1.Controls.Add(this.txtcarttons);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(121, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 293);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(147, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "EXPENSES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(29, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(107, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Items :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(79, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cartoons :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(91, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bill Amt :";
            // 
            // txtcarttons
            // 
            this.txtcarttons.BackColor = System.Drawing.Color.Honeydew;
            this.txtcarttons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtcarttons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtcarttons.Location = new System.Drawing.Point(175, 88);
            this.txtcarttons.Name = "txtcarttons";
            this.txtcarttons.Size = new System.Drawing.Size(88, 23);
            this.txtcarttons.TabIndex = 3;
            // 
            // txtitems
            // 
            this.txtitems.BackColor = System.Drawing.Color.Honeydew;
            this.txtitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtitems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtitems.Location = new System.Drawing.Point(175, 119);
            this.txtitems.Name = "txtitems";
            this.txtitems.Size = new System.Drawing.Size(88, 23);
            this.txtitems.TabIndex = 4;
            // 
            // txtbillamt
            // 
            this.txtbillamt.BackColor = System.Drawing.Color.Honeydew;
            this.txtbillamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtbillamt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbillamt.Location = new System.Drawing.Point(175, 150);
            this.txtbillamt.MaxLength = 10;
            this.txtbillamt.Name = "txtbillamt";
            this.txtbillamt.Size = new System.Drawing.Size(88, 23);
            this.txtbillamt.TabIndex = 5;
            // 
            // btnadddetail
            // 
            this.btnadddetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnadddetail.ForeColor = System.Drawing.Color.White;
            this.btnadddetail.Location = new System.Drawing.Point(171, 244);
            this.btnadddetail.Name = "btnadddetail";
            this.btnadddetail.Size = new System.Drawing.Size(134, 40);
            this.btnadddetail.TabIndex = 9;
            this.btnadddetail.Text = "ADD DETAIL";
            this.btnadddetail.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(87, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pay Amt :";
            // 
            // txtpaidamt
            // 
            this.txtpaidamt.BackColor = System.Drawing.Color.Honeydew;
            this.txtpaidamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtpaidamt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtpaidamt.Location = new System.Drawing.Point(175, 182);
            this.txtpaidamt.MaxLength = 10;
            this.txtpaidamt.Name = "txtpaidamt";
            this.txtpaidamt.Size = new System.Drawing.Size(88, 23);
            this.txtpaidamt.TabIndex = 6;
            // 
            // chkpaid
            // 
            this.chkpaid.AutoSize = true;
            this.chkpaid.Checked = true;
            this.chkpaid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkpaid.Location = new System.Drawing.Point(269, 186);
            this.chkpaid.Name = "chkpaid";
            this.chkpaid.Size = new System.Drawing.Size(56, 22);
            this.chkpaid.TabIndex = 7;
            this.chkpaid.Text = "Paid";
            this.chkpaid.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(109, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Date :";
            // 
            // caldate
            // 
            this.caldate.CalendarForeColor = System.Drawing.Color.Red;
            this.caldate.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.caldate.Location = new System.Drawing.Point(171, 212);
            this.caldate.Name = "caldate";
            this.caldate.Size = new System.Drawing.Size(154, 24);
            this.caldate.TabIndex = 8;
            // 
            // drpcompnay
            // 
            this.drpcompnay.BackColor = System.Drawing.Color.Honeydew;
            this.drpcompnay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.drpcompnay.FormattingEnabled = true;
            this.drpcompnay.Location = new System.Drawing.Point(175, 26);
            this.drpcompnay.Name = "drpcompnay";
            this.drpcompnay.Size = new System.Drawing.Size(154, 26);
            this.drpcompnay.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(102, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Bill No :";
            // 
            // txtbillno
            // 
            this.txtbillno.BackColor = System.Drawing.Color.Honeydew;
            this.txtbillno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtbillno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbillno.Location = new System.Drawing.Point(175, 58);
            this.txtbillno.MaxLength = 10;
            this.txtbillno.Name = "txtbillno";
            this.txtbillno.Size = new System.Drawing.Size(88, 23);
            this.txtbillno.TabIndex = 2;
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Expense";
            this.Text = "Expense";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbillno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox drpcompnay;
        private System.Windows.Forms.DateTimePicker caldate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkpaid;
        private System.Windows.Forms.TextBox txtpaidamt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnadddetail;
        private System.Windows.Forms.TextBox txtbillamt;
        private System.Windows.Forms.TextBox txtitems;
        private System.Windows.Forms.TextBox txtcarttons;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}