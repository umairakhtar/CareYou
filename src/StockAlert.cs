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
    public partial class StockAlert : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
        public StockAlert()
        {
            InitializeComponent();
        }

        private void StockAlert_Load(object sender, EventArgs e)
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
            this.drpsign.SelectedIndex = 0;
            this.gvstock.RowsDefaultCellStyle.BackColor = Color.White;
            this.gvstock.AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose;
            this.con.Close();
        }

        private void txtqnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
            if ((int)e.KeyChar == 8 || char.IsNumber(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            if (this.txtqnt.Text == "")
            {
                int num = (int)MessageBox.Show("Input Search Quantity !!", "Care You");
                this.groupBox2.Visible = false;
            }
            else
            {
                this.con.Open();
                if (this.drpsign.SelectedIndex == 0)
                {
                    if (this.txtname.Text != "")
                    {
                        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM StockMst where itemname='" + this.txtname.Text + "' and availableqnt <= " + this.txtqnt.Text, this.con);
                        DataTable dataTable = new DataTable();
                        oleDbDataAdapter.Fill(dataTable);
                        this.gvstock.AutoGenerateColumns = false;
                        this.gvstock.DataSource = (object)dataTable;
                        this.lbltotal.Text = "Serach Result = " + (object)dataTable.Rows.Count;
                        this.groupBox2.Visible = true;
                    }
                    else if (this.drpcompnayview.Text != "SELECT")
                    {
                        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM StockMst where companyname='" + this.drpcompnayview.Text + "' and availableqnt <= " + this.txtqnt.Text, this.con);
                        DataTable dataTable = new DataTable();
                        oleDbDataAdapter.Fill(dataTable);
                        this.gvstock.AutoGenerateColumns = false;
                        this.gvstock.DataSource = (object)dataTable;
                        this.lbltotal.Text = "Serach Result = " + (object)dataTable.Rows.Count;
                        this.groupBox2.Visible = true;
                    }
                    else
                    {
                        int num = (int)MessageBox.Show("Input Item name or Select Company name !!", "Care You");
                        this.groupBox2.Visible = false;
                    }
                }
                else if (this.drpsign.SelectedIndex == 1)
                {
                    if (this.txtname.Text != "")
                    {
                        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM StockMst where itemname='" + this.txtname.Text + "' and availableqnt >= " + this.txtqnt.Text, this.con);
                        DataTable dataTable = new DataTable();
                        oleDbDataAdapter.Fill(dataTable);
                        this.gvstock.AutoGenerateColumns = false;
                        this.gvstock.DataSource = (object)dataTable;
                        this.lbltotal.Text = "Serach Result = " + (object)dataTable.Rows.Count;
                        this.groupBox2.Visible = true;
                    }
                    else if (this.drpcompnayview.Text != "SELECT")
                    {
                        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM StockMst where companyname='" + this.drpcompnayview.Text + "' and availableqnt >= " + this.txtqnt.Text, this.con);
                        DataTable dataTable = new DataTable();
                        oleDbDataAdapter.Fill(dataTable);
                        this.gvstock.AutoGenerateColumns = false;
                        this.gvstock.DataSource = (object)dataTable;
                        this.lbltotal.Text = "Serach Result = " + (object)dataTable.Rows.Count;
                        this.groupBox2.Visible = true;
                    }
                    else
                    {
                        int num = (int)MessageBox.Show("Input Item name or Select Company name !!", "Care You");
                        this.groupBox2.Visible = false;
                    }
                }
                else if (this.drpsign.SelectedIndex == 2)
                {
                    if (this.txtname.Text != "")
                    {
                        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM StockMst where itemname='" + this.txtname.Text + "' and availableqnt = " + this.txtqnt.Text, this.con);
                        DataTable dataTable = new DataTable();
                        oleDbDataAdapter.Fill(dataTable);
                        this.gvstock.AutoGenerateColumns = false;
                        this.gvstock.DataSource = (object)dataTable;
                        this.lbltotal.Text = "Search Result = " + (object)dataTable.Rows.Count;
                        this.groupBox2.Visible = true;
                    }
                    else if (this.drpcompnayview.Text != "SELECT")
                    {
                        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM StockMst where companyname='" + this.drpcompnayview.Text + "' and availableqnt = " + this.txtqnt.Text, this.con);
                        DataTable dataTable = new DataTable();
                        oleDbDataAdapter.Fill(dataTable);
                        this.gvstock.AutoGenerateColumns = false;
                        this.gvstock.DataSource = (object)dataTable;
                        this.lbltotal.Text = "Search Result = " + (object)dataTable.Rows.Count;
                        this.groupBox2.Visible = true;
                    }
                    else
                    {
                        int num = (int)MessageBox.Show("Input Item name or Select Company name !!", "Care You");
                        this.groupBox2.Visible = false;
                    }
                }
                this.txtname.Text = "";
                this.txtqnt.Text = "";
                this.txtname.Focus();
                this.drpsign.SelectedIndex = 0;
                this.con.Close();
            }
        }

        private void txtqnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            this.btnselect.PerformClick();
        }

        private void drpsign_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
