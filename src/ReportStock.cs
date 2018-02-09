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
    public partial class ReportStock : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
        public ReportStock()
        {
            InitializeComponent();
        }

        private void ReportStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDataSet.StockMst' table. You can move, or remove it, as needed.
            this.stockMstTableAdapter.Fill(this.stockDataSet.StockMst);
            this.con.Open();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM CompanyMst", this.con);
            DataTable dataTable1 = new DataTable();
            oleDbDataAdapter.Fill(dataTable1);
            DataTable dataTable2 = new DataTable();
            oleDbDataAdapter.Fill(dataTable2);
            this.drpcompnayview.DataSource = (object)dataTable2;
            this.drpcompnayview.DisplayMember = "Companyname";
            this.drpcompnayview.ValueMember = "id";
            this.drpcompnayview.Text = "SELECT";
            OleDbDataReader oleDbDataReader = new OleDbCommand("select itemname from stockmst", this.con).ExecuteReader();
            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
            while (oleDbDataReader.Read())
                stringCollection.Add(oleDbDataReader.GetString(0));
            this.txtname.AutoCompleteCustomSource = stringCollection;
            this.gvstock.RowsDefaultCellStyle.BackColor = Color.White;
            this.gvstock.AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose;
            this.con.Close();
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            if (this.txtname.Text != "")
            {
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM StockMst where itemname='" + this.txtname.Text + "'", this.con);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                this.gvstock.AutoGenerateColumns = false;
                this.gvstock.DataSource = (object)dataTable1;
                this.lbltotal.Text = "Serach Result = " + (object)dataTable1.Rows.Count;
                this.groupBox2.Visible = true;
                OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT sum(TotalQnt) as qnt, sum(AvailableQnt) as aqnt, sum(SellQnt) as sqnt, sum(AvailablePrice) as aamt, sum(SellPrice) as samt FROM StockMst where itemname='" + this.txtname.Text + "'", this.con);
                DataTable dataTable2 = new DataTable();
                oleDbDataAdapter2.Fill(dataTable2);
                this.lblqnt.Text = dataTable2.Rows[0]["qnt"].ToString();
                this.lblaqnt.Text = dataTable2.Rows[0]["aqnt"].ToString();
                this.lblsqnt.Text = dataTable2.Rows[0]["sqnt"].ToString();
                this.lblaamt.Text = dataTable2.Rows[0]["aamt"].ToString();
                this.lblsamt.Text = dataTable2.Rows[0]["samt"].ToString();
            }
            else if (this.drpcompnayview.Text != "SELECT")
            {
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM StockMst where companyname='" + this.drpcompnayview.Text + "'", this.con);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                this.gvstock.AutoGenerateColumns = false;
                this.gvstock.DataSource = (object)dataTable1;
                this.lbltotal.Text = "Serach Result = " + (object)dataTable1.Rows.Count;
                this.groupBox2.Visible = true;
                OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT sum(TotalQnt) as qnt, sum(AvailableQnt) as aqnt, sum(SellQnt) as sqnt, sum(AvailablePrice) as aamt, sum(SellPrice) as samt FROM StockMst where companyname='" + this.drpcompnayview.Text + "'", this.con);
                DataTable dataTable2 = new DataTable();
                oleDbDataAdapter2.Fill(dataTable2);
                this.lblqnt.Text = dataTable2.Rows[0]["qnt"].ToString();
                this.lblaqnt.Text = dataTable2.Rows[0]["aqnt"].ToString();
                this.lblsqnt.Text = dataTable2.Rows[0]["sqnt"].ToString();
                this.lblaamt.Text = dataTable2.Rows[0]["aamt"].ToString();
                this.lblsamt.Text = dataTable2.Rows[0]["samt"].ToString();
            }
            else
            {
                int num = (int)MessageBox.Show("Input Item name or Select Company name !!", "Care You");
                this.groupBox2.Visible = false;
            }
            this.txtname.Text = "";
            this.txtname.Focus();
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            this.btnselect.PerformClick();
        }
    }
}
