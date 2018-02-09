namespace CareYou
{
    partial class ReportPayment
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
            this.btnbillreport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbillno = new System.Windows.Forms.TextBox();
            this.drpclient = new System.Windows.Forms.ComboBox();
            this.lblmobile = new System.Windows.Forms.Label();
            this.btnclientsearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btntotalsell = new System.Windows.Forms.Button();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.chkapply = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblpamt = new System.Windows.Forms.Label();
            this.lblamt = new System.Windows.Forms.Label();
            this.lblqnt = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.gvstockIn = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clientname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pricee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockDataSet = new CareYou.StockDataSet();
            this.paymentMstTableAdapter = new CareYou.StockDataSetTableAdapters.PaymentMstTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvstockIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).BeginInit();
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(245, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 116);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Report";
            // 
            // btnbillreport
            // 
            this.btnbillreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnbillreport.ForeColor = System.Drawing.Color.White;
            this.btnbillreport.Location = new System.Drawing.Point(69, 57);
            this.btnbillreport.Name = "btnbillreport";
            this.btnbillreport.Size = new System.Drawing.Size(97, 35);
            this.btnbillreport.TabIndex = 11;
            this.btnbillreport.Text = "SEARCH";
            this.btnbillreport.UseVisualStyleBackColor = false;
            this.btnbillreport.Click += new System.EventHandler(this.btnbillreport_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(25, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 42;
            this.label6.Text = "BillNO :";
            // 
            // txtbillno
            // 
            this.txtbillno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtbillno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtbillno.BackColor = System.Drawing.Color.Honeydew;
            this.txtbillno.Location = new System.Drawing.Point(91, 26);
            this.txtbillno.Name = "txtbillno";
            this.txtbillno.Size = new System.Drawing.Size(75, 23);
            this.txtbillno.TabIndex = 10;
            this.txtbillno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbillno_KeyDown);
            // 
            // drpclient
            // 
            this.drpclient.BackColor = System.Drawing.Color.Honeydew;
            this.drpclient.DropDownWidth = 153;
            this.drpclient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.drpclient.FormattingEnabled = true;
            this.drpclient.Location = new System.Drawing.Point(695, 30);
            this.drpclient.Name = "drpclient";
            this.drpclient.Size = new System.Drawing.Size(153, 24);
            this.drpclient.TabIndex = 8;
            this.drpclient.SelectedIndexChanged += new System.EventHandler(this.drpclient_SelectedIndexChanged);
            // 
            // lblmobile
            // 
            this.lblmobile.AutoSize = true;
            this.lblmobile.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblmobile.Location = new System.Drawing.Point(695, 10);
            this.lblmobile.Name = "lblmobile";
            this.lblmobile.Size = new System.Drawing.Size(16, 17);
            this.lblmobile.TabIndex = 39;
            this.lblmobile.Text = "--";
            // 
            // btnclientsearch
            // 
            this.btnclientsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnclientsearch.ForeColor = System.Drawing.Color.White;
            this.btnclientsearch.Location = new System.Drawing.Point(751, 60);
            this.btnclientsearch.Name = "btnclientsearch";
            this.btnclientsearch.Size = new System.Drawing.Size(97, 35);
            this.btnclientsearch.TabIndex = 9;
            this.btnclientsearch.Text = "SEARCH";
            this.btnclientsearch.UseVisualStyleBackColor = false;
            this.btnclientsearch.Click += new System.EventHandler(this.btnclientsearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(589, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Client Name :";
            // 
            // btntotalsell
            // 
            this.btntotalsell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btntotalsell.ForeColor = System.Drawing.Color.White;
            this.btntotalsell.Location = new System.Drawing.Point(406, 83);
            this.btntotalsell.Name = "btntotalsell";
            this.btntotalsell.Size = new System.Drawing.Size(97, 27);
            this.btntotalsell.TabIndex = 7;
            this.btntotalsell.Text = "Total Sell";
            this.btntotalsell.UseVisualStyleBackColor = false;
            this.btntotalsell.Click += new System.EventHandler(this.btntotalsell_Click);
            // 
            // todate
            // 
            this.todate.Location = new System.Drawing.Point(337, 55);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(163, 23);
            this.todate.TabIndex = 5;
            // 
            // fromdate
            // 
            this.fromdate.Location = new System.Drawing.Point(337, 28);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(163, 23);
            this.fromdate.TabIndex = 4;
            // 
            // chkapply
            // 
            this.chkapply.AutoSize = true;
            this.chkapply.Font = new System.Drawing.Font("Calibri", 10F);
            this.chkapply.Location = new System.Drawing.Point(337, 82);
            this.chkapply.Name = "chkapply";
            this.chkapply.Size = new System.Drawing.Size(58, 21);
            this.chkapply.TabIndex = 6;
            this.chkapply.Text = "Apply";
            this.chkapply.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(262, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "To Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(243, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "From Date :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblpamt);
            this.groupBox2.Controls.Add(this.lblamt);
            this.groupBox2.Controls.Add(this.lblqnt);
            this.groupBox2.Controls.Add(this.lbltotal);
            this.groupBox2.Controls.Add(this.gvstockIn);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox2.Location = new System.Drawing.Point(200, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(971, 473);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Result";
            this.groupBox2.Visible = false;
            // 
            // lblpamt
            // 
            this.lblpamt.AutoSize = true;
            this.lblpamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblpamt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblpamt.Location = new System.Drawing.Point(635, 444);
            this.lblpamt.Name = "lblpamt";
            this.lblpamt.Size = new System.Drawing.Size(17, 18);
            this.lblpamt.TabIndex = 36;
            this.lblpamt.Text = "0";
            // 
            // lblamt
            // 
            this.lblamt.AutoSize = true;
            this.lblamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblamt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblamt.Location = new System.Drawing.Point(541, 444);
            this.lblamt.Name = "lblamt";
            this.lblamt.Size = new System.Drawing.Size(17, 18);
            this.lblamt.TabIndex = 35;
            this.lblamt.Text = "0";
            // 
            // lblqnt
            // 
            this.lblqnt.AutoSize = true;
            this.lblqnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblqnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblqnt.Location = new System.Drawing.Point(447, 444);
            this.lblqnt.Name = "lblqnt";
            this.lblqnt.Size = new System.Drawing.Size(17, 18);
            this.lblqnt.TabIndex = 34;
            this.lblqnt.Text = "0";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbltotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltotal.Location = new System.Drawing.Point(14, 17);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(14, 19);
            this.lbltotal.TabIndex = 28;
            this.lbltotal.Text = "-";
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
            this.dataGridViewTextBoxColumn2,
            this.Clientname,
            this.mobile,
            this.dataGridViewTextBoxColumn3,
            this.Pricee,
            this.dataGridViewTextBoxColumn4,
            this.status,
            this.Date});
            this.gvstockIn.DataSource = this.paymentMstBindingSource;
            this.gvstockIn.GridColor = System.Drawing.Color.CadetBlue;
            this.gvstockIn.Location = new System.Drawing.Point(12, 47);
            this.gvstockIn.Name = "gvstockIn";
            this.gvstockIn.Size = new System.Drawing.Size(945, 388);
            this.gvstockIn.TabIndex = 7;
            this.gvstockIn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvstockIn_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "BILL_NO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // Clientname
            // 
            this.Clientname.DataPropertyName = "PartyName";
            this.Clientname.Frozen = true;
            this.Clientname.HeaderText = "CLIENT_NAME";
            this.Clientname.Name = "Clientname";
            this.Clientname.ReadOnly = true;
            this.Clientname.Width = 170;
            // 
            // mobile
            // 
            this.mobile.DataPropertyName = "Mobile";
            this.mobile.Frozen = true;
            this.mobile.HeaderText = "MOBILE";
            this.mobile.Name = "mobile";
            this.mobile.ReadOnly = true;
            this.mobile.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Qnt";
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "QUANTITY";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // Pricee
            // 
            this.Pricee.DataPropertyName = "Amount";
            this.Pricee.Frozen = true;
            this.Pricee.HeaderText = "AMOUNT";
            this.Pricee.Name = "Pricee";
            this.Pricee.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PaidAmt";
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "PAID_AMT";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.Frozen = true;
            this.status.HeaderText = "STATUS";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.status.Width = 80;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "EDate";
            this.Date.Frozen = true;
            this.Date.HeaderText = "ENTRY_DATE";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 180;
            // 
            // paymentMstBindingSource
            // 
            this.paymentMstBindingSource.DataMember = "PaymentMst";
            this.paymentMstBindingSource.DataSource = this.stockDataSet;
            // 
            // stockDataSet
            // 
            this.stockDataSet.DataSetName = "StockDataSet";
            this.stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentMstTableAdapter
            // 
            this.paymentMstTableAdapter.ClearBeforeFill = true;
            // 
            // ReportPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ReportPayment";
            this.Text = "ReportPayment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvstockIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gvstockIn;
        private System.Windows.Forms.Label lblpamt;
        private System.Windows.Forms.Label lblamt;
        private System.Windows.Forms.Label lblqnt;
        private System.Windows.Forms.Label lbltotal;
        private StockDataSet stockDataSet;
        private System.Windows.Forms.BindingSource paymentMstBindingSource;
        private StockDataSetTableAdapters.PaymentMstTableAdapter paymentMstTableAdapter;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clientname;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pricee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}