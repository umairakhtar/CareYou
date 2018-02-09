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
    public partial class Sell : Form
    {
        private int m = 0;
        private int p = 0;
        private int q = 0;
        private string oldprice = "";
        public Sell()
        {
            InitializeComponent();
            this.txtpname.ForeColor = Color.Gray;
            this.txtpname.Text = "Enter Name";
            this.txtpname.Leave += new EventHandler(this.txtpname_Leave);
            this.txtpname.Enter += new EventHandler(this.txtpname_Enter);
            this.txtmobile.ForeColor = Color.Gray;
            this.txtmobile.Text = "Enter Mobile";
            this.txtmobile.Leave += new EventHandler(this.txtmobile_Leave);
            this.txtmobile.Enter += new EventHandler(this.txtmobile_Enter);
        }

        private void Sell_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDataSet.SellMst' table. You can move, or remove it, as needed.
            this.sellMstTableAdapter.Fill(this.stockDataSet.SellMst);
            this.m = 1;
            OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
            selectConnection.Open();
            OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM CompanyMst", selectConnection);
            DataTable dataTable1 = new DataTable();
            oleDbDataAdapter1.Fill(dataTable1);
            DataTable dataTable2 = new DataTable();
            oleDbDataAdapter1.Fill(dataTable2);
            this.drpcompnayview.DataSource = (object)dataTable2;
            this.drpcompnayview.DisplayMember = "Companyname";
            this.drpcompnayview.ValueMember = "id";
            this.drpcompnayview.Text = "SELECT";
            OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM clientmst", selectConnection);
            DataTable dataTable3 = new DataTable();
            oleDbDataAdapter2.Fill(dataTable3);
            this.drpcustomer.DataSource = (object)dataTable3;
            this.drpcustomer.DisplayMember = "Name";
            this.drpcustomer.ValueMember = "mobile";
            this.drpcustomer.Text = "SELECT";
            this.m = 0;
            this.gvsales.RowsDefaultCellStyle.BackColor = Color.White;
            this.gvsales.AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void drpcompnayview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.m != 0)
                return;
            OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
            selectConnection.Open();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT distinct itemname FROM StockMst where companyname='" + this.drpcompnayview.Text + "'", selectConnection);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter.Fill(dataTable);
            this.p = 1;
            this.drpitemname.DataSource = (object)dataTable;
            this.drpitemname.DisplayMember = "Itemname";
            this.drpitemname.ValueMember = "Itemname";
            this.drpitemname.Enabled = true;
            this.drpitemname.Text = "SELECT";
            this.btnselect.Enabled = false;
            this.drptype.Enabled = false;
            this.p = 0;
        }

        private void drpitemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.p != 0)
                return;
            OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
            selectConnection.Open();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM StockMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.drpitemname.Text + "'", selectConnection);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter.Fill(dataTable);
            this.q = 1;
            this.drptype.DataSource = (object)dataTable;
            this.drptype.DisplayMember = "Type";
            this.drptype.ValueMember = "id";
            this.drptype.Enabled = true;
            this.btnselect.Enabled = true;
            this.drptype.Text = "SELECT";
            this.q = 0;
        }

        private void drptype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.q != 0)
                return;
            OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
            selectConnection.Open();
            OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM StockInMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.drpitemname.Text + "' and type='" + this.drptype.Text + "'", selectConnection);
            DataTable dataTable1 = new DataTable();
            oleDbDataAdapter1.Fill(dataTable1);
            OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM StockMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.drpitemname.Text + "' and type='" + this.drptype.Text + "'", selectConnection);
            DataTable dataTable2 = new DataTable();
            oleDbDataAdapter2.Fill(dataTable2);
            if (dataTable2.Rows.Count == 1)
            {
                this.lblq.Text = dataTable2.Rows[0]["availableqnt"].ToString();
                this.lbll.Text = dataTable1.Rows[0]["location"].ToString();
                this.lblp.Text = dataTable1.Rows[0]["buyprice"].ToString();
                this.lbls.Text = dataTable1.Rows[0]["sellprice"].ToString();
                this.oldprice = this.lbls.Text;
                this.txtq.Focus();
            }
        }

        private void txtdiscount_Leave(object sender, EventArgs e)
        {
            if (this.txtdiscount.Text != "0")
                this.lbls.Text = (Convert.ToInt32(this.oldprice) - Convert.ToInt32(this.oldprice) * Convert.ToInt32(this.txtdiscount.Text) / 100).ToString();
            else
                this.lbls.Text = this.oldprice;
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.lblq.Text) < Convert.ToInt32(this.txtq.Text))
            {
                int num = (int)MessageBox.Show("Stock is not enough!!", "Care You");
            }
            else
            {
                this.lblp.Visible = false;
                OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
                selectConnection.Open();
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("Select * from Sellmst  where company ='" + this.drpcompnayview.Text + "' and itemname='" + this.drpitemname.Text + "' and type='" + this.drptype.Text + "' and status='0'", selectConnection);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                if (dataTable1.Rows.Count == 0)
                    new OleDbDataAdapter("Insert into Sellmst (partyname,company,itemname,type,qnt,price,totalprice,billno,status,Edate) values('" + this.drpcustomer.Text + "','" + this.drpcompnayview.Text + "','" + this.drpitemname.Text + "','" + this.drptype.Text + "'," + this.txtq.Text + "," + this.lbls.Text + "," + (object)(Convert.ToInt32(this.txtq.Text) * Convert.ToInt32(this.lbls.Text)) + "," + (object)0 + "," + (object)0 + ",'" + (object)DateTime.Now + "')", selectConnection).Fill(new DataTable());
                else if (dataTable1.Rows.Count > 0)
                    new OleDbDataAdapter("update sellmst set qnt=" + this.txtq.Text + ",price=" + this.lbls.Text + ",totalprice=" + (object)(Convert.ToInt32(this.txtq.Text) * Convert.ToInt32(this.lbls.Text)) + " where id=" + (object)Convert.ToInt32(dataTable1.Rows[0]["id"].ToString()), selectConnection).Fill(new DataTable());
                OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("Select * from sellmst where status='0'", selectConnection);
                DataTable dataTable2 = new DataTable();
                oleDbDataAdapter2.Fill(dataTable2);
                OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("Select sum(qnt) as qnt,sum(totalprice) as tprice from sellmst where status='0'", selectConnection);
                DataTable dataTable3 = new DataTable();
                oleDbDataAdapter3.Fill(dataTable3);
                this.lblqnt.Text = dataTable3.Rows[0]["qnt"].ToString();
                this.lbltprice.Text = dataTable3.Rows[0]["tprice"].ToString();
                this.txtpay.Text = dataTable3.Rows[0]["tprice"].ToString();
                this.gvsales.AutoGenerateColumns = false;
                this.gvsales.DataSource = (object)dataTable2;
                this.txtq.Text = "1";
                this.txtdiscount.Text = "0";
                this.lblp.Visible = false;
            }
            this.drpcompnayview.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lblp.Visible = true;
        }

        private void gvsales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
            selectConnection.Open();
            try
            {
                if (!this.gvsales.Rows[e.RowIndex].Cells[4].Selected)
                    return;
                new OleDbDataAdapter("Delete from Sellmst  where id=" + (object)Convert.ToInt32(this.gvsales.Rows[e.RowIndex].Cells[5].Value.ToString()) + " and status='0'", selectConnection).Fill(new DataTable());
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("Select * from sellmst where status='0'", selectConnection);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                this.gvsales.AutoGenerateColumns = false;
                this.gvsales.DataSource = (object)dataTable1;
                OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("Select sum(qnt) as qnt,sum(totalprice) as tprice from sellmst where status='0'", selectConnection);
                DataTable dataTable2 = new DataTable();
                oleDbDataAdapter2.Fill(dataTable2);
                this.lblqnt.Text = dataTable2.Rows[0]["qnt"].ToString();
                this.lbltprice.Text = dataTable2.Rows[0]["tprice"].ToString();
                this.txtpay.Text = dataTable2.Rows[0]["tprice"].ToString();
            }
            catch (Exception )
            {
            }
        }

        private void drpcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.m != 0)
                return;
            this.lblmobile.Text = this.drpcustomer.SelectedValue.ToString();
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancle Order !!", "Care You", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;
            OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
            selectConnection.Open();
            try
            {
                new OleDbDataAdapter("Delete from Sellmst  where status='0'", selectConnection).Fill(new DataTable());
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("Select * from sellmst where status='0'", selectConnection);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                this.gvsales.AutoGenerateColumns = false;
                this.gvsales.DataSource = (object)dataTable1;
                this.txtmobile.Text = "";
                this.txtpname.Text = "";
                this.txtpay.Text = "";
                this.lbls.Text = "0";
                this.lbll.Text = "-";
                this.lblq.Text = "0";
                this.lblp.Visible = false;
                this.txtq.Text = "1";
                this.txtdiscount.Text = "0";
                this.lbltprice.Text = "0";
                this.lblqnt.Text = "0";
                OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM clientmst", selectConnection);
                DataTable dataTable2 = new DataTable();
                oleDbDataAdapter2.Fill(dataTable2);
                this.m = 1;
                this.drpcustomer.DataSource = (object)dataTable2;
                this.drpcustomer.DisplayMember = "Name";
                this.drpcustomer.ValueMember = "mobile";
                this.drpcustomer.Text = "SELECT";
                this.lblmobile.Text = "--";
                this.m = 0;
            }
            catch (Exception )
            {
            }
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order !!", "Care You", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;
            if (this.drpcustomer.Text == "SELECT")
            {
                int num1 = (int)MessageBox.Show("Select Customer !!", "Care You");
            }
            else
            {
                OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
                selectConnection.Open();
                try
                {
                    if (this.chkpaid.Checked)
                    {
                        OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("select * from sellmst where status='0'", selectConnection);
                        DataTable dataTable1 = new DataTable();
                        oleDbDataAdapter1.Fill(dataTable1);
                        for (int index = 0; index < dataTable1.Rows.Count; ++index)
                        {
                            int int32_1 = Convert.ToInt32(dataTable1.Rows[index]["qnt"].ToString());
                            int int32_2 = Convert.ToInt32(dataTable1.Rows[index]["totalprice"].ToString());
                            OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("select * from stockmst where companyname ='" + dataTable1.Rows[index]["company"].ToString() + "' and itemname='" + dataTable1.Rows[index]["itemname"].ToString() + "' and type='" + dataTable1.Rows[index]["type"].ToString() + "'", selectConnection);
                            DataTable dataTable2 = new DataTable();
                            oleDbDataAdapter2.Fill(dataTable2);
                            new OleDbDataAdapter("update stockmst set availableqnt=" + (object)(Convert.ToInt32(dataTable2.Rows[0]["availableqnt"].ToString()) - int32_1) + ", sellqnt=" + (object)(Convert.ToInt32(dataTable2.Rows[0]["sellqnt"].ToString()) + int32_1) + ", sellprice=" + (object)(Convert.ToInt32(dataTable2.Rows[0]["sellprice"].ToString()) + int32_2) + " where companyname ='" + dataTable1.Rows[index]["company"].ToString() + "' and itemname='" + dataTable1.Rows[index]["itemname"].ToString() + "' and type='" + dataTable1.Rows[index]["type"].ToString() + "'", selectConnection).Fill(new DataTable());
                        }
                        new OleDbDataAdapter("insert into paymentmst (partyname,mobile,qnt,amount,paidamt,status,edate) values('" + this.drpcustomer.Text + "','" + this.lblmobile.Text + "'," + this.lblqnt.Text + "," + this.lbltprice.Text + "," + this.txtpay.Text + ",'PAID','" + (object)DateTime.Now + "')", selectConnection).Fill(new DataTable());
                        OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("select top 1 id from paymentmst order by id desc", selectConnection);
                        DataTable dataTable3 = new DataTable();
                        oleDbDataAdapter3.Fill(dataTable3);
                        new OleDbDataAdapter("update Sellmst set partyname='" + this.drpcustomer.Text + "',mobile='" + this.lblmobile.Text + "',billno=" + dataTable3.Rows[0]["id"].ToString() + ",status='PAID' where status='0'", selectConnection).Fill(new DataTable());
                    }
                    else
                    {
                        OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("select * from sellmst where status='0'", selectConnection);
                        DataTable dataTable1 = new DataTable();
                        oleDbDataAdapter1.Fill(dataTable1);
                        for (int index = 0; index < dataTable1.Rows.Count; ++index)
                        {
                            int int32_1 = Convert.ToInt32(dataTable1.Rows[index]["qnt"].ToString());
                            int int32_2 = Convert.ToInt32(dataTable1.Rows[index]["totalprice"].ToString());
                            OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("select * from stockmst where companyname ='" + dataTable1.Rows[index]["company"].ToString() + "' and itemname='" + dataTable1.Rows[index]["itemname"].ToString() + "' and type='" + dataTable1.Rows[index]["type"].ToString() + "'", selectConnection);
                            DataTable dataTable2 = new DataTable();
                            oleDbDataAdapter2.Fill(dataTable2);
                            int num2 = Convert.ToInt32(dataTable2.Rows[0]["availableqnt"].ToString()) - int32_1;
                            int num3 = Convert.ToInt32(dataTable2.Rows[0]["sellprice"].ToString()) + int32_2;
                            int num4 = Convert.ToInt32(dataTable2.Rows[0]["sellqnt"].ToString()) + int32_1;
                            new OleDbDataAdapter("update stockmst set availableqnt=" + (object)num2 + ", sellqnt=" + (object)num4 + ", sellprice=" + (object)num3 + " where companyname ='" + dataTable1.Rows[index]["company"].ToString() + "' and itemname='" + dataTable1.Rows[index]["itemname"].ToString() + "' and type='" + dataTable1.Rows[index]["type"].ToString() + "'", selectConnection).Fill(new DataTable());
                        }
                        new OleDbDataAdapter("insert into paymentmst (partyname,mobile,qnt,amount,paidamt,status,edate) values('" + this.drpcustomer.Text + "','" + this.lblmobile.Text + "'," + this.lblqnt.Text + "," + this.lbltprice.Text + "," + this.txtpay.Text + ",'UNPAID','" + (object)DateTime.Now + "')", selectConnection).Fill(new DataTable());
                        OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("select top 1 id from paymentmst order by id desc", selectConnection);
                        DataTable dataTable3 = new DataTable();
                        oleDbDataAdapter3.Fill(dataTable3);
                        new OleDbDataAdapter("update Sellmst set partyname='" + this.drpcustomer.Text + "',mobile='" + this.lblmobile.Text + "',billno=" + dataTable3.Rows[0]["id"].ToString() + ",status='UNPAID' where status='0'", selectConnection).Fill(new DataTable());
                    }
                    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("Select * from sellmst where status='0'", selectConnection);
                    DataTable dataTable4 = new DataTable();
                    oleDbDataAdapter4.Fill(dataTable4);
                    this.gvsales.AutoGenerateColumns = false;
                    this.gvsales.DataSource = (object)dataTable4;
                    this.txtmobile.Text = "";
                    this.txtpname.Text = "";
                    this.txtpay.Text = "";
                    this.lbls.Text = "0";
                    this.lbll.Text = "-";
                    this.lblq.Text = "0";
                    this.lblp.Visible = false;
                    this.txtq.Text = "1";
                    this.txtdiscount.Text = "0";
                    this.lbltprice.Text = "0";
                    this.lblqnt.Text = "0";
                    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter("SELECT * FROM clientmst", selectConnection);
                    DataTable dataTable5 = new DataTable();
                    oleDbDataAdapter5.Fill(dataTable5);
                    this.m = 1;
                    this.drpcustomer.DataSource = (object)dataTable5;
                    this.drpcustomer.DisplayMember = "Name";
                    this.drpcustomer.ValueMember = "mobile";
                    this.drpcustomer.Text = "SELECT";
                    this.lblmobile.Text = "--";
                    this.m = 0;
                    new Bill().Show();
                }
                catch (Exception ex)
                {
                    int num2 = (int)MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void lbls_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
            if ((int)e.KeyChar == 8 || char.IsNumber(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
            if ((int)e.KeyChar == 8 || char.IsNumber(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void txtq_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
            if ((int)e.KeyChar == 8 || char.IsNumber(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void txtpay_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
            if ((int)e.KeyChar == 8 || char.IsNumber(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void txtmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
            if ((int)e.KeyChar == 8 || char.IsNumber(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void txtq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            this.btnselect.PerformClick();
        }

        private void txtpname_Enter(object sender, EventArgs e)
        {
            if (!(this.txtpname.Text == "Enter Name"))
                return;
            this.txtpname.Text = "";
            this.txtpname.ForeColor = Color.Black;
        }

        private void txtpname_Leave(object sender, EventArgs e)
        {
            if (!(this.txtpname.Text == ""))
                return;
            this.txtpname.Text = "Enter Name";
            this.txtpname.ForeColor = Color.Gray;
        }

        private void txtmobile_Enter(object sender, EventArgs e)
        {
            if (!(this.txtmobile.Text == "Enter Mobile"))
                return;
            this.txtmobile.Text = "";
            this.txtmobile.ForeColor = Color.Black;
        }

        private void txtmobile_Leave(object sender, EventArgs e)
        {
            if (!(this.txtmobile.Text == ""))
                return;
            this.txtmobile.Text = "Enter Mobile";
            this.txtmobile.ForeColor = Color.Gray;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
            selectConnection.Open();
            try
            {
                if (this.txtpname.Text == "Enter Name" || this.txtmobile.Text == "Enter Mobile")
                {
                    int num1 = (int)MessageBox.Show("Enter name - mobile ", "Care You");
                }
                else
                {
                    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM clientmst where mobile='" + this.txtmobile.Text + "'", selectConnection);
                    DataTable dataTable1 = new DataTable();
                    oleDbDataAdapter1.Fill(dataTable1);
                    if (dataTable1.Rows.Count == 0)
                    {
                        new OleDbDataAdapter("Insert into clientmst (name,mobile) values('" + this.txtpname.Text + "','" + this.txtmobile.Text + "')", selectConnection).Fill(new DataTable());
                        int num2 = (int)MessageBox.Show("Client Added !!", "Stock System");
                        OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM clientmst", selectConnection);
                        DataTable dataTable2 = new DataTable();
                        oleDbDataAdapter2.Fill(dataTable2);
                        this.m = 1;
                        this.drpcustomer.DataSource = (object)dataTable2;
                        this.drpcustomer.DisplayMember = "Name";
                        this.drpcustomer.ValueMember = "mobile";
                        this.drpcustomer.Text = "SELECT";
                        this.m = 0;
                        this.txtmobile.Text = "";
                        this.txtpname.Text = "";
                    }
                    else
                    {
                        int num2 = (int)MessageBox.Show("Mobile already registered !!", "Care You");
                        this.txtmobile.Focus();
                    }
                }
            }
            catch (Exception )
            {
            }
        }
    }
}
