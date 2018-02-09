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
    public partial class ReportPayment : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
        private int m = 0;
        public ReportPayment()
        {
            InitializeComponent();
        }

        private void ReportPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDataSet.PaymentMst' table. You can move, or remove it, as needed.
            this.paymentMstTableAdapter.Fill(this.stockDataSet.PaymentMst);
            this.con.Open();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM clientmst", this.con);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter.Fill(dataTable);
            this.m = 1;
            this.drpclient.DataSource = (object)dataTable;
            this.drpclient.DisplayMember = "name";
            this.drpclient.ValueMember = "mobile";
            this.drpclient.Text = "SELECT";
            this.m = 0;
            this.gvstockIn.RowsDefaultCellStyle.BackColor = Color.White;
            this.gvstockIn.AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose;
            this.con.Close();
        }

        private void btnbillreport_Click(object sender, EventArgs e)
        {
            this.con.Open();
            if (this.txtbillno.Text != "")
            {
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM paymentmst where id=" + this.txtbillno.Text, this.con);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                this.gvstockIn.AutoGenerateColumns = false;
                this.gvstockIn.DataSource = (object)dataTable1;
                this.lbltotal.Text = "Serach Result = " + (object)dataTable1.Rows.Count;
                this.groupBox2.Visible = true;
                OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT sum(qnt) as qnt, sum(amount) as amt, sum(paidamt) as pamt FROM paymentmst where id=" + this.txtbillno.Text, this.con);
                DataTable dataTable2 = new DataTable();
                oleDbDataAdapter2.Fill(dataTable2);
                this.lblqnt.Text = dataTable2.Rows[0]["qnt"].ToString();
                this.lblamt.Text = dataTable2.Rows[0]["amt"].ToString();
                this.lblpamt.Text = dataTable2.Rows[0]["pamt"].ToString();
                this.txtbillno.Text = "";
                this.txtbillno.Focus();
            }
            else
            {
                int num = (int)MessageBox.Show("Input Bill No. !!", "Care You");
                this.groupBox2.Visible = false;
            }
            this.con.Close();
        }

        private void btnclientsearch_Click(object sender, EventArgs e)
        {
            this.con.Open();
            if (!this.chkapply.Checked)
            {
                if (this.drpclient.Text != "SELECT")
                {
                    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM paymentmst where partyname='" + this.drpclient.Text + "' and mobile='" + this.lblmobile.Text + "'", this.con);
                    DataTable dataTable1 = new DataTable();
                    oleDbDataAdapter1.Fill(dataTable1);
                    this.gvstockIn.AutoGenerateColumns = false;
                    this.gvstockIn.DataSource = (object)dataTable1;
                    this.lbltotal.Text = "Serach Result = " + (object)dataTable1.Rows.Count;
                    this.groupBox2.Visible = true;
                    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT sum(qnt) as qnt, sum(amount) as amt, sum(paidamt) as pamt FROM paymentmst where partyname='" + this.drpclient.Text + "' and mobile='" + this.lblmobile.Text + "'", this.con);
                    DataTable dataTable2 = new DataTable();
                    oleDbDataAdapter2.Fill(dataTable2);
                    this.lblqnt.Text = dataTable2.Rows[0]["qnt"].ToString();
                    this.lblamt.Text = dataTable2.Rows[0]["amt"].ToString();
                    this.lblpamt.Text = dataTable2.Rows[0]["pamt"].ToString();
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
                object[] objArray1 = new object[9] { (object)"SELECT * FROM paymentmst where partyname='", (object)this.drpclient.Text, (object)"' and mobile='", (object)this.lblmobile.Text, (object)"' and edate >= #", null, null, null, null };
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

        private void btntotalsell_Click(object sender, EventArgs e)
        {
            this.con.Open();
            if (!this.chkapply.Checked)
            {
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM Paymentmst", this.con);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                this.gvstockIn.AutoGenerateColumns = false;
                this.gvstockIn.DataSource = (object)dataTable1;
                this.lbltotal.Text = "Serach Result = " + (object)dataTable1.Rows.Count;
                this.groupBox2.Visible = true;
                OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT sum(qnt) as qnt, sum(amount) as amt, sum(paidamt) as pamt FROM paymentmst", this.con);
                DataTable dataTable2 = new DataTable();
                oleDbDataAdapter2.Fill(dataTable2);
                this.lblqnt.Text = dataTable2.Rows[0]["qnt"].ToString();
                this.lblamt.Text = dataTable2.Rows[0]["amt"].ToString();
                this.lblpamt.Text = dataTable2.Rows[0]["pamt"].ToString();
            }
            else
            {
                DateTime date1 = this.todate.Value;
                date1 = date1.Date;
                DateTime dateTime = date1.AddHours(24.0);
                object[] objArray1 = new object[5] { (object)"SELECT * FROM paymentmst where edate >= #", null, null, null, null };
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
                this.lbltotal.Text = "Serach Result = " + (object)dataTable.Rows.Count;
                this.groupBox2.Visible = true;
            }
            this.con.Close();
        }

        private void txtbillno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            this.btnbillreport.PerformClick();
        }

        private void gvstockIn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!this.gvstockIn.Rows[e.RowIndex].Cells[6].Selected)
                    return;
                new Payment(Convert.ToInt32(this.gvstockIn.Rows[e.RowIndex].Cells[0].Value)).Show();
            }
            catch (Exception )
            {
            }
        }
    }
}
