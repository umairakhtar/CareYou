namespace CareYou
{
    partial class Sell
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
            this.drpcustomer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gvsales = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.btncancle = new System.Windows.Forms.Button();
            this.lblqnt = new System.Windows.Forms.Label();
            this.lbltprice = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.drpitemname = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.drptype = new System.Windows.Forms.ComboBox();
            this.lblmobile = new System.Windows.Forms.Label();
            this.drpcompnayview = new System.Windows.Forms.ComboBox();
            this.btnselect = new System.Windows.Forms.Button();
            this.chkpaid = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnadd = new System.Windows.Forms.Button();
            this.stockDataSet = new CareYou.StockDataSet();
            this.sellMstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellMstTableAdapter = new CareYou.StockDataSetTableAdapters.SellMstTableAdapter();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.IID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lblq = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblp = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbll = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbls = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtq = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvsales)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellMstBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.txtpay);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.chkpaid);
            this.groupBox1.Controls.Add(this.btnselect);
            this.groupBox1.Controls.Add(this.drpcompnayview);
            this.groupBox1.Controls.Add(this.lblmobile);
            this.groupBox1.Controls.Add(this.drptype);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.drpitemname);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lbltprice);
            this.groupBox1.Controls.Add(this.lblqnt);
            this.groupBox1.Controls.Add(this.btncancle);
            this.groupBox1.Controls.Add(this.btnconfirm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmobile);
            this.groupBox1.Controls.Add(this.txtpname);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.gvsales);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.drpcustomer);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox1.Location = new System.Drawing.Point(320, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 555);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sell Panel";
            // 
            // drpcustomer
            // 
            this.drpcustomer.BackColor = System.Drawing.Color.Honeydew;
            this.drpcustomer.DropDownWidth = 130;
            this.drpcustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.drpcustomer.FormattingEnabled = true;
            this.drpcustomer.Location = new System.Drawing.Point(186, 481);
            this.drpcustomer.Name = "drpcustomer";
            this.drpcustomer.Size = new System.Drawing.Size(130, 23);
            this.drpcustomer.TabIndex = 6;
            this.drpcustomer.SelectedIndexChanged += new System.EventHandler(this.drpcustomer_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(54, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Customer Name :";
            // 
            // gvsales
            // 
            this.gvsales.AllowUserToAddRows = false;
            this.gvsales.AllowUserToDeleteRows = false;
            this.gvsales.AllowUserToResizeColumns = false;
            this.gvsales.AllowUserToResizeRows = false;
            this.gvsales.AutoGenerateColumns = false;
            this.gvsales.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.gvsales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvsales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PName,
            this.Price,
            this.Quntity,
            this.TotalPrice,
            this.Remove,
            this.IID});
            this.gvsales.DataSource = this.sellMstBindingSource;
            this.gvsales.GridColor = System.Drawing.Color.CadetBlue;
            this.gvsales.Location = new System.Drawing.Point(58, 149);
            this.gvsales.Name = "gvsales";
            this.gvsales.Size = new System.Drawing.Size(624, 293);
            this.gvsales.TabIndex = 4;
            this.gvsales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvsales_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(56, 517);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 19);
            this.label12.TabIndex = 22;
            this.label12.Text = "New :";
            // 
            // txtpname
            // 
            this.txtpname.BackColor = System.Drawing.Color.Honeydew;
            this.txtpname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtpname.Location = new System.Drawing.Point(105, 516);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(130, 23);
            this.txtpname.TabIndex = 11;
            this.txtpname.Text = "Enter Name";
            this.txtpname.Enter += new System.EventHandler(this.txtpname_Enter);
            this.txtpname.Leave += new System.EventHandler(this.txtpname_Leave);
            // 
            // txtmobile
            // 
            this.txtmobile.BackColor = System.Drawing.Color.Honeydew;
            this.txtmobile.Location = new System.Drawing.Point(242, 515);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(130, 24);
            this.txtmobile.TabIndex = 12;
            this.txtmobile.Text = "Enter Mobile";
            this.txtmobile.Enter += new System.EventHandler(this.txtmobile_Enter);
            this.txtmobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmobile_KeyPress);
            this.txtmobile.Leave += new System.EventHandler(this.txtmobile_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(463, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pay :";
            // 
            // btnconfirm
            // 
            this.btnconfirm.BackColor = System.Drawing.Color.Green;
            this.btnconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnconfirm.ForeColor = System.Drawing.Color.White;
            this.btnconfirm.Location = new System.Drawing.Point(503, 511);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(109, 35);
            this.btnconfirm.TabIndex = 9;
            this.btnconfirm.Text = "CONFIRM";
            this.btnconfirm.UseVisualStyleBackColor = false;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // btncancle
            // 
            this.btncancle.BackColor = System.Drawing.Color.OrangeRed;
            this.btncancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btncancle.ForeColor = System.Drawing.Color.White;
            this.btncancle.Location = new System.Drawing.Point(613, 510);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(109, 35);
            this.btncancle.TabIndex = 10;
            this.btncancle.Text = "CANCEL";
            this.btncancle.UseVisualStyleBackColor = false;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // lblqnt
            // 
            this.lblqnt.AutoSize = true;
            this.lblqnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblqnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblqnt.Location = new System.Drawing.Point(408, 445);
            this.lblqnt.Name = "lblqnt";
            this.lblqnt.Size = new System.Drawing.Size(15, 15);
            this.lblqnt.TabIndex = 28;
            this.lblqnt.Text = "0";
            // 
            // lbltprice
            // 
            this.lbltprice.AutoSize = true;
            this.lbltprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbltprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbltprice.Location = new System.Drawing.Point(511, 445);
            this.lbltprice.Name = "lbltprice";
            this.lbltprice.Size = new System.Drawing.Size(15, 15);
            this.lbltprice.TabIndex = 29;
            this.lbltprice.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(338, 445);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "TOTAL =";
            // 
            // drpitemname
            // 
            this.drpitemname.BackColor = System.Drawing.Color.Honeydew;
            this.drpitemname.Enabled = false;
            this.drpitemname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.drpitemname.FormattingEnabled = true;
            this.drpitemname.Location = new System.Drawing.Point(265, 19);
            this.drpitemname.Name = "drpitemname";
            this.drpitemname.Size = new System.Drawing.Size(153, 23);
            this.drpitemname.TabIndex = 2;
            this.drpitemname.SelectedIndexChanged += new System.EventHandler(this.drpitemname_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 459);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(715, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "_________________________________________________________________________________" +
    "____________________";
            // 
            // drptype
            // 
            this.drptype.BackColor = System.Drawing.Color.Honeydew;
            this.drptype.Enabled = false;
            this.drptype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.drptype.FormattingEnabled = true;
            this.drptype.Location = new System.Drawing.Point(428, 19);
            this.drptype.Name = "drptype";
            this.drptype.Size = new System.Drawing.Size(153, 23);
            this.drptype.TabIndex = 3;
            this.drptype.SelectedIndexChanged += new System.EventHandler(this.drptype_SelectedIndexChanged);
            // 
            // lblmobile
            // 
            this.lblmobile.AutoSize = true;
            this.lblmobile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblmobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblmobile.Location = new System.Drawing.Point(322, 485);
            this.lblmobile.Name = "lblmobile";
            this.lblmobile.Size = new System.Drawing.Size(19, 19);
            this.lblmobile.TabIndex = 32;
            this.lblmobile.Text = "--";
            // 
            // drpcompnayview
            // 
            this.drpcompnayview.BackColor = System.Drawing.Color.Honeydew;
            this.drpcompnayview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.drpcompnayview.FormattingEnabled = true;
            this.drpcompnayview.Location = new System.Drawing.Point(103, 19);
            this.drpcompnayview.Name = "drpcompnayview";
            this.drpcompnayview.Size = new System.Drawing.Size(153, 23);
            this.drpcompnayview.TabIndex = 1;
            this.drpcompnayview.SelectedIndexChanged += new System.EventHandler(this.drpcompnayview_SelectedIndexChanged);
            // 
            // btnselect
            // 
            this.btnselect.Enabled = false;
            this.btnselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnselect.ForeColor = System.Drawing.Color.White;
            this.btnselect.Location = new System.Drawing.Point(587, 81);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(97, 45);
            this.btnselect.TabIndex = 5;
            this.btnselect.Text = "ADD";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // chkpaid
            // 
            this.chkpaid.AutoSize = true;
            this.chkpaid.Checked = true;
            this.chkpaid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkpaid.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.chkpaid.Location = new System.Drawing.Point(587, 480);
            this.chkpaid.Name = "chkpaid";
            this.chkpaid.Size = new System.Drawing.Size(52, 21);
            this.chkpaid.TabIndex = 8;
            this.chkpaid.Text = "Paid";
            this.chkpaid.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(18, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Company :";
            // 
            // txtpay
            // 
            this.txtpay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpay.BackColor = System.Drawing.Color.Honeydew;
            this.txtpay.Location = new System.Drawing.Point(503, 478);
            this.txtpay.Name = "txtpay";
            this.txtpay.Size = new System.Drawing.Size(78, 24);
            this.txtpay.TabIndex = 7;
            this.txtpay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpay_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.88598F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.11426F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.31987F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.66831F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.44004F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.57153F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblq, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblp, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtdiscount, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbll, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbls, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtq, 5, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(98, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(483, 70);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(377, 514);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(67, 27);
            this.btnadd.TabIndex = 13;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
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
            // PName
            // 
            this.PName.DataPropertyName = "ItemName";
            this.PName.HeaderText = "ITEM NAME";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            this.PName.Width = 160;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "PRICE";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quntity
            // 
            this.Quntity.DataPropertyName = "qnt";
            this.Quntity.HeaderText = "QUANTITY";
            this.Quntity.Name = "Quntity";
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "totalprice";
            this.TotalPrice.HeaderText = "TOTAL PRICE";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 120;
            // 
            // Remove
            // 
            this.Remove.DataPropertyName = "Remove";
            this.Remove.HeaderText = "Remove";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Text = "Remove";
            this.Remove.ToolTipText = "Remove Item Record";
            this.Remove.UseColumnTextForLinkValue = true;
            // 
            // IID
            // 
            this.IID.DataPropertyName = "ID";
            this.IID.HeaderText = "IID";
            this.IID.Name = "IID";
            this.IID.ReadOnly = true;
            this.IID.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(39, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Qnt :";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblq
            // 
            this.lblq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblq.AutoSize = true;
            this.lblq.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblq.ForeColor = System.Drawing.Color.Honeydew;
            this.lblq.Location = new System.Drawing.Point(90, 8);
            this.lblq.Name = "lblq";
            this.lblq.Size = new System.Drawing.Size(17, 19);
            this.lblq.TabIndex = 19;
            this.lblq.Text = "0";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(69)))), ((int)(((byte)(39)))));
            this.linkLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 5);
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(185, 8);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(43, 19);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Price";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblp
            // 
            this.lblp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblp.AutoSize = true;
            this.lblp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblp.ForeColor = System.Drawing.Color.Honeydew;
            this.lblp.Location = new System.Drawing.Point(254, 8);
            this.lblp.Name = "lblp";
            this.lblp.Size = new System.Drawing.Size(17, 19);
            this.lblp.TabIndex = 20;
            this.lblp.Text = "0";
            this.lblp.Visible = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(331, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 32);
            this.label11.TabIndex = 24;
            this.label11.Text = "Discount :";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdiscount.BackColor = System.Drawing.Color.Honeydew;
            this.txtdiscount.Location = new System.Drawing.Point(414, 6);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(62, 24);
            this.txtdiscount.TabIndex = 0;
            this.txtdiscount.Text = "0";
            this.txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiscount_KeyPress);
            this.txtdiscount.Leave += new System.EventHandler(this.txtdiscount_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(7, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Location :";
            // 
            // lbll
            // 
            this.lbll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbll.AutoSize = true;
            this.lbll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbll.ForeColor = System.Drawing.Color.Honeydew;
            this.lbll.Location = new System.Drawing.Point(90, 42);
            this.lbll.Name = "lbll";
            this.lbll.Size = new System.Drawing.Size(14, 19);
            this.lbll.TabIndex = 21;
            this.lbll.Text = "-";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(171, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "SellPrice :";
            // 
            // lbls
            // 
            this.lbls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbls.BackColor = System.Drawing.Color.Honeydew;
            this.lbls.Location = new System.Drawing.Point(254, 40);
            this.lbls.Name = "lbls";
            this.lbls.Size = new System.Drawing.Size(67, 24);
            this.lbls.TabIndex = 0;
            this.lbls.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbls_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(337, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "SellQnt :";
            // 
            // txtq
            // 
            this.txtq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtq.BackColor = System.Drawing.Color.Honeydew;
            this.txtq.Location = new System.Drawing.Point(414, 40);
            this.txtq.Name = "txtq";
            this.txtq.Size = new System.Drawing.Size(62, 24);
            this.txtq.TabIndex = 4;
            this.txtq.Text = "1";
            this.txtq.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtq_KeyDown);
            this.txtq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtq_KeyPress);
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sell";
            this.Text = "Sell";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sell_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvsales)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellMstBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox drpcustomer;
        private System.Windows.Forms.DataGridView gvsales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtpay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkpaid;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.ComboBox drpcompnayview;
        private System.Windows.Forms.Label lblmobile;
        private System.Windows.Forms.ComboBox drptype;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox drpitemname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbltprice;
        private System.Windows.Forms.Label lblqnt;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.Label label12;
        private StockDataSet stockDataSet;
        private System.Windows.Forms.BindingSource sellMstBindingSource;
        private StockDataSetTableAdapters.SellMstTableAdapter sellMstTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewLinkColumn Remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn IID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblq;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbll;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lbls;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtq;
    }
}