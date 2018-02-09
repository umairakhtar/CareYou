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
    public partial class Users : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
        public string namee;
        public Users(string nam)
        {
            InitializeComponent();
            this.namee = nam;
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDataSet.UserMst' table. You can move, or remove it, as needed.
            this.userMstTableAdapter.Fill(this.stockDataSet.UserMst);
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM UserMst", this.con);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter.Fill(dataTable);
            this.Gvuser.AutoGenerateColumns = false;
            this.Gvuser.DataSource = (object)dataTable;
            this.Gvuser.RowsDefaultCellStyle.BackColor = Color.White;
            this.Gvuser.AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            this.con.Open();
            if (this.txtuname.Text == "")
            {
                int num1 = (int)MessageBox.Show("Enter UserName !!", "Care You");
            }
            else if (this.txtupass.Text != "")
            {
                if (this.txtupass.Text == this.txtcpass.Text)
                {
                    new OleDbDataAdapter("Insert into UserMst(uname,upass,utype,edate)  values ('" + this.txtuname.Text + "','" + this.txtupass.Text + "','" + (!this.rdoadmin.Checked ? "USER" : "ADMIN") + "','" + (object)DateTime.Now.Date + "')", this.con).Fill(new DataTable());
                    int num2 = (int)MessageBox.Show("User Account Inserted !!", "Care You");
                    this.txtupass.Text = "";
                    this.txtuname.Text = "";
                    this.txtcpass.Text = "";
                    this.rdoadmin.Checked = true;
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM UserMst", this.con);
                    DataTable dataTable = new DataTable();
                    oleDbDataAdapter.Fill(dataTable);
                    this.Gvuser.AutoGenerateColumns = false;
                    this.Gvuser.DataSource = (object)dataTable;
                }
                else
                {
                    int num3 = (int)MessageBox.Show("Password not same !!", "Care You");
                }
            }
            else
            {
                int num4 = (int)MessageBox.Show("Enter Password !!", "Care You");
            }
            this.con.Close();
        }

        private void Gvuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!this.Gvuser.Rows[e.RowIndex].Cells[4].Selected || MessageBox.Show("Are you sure !! You want to Delete !!", "Care You", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;
            this.con.Open();
            if (this.namee == this.Gvuser.Rows[e.RowIndex].Cells[0].Value.ToString())
            {
                int num1 = (int)MessageBox.Show("You can't delete your account !!", "Care You");
            }
            else
            {
                new OleDbDataAdapter("delete from UserMSt where ID=" + this.Gvuser.Rows[e.RowIndex].Cells[5].Value, this.con).Fill(new DataTable());
                int num2 = (int)MessageBox.Show("User Detail Deleted !!", "Care You");
            }
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM UserMSt", this.con);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter.Fill(dataTable);
            this.Gvuser.AutoGenerateColumns = false;
            this.Gvuser.DataSource = (object)dataTable;
            this.con.Close();
        }
    }
}
