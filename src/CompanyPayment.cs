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
    public partial class CompanyPayment : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
        private string billnoview = "";
        private int billamt = 0;
        private int billpaid = 0;
        public CompanyPayment()
        {
            InitializeComponent();
        }

        private void CompanyPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDataSet.BillPaymentMst' table. You can move, or remove it, as needed.
            this.billPaymentMstTableAdapter.Fill(this.stockDataSet.BillPaymentMst);
            // TODO: This line of code loads data into the 'stockDataSet.ComPaymentMst' table. You can move, or remove it, as needed.
            this.comPaymentMstTableAdapter.Fill(this.stockDataSet.ComPaymentMst);
            this.con.Open();
            OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM CompanyMst", this.con);
            DataTable dataTable1 = new DataTable();
            oleDbDataAdapter1.Fill(dataTable1);
            this.drpcompnay.DataSource = (object)dataTable1;
            this.drpcompnay.DisplayMember = "Companyname";
            this.drpcompnay.ValueMember = "id";
            this.drpcompnay.Text = "SELECT";
            this.drpcomppayment.DataSource = (object)dataTable1;
            this.drpcomppayment.DisplayMember = "Companyname";
            this.drpcomppayment.ValueMember = "id";
            this.drpcomppayment.Text = "SELECT";
            this.drpcompanysearch.DataSource = (object)dataTable1;
            this.drpcompanysearch.DisplayMember = "Companyname";
            this.drpcompanysearch.ValueMember = "id";
            this.drpcompanysearch.Text = "SELECT";
            this.drptype.SelectedIndex = 0;
            OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("select * from compaymentmst order by edate desc", this.con);
            DataTable dataTable2 = new DataTable();
            oleDbDataAdapter2.Fill(dataTable2);
            if (dataTable2.Rows.Count == 0)
            {
                this.Gvpayment.AutoGenerateColumns = false;
                this.Gvpayment.DataSource = (object)null;
            }
            else
            {
                this.Gvpayment.AutoGenerateColumns = false;
                this.Gvpayment.DataSource = (object)dataTable2;
                OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("select sum(items) as sitem, sum(boxes) as sboxes, sum(amt) as samt from compaymentmst", this.con);
                DataTable dataTable3 = new DataTable();
                oleDbDataAdapter3.Fill(dataTable3);
                this.lblsamt.Text = dataTable3.Rows[0]["samt"].ToString();
                this.lblsitem.Text = dataTable3.Rows[0]["sitem"].ToString();
                this.lblsbox.Text = dataTable3.Rows[0]["sboxes"].ToString();
            }
            OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("select * from Billpaymentmst order by paymentdate desc", this.con);
            DataTable dataTable4 = new DataTable();
            oleDbDataAdapter4.Fill(dataTable4);
            if (dataTable4.Rows.Count == 0)
            {
                this.GvBillPayment.AutoGenerateColumns = false;
                this.GvBillPayment.DataSource = (object)null;
            }
            else
            {
                this.GvBillPayment.AutoGenerateColumns = false;
                this.GvBillPayment.DataSource = (object)dataTable4;
                OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("select  sum(amount) as bamt from billpaymentmst", this.con);
                DataTable dataTable3 = new DataTable();
                oleDbDataAdapter3.Fill(dataTable3);
                this.lblbamt.Text = dataTable3.Rows[0]["bamt"].ToString();
            }
            this.GvBillPayment.RowsDefaultCellStyle.BackColor = Color.White;
            this.GvBillPayment.AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose;
            this.Gvpayment.RowsDefaultCellStyle.BackColor = Color.White;
            this.Gvpayment.AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose;
            this.con.Close();
        }

        private void txtbillamt_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
            if ((int)e.KeyChar == 8 || char.IsNumber(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void btnadddetail_Click(object sender, EventArgs e)
        {
            this.con.Open();
            new OleDbDataAdapter("insert into compaymentmst (billno,company,boxes,items,amt,edate) values ('" + this.txtbillno.Text + "','" + this.drpcompnay.Text + "'," + this.txtcarttons.Text + "," + this.txtitems.Text + "," + this.txtbillamt.Text + ",'" + (object)this.caldate.Value.Date + "')", this.con).Fill(new DataTable());
            int num = (int)MessageBox.Show("Record Inserted !!", "Care You");
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from compaymentmst order by edate desc", this.con);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter.Fill(dataTable);
            this.Gvpayment.AutoGenerateColumns = false;
            this.Gvpayment.DataSource = (object)dataTable;
            this.txtbillno.Text = "";
            this.txtcarttons.Text = "";
            this.txtitems.Text = "";
            this.txtbillamt.Text = "";
            this.drpcompnay.Text = "SELECT";
            this.con.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.con.Open();
            if (this.drpcompanysearch.Text != "SELECT")
            {
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("select * from compaymentmst where company = '" + this.drpcompanysearch.Text + "'", this.con);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                this.Gvpayment.AutoGenerateColumns = false;
                this.Gvpayment.DataSource = (object)dataTable1;
                OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("select sum(items) as sitem, sum(boxes) as sboxes, sum(amt) as samt from compaymentmst where company = '" + this.drpcompanysearch.Text + "'", this.con);
                DataTable dataTable2 = new DataTable();
                oleDbDataAdapter2.Fill(dataTable2);
                this.lblsamt.Text = dataTable2.Rows[0]["samt"].ToString();
                this.lblsitem.Text = dataTable2.Rows[0]["sitem"].ToString();
                this.lblsbox.Text = dataTable2.Rows[0]["sboxes"].ToString();
                OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("select  * from billpaymentmst where companyname = '" + this.drpcompanysearch.Text + "'", this.con);
                DataTable dataTable3 = new DataTable();
                oleDbDataAdapter3.Fill(dataTable3);
                OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("select  sum(amount) as bamt from billpaymentmst where companyname = '" + this.drpcompanysearch.Text + "'", this.con);
                DataTable dataTable4 = new DataTable();
                oleDbDataAdapter4.Fill(dataTable4);
                this.lblbamt.Text = dataTable4.Rows[0]["bamt"].ToString();
                this.GvBillPayment.AutoGenerateColumns = false;
                this.GvBillPayment.DataSource = (object)dataTable3;
            }
            else
            {
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("select * from compaymentmst order by edate desc", this.con);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                this.Gvpayment.AutoGenerateColumns = false;
                this.Gvpayment.DataSource = (object)dataTable1;
                OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("select sum(items) as sitem, sum(boxes) as sboxes, sum(amt) as samt from compaymentmst", this.con);
                DataTable dataTable2 = new DataTable();
                oleDbDataAdapter2.Fill(dataTable2);
                this.lblsamt.Text = dataTable2.Rows[0]["samt"].ToString();
                this.lblsitem.Text = dataTable2.Rows[0]["sitem"].ToString();
                this.lblsbox.Text = dataTable2.Rows[0]["sboxes"].ToString();
                OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("select * from billpaymentmst order by paymentdate desc", this.con);
                DataTable dataTable3 = new DataTable();
                oleDbDataAdapter3.Fill(dataTable3);
                OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("select  sum(amount) as bamt from billpaymentmst", this.con);
                DataTable dataTable4 = new DataTable();
                oleDbDataAdapter4.Fill(dataTable4);
                this.lblbamt.Text = dataTable4.Rows[0]["bamt"].ToString();
                this.GvBillPayment.AutoGenerateColumns = false;
                this.GvBillPayment.DataSource = (object)dataTable3;
                this.drpcompanysearch.Text = "SELECT";
            }
            this.con.Close();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            this.con.Open();
            this.chkpaidedit.Checked = true;
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from compaymentmst where  billno = '" + this.txtbillview.Text + "'", this.con);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                this.lblbillamt.Text = "Bill Amt : " + dataTable.Rows[0]["amt"].ToString();
                this.billamt = Convert.ToInt32(dataTable.Rows[0]["amt"].ToString());
                this.lblpaidamt.Text = "Paid Amt : " + dataTable.Rows[0]["paidamt"].ToString();
                this.billpaid = Convert.ToInt32(dataTable.Rows[0]["paidamt"].ToString());
                this.chkpaidedit.Checked = dataTable.Rows[0]["status"].ToString() == "PAID";
                this.billnoview = this.txtbillview.Text;
                this.groupBox4.Visible = true;
                this.txtamtpaidd.Focus();
            }
            else
            {
                int num = (int)MessageBox.Show("Invalid Bill No !!", "Care You");
                this.txtbillview.Focus();
                this.groupBox4.Visible = false;
            }
            this.con.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Delete !!", "Care You", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;
            this.con.Open();
            if (this.txtbillview.Text != "")
            {
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("select * from compaymentmst where  billno = '" + this.txtbillview.Text + "'", this.con);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                if (dataTable1.Rows.Count > 0)
                {
                    new OleDbDataAdapter("Delete from compaymentmst where  billno = '" + this.txtbillview.Text + "'", this.con).Fill(new DataTable());
                    int num = (int)MessageBox.Show("Record Deleted !!", "Care You");
                    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("select top 10 * from compaymentmst order by id desc", this.con);
                    DataTable dataTable2 = new DataTable();
                    oleDbDataAdapter2.Fill(dataTable2);
                    this.Gvpayment.AutoGenerateColumns = false;
                    this.Gvpayment.DataSource = (object)dataTable2;
                }
                else
                {
                    int num1 = (int)MessageBox.Show("Invalid Bill no !!", "Care You");
                }
            }
            this.con.Close();
        }

        private void txtamtpaidd_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
            if ((int)e.KeyChar == 8 || char.IsNumber(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void txtbillview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            this.btnview.PerformClick();
        }

        private void btnddpayent_Click(object sender, EventArgs e)
        {
            this.con.Open();
            new OleDbDataAdapter("insert into billpaymentmst (companyname,Amount,type,paymentdate) values ('" + this.drpcomppayment.Text + "'," + this.txtamtpay.Text + ",'" + this.drptype.Text + "','" + (object)this.calpayamt.Value.Date + "')", this.con).Fill(new DataTable());
            int num = (int)MessageBox.Show("Payment Inserted !!", "Care You");
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select  * from billpaymentmst order by paymentdate desc", this.con);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter.Fill(dataTable);
            this.GvBillPayment.AutoGenerateColumns = false;
            this.GvBillPayment.DataSource = (object)dataTable;
            this.txtbillno.Text = "";
            this.txtcarttons.Text = "";
            this.txtitems.Text = "";
            this.txtbillamt.Text = "";
            this.drpcompnay.Text = "SELECT";
            this.txtamtpay.Text = "";
            this.drpcomppayment.Text = "SELECT";
            this.drptype.SelectedIndex = 0;
            this.con.Close();
        }

        private void Gvpayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!this.Gvpayment.Rows[e.RowIndex].Cells[7].Selected || MessageBox.Show("Are you sure !! You want to Delete !!", "Care You", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;
            OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
            selectConnection.Open();
            new OleDbDataAdapter("delete from ComPaymentMst where ID=" + this.Gvpayment.Rows[e.RowIndex].Cells[0].Value, selectConnection).Fill(new DataTable());
            int num = (int)MessageBox.Show("Bill Detail Deleted !!", "Care You");
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from compaymentmst order by edate desc", selectConnection);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter.Fill(dataTable);
            this.Gvpayment.AutoGenerateColumns = false;
            this.Gvpayment.DataSource = (object)dataTable;
        }

        private void GvBillPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!this.GvBillPayment.Rows[e.RowIndex].Cells[5].Selected || MessageBox.Show("Are you sure !! You want to Delete !!", "Care You", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;
            OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
            selectConnection.Open();
            new OleDbDataAdapter("delete from BillPaymentMst where ID=" + this.GvBillPayment.Rows[e.RowIndex].Cells[0].Value, selectConnection).Fill(new DataTable());
            int num = (int)MessageBox.Show("Payment Detail Deleted !!", "Care You");
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select  * from billpaymentmst order by paymentdate desc", selectConnection);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter.Fill(dataTable);
            this.GvBillPayment.AutoGenerateColumns = false;
            this.GvBillPayment.DataSource = (object)dataTable;
        }
    }
}
