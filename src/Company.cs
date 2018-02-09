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
    public partial class Company : Form
    {
        public Company()
        {
            InitializeComponent();
        }

        private void Company_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDataSet.CompanyMst' table. You can move, or remove it, as needed.
            this.companyMstTableAdapter.Fill(this.stockDataSet.CompanyMst);
            OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
            selectConnection.Open();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM CompanyMst", selectConnection);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter.Fill(dataTable);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = (object)dataTable;

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (this.txtcompnayname.Text == "")
            {
                int num1 = (int)MessageBox.Show("Enter company name !!", "Care You");
            }
            else if (this.txtconntactname.Text == "")
            {
                int num2 = (int)MessageBox.Show("Enter Person name !!", "Care You");
            }
            else if (this.txtadd.Text == "")
            {
                int num3 = (int)MessageBox.Show("Enter company address !!", "Care You");
            }
            else if (this.txtmobile.Text == "")
            {
                int num4 = (int)MessageBox.Show("Enter contact no. !!", "Care You");
            }
            else
            {
                OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
                selectConnection.Open();
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM CompanyMst where companyname='" + this.txtcompnayname.Text + "'", selectConnection);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                if (dataTable1.Rows.Count > 0)
                {
                    int num5 = (int)MessageBox.Show("Company Already Registered !!", "Care You");
                    this.txtcompnayname.Focus();
                }
                else
                {
                    new OleDbDataAdapter("Insert into CompanyMst(companyname,address,contactname,contact,edate) values('" + this.txtcompnayname.Text + "','" + this.txtadd.Text + "','" + this.txtconntactname.Text + "','" + this.txtmobile.Text + "','" + (object)DateTime.Now + "')", selectConnection).Fill(new DataTable());
                    int num5 = (int)MessageBox.Show("Company Detail Added !!", "Care You");
                    this.txtmobile.Text = "";
                    this.txtconntactname.Text = "";
                    this.txtcompnayname.Text = "";
                    this.txtadd.Text = "";
                    this.txtcompnayname.Focus();
                    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM CompanyMst", selectConnection);
                    DataTable dataTable2 = new DataTable();
                    oleDbDataAdapter2.Fill(dataTable2);
                    this.dataGridView1.AutoGenerateColumns = false;
                    this.dataGridView1.DataSource = (object)dataTable2;
                    this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
                    this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!this.dataGridView1.Rows[e.RowIndex].Cells[5].Selected || MessageBox.Show("Are you sure !! You want to Delete !!", "Stock System", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;
            OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
            selectConnection.Open();
            new OleDbDataAdapter("delete from CompanyMst where ID=" + this.dataGridView1.Rows[e.RowIndex].Cells[0].Value, selectConnection).Fill(new DataTable());
            int num = (int)MessageBox.Show("Company Detail Deleted !!", "Care You");
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM CompanyMst", selectConnection);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter.Fill(dataTable);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = (object)dataTable;
        }

        private void txtmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
            if ((int)e.KeyChar == 8 || char.IsNumber(e.KeyChar))
                return;
            e.Handled = true;
        }
    }
}
