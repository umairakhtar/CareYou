namespace CareYou
{
    partial class ReportStockReturn
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
            this.GvReport = new System.Windows.Forms.DataGridView();
            this.lbltotal = new System.Windows.Forms.Label();
            this.stockDataSet = new CareYou.StockDataSet();
            this.stockReturnMstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockReturnMstTableAdapter = new CareYou.StockDataSetTableAdapters.StockReturnMstTableAdapter();
            this.Companyname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pricee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drpcompnayview = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnselect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkapply = new System.Windows.Forms.CheckBox();
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockReturnMstBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBox1.Location = new System.Drawing.Point(262, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 107);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Alert Report";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbltotal);
            this.groupBox2.Controls.Add(this.GvReport);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox2.Location = new System.Drawing.Point(234, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(903, 421);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Result";
            // 
            // GvReport
            // 
            this.GvReport.AllowUserToAddRows = false;
            this.GvReport.AllowUserToDeleteRows = false;
            this.GvReport.AllowUserToResizeColumns = false;
            this.GvReport.AllowUserToResizeRows = false;
            this.GvReport.AutoGenerateColumns = false;
            this.GvReport.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.GvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Companyname,
            this.dataGridViewTextBoxColumn1,
            this.type,
            this.dataGridViewTextBoxColumn3,
            this.Pricee,
            this.Date});
            this.GvReport.DataSource = this.stockReturnMstBindingSource;
            this.GvReport.GridColor = System.Drawing.Color.CadetBlue;
            this.GvReport.Location = new System.Drawing.Point(12, 57);
            this.GvReport.Name = "GvReport";
            this.GvReport.Size = new System.Drawing.Size(877, 353);
            this.GvReport.TabIndex = 7;
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
            // Companyname
            // 
            this.Companyname.DataPropertyName = "Company";
            this.Companyname.HeaderText = "COMPANY NAME";
            this.Companyname.Name = "Companyname";
            this.Companyname.Width = 170;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn1.HeaderText = "ITEM NAME";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 160;
            // 
            // type
            // 
            this.type.DataPropertyName = "Type";
            this.type.HeaderText = "TYPE";
            this.type.Name = "type";
            this.type.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Qnt";
            this.dataGridViewTextBoxColumn3.HeaderText = "QUANTITY";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Pricee
            // 
            this.Pricee.DataPropertyName = "Price";
            this.Pricee.HeaderText = "PRICE";
            this.Pricee.Name = "Pricee";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "EDate";
            this.Date.HeaderText = "RETURN_DATE";
            this.Date.Name = "Date";
            this.Date.Width = 180;
            // 
            // drpcompnayview
            // 
            this.drpcompnayview.BackColor = System.Drawing.Color.Honeydew;
            this.drpcompnayview.DropDownWidth = 153;
            this.drpcompnayview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.drpcompnayview.FormattingEnabled = true;
            this.drpcompnayview.Location = new System.Drawing.Point(193, 72);
            this.drpcompnayview.Name = "drpcompnayview";
            this.drpcompnayview.Size = new System.Drawing.Size(153, 24);
            this.drpcompnayview.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtname.BackColor = System.Drawing.Color.Honeydew;
            this.txtname.Location = new System.Drawing.Point(193, 28);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(153, 23);
            this.txtname.TabIndex = 1;
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtname_KeyDown);
            // 
            // btnselect
            // 
            this.btnselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnselect.ForeColor = System.Drawing.Color.White;
            this.btnselect.Location = new System.Drawing.Point(352, 67);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(97, 35);
            this.btnselect.TabIndex = 5;
            this.btnselect.Text = "SEARCH";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(95, 28);
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
            this.label2.Location = new System.Drawing.Point(120, 54);
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
            this.label3.Location = new System.Drawing.Point(522, 32);
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
            this.label4.Location = new System.Drawing.Point(541, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "To Date :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(106, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Company :";
            // 
            // chkapply
            // 
            this.chkapply.AutoSize = true;
            this.chkapply.Font = new System.Drawing.Font("Calibri", 10F);
            this.chkapply.Location = new System.Drawing.Point(616, 86);
            this.chkapply.Name = "chkapply";
            this.chkapply.Size = new System.Drawing.Size(58, 21);
            this.chkapply.TabIndex = 32;
            this.chkapply.Text = "Apply";
            this.chkapply.UseVisualStyleBackColor = true;
            // 
            // fromdate
            // 
            this.fromdate.Location = new System.Drawing.Point(616, 32);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(163, 23);
            this.fromdate.TabIndex = 33;
            // 
            // todate
            // 
            this.todate.Location = new System.Drawing.Point(616, 59);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(163, 23);
            this.todate.TabIndex = 34;
            // 
            // ReportStockReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ReportStockReturn";
            this.Text = "ReportStockReturn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportStockReturn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockReturnMstBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DataGridView GvReport;
        private StockDataSet stockDataSet;
        private System.Windows.Forms.BindingSource stockReturnMstBindingSource;
        private StockDataSetTableAdapters.StockReturnMstTableAdapter stockReturnMstTableAdapter;
        private System.Windows.Forms.DateTimePicker todate;
        private System.Windows.Forms.DateTimePicker fromdate;
        private System.Windows.Forms.CheckBox chkapply;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox drpcompnayview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Companyname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pricee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}