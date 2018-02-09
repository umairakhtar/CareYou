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
    public partial class StockReturns : Form
    {
        private int m = 0;
        private int p = 0;
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
        public StockReturns()
        {
            InitializeComponent();
        }

        private void StockReturns_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDataSet.StockInMst' table. You can move, or remove it, as needed.
            this.stockInMstTableAdapter.Fill(this.stockDataSet.StockInMst);
            // TODO: This line of code loads data into the 'stockDataSet.StockMst' table. You can move, or remove it, as needed.
            this.stockMstTableAdapter.Fill(this.stockDataSet.StockMst);
            this.m = 1;
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
            this.m = 0;
        }

        private void drpcompnayview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.m != 0)
                return;
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM StockMst where companyname='" + this.drpcompnayview.Text + "'", this.con);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter.Fill(dataTable);
            this.p = 1;
            this.drpitemname.DataSource = (object)dataTable;
            this.drpitemname.DisplayMember = "Itemname";
            this.drpitemname.ValueMember = "id";
            this.drpitemname.Enabled = true;
            this.drpitemname.Text = "SELECT";
            this.drptype.Enabled = false;
            this.p = 0;
        }

        private void drpitemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.p != 0)
                return;
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM StockMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.drpitemname.Text + "'", this.con);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter.Fill(dataTable);
            this.drptype.DataSource = (object)dataTable;
            this.drptype.DisplayMember = "Type";
            this.drptype.ValueMember = "id";
            this.drptype.Enabled = true;
            this.drptype.Text = "SELECT";
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT top 1 * FROM StockInMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.drpitemname.Text + "' and type='" + this.drptype.Text + "' order by id desc", this.con);
            DataTable dataTable1 = new DataTable();
            oleDbDataAdapter1.Fill(dataTable1);
            this.gvstockin.AutoGenerateColumns = false;
            this.gvstockin.DataSource = (object)dataTable1;
            OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM StockMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.drpitemname.Text + "' and type='" + this.drptype.Text + "'", this.con);
            DataTable dataTable2 = new DataTable();
            oleDbDataAdapter2.Fill(dataTable2);
            this.gvstock.AutoGenerateColumns = false;
            this.gvstock.DataSource = (object)dataTable2;
            this.groupBox1.Visible = true;
        }

        private void btnreturns_Click(object sender, EventArgs e)
        {
            if (this.txtqnt.Text == "")
            {
                int num1 = (int)MessageBox.Show("Input Qnt !!", "Care You");
            }
            else
            {
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT top 1 * FROM StockInMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.drpitemname.Text + "' and type='" + this.drptype.Text + "' order by id desc", this.con);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                int int32_1 = Convert.ToInt32(dataTable1.Rows[0]["qnt"].ToString());
                int int32_2 = Convert.ToInt32(dataTable1.Rows[0]["id"].ToString());
                int int32_3 = Convert.ToInt32(dataTable1.Rows[0]["buyprice"].ToString());
                int int32_4 = Convert.ToInt32(this.txtqnt.Text);
                int num2 = int32_3 * int32_4;
                OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM StockMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.drpitemname.Text + "' and type='" + this.drptype.Text + "'", this.con);
                DataTable dataTable2 = new DataTable();
                oleDbDataAdapter2.Fill(dataTable2);
                int int32_5 = Convert.ToInt32(dataTable2.Rows[0]["id"].ToString());
                if (Convert.ToInt32(dataTable2.Rows[0]["availableqnt"].ToString()) > int32_4)
                {
                    if (Convert.ToInt32(this.txtqnt.Text) < int32_1)
                    {
                        new OleDbDataAdapter("update StockInMst set qnt=qnt" + (object)-int32_4 + " where id=" + (object)int32_2, this.con).Fill(new DataTable());
                        new OleDbDataAdapter("update StockMst set totalqnt=totalqnt" + (object)-int32_4 + ", availableqnt=availableqnt" + (object)-int32_4 + ", availableprice=availableprice " + (object)-num2 + " where id=" + (object)int32_5, this.con).Fill(new DataTable());
                        new OleDbDataAdapter("insert into StockreturnMst (Company,ItemName,type,qnt,Price,edate) values('" + dataTable2.Rows[0]["companyName"].ToString() + "','" + dataTable2.Rows[0]["itemname"].ToString() + "','" + dataTable2.Rows[0]["type"].ToString() + "'," + this.txtqnt.Text + "," + (object)num2 + ",'" + (object)DateTime.Now + "')", this.con).Fill(new DataTable());
                        int num3 = (int)MessageBox.Show("Stock Returned Successfully to Company !!", "Care You");
                        this.txtqnt.Text = "";
                        this.groupBox1.Visible = false;
                    }
                    else if (Convert.ToInt32(this.txtqnt.Text) == int32_1)
                    {
                        new OleDbDataAdapter("delete FROM StockInMst where id=" + (object)int32_2, this.con).Fill(new DataTable());
                        new OleDbDataAdapter("update StockMst set totalqnt=totalqnt" + (object)-int32_4 + ", availableqnt=availableqnt" + (object)-int32_4 + ", availableprice=availableprice " + (object)-num2 + " where id=" + (object)int32_5, this.con).Fill(new DataTable());
                        new OleDbDataAdapter("insert into StockreturnMst (Company,ItemName,type,qnt,Price,edate) values('" + dataTable2.Rows[0]["companyName"].ToString() + "','" + dataTable2.Rows[0]["itemname"].ToString() + "','" + dataTable2.Rows[0]["type"].ToString() + "'," + this.txtqnt.Text + "," + (object)num2 + ",'" + (object)DateTime.Now + "')", this.con).Fill(new DataTable());
                        int num3 = (int)MessageBox.Show("Stock Returned Successfully to Company !!", "Care You");
                        this.txtqnt.Text = "";
                        this.groupBox1.Visible = false;
                    }
                    else
                    {
                        int num4 = (int)MessageBox.Show("Enter valid qnt !!", "Care You");
                    }
                }
                else
                {
                    int num5 = (int)MessageBox.Show("Enter valid qnt !!", "Care You");
                }
                OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT top 1 * FROM StockInMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.drpitemname.Text + "' and type='" + this.drptype.Text + "' order by id desc", this.con);
                DataTable dataTable3 = new DataTable();
                oleDbDataAdapter3.Fill(dataTable3);
                this.gvstockin.AutoGenerateColumns = false;
                this.gvstockin.DataSource = (object)dataTable3;
                OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("SELECT * FROM StockMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.drpitemname.Text + "' and type='" + this.drptype.Text + "'", this.con);
                DataTable dataTable4 = new DataTable();
                oleDbDataAdapter4.Fill(dataTable4);
                this.gvstock.AutoGenerateColumns = false;
                this.gvstock.DataSource = (object)dataTable4;
                this.txtqnt.Focus();
            }
        }

        private void drptype_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnselect.Enabled = true;
        }
    }
}
