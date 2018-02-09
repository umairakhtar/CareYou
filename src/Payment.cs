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
    public partial class Payment : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
        private int billamt = 0;
        private int billpaid = 0;
        private string billnoview = "";
        public int pidd;
        public Payment(int pid)
        {
            InitializeComponent();
            this.pidd = pid;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            if (this.pidd == 0)
                return;
            this.txtbillno.Text = this.pidd.ToString();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.con.Open();
            if (this.txtbillno.Text != "")
            {
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM paymentmst where id=" + this.txtbillno.Text, this.con);
                DataTable dataTable = new DataTable();
                oleDbDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    this.chkpaidedit.Checked = dataTable.Rows[0]["Status"].ToString() == "PAID";
                    this.lblbillamt.Text = "Bill Amt : " + dataTable.Rows[0]["amount"].ToString();
                    this.billamt = Convert.ToInt32(dataTable.Rows[0]["amount"].ToString());
                    this.lblpaidamt.Text = "Paid Amt : " + dataTable.Rows[0]["paidamt"].ToString();
                    this.billpaid = Convert.ToInt32(dataTable.Rows[0]["paidamt"].ToString());
                    this.lblremainnig.Text = "Remaining Amt : " + (this.billamt - this.billpaid).ToString();
                    this.groupBox4.Visible = true;
                    this.billnoview = this.txtbillno.Text;
                    this.txtamtpaid.Focus();
                }
                else
                {
                    int num = (int)MessageBox.Show("Invalid Bill no !!", "Care You");
                    this.groupBox4.Visible = false;
                }
            }
            else
            {
                int num = (int)MessageBox.Show("Input Bill No. !!", "Care You");
                this.txtbillno.Focus();
                this.groupBox4.Visible = false;
            }
            this.con.Close();
        }

        private void btnaddpayment_Click(object sender, EventArgs e)
        {
            this.con.Open();
            if (this.txtamtpaid.Text != "")
            {
                if (this.billpaid + Convert.ToInt32(this.txtamtpaid.Text) <= this.billamt)
                {
                    if (this.chkpaidedit.Checked)
                        new OleDbDataAdapter("update paymentmst set paidamt = paidamt + " + this.txtamtpaid.Text + ", status='PAID' where  id = " + this.billnoview, this.con).Fill(new DataTable());
                    else
                        new OleDbDataAdapter("update paymentmst set paidamt = paidamt + " + this.txtamtpaid.Text + ", status='UNPAID' where  id = " + this.billnoview, this.con).Fill(new DataTable());
                    this.groupBox4.Visible = false;
                    this.txtamtpaid.Text = "";
                    this.txtbillno.Text = "";
                    this.txtbillno.Focus();
                    this.Close();
                }
                else
                {
                    int num = (int)MessageBox.Show("Invalid Amount Inserted !!", "Care You");
                    this.txtamtpaid.Focus();
                    this.groupBox4.Visible = true;
                }
            }
            else
            {
                int num = (int)MessageBox.Show("Input Paid Amount !!", "Care You");
                this.txtamtpaid.Focus();
                this.groupBox4.Visible = true;
            }
            this.con.Close();
        }

        private void txtbillno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            this.btnsearch.PerformClick();
        }
    }
}
