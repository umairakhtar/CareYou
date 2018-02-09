namespace CareYou
{
    partial class OrderReturns
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
            this.gbreturnorder = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.caldate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnselect = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbillno = new System.Windows.Forms.TextBox();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnselectnew = new System.Windows.Forms.Button();
            this.gvorder = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gvsell = new System.Windows.Forms.DataGridView();
            this.gbreturn = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtqnt = new System.Windows.Forms.TextBox();
            this.btnreturns = new System.Windows.Forms.Button();
            this.lbliqnt = new System.Windows.Forms.Label();
            this.lbliname = new System.Windows.Forms.Label();
            this.stockDataSet = new CareYou.StockDataSet();
            this.paymentMstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentMstTableAdapter = new CareYou.StockDataSetTableAdapters.PaymentMstTableAdapter();
            this.paymentMstBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sellMstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellMstTableAdapter = new CareYou.StockDataSetTableAdapters.SellMstTableAdapter();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbreturnorder.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvsell)).BeginInit();
            this.gbreturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMstBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellMstBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbreturnorder
            // 
            this.gbreturnorder.Controls.Add(this.gbreturn);
            this.gbreturnorder.Controls.Add(this.gvsell);
            this.gbreturnorder.Controls.Add(this.label7);
            this.gbreturnorder.Controls.Add(this.label8);
            this.gbreturnorder.Controls.Add(this.gvorder);
            this.gbreturnorder.Font = new System.Drawing.Font("Calibri", 10F);
            this.gbreturnorder.Location = new System.Drawing.Point(464, 78);
            this.gbreturnorder.Name = "gbreturnorder";
            this.gbreturnorder.Size = new System.Drawing.Size(718, 518);
            this.gbreturnorder.TabIndex = 32;
            this.gbreturnorder.TabStop = false;
            this.gbreturnorder.Text = "Returns";
            this.gbreturnorder.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnselectnew);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtmobile);
            this.groupBox3.Controls.Add(this.txtbillno);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnselect);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblname);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.caldate);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox3.Location = new System.Drawing.Point(96, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 351);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Return Order";
            // 
            // caldate
            // 
            this.caldate.Location = new System.Drawing.Point(123, 240);
            this.caldate.Name = "caldate";
            this.caldate.Size = new System.Drawing.Size(154, 24);
            this.caldate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(45, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Bill Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(134, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 27);
            this.label4.TabIndex = 30;
            this.label4.Text = "OR";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblname.Location = new System.Drawing.Point(121, 215);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(24, 19);
            this.lblname.TabIndex = 23;
            this.lblname.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(173, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "--------------------";
            // 
            // btnselect
            // 
            this.btnselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnselect.ForeColor = System.Drawing.Color.White;
            this.btnselect.Location = new System.Drawing.Point(123, 80);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(97, 32);
            this.btnselect.TabIndex = 1;
            this.btnselect.Text = "SELECT";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(30, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Mobile No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(55, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Bill No :";
            // 
            // txtbillno
            // 
            this.txtbillno.BackColor = System.Drawing.Color.Honeydew;
            this.txtbillno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtbillno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbillno.Location = new System.Drawing.Point(123, 41);
            this.txtbillno.MaxLength = 10;
            this.txtbillno.Name = "txtbillno";
            this.txtbillno.Size = new System.Drawing.Size(97, 23);
            this.txtbillno.TabIndex = 0;
            this.txtbillno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbillno_KeyDown);
            this.txtbillno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbillno_KeyPress);
            // 
            // txtmobile
            // 
            this.txtmobile.BackColor = System.Drawing.Color.Honeydew;
            this.txtmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtmobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtmobile.Location = new System.Drawing.Point(123, 189);
            this.txtmobile.MaxLength = 10;
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(154, 23);
            this.txtmobile.TabIndex = 2;
            this.txtmobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmobile_KeyPress);
            this.txtmobile.Leave += new System.EventHandler(this.txtmobile_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(6, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 23);
            this.label14.TabIndex = 34;
            this.label14.Text = "--------------------";
            // 
            // btnselectnew
            // 
            this.btnselectnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnselectnew.ForeColor = System.Drawing.Color.White;
            this.btnselectnew.Location = new System.Drawing.Point(123, 285);
            this.btnselectnew.Name = "btnselectnew";
            this.btnselectnew.Size = new System.Drawing.Size(97, 32);
            this.btnselectnew.TabIndex = 4;
            this.btnselectnew.Text = "SELECT";
            this.btnselectnew.UseVisualStyleBackColor = false;
            this.btnselectnew.Click += new System.EventHandler(this.btnselectnew_Click);
            // 
            // gvorder
            // 
            this.gvorder.AllowUserToAddRows = false;
            this.gvorder.AllowUserToDeleteRows = false;
            this.gvorder.AllowUserToResizeColumns = false;
            this.gvorder.AllowUserToResizeRows = false;
            this.gvorder.AutoGenerateColumns = false;
            this.gvorder.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.gvorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvorder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PName,
            this.Type,
            this.Quntity,
            this.Price,
            this.Location,
            this.IID});
            this.gvorder.DataSource = this.paymentMstBindingSource;
            this.gvorder.GridColor = System.Drawing.Color.CadetBlue;
            this.gvorder.Location = new System.Drawing.Point(20, 43);
            this.gvorder.Name = "gvorder";
            this.gvorder.Size = new System.Drawing.Size(679, 100);
            this.gvorder.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Order Record";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sell records of above order";
            // 
            // gvsell
            // 
            this.gvsell.AllowUserToAddRows = false;
            this.gvsell.AllowUserToDeleteRows = false;
            this.gvsell.AllowUserToResizeColumns = false;
            this.gvsell.AllowUserToResizeRows = false;
            this.gvsell.AutoGenerateColumns = false;
            this.gvsell.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.gvsell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvsell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.Select,
            this.dataGridViewTextBoxColumn11});
            this.gvsell.DataSource = this.sellMstBindingSource;
            this.gvsell.GridColor = System.Drawing.Color.CadetBlue;
            this.gvsell.Location = new System.Drawing.Point(20, 183);
            this.gvsell.Name = "gvsell";
            this.gvsell.Size = new System.Drawing.Size(679, 222);
            this.gvsell.TabIndex = 33;
            this.gvsell.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvsell_CellContentClick);
            // 
            // gbreturn
            // 
            this.gbreturn.Controls.Add(this.lbliname);
            this.gbreturn.Controls.Add(this.lbliqnt);
            this.gbreturn.Controls.Add(this.btnreturns);
            this.gbreturn.Controls.Add(this.txtqnt);
            this.gbreturn.Controls.Add(this.label11);
            this.gbreturn.Controls.Add(this.label10);
            this.gbreturn.Controls.Add(this.label6);
            this.gbreturn.Location = new System.Drawing.Point(28, 411);
            this.gbreturn.Name = "gbreturn";
            this.gbreturn.Size = new System.Drawing.Size(666, 83);
            this.gbreturn.TabIndex = 34;
            this.gbreturn.TabStop = false;
            this.gbreturn.Text = "Returns Order Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(11, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Item Name :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(30, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 19);
            this.label10.TabIndex = 26;
            this.label10.Text = "Buy Qnt :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(411, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 19);
            this.label11.TabIndex = 27;
            this.label11.Text = "Input Return Qnt :";
            // 
            // txtqnt
            // 
            this.txtqnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtqnt.BackColor = System.Drawing.Color.Honeydew;
            this.txtqnt.Location = new System.Drawing.Point(548, 17);
            this.txtqnt.Name = "txtqnt";
            this.txtqnt.Size = new System.Drawing.Size(67, 24);
            this.txtqnt.TabIndex = 9;
            this.txtqnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqnt_KeyPress);
            // 
            // btnreturns
            // 
            this.btnreturns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnreturns.ForeColor = System.Drawing.Color.White;
            this.btnreturns.Location = new System.Drawing.Point(546, 43);
            this.btnreturns.Name = "btnreturns";
            this.btnreturns.Size = new System.Drawing.Size(97, 32);
            this.btnreturns.TabIndex = 25;
            this.btnreturns.Text = "RETURN";
            this.btnreturns.UseVisualStyleBackColor = false;
            this.btnreturns.Click += new System.EventHandler(this.btnreturns_Click);
            // 
            // lbliqnt
            // 
            this.lbliqnt.AutoSize = true;
            this.lbliqnt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbliqnt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbliqnt.Location = new System.Drawing.Point(100, 50);
            this.lbliqnt.Name = "lbliqnt";
            this.lbliqnt.Size = new System.Drawing.Size(19, 19);
            this.lbliqnt.TabIndex = 28;
            this.lbliqnt.Text = "--";
            // 
            // lbliname
            // 
            this.lbliname.AutoSize = true;
            this.lbliname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbliname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbliname.Location = new System.Drawing.Point(100, 24);
            this.lbliname.Name = "lbliname";
            this.lbliname.Size = new System.Drawing.Size(19, 19);
            this.lbliname.TabIndex = 29;
            this.lbliname.Text = "--";
            // 
            // stockDataSet
            // 
            this.stockDataSet.DataSetName = "StockDataSet";
            this.stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentMstBindingSource
            // 
            this.paymentMstBindingSource.DataMember = "PaymentMst";
            this.paymentMstBindingSource.DataSource = this.stockDataSet;
            // 
            // paymentMstTableAdapter
            // 
            this.paymentMstTableAdapter.ClearBeforeFill = true;
            // 
            // paymentMstBindingSource1
            // 
            this.paymentMstBindingSource1.DataMember = "PaymentMst";
            this.paymentMstBindingSource1.DataSource = this.stockDataSet;
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
            this.PName.DataPropertyName = "PartyName";
            this.PName.HeaderText = "CUSTOMER NAME";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            this.PName.Width = 180;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Qnt";
            this.Type.HeaderText = "QNT";
            this.Type.Name = "Type";
            // 
            // Quntity
            // 
            this.Quntity.DataPropertyName = "Amount";
            this.Quntity.HeaderText = "BILL AMOUNT";
            this.Quntity.Name = "Quntity";
            this.Quntity.Width = 130;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "PaidAmt";
            this.Price.HeaderText = "PAID AMT";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Status";
            this.Location.HeaderText = "BILL STATUS";
            this.Location.Name = "Location";
            this.Location.Width = 120;
            // 
            // IID
            // 
            this.IID.DataPropertyName = "ID";
            this.IID.HeaderText = "ID";
            this.IID.Name = "IID";
            this.IID.ReadOnly = true;
            this.IID.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn10.HeaderText = "COMPANY";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn6.HeaderText = "ITEM NAME";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 160;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn7.HeaderText = "TYPE";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Qnt";
            this.dataGridViewTextBoxColumn8.HeaderText = "QUANTITY";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn9.HeaderText = "PRICE";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.Text = "Select";
            this.Select.UseColumnTextForLinkValue = true;
            this.Select.Width = 75;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn11.HeaderText = "IID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // OrderReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbreturnorder);
            this.Name = "OrderReturns";
            this.Text = "OrderReturns";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderReturns_Load);
            this.gbreturnorder.ResumeLayout(false);
            this.gbreturnorder.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvsell)).EndInit();
            this.gbreturn.ResumeLayout(false);
            this.gbreturn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMstBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellMstBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbreturnorder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtbillno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker caldate;
        private System.Windows.Forms.DataGridView gvorder;
        private System.Windows.Forms.Button btnselectnew;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.GroupBox gbreturn;
        private System.Windows.Forms.Label lbliname;
        private System.Windows.Forms.Label lbliqnt;
        private System.Windows.Forms.Button btnreturns;
        private System.Windows.Forms.TextBox txtqnt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gvsell;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private StockDataSet stockDataSet;
        private System.Windows.Forms.BindingSource paymentMstBindingSource;
        private StockDataSetTableAdapters.PaymentMstTableAdapter paymentMstTableAdapter;
        private System.Windows.Forms.BindingSource paymentMstBindingSource1;
        private System.Windows.Forms.BindingSource sellMstBindingSource;
        private StockDataSetTableAdapters.SellMstTableAdapter sellMstTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private new System.Windows.Forms.DataGridViewLinkColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn IID;
    }
}