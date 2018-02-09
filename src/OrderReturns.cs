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
    public partial class OrderReturns : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
        private int oid = 0;
        private int sid = 0;
        private int sprice = 0;
        private string companyname;
        private string iname;
        private string itype;
        public OrderReturns()
        {
            InitializeComponent();
        }

        private void OrderReturns_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDataSet.SellMst' table. You can move, or remove it, as needed.
            this.sellMstTableAdapter.Fill(this.stockDataSet.SellMst);
            // TODO: This line of code loads data into the 'stockDataSet.PaymentMst' table. You can move, or remove it, as needed.
            this.paymentMstTableAdapter.Fill(this.stockDataSet.PaymentMst);
            this.gbreturn.Visible = false;
            this.gvsell.RowsDefaultCellStyle.BackColor = Color.White;
            this.gvsell.AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose;
            this.gvorder.RowsDefaultCellStyle.BackColor = Color.White;
            this.gvorder.AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose;
        }

        private void txtmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
            if ((int)e.KeyChar == 8 || char.IsNumber(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void txtbillno_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
            if ((int)e.KeyChar == 8 || char.IsNumber(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            if (this.txtbillno.Text != "")
            {
                this.con.Open();
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM PaymentMst where id=" + this.txtbillno.Text, this.con);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                if (dataTable1.Rows.Count != 0)
                {
                    this.gvorder.AutoGenerateColumns = false;
                    this.gvorder.DataSource = (object)dataTable1;
                    this.oid = Convert.ToInt32(dataTable1.Rows[0]["id"].ToString());
                    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM sellmst where billno=" + this.txtbillno.Text, this.con);
                    DataTable dataTable2 = new DataTable();
                    oleDbDataAdapter2.Fill(dataTable2);
                    this.gvsell.AutoGenerateColumns = false;
                    this.gvsell.DataSource = (object)dataTable2;
                    this.gbreturnorder.Visible = true;
                }
                else
                {
                    int num = (int)MessageBox.Show("Invalid Bill No. ", "Care You");
                    this.gbreturnorder.Visible = false;
                }
                this.con.Close();
            }
            else
            {
                if (this.txtmobile.Text != "")
                    return;
                int num = (int)MessageBox.Show("Input mobile no or bill no !!", "Care You");
            }
        }

        private void gvsell_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!this.gvsell.Rows[e.RowIndex].Cells[5].Selected)
        return;
      this.sid = Convert.ToInt32(this.gvsell.Rows[e.RowIndex].Cells[6].Value.ToString());
      this.con.Open();
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM Sellmst where id=" + (object) this.sid, this.con);
      DataTable dataTable = new DataTable();
      oleDbDataAdapter.Fill(dataTable);
      this.lbliname.Text = dataTable.Rows[0]["itemname"].ToString();
      this.lbliqnt.Text = dataTable.Rows[0]["qnt"].ToString();
      this.sprice = Convert.ToInt32(dataTable.Rows[0]["price"].ToString());
      this.companyname = dataTable.Rows[0]["company"].ToString();
      this.iname = dataTable.Rows[0]["itemname"].ToString();
      this.itype = dataTable.Rows[0]["type"].ToString();
      this.gbreturn.Visible = true;
      this.con.Close();
      this.txtqnt.Focus();
        }

        private void txtqnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
            if ((int)e.KeyChar == 8 || char.IsNumber(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void btnreturns_Click(object sender, EventArgs e)
        {
            int int32_1 = Convert.ToInt32(this.txtqnt.Text);
            int int32_2 = Convert.ToInt32(this.lbliqnt.Text);
            this.sprice = this.sprice * int32_1;
            if (int32_2 == int32_1)
            {
                this.con.Open();
                new OleDbDataAdapter("update stockmst set availableqnt=availableqnt + " + (object)int32_1 + ", sellqnt=sellqnt - " + (object)int32_1 + ", sellprice=sellprice - " + (object)this.sprice + " where companyname='" + this.companyname + "' and itemname='" + this.iname + "' and type='" + this.itype + "'", this.con).Fill(new DataTable());
                new OleDbDataAdapter("Delete FROM Sellmst where id=" + (object)this.sid, this.con).Fill(new DataTable());
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from paymentmst where id=" + (object)this.oid, this.con);
                DataTable dataTable = new DataTable();
                oleDbDataAdapter.Fill(dataTable);
                if (Convert.ToInt32(dataTable.Rows[0]["qnt"].ToString()) == int32_1)
                    new OleDbDataAdapter("delete from paymentmst where id=" + (object)this.oid, this.con).Fill(new DataTable());
                else
                    new OleDbDataAdapter("update paymentmst set qnt=qnt - " + (object)int32_1 + ", amount=amount - " + (object)this.sprice + ", paidamt=paidamt - " + (object)this.sprice + " where id=" + (object)this.oid, this.con).Fill(new DataTable());
                int num = (int)MessageBox.Show("Product Returned Successfully. !!", "Care You");
                this.txtqnt.Text = "";
                this.txtbillno.Text = "";
                this.txtmobile.Text = "";
                this.lblname.Text = "";
                this.con.Close();
                this.gbreturn.Visible = false;
                this.gbreturnorder.Visible = false;
            }
            else if (int32_2 > int32_1)
            {
                this.con.Open();
                new OleDbDataAdapter("update stockmst set availableqnt=availableqnt + " + (object)int32_1 + ", sellqnt=sellqnt - " + (object)int32_1 + ", sellprice=sellprice - " + (object)this.sprice + " where companyname='" + this.companyname + "' and itemname='" + this.iname + "' and type='" + this.itype + "'", this.con).Fill(new DataTable());
                new OleDbDataAdapter("Update Sellmst set qnt=qnt - " + (object)int32_1 + ", totalprice=totalprice - " + (object)this.sprice + " where id=" + (object)this.sid, this.con).Fill(new DataTable());
                new OleDbDataAdapter("update paymentmst set qnt=qnt - " + (object)int32_1 + ", amount=amount - " + (object)this.sprice + ", paidamt=paidamt - " + (object)this.sprice + " where id=" + (object)this.oid, this.con).Fill(new DataTable());
                this.con.Close();
                int num = (int)MessageBox.Show("Product Returned Successfully. !!", "Care You");
                this.gbreturn.Visible = false;
                this.gbreturnorder.Visible = false;
                this.txtqnt.Text = "";
                this.txtbillno.Text = "";
                this.txtmobile.Text = "";
                this.lblname.Text = "";
            }
            else
            {
                int num = (int)MessageBox.Show("Return qnt must be less than sell qnt !!", " Error - Care You");
                this.txtqnt.Focus();
            }
        }

        private void btnselectnew_Click(object sender, EventArgs e)
        {
            if (this.txtmobile.Text != "")
            {
                this.con.Open();
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("select top 1 * from paymentmst where edate >= # " + (object)this.caldate.Value.Date + "# and edate <= #" + (object)this.caldate.Value.Date.AddHours(24.0) + "# and  mobile= '" + this.txtmobile.Text + "' and partyname='" + this.lblname.Text + "' order by id desc", this.con);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                this.gvorder.AutoGenerateColumns = false;
                this.gvorder.DataSource = (object)dataTable1;
                this.oid = Convert.ToInt32(dataTable1.Rows[0]["id"].ToString());
                OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM sellmst where billno=" + (object)this.oid, this.con);
                DataTable dataTable2 = new DataTable();
                oleDbDataAdapter2.Fill(dataTable2);
                this.gvsell.AutoGenerateColumns = false;
                this.gvsell.DataSource = (object)dataTable2;
                this.gbreturnorder.Visible = true;
            }
            else
            {
                int num = (int)MessageBox.Show("Input Mobile No. !!", "Care You");
            }
            this.con.Close();
        }

        private void txtmobile_Leave(object sender, EventArgs e)
        {
            if (this.txtmobile.Text != "")
            {
                this.con.Open();
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from clientmst where mobile= '" + this.txtmobile.Text + "'", this.con);
                DataTable dataTable = new DataTable();
                oleDbDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count != 0)
                {
                    this.lblname.Text = dataTable.Rows[0]["name"].ToString();
                }
                else
                {
                    int num = (int)MessageBox.Show("Invalid Mobile No. !!", "Care You");
                }
            }
            else
            {
                int num1 = (int)MessageBox.Show("Input Mobile No. !!", "Care You");
            }
            this.con.Close();
        }

        private void txtbillno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            this.btnselect.PerformClick();
        }
    }
}
