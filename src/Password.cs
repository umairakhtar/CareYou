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
    public partial class Password : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
        public string namee;
        public Password(string nam)
        {
            InitializeComponent();
            this.namee = nam;
        }

        private void btnchangepas_Click(object sender, EventArgs e)
        {
            this.con.Open();
            if (this.txtupass.Text == "")
            {
                int num1 = (int)MessageBox.Show("Enter New Password !!", "Care You");
            }
            else if (this.txtupass.Text != this.txtcpass.Text)
            {
                int num2 = (int)MessageBox.Show("Password not same !!", "Care You");
            }
            else
            {
                new OleDbDataAdapter("update UserMst set upass='" + this.txtupass.Text + "' where uname='" + this.namee + "'", this.con).Fill(new DataTable());
                int num3 = (int)MessageBox.Show("Password Changed Successfully !!", "Care You");
                this.txtcpass.Text = "";
                this.txtupass.Text = "";
            }
            this.con.Close();
        }

        private void Password_Load(object sender, EventArgs e)
        {

        }
    }
}
