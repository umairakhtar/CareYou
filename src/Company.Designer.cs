using System.Windows.Forms;

namespace CareYou
{
    partial class Company
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.txtconntactname = new System.Windows.Forms.TextBox();
            this.txtcompnayname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.companyMstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockDataSet = new CareYou.StockDataSet();
            this.companyMstTableAdapter = new CareYou.StockDataSetTableAdapters.CompanyMstTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScaleA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScaleB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyMstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(169, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMPANY DETAIL";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Controls.Add(this.btnlogin);
            this.groupBox1.Controls.Add(this.txtmobile);
            this.groupBox1.Controls.Add(this.txtadd);
            this.groupBox1.Controls.Add(this.txtconntactname);
            this.groupBox1.Controls.Add(this.txtcompnayname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(114, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 273);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Company";
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(178, 202);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(154, 45);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "ADD DETAIL";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtmobile
            // 
            this.txtmobile.BackColor = System.Drawing.Color.Honeydew;
            this.txtmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtmobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtmobile.Location = new System.Drawing.Point(178, 153);
            this.txtmobile.MaxLength = 10;
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(154, 23);
            this.txtmobile.TabIndex = 4;
            this.txtmobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmobile_KeyPress);
            // 
            // txtadd
            // 
            this.txtadd.BackColor = System.Drawing.Color.Honeydew;
            this.txtadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtadd.Location = new System.Drawing.Point(178, 114);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(154, 23);
            this.txtadd.TabIndex = 3;
            // 
            // txtconntactname
            // 
            this.txtconntactname.BackColor = System.Drawing.Color.Honeydew;
            this.txtconntactname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtconntactname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtconntactname.Location = new System.Drawing.Point(178, 76);
            this.txtconntactname.Name = "txtconntactname";
            this.txtconntactname.Size = new System.Drawing.Size(154, 23);
            this.txtconntactname.TabIndex = 6;
            // 
            // txtcompnayname
            // 
            this.txtcompnayname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtcompnayname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtcompnayname.Location = new System.Drawing.Point(178, 38);
            this.txtcompnayname.Name = "txtcompnayname";
            this.txtcompnayname.Size = new System.Drawing.Size(154, 23);
            this.txtcompnayname.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(101, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mobile :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(39, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contact Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(87, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(28, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Company Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox2.Location = new System.Drawing.Point(521, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 490);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Company";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ScaleA,
            this.ScaleB,
            this.Address,
            this.Mobile,
            this.Delete});
            this.dataGridView1.DataSource = this.companyMstBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 459);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // companyMstBindingSource
            // 
            this.companyMstBindingSource.DataMember = "CompanyMst";
            this.companyMstBindingSource.DataSource = this.stockDataSet;
            // 
            // stockDataSet
            // 
            this.stockDataSet.DataSetName = "StockDataSet";
            this.stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyMstTableAdapter
            // 
            this.companyMstTableAdapter.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ScaleA
            // 
            this.ScaleA.DataPropertyName = "CompanyName";
            this.ScaleA.HeaderText = "CompanyName";
            this.ScaleA.Name = "ScaleA";
            this.ScaleA.ReadOnly = true;
            this.ScaleA.Width = 160;
            // 
            // ScaleB
            // 
            this.ScaleB.DataPropertyName = "ContactName";
            this.ScaleB.HeaderText = "ContactName";
            this.ScaleB.Name = "ScaleB";
            this.ScaleB.ReadOnly = true;
            this.ScaleB.Width = 140;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 140;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Contact";
            this.Mobile.HeaderText = "Mobile";
            this.Mobile.Name = "Mobile";
            this.Mobile.Width = 120;
            // 
            // Delete
            // 
            this.Delete.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.Delete.HeaderText = "Delete";
            this.Delete.LinkColor = System.Drawing.Color.Red;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            this.Delete.Width = 90;
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Company";
            this.Text = "Company";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Company_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyMstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.TextBox txtconntactname;
        private System.Windows.Forms.TextBox txtcompnayname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StockDataSet stockDataSet;
        private System.Windows.Forms.BindingSource companyMstBindingSource;
        private StockDataSetTableAdapters.CompanyMstTableAdapter companyMstTableAdapter;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ScaleA;
        private DataGridViewTextBoxColumn ScaleB;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Mobile;
        private DataGridViewLinkColumn Delete;
    }
}