namespace CareYou
{
    partial class CompanyPayment
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblbamt = new System.Windows.Forms.Label();
            this.lblsbox = new System.Windows.Forms.Label();
            this.lblsamt = new System.Windows.Forms.Label();
            this.lblsitem = new System.Windows.Forms.Label();
            this.GvBillPayment = new System.Windows.Forms.DataGridView();
            this.IDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deletee = new System.Windows.Forms.DataGridViewLinkColumn();
            this.billPaymentMstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockDataSet = new CareYou.StockDataSet();
            this.btnsearch = new System.Windows.Forms.Button();
            this.drpcompanysearch = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Gvpayment = new System.Windows.Forms.DataGridView();
            this.IDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScaleA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScaleB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.comPaymentMstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbillno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.drpcompnay = new System.Windows.Forms.ComboBox();
            this.caldate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnadddetail = new System.Windows.Forms.Button();
            this.txtbillamt = new System.Windows.Forms.TextBox();
            this.txtitems = new System.Windows.Forms.TextBox();
            this.txtcarttons = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtamtpaidd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblupadate = new System.Windows.Forms.Button();
            this.lblpaidamt = new System.Windows.Forms.Label();
            this.chkpaidedit = new System.Windows.Forms.CheckBox();
            this.lblbillamt = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.txtbillview = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.drptype = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.drpcomppayment = new System.Windows.Forms.ComboBox();
            this.calpayamt = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnddpayent = new System.Windows.Forms.Button();
            this.txtamtpay = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comPaymentMstTableAdapter = new CareYou.StockDataSetTableAdapters.ComPaymentMstTableAdapter();
            this.billPaymentMstTableAdapter = new CareYou.StockDataSetTableAdapters.BillPaymentMstTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvBillPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPaymentMstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gvpayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comPaymentMstBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox2.Controls.Add(this.lblbamt);
            this.groupBox2.Controls.Add(this.lblsbox);
            this.groupBox2.Controls.Add(this.lblsamt);
            this.groupBox2.Controls.Add(this.lblsitem);
            this.groupBox2.Controls.Add(this.GvBillPayment);
            this.groupBox2.Controls.Add(this.btnsearch);
            this.groupBox2.Controls.Add(this.drpcompanysearch);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Gvpayment);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(317, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1026, 550);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Report";
            // 
            // lblbamt
            // 
            this.lblbamt.AutoSize = true;
            this.lblbamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblbamt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblbamt.Location = new System.Drawing.Point(729, 521);
            this.lblbamt.Name = "lblbamt";
            this.lblbamt.Size = new System.Drawing.Size(17, 18);
            this.lblbamt.TabIndex = 18;
            this.lblbamt.Text = "0";
            // 
            // lblsbox
            // 
            this.lblsbox.AutoSize = true;
            this.lblsbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblsbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblsbox.Location = new System.Drawing.Point(212, 522);
            this.lblsbox.Name = "lblsbox";
            this.lblsbox.Size = new System.Drawing.Size(17, 18);
            this.lblsbox.TabIndex = 8;
            this.lblsbox.Text = "0";
            // 
            // lblsamt
            // 
            this.lblsamt.AutoSize = true;
            this.lblsamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblsamt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblsamt.Location = new System.Drawing.Point(328, 522);
            this.lblsamt.Name = "lblsamt";
            this.lblsamt.Size = new System.Drawing.Size(17, 18);
            this.lblsamt.TabIndex = 17;
            this.lblsamt.Text = "0";
            // 
            // lblsitem
            // 
            this.lblsitem.AutoSize = true;
            this.lblsitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblsitem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblsitem.Location = new System.Drawing.Point(265, 523);
            this.lblsitem.Name = "lblsitem";
            this.lblsitem.Size = new System.Drawing.Size(17, 18);
            this.lblsitem.TabIndex = 16;
            this.lblsitem.Text = "0";
            // 
            // GvBillPayment
            // 
            this.GvBillPayment.AutoGenerateColumns = false;
            this.GvBillPayment.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.GvBillPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvBillPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDI,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Deletee});
            this.GvBillPayment.DataSource = this.billPaymentMstBindingSource;
            this.GvBillPayment.Location = new System.Drawing.Point(585, 55);
            this.GvBillPayment.Name = "GvBillPayment";
            this.GvBillPayment.Size = new System.Drawing.Size(433, 463);
            this.GvBillPayment.TabIndex = 15;
            this.GvBillPayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvBillPayment_CellContentClick);
            // 
            // IDI
            // 
            this.IDI.DataPropertyName = "ID";
            this.IDI.HeaderText = "ID";
            this.IDI.Name = "IDI";
            this.IDI.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CompanyName";
            this.dataGridViewTextBoxColumn1.HeaderText = "COMPANY";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn2.HeaderText = "AMOUNT";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn3.HeaderText = "TYPE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PaymentDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "DATE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // Deletee
            // 
            this.Deletee.HeaderText = "Delete";
            this.Deletee.Name = "Deletee";
            this.Deletee.Text = "Del";
            this.Deletee.UseColumnTextForLinkValue = true;
            this.Deletee.Width = 50;
            // 
            // billPaymentMstBindingSource
            // 
            this.billPaymentMstBindingSource.DataMember = "BillPaymentMst";
            this.billPaymentMstBindingSource.DataSource = this.stockDataSet;
            // 
            // stockDataSet
            // 
            this.stockDataSet.DataSetName = "StockDataSet";
            this.stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(507, 19);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(121, 33);
            this.btnsearch.TabIndex = 13;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // drpcompanysearch
            // 
            this.drpcompanysearch.BackColor = System.Drawing.Color.Honeydew;
            this.drpcompanysearch.DropDownWidth = 154;
            this.drpcompanysearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.drpcompanysearch.FormattingEnabled = true;
            this.drpcompanysearch.Location = new System.Drawing.Point(347, 23);
            this.drpcompanysearch.Name = "drpcompanysearch";
            this.drpcompanysearch.Size = new System.Drawing.Size(154, 23);
            this.drpcompanysearch.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(197, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Company Name :";
            // 
            // Gvpayment
            // 
            this.Gvpayment.AutoGenerateColumns = false;
            this.Gvpayment.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.Gvpayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gvpayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDD,
            this.ID,
            this.ScaleA,
            this.ScaleB,
            this.Price,
            this.Scale,
            this.Date,
            this.Delete});
            this.Gvpayment.DataSource = this.comPaymentMstBindingSource;
            this.Gvpayment.Location = new System.Drawing.Point(6, 58);
            this.Gvpayment.Name = "Gvpayment";
            this.Gvpayment.Size = new System.Drawing.Size(573, 461);
            this.Gvpayment.TabIndex = 14;
            this.Gvpayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gvpayment_CellContentClick);
            // 
            // IDD
            // 
            this.IDD.DataPropertyName = "ID";
            this.IDD.HeaderText = "ID";
            this.IDD.Name = "IDD";
            this.IDD.ReadOnly = true;
            this.IDD.Visible = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "BillNo";
            this.ID.HeaderText = "BILLNO";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 70;
            // 
            // ScaleA
            // 
            this.ScaleA.DataPropertyName = "Company";
            this.ScaleA.HeaderText = "Company";
            this.ScaleA.Name = "ScaleA";
            this.ScaleA.ReadOnly = true;
            this.ScaleA.Width = 110;
            // 
            // ScaleB
            // 
            this.ScaleB.DataPropertyName = "Boxes";
            this.ScaleB.HeaderText = "Boxes";
            this.ScaleB.Name = "ScaleB";
            this.ScaleB.ReadOnly = true;
            this.ScaleB.Width = 50;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Items";
            this.Price.HeaderText = "Items";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 60;
            // 
            // Scale
            // 
            this.Scale.DataPropertyName = "Amt";
            this.Scale.HeaderText = "Bill Amt";
            this.Scale.Name = "Scale";
            this.Scale.ReadOnly = true;
            this.Scale.Width = 80;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Edate";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 110;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Del";
            this.Delete.UseColumnTextForLinkValue = true;
            this.Delete.Width = 50;
            // 
            // comPaymentMstBindingSource
            // 
            this.comPaymentMstBindingSource.DataMember = "ComPaymentMst";
            this.comPaymentMstBindingSource.DataSource = this.stockDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Controls.Add(this.txtbillno);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.drpcompnay);
            this.groupBox1.Controls.Add(this.caldate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnadddetail);
            this.groupBox1.Controls.Add(this.txtbillamt);
            this.groupBox1.Controls.Add(this.txtitems);
            this.groupBox1.Controls.Add(this.txtcarttons);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(18, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 271);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill Entry";
            // 
            // txtbillno
            // 
            this.txtbillno.BackColor = System.Drawing.Color.Honeydew;
            this.txtbillno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtbillno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbillno.Location = new System.Drawing.Point(117, 58);
            this.txtbillno.MaxLength = 10;
            this.txtbillno.Name = "txtbillno";
            this.txtbillno.Size = new System.Drawing.Size(88, 23);
            this.txtbillno.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(44, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Bill No :";
            // 
            // drpcompnay
            // 
            this.drpcompnay.BackColor = System.Drawing.Color.Honeydew;
            this.drpcompnay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.drpcompnay.FormattingEnabled = true;
            this.drpcompnay.Location = new System.Drawing.Point(117, 26);
            this.drpcompnay.Name = "drpcompnay";
            this.drpcompnay.Size = new System.Drawing.Size(154, 26);
            this.drpcompnay.TabIndex = 1;
            // 
            // caldate
            // 
            this.caldate.CalendarForeColor = System.Drawing.Color.Red;
            this.caldate.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.caldate.Location = new System.Drawing.Point(113, 179);
            this.caldate.Name = "caldate";
            this.caldate.Size = new System.Drawing.Size(154, 24);
            this.caldate.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(51, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Date :";
            // 
            // btnadddetail
            // 
            this.btnadddetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnadddetail.ForeColor = System.Drawing.Color.White;
            this.btnadddetail.Location = new System.Drawing.Point(113, 211);
            this.btnadddetail.Name = "btnadddetail";
            this.btnadddetail.Size = new System.Drawing.Size(134, 40);
            this.btnadddetail.TabIndex = 9;
            this.btnadddetail.Text = "ADD DETAIL";
            this.btnadddetail.UseVisualStyleBackColor = false;
            this.btnadddetail.Click += new System.EventHandler(this.btnadddetail_Click);
            // 
            // txtbillamt
            // 
            this.txtbillamt.BackColor = System.Drawing.Color.Honeydew;
            this.txtbillamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtbillamt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbillamt.Location = new System.Drawing.Point(117, 150);
            this.txtbillamt.MaxLength = 10;
            this.txtbillamt.Name = "txtbillamt";
            this.txtbillamt.Size = new System.Drawing.Size(88, 23);
            this.txtbillamt.TabIndex = 5;
            this.txtbillamt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbillamt_KeyPress);
            // 
            // txtitems
            // 
            this.txtitems.BackColor = System.Drawing.Color.Honeydew;
            this.txtitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtitems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtitems.Location = new System.Drawing.Point(117, 119);
            this.txtitems.Name = "txtitems";
            this.txtitems.Size = new System.Drawing.Size(88, 23);
            this.txtitems.TabIndex = 4;
            // 
            // txtcarttons
            // 
            this.txtcarttons.BackColor = System.Drawing.Color.Honeydew;
            this.txtcarttons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtcarttons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtcarttons.Location = new System.Drawing.Point(117, 88);
            this.txtcarttons.Name = "txtcarttons";
            this.txtcarttons.Size = new System.Drawing.Size(88, 23);
            this.txtcarttons.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(33, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bill Amt :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(21, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cartoons :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(49, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Items :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(-2, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "COMPANY PAYMENT";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btndelete);
            this.groupBox3.Controls.Add(this.btnview);
            this.groupBox3.Controls.Add(this.txtbillview);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(946, 656);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 206);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bill Payment";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtamtpaidd);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lblupadate);
            this.groupBox4.Controls.Add(this.lblpaidamt);
            this.groupBox4.Controls.Add(this.chkpaidedit);
            this.groupBox4.Controls.Add(this.lblbillamt);
            this.groupBox4.Location = new System.Drawing.Point(33, 62);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(330, 86);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "-";
            this.groupBox4.Visible = false;
            // 
            // txtamtpaidd
            // 
            this.txtamtpaidd.BackColor = System.Drawing.Color.Honeydew;
            this.txtamtpaidd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtamtpaidd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtamtpaidd.Location = new System.Drawing.Point(80, 55);
            this.txtamtpaidd.MaxLength = 10;
            this.txtamtpaidd.Name = "txtamtpaidd";
            this.txtamtpaidd.Size = new System.Drawing.Size(75, 23);
            this.txtamtpaidd.TabIndex = 100;
            this.txtamtpaidd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtamtpaidd_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = " Amt : ";
            // 
            // lblupadate
            // 
            this.lblupadate.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblupadate.ForeColor = System.Drawing.Color.White;
            this.lblupadate.Location = new System.Drawing.Point(239, 52);
            this.lblupadate.Name = "lblupadate";
            this.lblupadate.Size = new System.Drawing.Size(77, 26);
            this.lblupadate.TabIndex = 102;
            this.lblupadate.Text = "Update";
            this.lblupadate.UseVisualStyleBackColor = false;
            // 
            // lblpaidamt
            // 
            this.lblpaidamt.AutoSize = true;
            this.lblpaidamt.Location = new System.Drawing.Point(167, 20);
            this.lblpaidamt.Name = "lblpaidamt";
            this.lblpaidamt.Size = new System.Drawing.Size(54, 17);
            this.lblpaidamt.TabIndex = 4;
            this.lblpaidamt.Text = "label12";
            // 
            // chkpaidedit
            // 
            this.chkpaidedit.AutoSize = true;
            this.chkpaidedit.Checked = true;
            this.chkpaidedit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkpaidedit.Location = new System.Drawing.Point(181, 55);
            this.chkpaidedit.Name = "chkpaidedit";
            this.chkpaidedit.Size = new System.Drawing.Size(55, 21);
            this.chkpaidedit.TabIndex = 101;
            this.chkpaidedit.Text = "Paid";
            this.chkpaidedit.UseVisualStyleBackColor = true;
            // 
            // lblbillamt
            // 
            this.lblbillamt.AutoSize = true;
            this.lblbillamt.Location = new System.Drawing.Point(23, 19);
            this.lblbillamt.Name = "lblbillamt";
            this.lblbillamt.Size = new System.Drawing.Size(54, 17);
            this.lblbillamt.TabIndex = 0;
            this.lblbillamt.Text = "label12";
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btndelete.ForeColor = System.Drawing.Color.Yellow;
            this.btndelete.Location = new System.Drawing.Point(265, 20);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(88, 30);
            this.btndelete.TabIndex = 16;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnview
            // 
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnview.ForeColor = System.Drawing.Color.White;
            this.btnview.Location = new System.Drawing.Point(182, 20);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(77, 30);
            this.btnview.TabIndex = 15;
            this.btnview.Text = "VIEW";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // txtbillview
            // 
            this.txtbillview.BackColor = System.Drawing.Color.Honeydew;
            this.txtbillview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtbillview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbillview.Location = new System.Drawing.Point(87, 23);
            this.txtbillview.MaxLength = 10;
            this.txtbillview.Name = "txtbillview";
            this.txtbillview.Size = new System.Drawing.Size(88, 23);
            this.txtbillview.TabIndex = 14;
            this.txtbillview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbillview_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(15, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 20);
            this.label11.TabIndex = 0;
            this.label11.Tag = "16";
            this.label11.Text = "Bill No :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.drptype);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.drpcomppayment);
            this.groupBox5.Controls.Add(this.calpayamt);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.btnddpayent);
            this.groupBox5.Controls.Add(this.txtamtpay);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox5.Location = new System.Drawing.Point(15, 409);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(284, 219);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bill Payment";
            // 
            // drptype
            // 
            this.drptype.BackColor = System.Drawing.Color.Honeydew;
            this.drptype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.drptype.FormattingEnabled = true;
            this.drptype.Items.AddRange(new object[] {
            "SELECT",
            "CASH",
            "CHECK"});
            this.drptype.Location = new System.Drawing.Point(116, 89);
            this.drptype.Name = "drptype";
            this.drptype.Size = new System.Drawing.Size(89, 23);
            this.drptype.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(58, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "Type :";
            // 
            // drpcomppayment
            // 
            this.drpcomppayment.BackColor = System.Drawing.Color.Honeydew;
            this.drpcomppayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.drpcomppayment.FormattingEnabled = true;
            this.drpcomppayment.Location = new System.Drawing.Point(117, 23);
            this.drpcomppayment.Name = "drpcomppayment";
            this.drpcomppayment.Size = new System.Drawing.Size(154, 23);
            this.drpcomppayment.TabIndex = 11;
            // 
            // calpayamt
            // 
            this.calpayamt.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.calpayamt.CalendarForeColor = System.Drawing.Color.Red;
            this.calpayamt.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.calpayamt.Location = new System.Drawing.Point(117, 120);
            this.calpayamt.Name = "calpayamt";
            this.calpayamt.Size = new System.Drawing.Size(154, 24);
            this.calpayamt.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(53, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Date :";
            // 
            // btnddpayent
            // 
            this.btnddpayent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnddpayent.ForeColor = System.Drawing.Color.White;
            this.btnddpayent.Location = new System.Drawing.Point(117, 155);
            this.btnddpayent.Name = "btnddpayent";
            this.btnddpayent.Size = new System.Drawing.Size(150, 40);
            this.btnddpayent.TabIndex = 15;
            this.btnddpayent.Text = "ADD PAYMENT";
            this.btnddpayent.UseVisualStyleBackColor = false;
            this.btnddpayent.Click += new System.EventHandler(this.btnddpayent_Click);
            // 
            // txtamtpay
            // 
            this.txtamtpay.BackColor = System.Drawing.Color.Honeydew;
            this.txtamtpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtamtpay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtamtpay.Location = new System.Drawing.Point(117, 56);
            this.txtamtpay.MaxLength = 10;
            this.txtamtpay.Name = "txtamtpay";
            this.txtamtpay.Size = new System.Drawing.Size(88, 23);
            this.txtamtpay.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(37, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Bill Amt :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(24, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "Company :";
            // 
            // comPaymentMstTableAdapter
            // 
            this.comPaymentMstTableAdapter.ClearBeforeFill = true;
            // 
            // billPaymentMstTableAdapter
            // 
            this.billPaymentMstTableAdapter.ClearBeforeFill = true;
            // 
            // CompanyPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "CompanyPayment";
            this.Text = "CompanyPayment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CompanyPayment_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvBillPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billPaymentMstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gvpayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comPaymentMstBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Gvpayment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblbamt;
        private System.Windows.Forms.Label lblsbox;
        private System.Windows.Forms.Label lblsamt;
        private System.Windows.Forms.Label lblsitem;
        private System.Windows.Forms.DataGridView GvBillPayment;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.ComboBox drpcompanysearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbillno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox drpcompnay;
        private System.Windows.Forms.DateTimePicker caldate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnadddetail;
        private System.Windows.Forms.TextBox txtbillamt;
        private System.Windows.Forms.TextBox txtitems;
        private System.Windows.Forms.TextBox txtcarttons;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtamtpaidd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button lblupadate;
        private System.Windows.Forms.Label lblpaidamt;
        private System.Windows.Forms.CheckBox chkpaidedit;
        private System.Windows.Forms.Label lblbillamt;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.TextBox txtbillview;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox drptype;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox drpcomppayment;
        private System.Windows.Forms.DateTimePicker calpayamt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnddpayent;
        private System.Windows.Forms.TextBox txtamtpay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private StockDataSet stockDataSet;
        private System.Windows.Forms.BindingSource comPaymentMstBindingSource;
        private StockDataSetTableAdapters.ComPaymentMstTableAdapter comPaymentMstTableAdapter;
        private System.Windows.Forms.BindingSource billPaymentMstBindingSource;
        private StockDataSetTableAdapters.BillPaymentMstTableAdapter billPaymentMstTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDI;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewLinkColumn Deletee;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScaleA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScaleB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Scale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}