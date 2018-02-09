namespace CareYou
{
    partial class ReportSellStock
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvstockIn = new System.Windows.Forms.DataGridView();
            this.lbltotal = new System.Windows.Forms.Label();
            this.drpcompnayview = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnselect = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkapply = new System.Windows.Forms.CheckBox();
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.btntotalsell = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnclientsearch = new System.Windows.Forms.Button();
            this.lblmobile = new System.Windows.Forms.Label();
            this.drpclient = new System.Windows.Forms.ComboBox();
            this.txtbillno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnbillreport = new System.Windows.Forms.Button();
            this.stockDataSet = new CareYou.StockDataSet();
            this.sellMstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellMstTableAdapter = new CareYou.StockDataSetTableAdapters.SellMstTableAdapter();
            this.Clientname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Companyname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pricee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvstockIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellMstBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbillreport);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtbillno);
            this.groupBox1.Controls.Add(this.drpclient);
            this.groupBox1.Controls.Add(this.lblmobile);
            this.groupBox1.Controls.Add(this.btnclientsearch);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btntotalsell);
            this.groupBox1.Controls.Add(this.todate);
            this.groupBox1.Controls.Add(this.fromdate);
            this.groupBox1.Controls.Add(this.chkapply);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnselect);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.drpcompnayview);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(104, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1162, 116);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Alert Report";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbltotal);
            this.groupBox2.Controls.Add(this.gvstockIn);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox2.Location = new System.Drawing.Point(104, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1162, 473);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Result";
            this.groupBox2.Visible = false;
            // 
            // gvstockIn
            // 
            this.gvstockIn.AllowUserToAddRows = false;
            this.gvstockIn.AllowUserToDeleteRows = false;
            this.gvstockIn.AllowUserToResizeColumns = false;
            this.gvstockIn.AllowUserToResizeRows = false;
            this.gvstockIn.AutoGenerateColumns = false;
            this.gvstockIn.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.gvstockIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvstockIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clientname,
            this.mobile,
            this.Companyname,
            this.dataGridViewTextBoxColumn1,
            this.type,
            this.dataGridViewTextBoxColumn3,
            this.Pricee,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.status,
            this.Date});
            this.gvstockIn.DataSource = this.sellMstBindingSource;
            this.gvstockIn.GridColor = System.Drawing.Color.CadetBlue;
            this.gvstockIn.Location = new System.Drawing.Point(12, 56);
            this.gvstockIn.Name = "gvstockIn";
            this.gvstockIn.Size = new System.Drawing.Size(1134, 403);
            this.gvstockIn.TabIndex = 7;
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
            // drpcompnayview
            // 
            this.drpcompnayview.BackColor = System.Drawing.Color.Honeydew;
            this.drpcompnayview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.drpcompnayview.FormattingEnabled = true;
            this.drpcompnayview.Location = new System.Drawing.Point(136, 74);
            this.drpcompnayview.Name = "drpcompnayview";
            this.drpcompnayview.Size = new System.Drawing.Size(153, 24);
            this.drpcompnayview.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtname.BackColor = System.Drawing.Color.Honeydew;
            this.txtname.Location = new System.Drawing.Point(136, 30);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(153, 23);
            this.txtname.TabIndex = 1;
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtname_KeyDown);
            // 
            // btnselect
            // 
            this.btnselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnselect.ForeColor = System.Drawing.Color.White;
            this.btnselect.Location = new System.Drawing.Point(295, 69);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(97, 35);
            this.btnselect.TabIndex = 3;
            this.btnselect.Text = "SEARCH";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(49, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Company :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Item Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(63, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "OR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(416, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "From Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(435, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "To Date :";
            // 
            // chkapply
            // 
            this.chkapply.AutoSize = true;
            this.chkapply.Font = new System.Drawing.Font("Calibri", 10F);
            this.chkapply.Location = new System.Drawing.Point(510, 79);
            this.chkapply.Name = "chkapply";
            this.chkapply.Size = new System.Drawing.Size(58, 21);
            this.chkapply.TabIndex = 6;
            this.chkapply.Text = "Apply";
            this.chkapply.UseVisualStyleBackColor = true;
            // 
            // fromdate
            // 
            this.fromdate.Location = new System.Drawing.Point(510, 25);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(163, 23);
            this.fromdate.TabIndex = 4;
            // 
            // todate
            // 
            this.todate.Location = new System.Drawing.Point(510, 52);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(163, 23);
            this.todate.TabIndex = 5;
            // 
            // btntotalsell
            // 
            this.btntotalsell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btntotalsell.ForeColor = System.Drawing.Color.White;
            this.btntotalsell.Location = new System.Drawing.Point(579, 80);
            this.btntotalsell.Name = "btntotalsell";
            this.btntotalsell.Size = new System.Drawing.Size(97, 27);
            this.btntotalsell.TabIndex = 7;
            this.btntotalsell.Text = "Total Sell";
            this.btntotalsell.UseVisualStyleBackColor = false;
            this.btntotalsell.Click += new System.EventHandler(this.btntotalsell_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(713, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Client Name :";
            // 
            // btnclientsearch
            // 
            this.btnclientsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnclientsearch.ForeColor = System.Drawing.Color.White;
            this.btnclientsearch.Location = new System.Drawing.Point(876, 58);
            this.btnclientsearch.Name = "btnclientsearch";
            this.btnclientsearch.Size = new System.Drawing.Size(97, 35);
            this.btnclientsearch.TabIndex = 9;
            this.btnclientsearch.Text = "SEARCH";
            this.btnclientsearch.UseVisualStyleBackColor = false;
            this.btnclientsearch.Click += new System.EventHandler(this.btnclientsearch_Click);
            // 
            // lblmobile
            // 
            this.lblmobile.AutoSize = true;
            this.lblmobile.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblmobile.Location = new System.Drawing.Point(818, 11);
            this.lblmobile.Name = "lblmobile";
            this.lblmobile.Size = new System.Drawing.Size(16, 17);
            this.lblmobile.TabIndex = 39;
            this.lblmobile.Text = "--";
            // 
            // drpclient
            // 
            this.drpclient.BackColor = System.Drawing.Color.Honeydew;
            this.drpclient.DropDownWidth = 153;
            this.drpclient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.drpclient.FormattingEnabled = true;
            this.drpclient.Location = new System.Drawing.Point(819, 29);
            this.drpclient.Name = "drpclient";
            this.drpclient.Size = new System.Drawing.Size(153, 24);
            this.drpclient.TabIndex = 8;
            this.drpclient.SelectedIndexChanged += new System.EventHandler(this.drpclient_SelectedIndexChanged);
            // 
            // txtbillno
            // 
            this.txtbillno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtbillno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtbillno.BackColor = System.Drawing.Color.Honeydew;
            this.txtbillno.Location = new System.Drawing.Point(1071, 26);
            this.txtbillno.Name = "txtbillno";
            this.txtbillno.Size = new System.Drawing.Size(75, 23);
            this.txtbillno.TabIndex = 10;
            this.txtbillno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbillno_KeyDown);
            this.txtbillno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbillno_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(1005, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 42;
            this.label6.Text = "BillNO :";
            // 
            // btnbillreport
            // 
            this.btnbillreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnbillreport.ForeColor = System.Drawing.Color.White;
            this.btnbillreport.Location = new System.Drawing.Point(1049, 57);
            this.btnbillreport.Name = "btnbillreport";
            this.btnbillreport.Size = new System.Drawing.Size(97, 35);
            this.btnbillreport.TabIndex = 11;
            this.btnbillreport.Text = "SEARCH";
            this.btnbillreport.UseVisualStyleBackColor = false;
            this.btnbillreport.Click += new System.EventHandler(this.btnbillreport_Click);
            // 
            // stockDataSet
            // 
            this.stockDataSet.DataSetName = "StockDataSet";
            this.stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sellMstBindingSource
            // 
            this.sellMstBindingSource.DataMember = "SellMst";
            this.sellMstBindingSource.DataSource = this.stockDataSet;
            // 
            // sellMstTableAdapter
            // 
            this.sellMstTableAdapter.ClearBeforeFill = true;
            // 
            // Clientname
            // 
            this.Clientname.DataPropertyName = "PartyName";
            this.Clientname.HeaderText = "CLIENT_NAME";
            this.Clientname.Name = "Clientname";
            this.Clientname.Width = 140;
            // 
            // mobile
            // 
            this.mobile.DataPropertyName = "Mobile";
            this.mobile.HeaderText = "MOBILE";
            this.mobile.Name = "mobile";
            // 
            // Companyname
            // 
            this.Companyname.DataPropertyName = "Company";
            this.Companyname.HeaderText = "COMPANY NAME";
            this.Companyname.Name = "Companyname";
            this.Companyname.Width = 130;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn1.HeaderText = "ITEM NAME";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // type
            // 
            this.type.DataPropertyName = "Type";
            this.type.HeaderText = "TYPE";
            this.type.Name = "type";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Qnt";
            this.dataGridViewTextBoxColumn3.HeaderText = "QUANTITY";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // Pricee
            // 
            this.Pricee.DataPropertyName = "Price";
            this.Pricee.HeaderText = "PRICE";
            this.Pricee.Name = "Pricee";
            this.Pricee.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TotalPrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "Total_PRICE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BillNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "BILL_NO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "STATUS";
            this.status.Name = "status";
            this.status.Width = 70;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "EDate";
            this.Date.HeaderText = "ENTRY_DATE";
            this.Date.Name = "Date";
            this.Date.Width = 140;
            // 
            // ReportSellStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportSellStock";
            this.Text = "ReportSellStock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportSellStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvstockIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellMstBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox drpcompnayview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DataGridView gvstockIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnbillreport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbillno;
        private System.Windows.Forms.ComboBox drpclient;
        private System.Windows.Forms.Label lblmobile;
        private System.Windows.Forms.Button btnclientsearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btntotalsell;
        private System.Windows.Forms.DateTimePicker todate;
        private System.Windows.Forms.DateTimePicker fromdate;
        private System.Windows.Forms.CheckBox chkapply;
        private StockDataSet stockDataSet;
        private System.Windows.Forms.BindingSource sellMstBindingSource;
        private StockDataSetTableAdapters.SellMstTableAdapter sellMstTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clientname;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Companyname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pricee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}