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
    public partial class ReportSellStock : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
        private int m = 0;
        public ReportSellStock()
        {
            InitializeComponent();
        }

        private void ReportSellStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDataSet.SellMst' table. You can move, or remove it, as needed.
            this.sellMstTableAdapter.Fill(this.stockDataSet.SellMst);
            this.con.Open();
            OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM CompanyMst", this.con);
            DataTable dataTable1 = new DataTable();
            oleDbDataAdapter1.Fill(dataTable1);
            this.drpcompnayview.DataSource = (object)dataTable1;
            this.drpcompnayview.DisplayMember = "Companyname";
            this.drpcompnayview.ValueMember = "id";
            this.drpcompnayview.Text = "SELECT";
            OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM clientmst", this.con);
            DataTable dataTable2 = new DataTable();
            oleDbDataAdapter2.Fill(dataTable2);
            this.m = 1;
            this.drpclient.DataSource = (object)dataTable2;
            this.drpclient.DisplayMember = "name";
            this.drpclient.ValueMember = "mobile";
            this.drpclient.Text = "SELECT";
            this.m = 0;
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
            this.con.Open();
            if (!this.chkapply.Checked)
            {
                if (this.txtname.Text != "")
                {
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SellMst where itemname='" + this.txtname.Text + "'", this.con);
                    DataTable dataTable = new DataTable();
                    oleDbDataAdapter.Fill(dataTable);
                    this.gvstockIn.AutoGenerateColumns = false;
                    this.gvstockIn.DataSource = (object)dataTable;
                    this.lbltotal.Text = "Serach Result = " + (object)dataTable.Rows.Count;
                    this.groupBox2.Visible = true;
                }
                else if (this.drpcompnayview.Text != "SELECT")
                {
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SellMst where company='" + this.drpcompnayview.Text + "'", this.con);
                    DataTable dataTable = new DataTable();
                    oleDbDataAdapter.Fill(dataTable);
                    this.gvstockIn.AutoGenerateColumns = false;
                    this.gvstockIn.DataSource = (object)dataTable;
                    this.lbltotal.Text = "Serach Result = " + (object)dataTable.Rows.Count;
                    this.groupBox2.Visible = true;
                }
                else
                {
                    int num = (int)MessageBox.Show("Input Item name or Select Company name !!", "Care You");
                    this.groupBox2.Visible = false;
                }
            }
            else
            {
                DateTime date1 = this.todate.Value;
                date1 = date1.Date;
                DateTime dateTime = date1.AddHours(24.0);
                if (this.txtname.Text != "")
                {
                    object[] objArray1 = new object[7]
                    {
            (object) "SELECT * FROM sellmst where itemname='",
            (object) this.txtname.Text,
            (object) "' and edate >= #",
            null,
            null,
            null,
            null
                    };
                    object[] objArray2 = objArray1;
                    int index = 3;
                    date1 = this.fromdate.Value;
                    // ISSUE: variable of a boxed type
                    DateTime date2 = date1.Date;
                    objArray2[index] = (object)date2;
                    objArray1[4] = (object)"# and edate <= #";
                    objArray1[5] = (object)dateTime;
                    objArray1[6] = (object)"#";
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(string.Concat(objArray1), this.con);
                    DataTable dataTable = new DataTable();
                    oleDbDataAdapter.Fill(dataTable);
                    this.gvstockIn.AutoGenerateColumns = false;
                    this.gvstockIn.DataSource = (object)dataTable;
                    this.lbltotal.Text = "Serach Result = " + (object)dataTable.Rows.Count;
                    this.groupBox2.Visible = true;
                }
                else if (this.drpcompnayview.Text != "SELECT")
                {
                    object[] objArray1 = new object[7]
                    {
            (object) "SELECT * FROM sellmst where company='",
            (object) this.drpcompnayview.Text,
            (object) "' and edate >= #",
            null,
            null,
            null,
            null
                    };
                    object[] objArray2 = objArray1;
                    int index = 3;
                    date1 = this.fromdate.Value;
                    // ISSUE: variable of a boxed type
                    DateTime date2 = date1.Date;
                    objArray2[index] = (object)date2;
                    objArray1[4] = (object)"# and edate <= #";
                    objArray1[5] = (object)dateTime;
                    objArray1[6] = (object)"#";
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(string.Concat(objArray1), this.con);
                    DataTable dataTable = new DataTable();
                    oleDbDataAdapter.Fill(dataTable);
                    this.gvstockIn.AutoGenerateColumns = false;
                    this.gvstockIn.DataSource = (object)dataTable;
                    this.lbltotal.Text = "Serach Result = " + (object)dataTable.Rows.Count;
                    this.groupBox2.Visible = true;
                }
                else
                {
                    int num = (int)MessageBox.Show("Input Item name or Select Company name !!", "Care You");
                    this.groupBox2.Visible = false;
                }
            }
            this.txtname.Text = "";
            this.txtname.Focus();
            this.con.Close();
        }

        private void btntotalsell_Click(object sender, EventArgs e)
        {
            this.con.Open();
            if (!this.chkapply.Checked)
            {
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SellMst", this.con);
                DataTable dataTable = new DataTable();
                oleDbDataAdapter.Fill(dataTable);
                this.gvstockIn.AutoGenerateColumns = false;
                this.gvstockIn.DataSource = (object)dataTable;
                this.lbltotal.Text = "Serach Result = " + (object)dataTable.Rows.Count;
                this.groupBox2.Visible = true;
            }
            else
            {
                DateTime date1 = this.todate.Value;
                date1 = date1.Date;
                DateTime dateTime = date1.AddHours(24.0);
                object[] objArray1 = new object[5]
                {
          (object) "SELECT * FROM sellmst where edate >= #",
          null,
          null,
          null,
          null
                };
                object[] objArray2 = objArray1;
                int index = 1;
                date1 = this.fromdate.Value;
                // ISSUE: variable of a boxed type
                DateTime date2 = date1.Date;
                objArray2[index] = (object)date2;
                objArray1[2] = (object)"# and edate <= #";
                objArray1[3] = (object)dateTime;
                objArray1[4] = (object)"#";
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(string.Concat(objArray1), this.con);
                DataTable dataTable = new DataTable();
                oleDbDataAdapter.Fill(dataTable);
                this.gvstockIn.AutoGenerateColumns = false;
                this.gvstockIn.DataSource = (object)dataTable;
                this.lbltotal.Text = "Search Result = " + (object)dataTable.Rows.Count;
                this.groupBox2.Visible = true;
            }
            this.txtname.Text = "";
            this.txtname.Focus();
            this.con.Close();
        }

        private void btnclientsearch_Click(object sender, EventArgs e)
        {
            this.con.Open();
            if (!this.chkapply.Checked)
            {
                if (this.drpclient.Text != "SELECT")
                {
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SellMst where partyname='" + this.drpclient.Text + "' and mobile='" + this.lblmobile.Text + "'", this.con);
                    DataTable dataTable = new DataTable();
                    oleDbDataAdapter.Fill(dataTable);
                    this.gvstockIn.AutoGenerateColumns = false;
                    this.gvstockIn.DataSource = (object)dataTable;
                    this.lbltotal.Text = "Serach Result = " + (object)dataTable.Rows.Count;
                    this.groupBox2.Visible = true;
                }
                else
                {
                    int num = (int)MessageBox.Show("Input Client name !!", "Care You");
                    this.groupBox2.Visible = false;
                }
            }
            else if (this.drpclient.Text != "SELECT")
            {
                DateTime date1 = this.todate.Value;
                date1 = date1.Date;
                DateTime dateTime = date1.AddHours(24.0);
                object[] objArray1 = new object[9]
                {
          (object) "SELECT * FROM SellMst where partyname='",
          (object) this.drpclient.Text,
          (object) "' and mobile='",
          (object) this.lblmobile.Text,
          (object) "' and edate >= #",
          null,
          null,
          null,
          null
                };
                object[] objArray2 = objArray1;
                int index = 5;
                date1 = this.fromdate.Value;
                // ISSUE: variable of a boxed type
                DateTime date2 = date1.Date;
                objArray2[index] = (object)date2;
                objArray1[6] = (object)"# and edate <= #";
                objArray1[7] = (object)dateTime;
                objArray1[8] = (object)"#";
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(string.Concat(objArray1), this.con);
                DataTable dataTable = new DataTable();
                oleDbDataAdapter.Fill(dataTable);
                this.gvstockIn.AutoGenerateColumns = false;
                this.gvstockIn.DataSource = (object)dataTable;
                this.lbltotal.Text = "Serach Result = " + (object)dataTable.Rows.Count;
                this.groupBox2.Visible = true;
            }
            else
            {
                int num = (int)MessageBox.Show("Input Client name !!", "Care You");
                this.groupBox2.Visible = false;
            }
            this.con.Close();
        }

        private void drpclient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.m != 0 || !(this.drpclient.Text != "SELECT"))
                return;
            this.lblmobile.Text = this.drpclient.SelectedValue.ToString();
        }

        private void txtbillno_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
            if ((int)e.KeyChar == 8 || char.IsNumber(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void btnbillreport_Click(object sender, EventArgs e)
        {
            this.con.Open();
            if (this.txtbillno.Text != "")
            {
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SellMst where billno=" + this.txtbillno.Text, this.con);
                DataTable dataTable = new DataTable();
                oleDbDataAdapter.Fill(dataTable);
                this.gvstockIn.AutoGenerateColumns = false;
                this.gvstockIn.DataSource = (object)dataTable;
                this.lbltotal.Text = "Serach Result = " + (object)dataTable.Rows.Count;
                this.groupBox2.Visible = true;
                this.txtbillno.Focus();
            }
            else
            {
                int num = (int)MessageBox.Show("Input Bill No. !!", "Care You");
                this.groupBox2.Visible = false;
            }
            this.con.Close();
        }

        private void txtbillno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            this.btnbillreport.PerformClick();
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            this.btnselect.PerformClick();
        }
    }
}
