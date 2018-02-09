namespace CareYou
{
    partial class StockAlert
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtqnt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drpsign = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnselect = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.drpcompnayview = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.gvstock = new System.Windows.Forms.DataGridView();
            this.Companyname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pricee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockDataSet = new CareYou.StockDataSet();
            this.stockMstTableAdapter = new CareYou.StockDataSetTableAdapters.StockMstTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockMstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtqnt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.drpsign);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnselect);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.drpcompnayview);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(262, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 120);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Alert Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(171, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "OR";
            // 
            // txtqnt
            // 
            this.txtqnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtqnt.BackColor = System.Drawing.Color.Honeydew;
            this.txtqnt.Location = new System.Drawing.Point(492, 37);
            this.txtqnt.Name = "txtqnt";
            this.txtqnt.Size = new System.Drawing.Size(67, 23);
            this.txtqnt.TabIndex = 4;
            this.txtqnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtqnt_KeyDown);
            this.txtqnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqnt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(95, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Item Name :";
            // 
            // drpsign
            // 
            this.drpsign.BackColor = System.Drawing.Color.Honeydew;
            this.drpsign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.drpsign.FormattingEnabled = true;
            this.drpsign.Items.AddRange(new object[] {
            "<=",
            ">=",
            "=="});
            this.drpsign.Location = new System.Drawing.Point(422, 37);
            this.drpsign.Name = "drpsign";
            this.drpsign.Size = new System.Drawing.Size(64, 24);
            this.drpsign.TabIndex = 3;
            this.drpsign.SelectedIndexChanged += new System.EventHandler(this.drpsign_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(106, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Company :";
            // 
            // btnselect
            // 
            this.btnselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnselect.ForeColor = System.Drawing.Color.White;
            this.btnselect.Location = new System.Drawing.Point(462, 72);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(97, 35);
            this.btnselect.TabIndex = 5;
            this.btnselect.Text = "SEARCH";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // txtname
            // 
            this.txtname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtname.BackColor = System.Drawing.Color.Honeydew;
            this.txtname.Location = new System.Drawing.Point(193, 24);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(153, 23);
            this.txtname.TabIndex = 1;
            // 
            // drpcompnayview
            // 
            this.drpcompnayview.BackColor = System.Drawing.Color.Honeydew;
            this.drpcompnayview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.drpcompnayview.FormattingEnabled = true;
            this.drpcompnayview.Location = new System.Drawing.Point(193, 79);
            this.drpcompnayview.Name = "drpcompnayview";
            this.drpcompnayview.Size = new System.Drawing.Size(153, 24);
            this.drpcompnayview.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbltotal);
            this.groupBox2.Controls.Add(this.gvstock);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox2.Location = new System.Drawing.Point(262, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(847, 438);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Result";
            this.groupBox2.Visible = false;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbltotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltotal.Location = new System.Drawing.Point(14, 25);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(14, 19);
            this.lbltotal.TabIndex = 28;
            this.lbltotal.Text = "-";
            // 
            // gvstock
            // 
            this.gvstock.AllowUserToAddRows = false;
            this.gvstock.AllowUserToDeleteRows = false;
            this.gvstock.AllowUserToResizeColumns = false;
            this.gvstock.AllowUserToResizeRows = false;
            this.gvstock.AutoGenerateColumns = false;
            this.gvstock.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.gvstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvstock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Companyname,
            this.dataGridViewTextBoxColumn1,
            this.type,
            this.Pricee,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2});
            this.gvstock.DataSource = this.stockMstBindingSource;
            this.gvstock.GridColor = System.Drawing.Color.CadetBlue;
            this.gvstock.Location = new System.Drawing.Point(12, 56);
            this.gvstock.Name = "gvstock";
            this.gvstock.Size = new System.Drawing.Size(825, 368);
            this.gvstock.TabIndex = 7;
            // 
            // Companyname
            // 
            this.Companyname.DataPropertyName = "CompanyName";
            this.Companyname.HeaderText = "COMPANY NAME";
            this.Companyname.Name = "Companyname";
            this.Companyname.Width = 160;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn1.HeaderText = "ITEM NAME";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 180;
            // 
            // type
            // 
            this.type.DataPropertyName = "Type";
            this.type.HeaderText = "TYPE";
            this.type.Name = "type";
            this.type.Width = 120;
            // 
            // Pricee
            // 
            this.Pricee.DataPropertyName = "Price";
            this.Pricee.HeaderText = "PRICE";
            this.Pricee.Name = "Pricee";
            this.Pricee.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TotalQnt";
            this.dataGridViewTextBoxColumn3.HeaderText = "QUANTITY";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AvailableQnt";
            this.dataGridViewTextBoxColumn4.HeaderText = "AVAIL_QNT";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SellQnt";
            this.dataGridViewTextBoxColumn2.HeaderText = "SELL_QNT";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // stockMstBindingSource
            // 
            this.stockMstBindingSource.DataMember = "StockMst";
            this.stockMstBindingSource.DataSource = this.stockDataSet;
            // 
            // stockDataSet
            // 
            this.stockDataSet.DataSetName = "StockDataSet";
            this.stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockMstTableAdapter
            // 
            this.stockMstTableAdapter.ClearBeforeFill = true;
            // 
            // StockAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockAlert";
            this.Text = "StockAlert";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StockAlert_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockMstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtqnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox drpsign;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox drpcompnayview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DataGridView gvstock;
        private StockDataSet stockDataSet;
        private System.Windows.Forms.BindingSource stockMstBindingSource;
        private StockDataSetTableAdapters.StockMstTableAdapter stockMstTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Companyname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pricee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}