namespace CareYou
{
    partial class StockReturns
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
            this.btnselect = new System.Windows.Forms.Button();
            this.drptype = new System.Windows.Forms.ComboBox();
            this.drpitemname = new System.Windows.Forms.ComboBox();
            this.drpcompnayview = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gvstockin = new System.Windows.Forms.DataGridView();
            this.gvstock = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtqnt = new System.Windows.Forms.TextBox();
            this.btnreturns = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.stockDataSet = new CareYou.StockDataSet();
            this.stockReturnMstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockReturnMstTableAdapter = new CareYou.StockDataSetTableAdapters.StockReturnMstTableAdapter();
            this.orderReturnMstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderReturnMstTableAdapter = new CareYou.StockDataSetTableAdapters.OrderReturnMstTableAdapter();
            this.stockMstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockMstTableAdapter = new CareYou.StockDataSetTableAdapters.StockMstTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pricee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockInMstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockInMstTableAdapter = new CareYou.StockDataSetTableAdapters.StockInMstTableAdapter();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvstockin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockReturnMstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderReturnMstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockMstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockInMstBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnreturns);
            this.groupBox1.Controls.Add(this.txtqnt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gvstock);
            this.groupBox1.Controls.Add(this.gvstockin);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox1.Location = new System.Drawing.Point(340, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 310);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Returns";
            this.groupBox1.Visible = false;
            // 
            // btnselect
            // 
            this.btnselect.Enabled = false;
            this.btnselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnselect.ForeColor = System.Drawing.Color.White;
            this.btnselect.Location = new System.Drawing.Point(893, 78);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(97, 32);
            this.btnselect.TabIndex = 3;
            this.btnselect.Text = "SELECT";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // drptype
            // 
            this.drptype.BackColor = System.Drawing.Color.Honeydew;
            this.drptype.Enabled = false;
            this.drptype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.drptype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.drptype.FormattingEnabled = true;
            this.drptype.ItemHeight = 18;
            this.drptype.Location = new System.Drawing.Point(732, 82);
            this.drptype.Name = "drptype";
            this.drptype.Size = new System.Drawing.Size(153, 26);
            this.drptype.TabIndex = 2;
            this.drptype.SelectedIndexChanged += new System.EventHandler(this.drptype_SelectedIndexChanged);
            // 
            // drpitemname
            // 
            this.drpitemname.BackColor = System.Drawing.Color.Honeydew;
            this.drpitemname.DropDownWidth = 153;
            this.drpitemname.Enabled = false;
            this.drpitemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.drpitemname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.drpitemname.FormattingEnabled = true;
            this.drpitemname.Location = new System.Drawing.Point(573, 82);
            this.drpitemname.Name = "drpitemname";
            this.drpitemname.Size = new System.Drawing.Size(153, 26);
            this.drpitemname.TabIndex = 1;
            this.drpitemname.SelectedIndexChanged += new System.EventHandler(this.drpitemname_SelectedIndexChanged);
            // 
            // drpcompnayview
            // 
            this.drpcompnayview.BackColor = System.Drawing.Color.Honeydew;
            this.drpcompnayview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.drpcompnayview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.drpcompnayview.FormattingEnabled = true;
            this.drpcompnayview.ItemHeight = 18;
            this.drpcompnayview.Location = new System.Drawing.Point(414, 82);
            this.drpcompnayview.Name = "drpcompnayview";
            this.drpcompnayview.Size = new System.Drawing.Size(153, 26);
            this.drpcompnayview.TabIndex = 0;
            this.drpcompnayview.SelectedIndexChanged += new System.EventHandler(this.drpcompnayview_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(286, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Select Company :";
            // 
            // gvstockin
            // 
            this.gvstockin.AllowUserToAddRows = false;
            this.gvstockin.AllowUserToDeleteRows = false;
            this.gvstockin.AllowUserToResizeColumns = false;
            this.gvstockin.AllowUserToResizeRows = false;
            this.gvstockin.AutoGenerateColumns = false;
            this.gvstockin.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.gvstockin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvstockin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PName,
            this.Type,
            this.Quntity,
            this.Price,
            this.Location,
            this.IID});
            this.gvstockin.DataSource = this.stockInMstBindingSource;
            this.gvstockin.GridColor = System.Drawing.Color.CadetBlue;
            this.gvstockin.Location = new System.Drawing.Point(20, 43);
            this.gvstockin.Name = "gvstockin";
            this.gvstockin.Size = new System.Drawing.Size(606, 81);
            this.gvstockin.TabIndex = 5;
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
            this.dataGridViewTextBoxColumn1,
            this.Pricee,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5});
            this.gvstock.DataSource = this.stockMstBindingSource;
            this.gvstock.GridColor = System.Drawing.Color.CadetBlue;
            this.gvstock.Location = new System.Drawing.Point(20, 161);
            this.gvstock.Name = "gvstock";
            this.gvstock.Size = new System.Drawing.Size(606, 78);
            this.gvstock.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Last Added Stock Record";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Stock Record";
            // 
            // txtqnt
            // 
            this.txtqnt.BackColor = System.Drawing.Color.Honeydew;
            this.txtqnt.Location = new System.Drawing.Point(456, 273);
            this.txtqnt.Name = "txtqnt";
            this.txtqnt.Size = new System.Drawing.Size(67, 24);
            this.txtqnt.TabIndex = 4;
            // 
            // btnreturns
            // 
            this.btnreturns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnreturns.ForeColor = System.Drawing.Color.White;
            this.btnreturns.Location = new System.Drawing.Point(527, 268);
            this.btnreturns.Name = "btnreturns";
            this.btnreturns.Size = new System.Drawing.Size(97, 32);
            this.btnreturns.TabIndex = 5;
            this.btnreturns.Text = "RETURN";
            this.btnreturns.UseVisualStyleBackColor = false;
            this.btnreturns.Click += new System.EventHandler(this.btnreturns_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(317, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Input Return Qnt :";
            // 
            // stockDataSet
            // 
            this.stockDataSet.DataSetName = "StockDataSet";
            this.stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockReturnMstBindingSource
            // 
            this.stockReturnMstBindingSource.DataMember = "StockReturnMst";
            this.stockReturnMstBindingSource.DataSource = this.stockDataSet;
            // 
            // stockReturnMstTableAdapter
            // 
            this.stockReturnMstTableAdapter.ClearBeforeFill = true;
            // 
            // orderReturnMstBindingSource
            // 
            this.orderReturnMstBindingSource.DataMember = "OrderReturnMst";
            this.orderReturnMstBindingSource.DataSource = this.stockDataSet;
            // 
            // orderReturnMstTableAdapter
            // 
            this.orderReturnMstTableAdapter.ClearBeforeFill = true;
            // 
            // stockMstBindingSource
            // 
            this.stockMstBindingSource.DataMember = "StockMst";
            this.stockMstBindingSource.DataSource = this.stockDataSet;
            // 
            // stockMstTableAdapter
            // 
            this.stockMstTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "itemName";
            this.dataGridViewTextBoxColumn1.HeaderText = "ITEM NAME";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 160;
            // 
            // Pricee
            // 
            this.Pricee.DataPropertyName = "p";
            this.Pricee.HeaderText = "PRICE";
            this.Pricee.Name = "Pricee";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "totalqnt";
            this.dataGridViewTextBoxColumn3.HeaderText = "QUANTITY";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "availableqnt";
            this.dataGridViewTextBoxColumn4.HeaderText = "AVAIL_QNT";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "availableprice";
            this.dataGridViewTextBoxColumn2.HeaderText = "TOTALPRICE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "IID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // stockInMstBindingSource
            // 
            this.stockInMstBindingSource.DataMember = "StockInMst";
            this.stockInMstBindingSource.DataSource = this.stockDataSet;
            // 
            // stockInMstTableAdapter
            // 
            this.stockInMstTableAdapter.ClearBeforeFill = true;
            // 
            // PName
            // 
            this.PName.DataPropertyName = "ItemName";
            this.PName.HeaderText = "ITEM NAME";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            this.PName.Width = 160;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "TYPE";
            this.Type.Name = "Type";
            // 
            // Quntity
            // 
            this.Quntity.DataPropertyName = "Qnt";
            this.Quntity.HeaderText = "QUANTITY";
            this.Quntity.Name = "Quntity";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "BuyPrice";
            this.Price.HeaderText = "BuyPrice";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "LOCATION";
            this.Location.Name = "Location";
            // 
            // IID
            // 
            this.IID.DataPropertyName = "ID";
            this.IID.HeaderText = "IID";
            this.IID.Name = "IID";
            this.IID.ReadOnly = true;
            this.IID.Visible = false;
            // 
            // StockReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.drpcompnayview);
            this.Controls.Add(this.drpitemname);
            this.Controls.Add(this.drptype);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockReturns";
            this.Text = "StockReturns";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StockReturns_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvstockin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockReturnMstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderReturnMstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockMstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockInMstBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnreturns;
        private System.Windows.Forms.TextBox txtqnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvstock;
        private System.Windows.Forms.DataGridView gvstockin;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.ComboBox drptype;
        private System.Windows.Forms.ComboBox drpitemname;
        private System.Windows.Forms.ComboBox drpcompnayview;
        private System.Windows.Forms.Label label9;
        private StockDataSet stockDataSet;
        private System.Windows.Forms.BindingSource stockReturnMstBindingSource;
        private StockDataSetTableAdapters.StockReturnMstTableAdapter stockReturnMstTableAdapter;
        private System.Windows.Forms.BindingSource orderReturnMstBindingSource;
        private StockDataSetTableAdapters.OrderReturnMstTableAdapter orderReturnMstTableAdapter;
        private System.Windows.Forms.BindingSource stockMstBindingSource;
        private StockDataSetTableAdapters.StockMstTableAdapter stockMstTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pricee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource stockInMstBindingSource;
        private StockDataSetTableAdapters.StockInMstTableAdapter stockInMstTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn IID;
    }
}