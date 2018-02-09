using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareYou
{
    public partial class ReportStockIn : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
        public ReportStockIn()
        {
            InitializeComponent();
        }

        private void ReportStockIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDataSet.StockInMst' table. You can move, or remove it, as needed.
            this.stockInMstTableAdapter.Fill(this.stockDataSet.StockInMst);
            this.con.Open();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM CompanyMst", this.con);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter.Fill(dataTable);
            this.drpcompnayview.DataSource = (object)dataTable;
            this.drpcompnayview.DisplayMember = "Companyname";
            this.drpcompnayview.ValueMember = "id";
            this.drpcompnayview.Text = "SELECT";
            OleDbDataReader oleDbDataReader = new OleDbCommand("select itemname from stockmst", this.con).ExecuteReader();
            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
            while (oleDbDataReader.Read())
            stringCollection.Add(oleDbDataReader.GetString(0));
            this.txtname.AutoCompleteCustomSource = stringCollection;
            this.gvstockIn.RowsDefaultCellStyle.BackColor = Color.White;
            this.gvstockIn.AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose;
            this.con.Close();
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            if (!this.chkapply.Checked)
            {
                if (this.txtname.Text != "")
                {
                    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM StockInMst where itemname='" + this.txtname.Text + "'", this.con);
                    DataTable dataTable1 = new DataTable();
                    oleDbDataAdapter1.Fill(dataTable1);
                    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT sum(qnt) as qnt,sum(buyprice) as bprice,sum(sellprice) as sprice FROM StockInMst where itemname='" + this.txtname.Text + "'", this.con);
                    DataTable dataTable2 = new DataTable();
                    oleDbDataAdapter2.Fill(dataTable2);
                    this.lblqnt.Text = dataTable2.Rows[0]["qnt"].ToString();
                    this.lblbamt.Text = dataTable2.Rows[0]["bprice"].ToString();
                    this.lblsamt.Text = dataTable2.Rows[0]["sprice"].ToString();
                    this.gvstockIn.AutoGenerateColumns = false;
                    this.gvstockIn.DataSource = (object)dataTable1;
                    this.lbltotal.Text = "Serach Result = " + (object)dataTable1.Rows.Count;
                    this.groupBox2.Visible = true;
                }
                else if (this.drpcompnayview.Text != "SELECT")
                {
                    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM StockInMst where companyname='" + this.drpcompnayview.Text + "'", this.con);
                    DataTable dataTable1 = new DataTable();
                    oleDbDataAdapter1.Fill(dataTable1);
                    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT sum(qnt) as qnt,sum(buyprice) as bprice,sum(sellprice) as sprice FROM StockInMst  where companyname='" + this.drpcompnayview.Text + "'", this.con);
                    DataTable dataTable2 = new DataTable();
                    oleDbDataAdapter2.Fill(dataTable2);
                    this.lblqnt.Text = dataTable2.Rows[0]["qnt"].ToString();
                    this.lblbamt.Text = dataTable2.Rows[0]["bprice"].ToString();
                    this.lblsamt.Text = dataTable2.Rows[0]["sprice"].ToString();
                    this.gvstockIn.AutoGenerateColumns = false;
                    this.gvstockIn.DataSource = (object)dataTable1;
                    this.lbltotal.Text = "Serach Result = " + (object)dataTable1.Rows.Count;
                    this.groupBox2.Visible = true;
                }
                else
                {
                    int num = (int)MessageBox.Show("Input Item name or Select Company name !!", "Stock System");
                    this.groupBox2.Visible = false;
                }
            }
            else
            {
                DateTime dateTime = this.todate.Value.Date.AddHours(24.0);
                if (this.txtname.Text != "")
                {
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM StockInMst where itemname='" + this.txtname.Text + "' and edate >= #" + (object)this.fromdate.Value.Date + "# and edate <= #" + (object)dateTime + "#", this.con);
                    DataTable dataTable = new DataTable();
                    oleDbDataAdapter.Fill(dataTable);
                    this.gvstockIn.AutoGenerateColumns = false;
                    this.gvstockIn.DataSource = (object)dataTable;
                    this.lbltotal.Text = "Serach Result = " + (object)dataTable.Rows.Count;
                    this.groupBox2.Visible = true;
                }
                else if (this.drpcompnayview.Text != "SELECT")
                {
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM StockInMst where companyname='" + this.drpcompnayview.Text + "' and edate >= #" + (object)this.fromdate.Value.Date + "# and edate <= #" + (object)dateTime + "#", this.con);
                    DataTable dataTable = new DataTable();
                    oleDbDataAdapter.Fill(dataTable);
                    this.gvstockIn.AutoGenerateColumns = false;
                    this.gvstockIn.DataSource = (object)dataTable;
                    this.lbltotal.Text = "Serach Result = " + (object)dataTable.Rows.Count;
                    this.groupBox2.Visible = true;
                }
                else
                {
                    int num = (int)MessageBox.Show("Input Item name or Select Company name !!", "Stock System");
                    this.groupBox2.Visible = false;
                }
            }
            this.txtname.Text = "";
            this.txtname.Focus();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            this.btnselect.PerformClick();
        }
    }
}
