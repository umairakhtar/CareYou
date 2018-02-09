namespace CareYou
{
    partial class Payment
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
            this.txtbillno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.lblbillamt = new System.Windows.Forms.Label();
            this.chkpaidedit = new System.Windows.Forms.CheckBox();
            this.lblpaidamt = new System.Windows.Forms.Label();
            this.btnaddpayment = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtamtpaid = new System.Windows.Forms.TextBox();
            this.lblremainnig = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(175, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "ADD PAYMENT";
            // 
            // txtbillno
            // 
            this.txtbillno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtbillno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtbillno.BackColor = System.Drawing.Color.Honeydew;
            this.txtbillno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtbillno.Location = new System.Drawing.Point(229, 85);
            this.txtbillno.Name = "txtbillno";
            this.txtbillno.Size = new System.Drawing.Size(75, 23);
            this.txtbillno.TabIndex = 43;
            this.txtbillno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbillno_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(163, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 45;
            this.label6.Text = "BillNO :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.lblremainnig);
            this.groupBox4.Controls.Add(this.txtamtpaid);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.btnaddpayment);
            this.groupBox4.Controls.Add(this.lblpaidamt);
            this.groupBox4.Controls.Add(this.chkpaidedit);
            this.groupBox4.Controls.Add(this.lblbillamt);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 11F);
            this.groupBox4.Location = new System.Drawing.Point(123, 143);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 163);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Payment";
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(310, 78);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(97, 35);
            this.btnsearch.TabIndex = 44;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lblbillamt
            // 
            this.lblbillamt.AutoSize = true;
            this.lblbillamt.Location = new System.Drawing.Point(23, 26);
            this.lblbillamt.Name = "lblbillamt";
            this.lblbillamt.Size = new System.Drawing.Size(53, 18);
            this.lblbillamt.TabIndex = 0;
            this.lblbillamt.Text = "label12";
            // 
            // chkpaidedit
            // 
            this.chkpaidedit.AutoSize = true;
            this.chkpaidedit.Checked = true;
            this.chkpaidedit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkpaidedit.Location = new System.Drawing.Point(162, 115);
            this.chkpaidedit.Name = "chkpaidedit";
            this.chkpaidedit.Size = new System.Drawing.Size(54, 22);
            this.chkpaidedit.TabIndex = 101;
            this.chkpaidedit.Text = "Paid";
            this.chkpaidedit.UseVisualStyleBackColor = true;
            // 
            // lblpaidamt
            // 
            this.lblpaidamt.AutoSize = true;
            this.lblpaidamt.Location = new System.Drawing.Point(21, 53);
            this.lblpaidamt.Name = "lblpaidamt";
            this.lblpaidamt.Size = new System.Drawing.Size(53, 18);
            this.lblpaidamt.TabIndex = 4;
            this.lblpaidamt.Text = "label12";
            // 
            // btnaddpayment
            // 
            this.btnaddpayment.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnaddpayment.ForeColor = System.Drawing.Color.White;
            this.btnaddpayment.Location = new System.Drawing.Point(223, 111);
            this.btnaddpayment.Name = "btnaddpayment";
            this.btnaddpayment.Size = new System.Drawing.Size(77, 34);
            this.btnaddpayment.TabIndex = 102;
            this.btnaddpayment.Text = "ADD";
            this.btnaddpayment.UseVisualStyleBackColor = false;
            this.btnaddpayment.Click += new System.EventHandler(this.btnaddpayment_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = " Amt : ";
            // 
            // txtamtpaid
            // 
            this.txtamtpaid.BackColor = System.Drawing.Color.Honeydew;
            this.txtamtpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtamtpaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtamtpaid.Location = new System.Drawing.Point(77, 115);
            this.txtamtpaid.MaxLength = 10;
            this.txtamtpaid.Name = "txtamtpaid";
            this.txtamtpaid.Size = new System.Drawing.Size(75, 23);
            this.txtamtpaid.TabIndex = 100;
            // 
            // lblremainnig
            // 
            this.lblremainnig.AutoSize = true;
            this.lblremainnig.Location = new System.Drawing.Point(198, 58);
            this.lblremainnig.Name = "lblremainnig";
            this.lblremainnig.Size = new System.Drawing.Size(53, 18);
            this.lblremainnig.TabIndex = 103;
            this.lblremainnig.Text = "label12";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 18);
            this.label3.TabIndex = 104;
            this.label3.Text = "-------------------------------------------------------------------";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(583, 374);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbillno);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbillno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblremainnig;
        private System.Windows.Forms.TextBox txtamtpaid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnaddpayment;
        private System.Windows.Forms.Label lblpaidamt;
        private System.Windows.Forms.CheckBox chkpaidedit;
        private System.Windows.Forms.Label lblbillamt;
        private System.Windows.Forms.Button btnsearch;
    }
}