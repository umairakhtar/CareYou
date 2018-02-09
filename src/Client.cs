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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDataSet.ClientMst' table. You can move, or remove it, as needed.
            this.clientMstTableAdapter.Fill(this.stockDataSet.ClientMst);
            OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
            selectConnection.Open();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM ClientMst", selectConnection);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter.Fill(dataTable);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = (object)dataTable;
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose;
        }

        private void btnaddclient_Click(object sender, EventArgs e)
        {
            if (this.txtname.Text == "")
            {
                int num1 = (int)MessageBox.Show("Enter Client name !!", "Care You");
            }
            else if (this.txtmobile.Text == "")
            {
                int num2 = (int)MessageBox.Show("Enter mobile no. !!", "Care You");
            }
            else if (this.txtaddress.Text == "")
            {
                int num3 = (int)MessageBox.Show("Enter client address !!", "Care You");
            }
            else
            {
                OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
                selectConnection.Open();
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM ClientMst Where Mobile='" + this.txtmobile.Text + "'", selectConnection);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                if (dataTable1.Rows.Count == 0)
                {
                    new OleDbDataAdapter("Insert into ClientMst(name,mobile,address,edate) values('" + this.txtname.Text + "','" + this.txtmobile.Text + "','" + this.txtaddress.Text + "','" + (object)DateTime.Now + "')", selectConnection).Fill(new DataTable());
                    int num4 = (int)MessageBox.Show("Client Detail Added !!", "Care You");
                    this.txtaddress.Text = "";
                    this.txtname.Text = "";
                    this.txtmobile.Text = "";
                    this.txtname.Focus();
                    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM ClientMst", selectConnection);
                    DataTable dataTable2 = new DataTable();
                    oleDbDataAdapter2.Fill(dataTable2);
                    this.dataGridView1.AutoGenerateColumns = false;
                    this.dataGridView1.DataSource = (object)dataTable2;
                }
                else
                {
                    int num4 = (int)MessageBox.Show("Mobile Already Registered !!", "Care You");
                    this.txtmobile.Focus();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!this.dataGridView1.Rows[e.RowIndex].Cells[4].Selected || MessageBox.Show("Are you sure !! You want to Delete !!", "Care You", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;
            OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
            selectConnection.Open();
            new OleDbDataAdapter("delete from ClientMst where ID=" + this.dataGridView1.Rows[e.RowIndex].Cells[0].Value, selectConnection).Fill(new DataTable());
            int num = (int)MessageBox.Show("Client Detail Deleted !!", "Care You");
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM ClientMst", selectConnection);
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
