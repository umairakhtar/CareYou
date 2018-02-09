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
    public partial class Login : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT sum(totalqnt) as tqnt, sum(availableqnt) as aqnt, sum(sellqnt) as sqnt, sum(availableprice) as aamt, sum(sellprice) as samt FROM StockMst", this.con);
            DataTable dataTable1 = new DataTable();
            oleDbDataAdapter1.Fill(dataTable1);
            if (dataTable1.Rows.Count > 0 && dataTable1.Rows[0]["samt"].ToString() != "")
            {
                this.lbltstock.Text = dataTable1.Rows[0]["tqnt"].ToString();
                this.lbltsell.Text = dataTable1.Rows[0]["sqnt"].ToString();
                this.lbltavailable.Text = dataTable1.Rows[0]["aqnt"].ToString();
                double num = Convert.ToDouble(dataTable1.Rows[0]["samt"].ToString()) + Convert.ToDouble(dataTable1.Rows[0]["aamt"].ToString());
                this.lblsamt.Text = "Rs. " + dataTable1.Rows[0]["samt"].ToString();
                this.lblaamt.Text = "Rs. " + dataTable1.Rows[0]["aamt"].ToString();
                this.lbltamt.Text = "Rs. " + num.ToString();
            }
            OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT count(id) as record, status FROM paymentmst group by status", this.con);
            DataTable dataTable2 = new DataTable();
            oleDbDataAdapter2.Fill(dataTable2);
            if (dataTable2.Rows.Count == 1)
            {
                if (dataTable2.Rows[0]["status"].ToString() == "PAID")
                {
                    this.lbltorder.Text = dataTable2.Rows[0]["record"].ToString();
                    this.lblpaidorder.Text = dataTable2.Rows[0]["record"].ToString();
                    this.lblunpaidorder.Text = "0";
                }
                else if (dataTable2.Rows[0]["status"].ToString() == "UNPAID")
                {
                    this.lbltorder.Text = dataTable2.Rows[0]["record"].ToString();
                    this.lblpaidorder.Text = "0";
                    this.lblunpaidorder.Text = dataTable2.Rows[0]["record"].ToString();
                }
            }
            else if (dataTable2.Rows.Count == 2)
            {
                this.lbltorder.Text = (Convert.ToInt32(dataTable2.Rows[0]["record"].ToString()) + Convert.ToInt32(dataTable2.Rows[1]["record"].ToString())).ToString();
                this.lblpaidorder.Text = dataTable2.Rows[0]["record"].ToString();
                this.lblunpaidorder.Text = dataTable2.Rows[1]["record"].ToString();
            }
            OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT sum(amount) as oamt, sum(paidamt) as opamt FROM paymentmst", this.con);
            DataTable dataTable3 = new DataTable();
            oleDbDataAdapter3.Fill(dataTable3);
            if (dataTable3.Rows.Count <= 0 || !(dataTable3.Rows[0]["oamt"].ToString() != ""))
                return;
            this.lblopamt.Text = "Rs. " + dataTable3.Rows[0]["opamt"].ToString();
            this.lbloamt.Text = "Rs. " + dataTable3.Rows[0]["oamt"].ToString();
            this.lblouamt.Text = "Rs. " + (Convert.ToDouble(dataTable3.Rows[0]["oamt"].ToString()) - Convert.ToDouble(dataTable3.Rows[0]["opamt"].ToString())).ToString();
        }
    }
}
