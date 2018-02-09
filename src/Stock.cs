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
    public partial class Stock : Form
    {
        private int m = 0;        
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
        public Stock()
        {
            InitializeComponent();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void Stock_Load(object sender, EventArgs e)
        {

            this.m = 1;
            this.con.Open();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM CompanyMst", this.con);
            DataTable dataTable1 = new DataTable();
            oleDbDataAdapter.Fill(dataTable1);
            DataTable dataTable2 = new DataTable();
            oleDbDataAdapter.Fill(dataTable2);
            this.drpcompnay.DataSource = (object)dataTable1;
            this.drpcompnay.DisplayMember = "Companyname";
            this.drpcompnay.ValueMember = "id";
            this.drpcompnay.Text = "SELECT";
            this.drpcompnayview.DataSource = (object)dataTable2;
            this.drpcompnayview.DisplayMember = "Companyname";
            this.drpcompnayview.ValueMember = "id";
            this.drpcompnayview.Text = "SELECT";
            this.m = 0;
            this.con.Close();
        }

        private void btnaddstock_Click(object sender, EventArgs e)
        {
            this.con.Open();
            if (this.drpcompnay.Text == "SELECT")
            {
                int num1 = (int)MessageBox.Show("Select commpany name !!", "Care You");
            }
            else if (this.txtname.Text == "")
            {
                int num2 = (int)MessageBox.Show("Enter stock name !!", "Care You");
            }
            else if (this.txttype.Text == "")
            {
                int num3 = (int)MessageBox.Show("Enter type !!", "Care You");
            }
            else if (this.txtqnt.Text == "")
            {
                int num4 = (int)MessageBox.Show("Enter quantity !!", "Care You");
            }
            else if (this.txtbuyprice.Text == "")
            {
                int num5 = (int)MessageBox.Show("Enter buy price !!", "Care You");
            }
            else if (this.txtsellprice.Text == "")
            {
                int num6 = (int)MessageBox.Show("Enter sell price !!", "Care You");
            }
            else
            {
                
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("Select * from StockMSt Where ItemName='" + this.txtname.Text + "' and Type='" + this.txttype.Text + "' and companyname='" + this.drpcompnay.Text + "'", this.con);
                DataTable dataTable = new DataTable();
                oleDbDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count == 0)
                {
                    new OleDbDataAdapter("Insert into StockInMst(CompanyName,ItemName,type,qnt,BuyPrice,Sellprice,location,edate) values('" + this.drpcompnay.Text + "','" + this.txtname.Text + "','" + this.txttype.Text + "'," + this.txtqnt.Text + "," + this.txtbuyprice.Text + "," + this.txtsellprice.Text + ",'" + this.txtlocation.Text + "','" + (object)this.caldate.Value + "')", this.con).Fill(new DataTable());
                    new OleDbDataAdapter("Insert into StockMst(CompanyName,ItemName,type,price,totalqnt,availableqnt,sellqnt,availableprice,sellprice,entrydate) values('" + this.drpcompnay.Text + "','" + this.txtname.Text + "','" + this.txttype.Text + "'," + this.txtbuyprice.Text + "," + this.txtqnt.Text + "," + this.txtqnt.Text + "," + (object)0 + "," + (object)(Convert.ToInt32(this.txtbuyprice.Text) * Convert.ToInt32(this.txtqnt.Text)) + "," + (object)0 + ",'" + (object)this.caldate.Value + "')", this.con).Fill(new DataTable());
                    int num7 = (int)MessageBox.Show("Stock Detail Added !!", "Care You");
                    this.txtname.Text = "";
                    this.txttype.Text = "";
                    this.txtqnt.Text = "";
                    this.txtbuyprice.Text = "";
                    this.txtsellprice.Text = "";
                    this.txtlocation.Text = "";
                    this.drpcompnay.Text = "SELECT";
                    this.drpcompnay.Focus();
                }
                else
                {
                    int num7 = (int)MessageBox.Show("Stock Detail Already Exists !!", "Care You");
                    this.drpcompnay.Focus();
                }
                this.con.Close();
            }
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            this.con.Open();
            OleDbDataReader oleDbDataReader = new OleDbCommand("select itemname from stockmst where companyname = '" + this.drpcompnayview.Text + "'", this.con).ExecuteReader();
            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
            while (oleDbDataReader.Read())
                stringCollection.Add(oleDbDataReader.GetString(0));
            this.txti1.AutoCompleteCustomSource = stringCollection;
            this.txti2.AutoCompleteCustomSource = stringCollection;
            this.txti3.AutoCompleteCustomSource = stringCollection;
            this.txti4.AutoCompleteCustomSource = stringCollection;
            this.txti5.AutoCompleteCustomSource = stringCollection;
            this.txti6.AutoCompleteCustomSource = stringCollection;
            this.txti7.AutoCompleteCustomSource = stringCollection;
            this.txti8.AutoCompleteCustomSource = stringCollection;
            this.txti9.AutoCompleteCustomSource = stringCollection;
            this.txti10.AutoCompleteCustomSource = stringCollection;
            this.txtditem.AutoCompleteCustomSource = stringCollection;
            this.tabControl1.Enabled = true;
            this.txti1.Enabled = true;
            this.txti1.BackColor = Color.Honeydew;
            this.txtt1.Enabled = true;
            this.txtt1.BackColor = Color.Honeydew;
            this.txtnq1.Enabled = true;
            this.txtnq1.BackColor = Color.Honeydew;
            this.txti1.Focus();
            this.con.Close();
        }

        private void btnaddqnt_Click(object sender, EventArgs e)
        {
            this.con.Open();
            int num1 = 0;
            if (this.txti1.Text != "" && this.txtt1.Text != "" && this.txtnq1.Text != "")
            {
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM StockMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.txti1.Text + "' and type='" + this.txtt1.Text + "'", this.con);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM StockInMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.txti1.Text + "' and type='" + this.txtt1.Text + "'", this.con);
                DataTable dataTable2 = new DataTable();
                oleDbDataAdapter2.Fill(dataTable2);
                if (dataTable1.Rows.Count != 0)
                {
                    new OleDbDataAdapter("Insert into StockInMst(CompanyName,ItemName,type,qnt,BuyPrice,Sellprice,location,edate) values('" + dataTable2.Rows[0]["companyname"].ToString() + "','" + dataTable2.Rows[0]["itemname"].ToString() + "','" + dataTable2.Rows[0]["type"].ToString() + "'," + this.txtnq1.Text + "," + dataTable2.Rows[0]["buyprice"].ToString() + "," + dataTable2.Rows[0]["sellprice"].ToString() + ",'" + dataTable2.Rows[0]["location"].ToString() + "','" + (object)this.calbilldate.Value + "')", this.con).Fill(new DataTable());
                    new OleDbDataAdapter("Update stockmst set totalqnt=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["totalqnt"].ToString()) + Convert.ToInt32(this.txtnq1.Text)) + ",availableqnt=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["availableqnt"].ToString()) + Convert.ToInt32(this.txtnq1.Text)) + ",availableprice=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["price"].ToString()) * Convert.ToInt32(this.txtnq1.Text) + Convert.ToInt32(dataTable1.Rows[0]["availableprice"].ToString())) + " where id=" + (object)Convert.ToInt32(dataTable1.Rows[0]["id"].ToString()), this.con).Fill(new DataTable());
                    num1 = 1;
                    this.txti1.Text = "";
                    this.txtt1.Text = "";
                    this.txtnq1.Text = "";
                    this.txti1.Enabled = false;
                    this.txtt1.Enabled = false;
                    this.txtnq1.Enabled = false;
                    this.txti1.BackColor = Color.DarkSeaGreen;
                    this.txtt1.BackColor = Color.DarkSeaGreen;
                    this.txtnq1.BackColor = Color.DarkSeaGreen;
                }
                else
                {
                    int num2 = (int)MessageBox.Show("Error in 1st Entry !!", "Care You");
                    this.txti1.BackColor = Color.Red;
                    this.txtt1.BackColor = Color.Red;
                    this.txtnq1.BackColor = Color.Red;
                    this.txti1.Focus();
                }
            }
            if (this.txti2.Text != "" && this.txtt2.Text != "" && this.txtnq2.Text != "")
            {
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM StockMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.txti2.Text + "' and type='" + this.txtt2.Text + "'", this.con);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM StockInMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.txti2.Text + "' and type='" + this.txtt2.Text + "'", this.con);
                DataTable dataTable2 = new DataTable();
                oleDbDataAdapter2.Fill(dataTable2);
                if (dataTable1.Rows.Count != 0)
                {
                    new OleDbDataAdapter("Insert into StockInMst(CompanyName,ItemName,type,qnt,BuyPrice,Sellprice,location,edate) values('" + dataTable2.Rows[0]["companyname"].ToString() + "','" + dataTable2.Rows[0]["itemname"].ToString() + "','" + dataTable2.Rows[0]["type"].ToString() + "'," + this.txtnq2.Text + "," + dataTable2.Rows[0]["buyprice"].ToString() + "," + dataTable2.Rows[0]["sellprice"].ToString() + ",'" + dataTable2.Rows[0]["location"].ToString() + "','" + (object)this.calbilldate.Value + "')", this.con).Fill(new DataTable());
                    new OleDbDataAdapter("Update stockmst set totalqnt=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["totalqnt"].ToString()) + Convert.ToInt32(this.txtnq2.Text)) + ",availableqnt=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["availableqnt"].ToString()) + Convert.ToInt32(this.txtnq2.Text)) + ",availableprice=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["price"].ToString()) * Convert.ToInt32(this.txtnq2.Text) + Convert.ToInt32(dataTable1.Rows[0]["availableprice"].ToString())) + " where id=" + (object)Convert.ToInt32(dataTable1.Rows[0]["id"].ToString()), this.con).Fill(new DataTable());
                    this.txti2.Text = "";
                    this.txtt2.Text = "";
                    this.txtnq2.Text = "";
                    this.txti2.Enabled = false;
                    this.txtt2.Enabled = false;
                    this.txtnq2.Enabled = false;
                    this.txti2.BackColor = Color.DarkSeaGreen;
                    this.txtt2.BackColor = Color.DarkSeaGreen;
                    this.txtnq2.BackColor = Color.DarkSeaGreen;
                }
                else
                {
                    int num2 = (int)MessageBox.Show("Error in 2nd Entry !!", "Care You");
                    this.txti2.BackColor = Color.Red;
                    this.txtt2.BackColor = Color.Red;
                    this.txtnq2.BackColor = Color.Red;
                    this.txti2.Focus();
                }
            }
            if (this.txti3.Text != "" && this.txtt3.Text != "" && this.txtnq3.Text != "")
            {
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM StockMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.txti3.Text + "' and type='" + this.txtt3.Text + "'", this.con);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM StockInMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.txti3.Text + "' and type='" + this.txtt3.Text + "'", this.con);
                DataTable dataTable2 = new DataTable();
                oleDbDataAdapter2.Fill(dataTable2);
                if (dataTable1.Rows.Count != 0)
                {
                    new OleDbDataAdapter("Insert into StockInMst(CompanyName,ItemName,type,qnt,BuyPrice,Sellprice,location,edate) values('" + dataTable2.Rows[0]["companyname"].ToString() + "','" + dataTable2.Rows[0]["itemname"].ToString() + "','" + dataTable2.Rows[0]["type"].ToString() + "'," + this.txtnq3.Text + "," + dataTable2.Rows[0]["buyprice"].ToString() + "," + dataTable2.Rows[0]["sellprice"].ToString() + ",'" + dataTable2.Rows[0]["location"].ToString() + "','" + (object)this.calbilldate.Value + "')", this.con).Fill(new DataTable());
                    new OleDbDataAdapter("Update stockmst set totalqnt=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["totalqnt"].ToString()) + Convert.ToInt32(this.txtnq3.Text)) + ",availableqnt=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["availableqnt"].ToString()) + Convert.ToInt32(this.txtnq3.Text)) + ",availableprice=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["price"].ToString()) * Convert.ToInt32(this.txtnq3.Text) + Convert.ToInt32(dataTable1.Rows[0]["availableprice"].ToString())) + " where id=" + (object)Convert.ToInt32(dataTable1.Rows[0]["id"].ToString()), this.con).Fill(new DataTable());
                    this.txti3.Text = "";
                    this.txtt3.Text = "";
                    this.txtnq3.Text = "";
                    this.txti3.Enabled = false;
                    this.txtt3.Enabled = false;
                    this.txtnq3.Enabled = false;
                    this.txti3.BackColor = Color.DarkSeaGreen;
                    this.txtt3.BackColor = Color.DarkSeaGreen;
                    this.txtnq3.BackColor = Color.DarkSeaGreen;
                }
                else
                {
                    int num2 = (int)MessageBox.Show("Error in 3rd Entry !!", "Care You");
                    this.txti3.BackColor = Color.Red;
                    this.txtt3.BackColor = Color.Red;
                    this.txtnq3.BackColor = Color.Red;
                    this.txti3.Focus();
                }
            }
            if (this.txti4.Text != "" && this.txtt4.Text != "" && this.txtnq4.Text != "")
            {
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM StockMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.txti4.Text + "' and type='" + this.txtt4.Text + "'", this.con);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM StockInMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.txti4.Text + "' and type='" + this.txtt4.Text + "'", this.con);
                DataTable dataTable2 = new DataTable();
                oleDbDataAdapter2.Fill(dataTable2);
                if (dataTable1.Rows.Count != 0)
                {
                    new OleDbDataAdapter("Insert into StockInMst(CompanyName,ItemName,type,qnt,BuyPrice,Sellprice,location,edate) values('" + dataTable2.Rows[0]["companyname"].ToString() + "','" + dataTable2.Rows[0]["itemname"].ToString() + "','" + dataTable2.Rows[0]["type"].ToString() + "'," + this.txtnq4.Text + "," + dataTable2.Rows[0]["buyprice"].ToString() + "," + dataTable2.Rows[0]["sellprice"].ToString() + ",'" + dataTable2.Rows[0]["location"].ToString() + "','" + (object)this.calbilldate.Value + "')", this.con).Fill(new DataTable());
                    new OleDbDataAdapter("Update stockmst set totalqnt=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["totalqnt"].ToString()) + Convert.ToInt32(this.txtnq4.Text)) + ",availableqnt=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["availableqnt"].ToString()) + Convert.ToInt32(this.txtnq4.Text)) + ",availableprice=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["price"].ToString()) * Convert.ToInt32(this.txtnq4.Text) + Convert.ToInt32(dataTable1.Rows[0]["availableprice"].ToString())) + " where id=" + (object)Convert.ToInt32(dataTable1.Rows[0]["id"].ToString()), this.con).Fill(new DataTable());
                    this.txti4.Text = "";
                    this.txtt4.Text = "";
                    this.txtnq4.Text = "";
                    this.txti4.Enabled = false;
                    this.txtt4.Enabled = false;
                    this.txtnq4.Enabled = false;
                    this.txti4.BackColor = Color.DarkSeaGreen;
                    this.txtt4.BackColor = Color.DarkSeaGreen;
                    this.txtnq4.BackColor = Color.DarkSeaGreen;
                }
                else
                {
                    int num2 = (int)MessageBox.Show("Error in 4th Entry !!", "Care You");
                    this.txti4.BackColor = Color.Red;
                    this.txtt4.BackColor = Color.Red;
                    this.txtnq4.BackColor = Color.Red;
                    this.txti4.Focus();
                }
            }
            if (this.txti5.Text != "" && this.txtt5.Text != "" && this.txtnq5.Text != "")
            {
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM StockMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.txti5.Text + "' and type='" + this.txtt5.Text + "'", this.con);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM StockInMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.txti5.Text + "' and type='" + this.txtt5.Text + "'", this.con);
                DataTable dataTable2 = new DataTable();
                oleDbDataAdapter2.Fill(dataTable2);
                if (dataTable1.Rows.Count != 0)
                {
                    new OleDbDataAdapter("Insert into StockInMst(CompanyName,ItemName,type,qnt,BuyPrice,Sellprice,location,edate) values('" + dataTable2.Rows[0]["companyname"].ToString() + "','" + dataTable2.Rows[0]["itemname"].ToString() + "','" + dataTable2.Rows[0]["type"].ToString() + "'," + this.txtnq5.Text + "," + dataTable2.Rows[0]["buyprice"].ToString() + "," + dataTable2.Rows[0]["sellprice"].ToString() + ",'" + dataTable2.Rows[0]["location"].ToString() + "','" + (object)this.calbilldate.Value + "')", this.con).Fill(new DataTable());
                    new OleDbDataAdapter("Update stockmst set totalqnt=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["totalqnt"].ToString()) + Convert.ToInt32(this.txtnq5.Text)) + ",availableqnt=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["availableqnt"].ToString()) + Convert.ToInt32(this.txtnq5.Text)) + ",availableprice=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["price"].ToString()) * Convert.ToInt32(this.txtnq5.Text) + Convert.ToInt32(dataTable1.Rows[0]["availableprice"].ToString())) + " where id=" + (object)Convert.ToInt32(dataTable1.Rows[0]["id"].ToString()), this.con).Fill(new DataTable());
                    this.txti5.Text = "";
                    this.txtt5.Text = "";
                    this.txtnq5.Text = "";
                    this.txti5.Enabled = false;
                    this.txtt5.Enabled = false;
                    this.txtnq5.Enabled = false;
                    this.txti5.BackColor = Color.DarkSeaGreen;
                    this.txtt5.BackColor = Color.DarkSeaGreen;
                    this.txtnq5.BackColor = Color.DarkSeaGreen;
                }
                else
                {
                    int num2 = (int)MessageBox.Show("Error in 5th Entry !!", "Care You");
                    this.txti5.BackColor = Color.Red;
                    this.txtt5.BackColor = Color.Red;
                    this.txtnq5.BackColor = Color.Red;
                    this.txti5.Focus();
                }
            }
            if (this.txti6.Text != "" && this.txtt6.Text != "" && this.txtnq6.Text != "")
            {
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM StockMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.txti6.Text + "' and type='" + this.txtt6.Text + "'", this.con);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM StockInMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.txti6.Text + "' and type='" + this.txtt6.Text + "'", this.con);
                DataTable dataTable2 = new DataTable();
                oleDbDataAdapter2.Fill(dataTable2);
                if (dataTable1.Rows.Count != 0)
                {
                    new OleDbDataAdapter("Insert into StockInMst(CompanyName,ItemName,type,qnt,BuyPrice,Sellprice,location,edate) values('" + dataTable2.Rows[0]["companyname"].ToString() + "','" + dataTable2.Rows[0]["itemname"].ToString() + "','" + dataTable2.Rows[0]["type"].ToString() + "'," + this.txtnq6.Text + "," + dataTable2.Rows[0]["buyprice"].ToString() + "," + dataTable2.Rows[0]["sellprice"].ToString() + ",'" + dataTable2.Rows[0]["location"].ToString() + "','" + (object)this.calbilldate.Value + "')", this.con).Fill(new DataTable());
                    new OleDbDataAdapter("Update stockmst set totalqnt=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["totalqnt"].ToString()) + Convert.ToInt32(this.txtnq6.Text)) + ",availableqnt=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["availableqnt"].ToString()) + Convert.ToInt32(this.txtnq6.Text)) + ",availableprice=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["price"].ToString()) * Convert.ToInt32(this.txtnq6.Text) + Convert.ToInt32(dataTable1.Rows[0]["availableprice"].ToString())) + " where id=" + (object)Convert.ToInt32(dataTable1.Rows[0]["id"].ToString()), this.con).Fill(new DataTable());
                    num1 = 1;
                    this.txti6.Text = "";
                    this.txtt6.Text = "";
                    this.txtnq6.Text = "";
                    this.txti6.Enabled = false;
                    this.txtt6.Enabled = false;
                    this.txtnq6.Enabled = false;
                    this.txti6.BackColor = Color.DarkSeaGreen;
                    this.txtt6.BackColor = Color.DarkSeaGreen;
                    this.txtnq6.BackColor = Color.DarkSeaGreen;
                }
                else
                {
                    int num2 = (int)MessageBox.Show("Error in 6th Entry !!", "Care You");
                    this.txti6.BackColor = Color.Red;
                    this.txtt6.BackColor = Color.Red;
                    this.txtnq6.BackColor = Color.Red;
                    this.txti6.Focus();
                }
            }
            if (this.txti7.Text != "" && this.txtt7.Text != "" && this.txtnq7.Text != "")
            {
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM StockMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.txti7.Text + "' and type='" + this.txtt7.Text + "'", this.con);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM StockInMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.txti7.Text + "' and type='" + this.txtt7.Text + "'", this.con);
                DataTable dataTable2 = new DataTable();
                oleDbDataAdapter2.Fill(dataTable2);
                if (dataTable1.Rows.Count != 0)
                {
                    new OleDbDataAdapter("Insert into StockInMst(CompanyName,ItemName,type,qnt,BuyPrice,Sellprice,location,edate) values('" + dataTable2.Rows[0]["companyname"].ToString() + "','" + dataTable2.Rows[0]["itemname"].ToString() + "','" + dataTable2.Rows[0]["type"].ToString() + "'," + this.txtnq7.Text + "," + dataTable2.Rows[0]["buyprice"].ToString() + "," + dataTable2.Rows[0]["sellprice"].ToString() + ",'" + dataTable2.Rows[0]["location"].ToString() + "','" + (object)this.calbilldate.Value + "')", this.con).Fill(new DataTable());
                    new OleDbDataAdapter("Update stockmst set totalqnt=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["totalqnt"].ToString()) + Convert.ToInt32(this.txtnq7.Text)) + ",availableqnt=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["availableqnt"].ToString()) + Convert.ToInt32(this.txtnq7.Text)) + ",availableprice=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["price"].ToString()) * Convert.ToInt32(this.txtnq7.Text) + Convert.ToInt32(dataTable1.Rows[0]["availableprice"].ToString())) + " where id=" + (object)Convert.ToInt32(dataTable1.Rows[0]["id"].ToString()), this.con).Fill(new DataTable());
                    this.txti7.Text = "";
                    this.txtt7.Text = "";
                    this.txtnq7.Text = "";
                    this.txti7.Enabled = false;
                    this.txtt7.Enabled = false;
                    this.txtnq7.Enabled = false;
                    this.txti7.BackColor = Color.DarkSeaGreen;
                    this.txtt7.BackColor = Color.DarkSeaGreen;
                    this.txtnq7.BackColor = Color.DarkSeaGreen;
                }
                else
                {
                    int num2 = (int)MessageBox.Show("Error in 7th Entry !!", "Care You");
                    this.txti7.BackColor = Color.Red;
                    this.txtt7.BackColor = Color.Red;
                    this.txtnq7.BackColor = Color.Red;
                    this.txti7.Focus();
                }
            }
            if (this.txti8.Text != "" && this.txtt8.Text != "" && this.txtnq8.Text != "")
            {
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM StockMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.txti8.Text + "' and type='" + this.txtt8.Text + "'", this.con);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM StockInMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.txti8.Text + "' and type='" + this.txtt8.Text + "'", this.con);
                DataTable dataTable2 = new DataTable();
                oleDbDataAdapter2.Fill(dataTable2);
                if (dataTable1.Rows.Count != 0)
                {
                    new OleDbDataAdapter("Insert into StockInMst(CompanyName,ItemName,type,qnt,BuyPrice,Sellprice,location,edate) values('" + dataTable2.Rows[0]["companyname"].ToString() + "','" + dataTable2.Rows[0]["itemname"].ToString() + "','" + dataTable2.Rows[0]["type"].ToString() + "'," + this.txtnq8.Text + "," + dataTable2.Rows[0]["buyprice"].ToString() + "," + dataTable2.Rows[0]["sellprice"].ToString() + ",'" + dataTable2.Rows[0]["location"].ToString() + "','" + (object)this.calbilldate.Value + "')", this.con).Fill(new DataTable());
                    new OleDbDataAdapter("Update stockmst set totalqnt=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["totalqnt"].ToString()) + Convert.ToInt32(this.txtnq8.Text)) + ",availableqnt=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["availableqnt"].ToString()) + Convert.ToInt32(this.txtnq8.Text)) + ",availableprice=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["price"].ToString()) * Convert.ToInt32(this.txtnq8.Text) + Convert.ToInt32(dataTable1.Rows[0]["availableprice"].ToString())) + " where id=" + (object)Convert.ToInt32(dataTable1.Rows[0]["id"].ToString()), this.con).Fill(new DataTable());
                    this.txti8.Text = "";
                    this.txtt8.Text = "";
                    this.txtnq8.Text = "";
                    this.txti8.Enabled = false;
                    this.txtt8.Enabled = false;
                    this.txtnq8.Enabled = false;
                    this.txti8.BackColor = Color.DarkSeaGreen;
                    this.txtt8.BackColor = Color.DarkSeaGreen;
                    this.txtnq8.BackColor = Color.DarkSeaGreen;
                }
                else
                {
                    int num2 = (int)MessageBox.Show("Error in 8th Entry !!", "Care You");
                    this.txti8.BackColor = Color.Red;
                    this.txtt8.BackColor = Color.Red;
                    this.txtnq8.BackColor = Color.Red;
                    this.txti8.Focus();
                }
            }
            if (this.txti9.Text != "" && this.txtt9.Text != "" && this.txtnq9.Text != "")
            {
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM StockMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.txti9.Text + "' and type='" + this.txtt9.Text + "'", this.con);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM StockInMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.txti9.Text + "' and type='" + this.txtt9.Text + "'", this.con);
                DataTable dataTable2 = new DataTable();
                oleDbDataAdapter2.Fill(dataTable2);
                if (dataTable1.Rows.Count != 0)
                {
                    new OleDbDataAdapter("Insert into StockInMst(CompanyName,ItemName,type,qnt,BuyPrice,Sellprice,location,edate) values('" + dataTable2.Rows[0]["companyname"].ToString() + "','" + dataTable2.Rows[0]["itemname"].ToString() + "','" + dataTable2.Rows[0]["type"].ToString() + "'," + this.txtnq9.Text + "," + dataTable2.Rows[0]["buyprice"].ToString() + "," + dataTable2.Rows[0]["sellprice"].ToString() + ",'" + dataTable2.Rows[0]["location"].ToString() + "','" + (object)this.calbilldate.Value + "')", this.con).Fill(new DataTable());
                    new OleDbDataAdapter("Update stockmst set totalqnt=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["totalqnt"].ToString()) + Convert.ToInt32(this.txtnq9.Text)) + ",availableqnt=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["availableqnt"].ToString()) + Convert.ToInt32(this.txtnq9.Text)) + ",availableprice=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["price"].ToString()) * Convert.ToInt32(this.txtnq9.Text) + Convert.ToInt32(dataTable1.Rows[0]["availableprice"].ToString())) + " where id=" + (object)Convert.ToInt32(dataTable1.Rows[0]["id"].ToString()), this.con).Fill(new DataTable());
                    this.txti9.Text = "";
                    this.txtt9.Text = "";
                    this.txtnq9.Text = "";
                    this.txti9.Enabled = false;
                    this.txtt9.Enabled = false;
                    this.txtnq9.Enabled = false;
                    this.txti9.BackColor = Color.DarkSeaGreen;
                    this.txtt9.BackColor = Color.DarkSeaGreen;
                    this.txtnq9.BackColor = Color.DarkSeaGreen;
                }
                else
                {
                    int num2 = (int)MessageBox.Show("Error in 9th Entry !!", "Care You");
                    this.txti9.BackColor = Color.Red;
                    this.txtt9.BackColor = Color.Red;
                    this.txtnq9.BackColor = Color.Red;
                    this.txti9.Focus();
                }
            }
            if (this.txti10.Text != "" && this.txtt10.Text != "" && this.txtnq10.Text != "")
            {
                OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT * FROM StockMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.txti10.Text + "' and type='" + this.txtt10.Text + "'", this.con);
                DataTable dataTable1 = new DataTable();
                oleDbDataAdapter1.Fill(dataTable1);
                OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM StockInMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.txti10.Text + "' and type='" + this.txtt10.Text + "'", this.con);
                DataTable dataTable2 = new DataTable();
                oleDbDataAdapter2.Fill(dataTable2);
                if (dataTable1.Rows.Count != 0)
                {
                    new OleDbDataAdapter("Insert into StockInMst(CompanyName,ItemName,type,qnt,BuyPrice,Sellprice,location,edate) values('" + dataTable2.Rows[0]["companyname"].ToString() + "','" + dataTable2.Rows[0]["itemname"].ToString() + "','" + dataTable2.Rows[0]["type"].ToString() + "'," + this.txtnq10.Text + "," + dataTable2.Rows[0]["buyprice"].ToString() + "," + dataTable2.Rows[0]["sellprice"].ToString() + ",'" + dataTable2.Rows[0]["location"].ToString() + "','" + (object)this.calbilldate.Value + "')", this.con).Fill(new DataTable());
                    new OleDbDataAdapter("Update stockmst set totalqnt=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["totalqnt"].ToString()) + Convert.ToInt32(this.txtnq10.Text)) + ",availableqnt=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["availableqnt"].ToString()) + Convert.ToInt32(this.txtnq10.Text)) + ",availableprice=" + (object)(Convert.ToInt32(dataTable1.Rows[0]["price"].ToString()) * Convert.ToInt32(this.txtnq10.Text) + Convert.ToInt32(dataTable1.Rows[0]["availableprice"].ToString())) + " where id=" + (object)Convert.ToInt32(dataTable1.Rows[0]["id"].ToString()), this.con).Fill(new DataTable());
                    this.txti10.Text = "";
                    this.txtt10.Text = "";
                    this.txtnq10.Text = "";
                    this.txti10.Enabled = false;
                    this.txtt10.Enabled = false;
                    this.txtnq10.Enabled = false;
                    this.txti10.BackColor = Color.DarkSeaGreen;
                    this.txtt10.BackColor = Color.DarkSeaGreen;
                    this.txtnq10.BackColor = Color.DarkSeaGreen;
                }
                else
                {
                    int num2 = (int)MessageBox.Show("Error in 10th Entry !!", "Care You");
                    this.txti10.BackColor = Color.Red;
                    this.txtt10.BackColor = Color.Red;
                    this.txtnq10.BackColor = Color.Red;
                    this.txti10.Focus();
                }
            }
            if (num1 == 1)
            {
                int num3 = (int)MessageBox.Show("Stock Quantity Added !!", "Care You");
            }
            else
            {
                int num4 = (int)MessageBox.Show("Invalid Entry !!", "Care You");
            }
            this.con.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.con.Open();
            if (MessageBox.Show("Are you sure to Delete Stock !!", "Care You", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * FROM sellmst where company='" + this.drpcompnayview.Text + "' and itemname='" + this.txtditem.Text + "' and type='" + this.txtdtype.Text + "'", this.con);
                DataTable dataTable = new DataTable();
                oleDbDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count == 0)
                {
                    new OleDbDataAdapter("delete FROM StockInMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.txtditem.Text + "' and type='" + this.txtdtype.Text + "'", this.con).Fill(new DataTable());
                    new OleDbDataAdapter("delete FROM StockMst where companyname='" + this.drpcompnayview.Text + "' and itemname='" + this.txtditem.Text + "' and type='" + this.txtdtype.Text + "'", this.con).Fill(new DataTable());
                    int num = (int)MessageBox.Show("Stock Deleted !!", "Care You");
                    this.txtdtype.Text = "";
                    this.txtditem.Text = "";
                    this.tabControl1.Enabled = false;
                }
                else
                {
                    int num1 = (int)MessageBox.Show("Delete first sell order histry !!", "Care You");
                }
            }
            this.con.Close();
        }

        private void txtqnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
            if ((int)e.KeyChar == 8 || char.IsNumber(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void txtbuyprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
            if ((int)e.KeyChar == 8 || char.IsNumber(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void txtsellprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
            if ((int)e.KeyChar == 8 || char.IsNumber(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void drpcompnay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.m != 0)
                return;
            this.con.Open();
            OleDbDataReader oleDbDataReader = new OleDbCommand("select itemname from stockmst where companyname = '" + this.drpcompnay.Text + "'", this.con).ExecuteReader();
            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
            while (oleDbDataReader.Read())
                stringCollection.Add(oleDbDataReader.GetString(0));
            this.txtname.AutoCompleteCustomSource = stringCollection;
            this.con.Close();
        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            this.con.Open();
            OleDbDataReader oleDbDataReader = new OleDbCommand("select type from stockmst where itemname='" + this.txtname.Text + "'", this.con).ExecuteReader();
            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
            while (oleDbDataReader.Read())
                stringCollection.Add(oleDbDataReader.GetString(0));
            this.txttype.AutoCompleteCustomSource = stringCollection;
            this.con.Close();
        }

        private void txti1_Leave(object sender, EventArgs e)
        {
            this.con.Open();
            OleDbDataReader oleDbDataReader = new OleDbCommand("select type from stockmst where itemname='" + this.txti1.Text + "'", this.con).ExecuteReader();
            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
            while (oleDbDataReader.Read())
                stringCollection.Add(oleDbDataReader.GetString(0));
            this.txtt1.AutoCompleteCustomSource = stringCollection;
            this.con.Close();
        }

        private void txti2_Leave(object sender, EventArgs e)
        {
            this.con.Open();
            OleDbDataReader oleDbDataReader = new OleDbCommand("select type from stockmst where itemname='" + this.txti2.Text + "'", this.con).ExecuteReader();
            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
            while (oleDbDataReader.Read())
                stringCollection.Add(oleDbDataReader.GetString(0));
            this.txtt2.AutoCompleteCustomSource = stringCollection;
            this.con.Close();
        }

        private void txti3_Leave(object sender, EventArgs e)
        {
            this.con.Open();
            OleDbDataReader oleDbDataReader = new OleDbCommand("select type from stockmst where itemname='" + this.txti3.Text + "'", this.con).ExecuteReader();
            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
            while (oleDbDataReader.Read())
                stringCollection.Add(oleDbDataReader.GetString(0));
            this.txtt3.AutoCompleteCustomSource = stringCollection;
            this.con.Close();
        }

        private void txti4_Leave(object sender, EventArgs e)
        {
            this.con.Open();
            OleDbDataReader oleDbDataReader = new OleDbCommand("select type from stockmst where itemname='" + this.txti4.Text + "'", this.con).ExecuteReader();
            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
            while (oleDbDataReader.Read())
                stringCollection.Add(oleDbDataReader.GetString(0));
            this.txtt4.AutoCompleteCustomSource = stringCollection;
            this.con.Close();
        }

        private void txti5_Leave(object sender, EventArgs e)
        {
            this.con.Open();
            OleDbDataReader oleDbDataReader = new OleDbCommand("select type from stockmst where itemname='" + this.txti5.Text + "'", this.con).ExecuteReader();
            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
            while (oleDbDataReader.Read())
                stringCollection.Add(oleDbDataReader.GetString(0));
            this.txtt5.AutoCompleteCustomSource = stringCollection;
            this.con.Close();
        }

        private void txtnq1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            if (this.txtnq1.Text != "")
            {
                this.txti2.Enabled = true;
                this.txti2.BackColor = Color.Honeydew;
                this.txtt2.Enabled = true;
                this.txtt2.BackColor = Color.Honeydew;
                this.txtnq2.Enabled = true;
                this.txtnq2.BackColor = Color.Honeydew;
                this.txti2.Focus();
            }
            else
            {
                int num = (int)MessageBox.Show("Input Quantity !!", "Care You");
                this.txtnq1.Focus();
            }
        }

        private void txtnq2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            if (this.txtnq2.Text != "")
            {
                this.txti3.Enabled = true;
                this.txti3.BackColor = Color.Honeydew;
                this.txtt3.Enabled = true;
                this.txtt3.BackColor = Color.Honeydew;
                this.txtnq3.Enabled = true;
                this.txtnq3.BackColor = Color.Honeydew;
                this.txti3.Focus();
            }
            else
            {
                int num = (int)MessageBox.Show("Input Quantity !!", "Care You");
                this.txtnq2.Focus();
            }
        }

        private void txtnq3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            if (this.txtnq3.Text != "")
            {
                this.txti4.Enabled = true;
                this.txti4.BackColor = Color.Honeydew;
                this.txtt4.Enabled = true;
                this.txtt4.BackColor = Color.Honeydew;
                this.txtnq4.Enabled = true;
                this.txtnq4.BackColor = Color.Honeydew;
                this.txti4.Focus();
            }
            else
            {
                int num = (int)MessageBox.Show("Input Quantity !!", "Care You");
                this.txtnq3.Focus();
            }
        }

        private void txtnq4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            if (this.txtnq4.Text != "")
            {
                this.txti5.Enabled = true;
                this.txti5.BackColor = Color.Honeydew;
                this.txtt5.Enabled = true;
                this.txtt5.BackColor = Color.Honeydew;
                this.txtnq5.Enabled = true;
                this.txtnq5.BackColor = Color.Honeydew;
                this.txti5.Focus();
            }
            else
            {
                int num = (int)MessageBox.Show("Input Quantity !!", "Care You");
                this.txtnq4.Focus();
            }
        }

        private void txtnq5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            if (this.txtnq5.Text != "")
            {
                this.txti6.Enabled = true;
                this.txti6.BackColor = Color.Honeydew;
                this.txtt6.Enabled = true;
                this.txtt6.BackColor = Color.Honeydew;
                this.txtnq6.Enabled = true;
                this.txtnq6.BackColor = Color.Honeydew;
                this.txti6.Focus();
            }
            else
            {
                int num = (int)MessageBox.Show("Input Quantity !!", "Care You");
                this.txtnq5.Focus();
            }
        }

        private void txtditem_Leave(object sender, EventArgs e)
        {
            this.con.Open();
            OleDbDataReader oleDbDataReader = new OleDbCommand("select type from stockmst where itemname='" + this.txtditem.Text + "'", this.con).ExecuteReader();
            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
            while (oleDbDataReader.Read())
                stringCollection.Add(oleDbDataReader.GetString(0));
            this.txtdtype.AutoCompleteCustomSource = stringCollection;
            this.con.Close();
        }

        private void txti6_Leave(object sender, EventArgs e)
        {
            this.con.Open();
            OleDbDataReader oleDbDataReader = new OleDbCommand("select type from stockmst where itemname='" + this.txti6.Text + "'", this.con).ExecuteReader();
            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
            while (oleDbDataReader.Read())
                stringCollection.Add(oleDbDataReader.GetString(0));
            this.txtt6.AutoCompleteCustomSource = stringCollection;
            this.con.Close();
        }

        private void txti7_Leave(object sender, EventArgs e)
        {
            this.con.Open();
            OleDbDataReader oleDbDataReader = new OleDbCommand("select type from stockmst where itemname='" + this.txti7.Text + "'", this.con).ExecuteReader();
            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
            while (oleDbDataReader.Read())
                stringCollection.Add(oleDbDataReader.GetString(0));
            this.txtt7.AutoCompleteCustomSource = stringCollection;
            this.con.Close();
        }

        private void txti8_Leave(object sender, EventArgs e)
        {
            this.con.Open();
            OleDbDataReader oleDbDataReader = new OleDbCommand("select type from stockmst where itemname='" + this.txti8.Text + "'", this.con).ExecuteReader();
            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
            while (oleDbDataReader.Read())
                stringCollection.Add(oleDbDataReader.GetString(0));
            this.txtt8.AutoCompleteCustomSource = stringCollection;
            this.con.Close();
        }

        private void txti9_Leave(object sender, EventArgs e)
        {
            this.con.Open();
            OleDbDataReader oleDbDataReader = new OleDbCommand("select type from stockmst where itemname='" + this.txti9.Text + "'", this.con).ExecuteReader();
            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
            while (oleDbDataReader.Read())
                stringCollection.Add(oleDbDataReader.GetString(0));
            this.txtt9.AutoCompleteCustomSource = stringCollection;
            this.con.Close();
        }

        private void txti10_Leave(object sender, EventArgs e)
        {
            this.con.Open();
            OleDbDataReader oleDbDataReader = new OleDbCommand("select type from stockmst where itemname='" + this.txti10.Text + "'", this.con).ExecuteReader();
            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
            while (oleDbDataReader.Read())
                stringCollection.Add(oleDbDataReader.GetString(0));
            this.txtt10.AutoCompleteCustomSource = stringCollection;
            this.con.Close();
        }

        private void txtnq6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            if (this.txtnq6.Text != "")
            {
                this.txti7.Enabled = true;
                this.txti7.BackColor = Color.Honeydew;
                this.txtt7.Enabled = true;
                this.txtt7.BackColor = Color.Honeydew;
                this.txtnq7.Enabled = true;
                this.txtnq7.BackColor = Color.Honeydew;
                this.txti7.Focus();
            }
            else
            {
                int num = (int)MessageBox.Show("Input Quantity !!", "Care You");
                this.txtnq6.Focus();
            }
        }

        private void txtnq7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            if (this.txtnq7.Text != "")
            {
                this.txti8.Enabled = true;
                this.txti8.BackColor = Color.Honeydew;
                this.txtt8.Enabled = true;
                this.txtt8.BackColor = Color.Honeydew;
                this.txtnq8.Enabled = true;
                this.txtnq8.BackColor = Color.Honeydew;
                this.txti8.Focus();
            }
            else
            {
                int num = (int)MessageBox.Show("Input Quantity !!", "Care You");
                this.txtnq7.Focus();
            }
        }

        private void txtnq8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            if (this.txtnq8.Text != "")
            {
                this.txti9.Enabled = true;
                this.txti9.BackColor = Color.Honeydew;
                this.txtt9.Enabled = true;
                this.txtt9.BackColor = Color.Honeydew;
                this.txtnq9.Enabled = true;
                this.txtnq9.BackColor = Color.Honeydew;
                this.txti9.Focus();
            }
            else
            {
                int num = (int)MessageBox.Show("Input Quantity !!", "Care You");
                this.txtnq8.Focus();
            }
        }

        private void txtnq9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            if (this.txtnq9.Text != "")
            {
                this.txti10.Enabled = true;
                this.txti10.BackColor = Color.Honeydew;
                this.txtt10.Enabled = true;
                this.txtt10.BackColor = Color.Honeydew;
                this.txtnq10.Enabled = true;
                this.txtnq10.BackColor = Color.Honeydew;
                this.txti10.Focus();
            }
            else
            {
                int num = (int)MessageBox.Show("Input Quantity !!", "Care You");
                this.txtnq9.Focus();
            }
        }

        private void txtnq10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            if (this.txtnq10.Text != "")
            {
                this.btnaddqnt.PerformClick();
            }
            else
            {
                int num = (int)MessageBox.Show("Input Quantity !!", "Care You");
                this.txtnq10.Focus();
            }
        }
    }
}
