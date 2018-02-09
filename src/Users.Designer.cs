namespace CareYou
{
    partial class Users
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnadduser = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtupass = new System.Windows.Forms.TextBox();
            this.txtcpass = new System.Windows.Forms.TextBox();
            this.rdoadmin = new System.Windows.Forms.RadioButton();
            this.rdouser = new System.Windows.Forms.RadioButton();
            this.Gvuser = new System.Windows.Forms.DataGridView();
            this.stockDataSet = new CareYou.StockDataSet();
            this.userMstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userMstTableAdapter = new CareYou.StockDataSetTableAdapters.UserMstTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScaleA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScaleB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gvuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userMstBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(147, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "USER ACCOUNT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdouser);
            this.groupBox1.Controls.Add(this.rdoadmin);
            this.groupBox1.Controls.Add(this.txtcpass);
            this.groupBox1.Controls.Add(this.txtupass);
            this.groupBox1.Controls.Add(this.txtuname);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnadduser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(121, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 236);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New User";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Gvuser);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(508, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 418);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(63, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(107, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(32, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm - Pass :";
            // 
            // btnadduser
            // 
            this.btnadduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnadduser.ForeColor = System.Drawing.Color.White;
            this.btnadduser.Location = new System.Drawing.Point(170, 172);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(134, 40);
            this.btnadduser.TabIndex = 6;
            this.btnadduser.Text = "ADD USER";
            this.btnadduser.UseVisualStyleBackColor = false;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(73, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Password :";
            // 
            // txtuname
            // 
            this.txtuname.BackColor = System.Drawing.Color.Honeydew;
            this.txtuname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtuname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtuname.Location = new System.Drawing.Point(173, 39);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(154, 23);
            this.txtuname.TabIndex = 1;
            // 
            // txtupass
            // 
            this.txtupass.BackColor = System.Drawing.Color.Honeydew;
            this.txtupass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtupass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtupass.Location = new System.Drawing.Point(171, 71);
            this.txtupass.Name = "txtupass";
            this.txtupass.Size = new System.Drawing.Size(154, 23);
            this.txtupass.TabIndex = 2;
            this.txtupass.UseSystemPasswordChar = true;
            // 
            // txtcpass
            // 
            this.txtcpass.BackColor = System.Drawing.Color.Honeydew;
            this.txtcpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtcpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtcpass.Location = new System.Drawing.Point(170, 103);
            this.txtcpass.Name = "txtcpass";
            this.txtcpass.Size = new System.Drawing.Size(154, 23);
            this.txtcpass.TabIndex = 3;
            this.txtcpass.UseSystemPasswordChar = true;
            // 
            // rdoadmin
            // 
            this.rdoadmin.AutoSize = true;
            this.rdoadmin.Location = new System.Drawing.Point(170, 135);
            this.rdoadmin.Name = "rdoadmin";
            this.rdoadmin.Size = new System.Drawing.Size(67, 22);
            this.rdoadmin.TabIndex = 4;
            this.rdoadmin.TabStop = true;
            this.rdoadmin.Text = "Admin";
            this.rdoadmin.UseVisualStyleBackColor = true;
            // 
            // rdouser
            // 
            this.rdouser.AutoSize = true;
            this.rdouser.Location = new System.Drawing.Point(237, 135);
            this.rdouser.Name = "rdouser";
            this.rdouser.Size = new System.Drawing.Size(58, 22);
            this.rdouser.TabIndex = 5;
            this.rdouser.Text = "User";
            this.rdouser.UseVisualStyleBackColor = true;
            // 
            // Gvuser
            // 
            this.Gvuser.AutoGenerateColumns = false;
            this.Gvuser.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.Gvuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gvuser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ScaleA,
            this.ScaleB,
            this.Date,
            this.Delete,
            this.UID});
            this.Gvuser.DataSource = this.userMstBindingSource;
            this.Gvuser.Location = new System.Drawing.Point(9, 25);
            this.Gvuser.Name = "Gvuser";
            this.Gvuser.Size = new System.Drawing.Size(724, 380);
            this.Gvuser.TabIndex = 7;
            this.Gvuser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gvuser_CellContentClick);
            // 
            // stockDataSet
            // 
            this.stockDataSet.DataSetName = "StockDataSet";
            this.stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userMstBindingSource
            // 
            this.userMstBindingSource.DataMember = "UserMst";
            this.userMstBindingSource.DataSource = this.stockDataSet;
            // 
            // userMstTableAdapter
            // 
            this.userMstTableAdapter.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "UName";
            this.ID.Frozen = true;
            this.ID.HeaderText = "USERNAME";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 160;
            // 
            // ScaleA
            // 
            this.ScaleA.DataPropertyName = "UPass";
            this.ScaleA.Frozen = true;
            this.ScaleA.HeaderText = "PASSWORD";
            this.ScaleA.Name = "ScaleA";
            this.ScaleA.Width = 160;
            // 
            // ScaleB
            // 
            this.ScaleB.DataPropertyName = "UType";
            this.ScaleB.Frozen = true;
            this.ScaleB.HeaderText = "Type";
            this.ScaleB.Name = "ScaleB";
            this.ScaleB.ReadOnly = true;
            this.ScaleB.Width = 120;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "EDate";
            this.Date.Frozen = true;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 140;
            // 
            // Delete
            // 
            this.Delete.Frozen = true;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // UID
            // 
            this.UID.DataPropertyName = "ID";
            this.UID.HeaderText = "ID";
            this.UID.Name = "UID";
            this.UID.Visible = false;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Users";
            this.Text = "Users";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Users_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gvuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userMstBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdouser;
        private System.Windows.Forms.RadioButton rdoadmin;
        private System.Windows.Forms.TextBox txtcpass;
        private System.Windows.Forms.TextBox txtupass;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnadduser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Gvuser;
        private StockDataSet stockDataSet;
        private System.Windows.Forms.BindingSource userMstBindingSource;
        private StockDataSetTableAdapters.UserMstTableAdapter userMstTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScaleA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScaleB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
    }
}