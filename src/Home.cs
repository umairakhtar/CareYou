using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Windows.Forms.Layout;

namespace CareYou
{
    public partial class Home : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.lbltime.Text = DateTime.Now.ToString();
            this.lblday.Text = DateTime.Now.DayOfWeek.ToString();
            foreach (Control control in (ArrangedElementCollection)this.Controls)
            {
                try
                {
                    control.BackColor = Color.CadetBlue;
                }
                catch (Exception)
                {
                }
            }
        }
        private void closeExistingForm()
        {
            try
            {
                this.ActiveMdiChild.Close();
            }
            catch (Exception )
            {
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbltime.Text = DateTime.Now.ToString();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (this.txtname.Text == "")
            {
                int num1 = (int)MessageBox.Show("Enter Login Name !", "Care You");
            }
            else if (this.txtpass.Text == "")
            {
                int num2 = (int)MessageBox.Show("Enter Login Password !", "Care You");
            }
            else
            {
                this.con.Open();
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from  UserMst where Uname='" + this.txtname.Text + "' and UPass='" + this.txtpass.Text + "'", this.con);
                DataTable dataTable = new DataTable();
                oleDbDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count == 0)
                {
                    int num3 = (int)MessageBox.Show("Invalid User Detail !!", "Care You");
                }
                else
                {
                    if (dataTable.Rows[0]["utype"].ToString() == "ADMIN")
                    {
                        this.sELLToolStripMenuItem.Visible = true;
                        this.hOMEToolStripMenuItem1.Visible = true;
                        this.logOutToolStripMenuItem.Visible = true;
                        this.companyToolStripMenuItem.Visible = true;
                        this.rEPORTSToolStripMenuItem.Visible = true;
                        this.sTOCKINToolStripMenuItem.Visible = true;
                        this.rETURNSToolStripMenuItem.Visible = true;
                        this.aDMINToolStripMenuItem.Visible = true;
                        this.companyPaymentToolStripMenuItem.Visible = true;
                        this.userAccountToolStripMenuItem.Visible = true;
                        this.customerOrderToolStripMenuItem.Visible = true;
                        this.companyStockToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        this.sELLToolStripMenuItem.Visible = true;
                        this.hOMEToolStripMenuItem1.Visible = true;
                        this.logOutToolStripMenuItem.Visible = true;
                        this.companyToolStripMenuItem.Visible = true;
                        this.rEPORTSToolStripMenuItem.Visible = true;
                        this.sTOCKINToolStripMenuItem.Visible = true;
                        this.rETURNSToolStripMenuItem.Visible = true;
                        this.aDMINToolStripMenuItem.Visible = true;
                        this.companyPaymentToolStripMenuItem.Visible = false;
                        this.userAccountToolStripMenuItem.Visible = false;
                        this.customerOrderToolStripMenuItem.Visible = false;
                        this.companyStockToolStripMenuItem.Visible = false;
                    }

                    this.lblname.Text = this.txtname.Text;
                    this.label4.Text = "Welcome";
                    this.txtname.Text = "";
                    this.txtpass.Text = "";
                    this.gplogin.Visible = false;
                    this.lbltitle.Visible = true;
                    this.pictureBox4.Visible = false;
                    this.pictureBox1.Visible = true;
                    this.label3.Visible = true;
                    this.closeExistingForm();
                    Form form = (Form)new Login();
                    form.MdiParent = (Form)this;
                    form.Show();
                }
            }
            this.con.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.sELLToolStripMenuItem.Visible = false;
            this.logOutToolStripMenuItem.Visible = false;
            this.rEPORTSToolStripMenuItem.Visible = false;
            this.sTOCKINToolStripMenuItem.Visible = false;
            this.rETURNSToolStripMenuItem.Visible = false;
            this.aDMINToolStripMenuItem.Visible = false;
            this.hOMEToolStripMenuItem1.Visible = false;
            this.closeExistingForm();
            this.lblname.Text = "";
            this.label4.Text = "";
            this.gplogin.Visible = true;
            this.lbltitle.Visible = true;
            this.pictureBox4.Visible = true;
            this.pictureBox1.Visible = false;
            this.label3.Visible = true;
            this.txtname.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.closeExistingForm();
            Form form = (Form)new Company();
            form.MdiParent = (Form)this;
            form.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.closeExistingForm();
            Form form = (Form)new Stock();
            form.MdiParent = (Form)this;
            form.Show();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.closeExistingForm();
            Form form = (Form)new Client();
            form.MdiParent = (Form)this;
            form.Show();
        }

        private void sELLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.closeExistingForm();
            Form form = (Form)new Sell();
            form.MdiParent = (Form)this;
            form.Show();
        }

        private void companyStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.closeExistingForm();
            Form form = (Form)new StockReturns();
            form.MdiParent = (Form)this;
            form.Show();
        }

        private void customerOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.closeExistingForm();
            Form form = (Form)new OrderReturns();
            form.MdiParent = (Form)this;
            form.Show();
        }

        private void alertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.closeExistingForm();
            Form form = (Form)new StockAlert();
            form.MdiParent = (Form)this;
            form.Show();
        }

        private void stockINToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.closeExistingForm();
            Form form = (Form)new ReportStockIn();
            form.MdiParent = (Form)this;
            form.Show();
        }

        private void stockToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.closeExistingForm();
            Form form = (Form)new ReportStock();
            form.MdiParent = (Form)this;
            form.Show();
        }

        private void sellToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.closeExistingForm();
            Form form = (Form)new ReportSellStock();
            form.MdiParent = (Form)this;
            form.Show();
        }

        private void paymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.closeExistingForm();
            Form form = (Form)new ReportPayment();
            form.MdiParent = (Form)this;
            form.Show();
        }

        private void companyPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.closeExistingForm();
            Form form = (Form)new CompanyPayment();
            form.MdiParent = (Form)this;
            form.Show();
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.closeExistingForm();
            Form form = (Form)new Users(this.lblname.Text);
            form.MdiParent = (Form)this;
            form.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.closeExistingForm();
            Form form = (Form)new Password(this.lblname.Text);
            form.MdiParent = (Form)this;
            form.Show();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.closeExistingForm();
            Form form = (Form)new Payment(0);
            form.MdiParent = (Form)this;
            form.Show();
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            this.btnlogin.PerformClick();
        }

        private void returnStockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.closeExistingForm();
            Form form = (Form)new ReportStockReturn();
            form.MdiParent = (Form)this;
            form.Show();
        }

        private void hOMEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.closeExistingForm();
            Form form = (Form)new Login();
            form.MdiParent = (Form)this;
            form.Show();
        }

        private void printBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.closeExistingForm();
            Form form = (Form)new Bill();
            form.MdiParent = (Form)this;
            form.Show();
        }
    }
}
