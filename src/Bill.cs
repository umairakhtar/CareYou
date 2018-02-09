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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace CareYou
{
    public partial class Bill : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source=F:\\Care You\\CareYou\\Stock.accdb");
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            this.con.Open();
            OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT top 1 billno FROM sellmst order by billno desc", this.con);
            DataTable dataTable1 = new DataTable();
            oleDbDataAdapter1.Fill(dataTable1);
            OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM sellmst where billno=" + (object)Convert.ToInt32(dataTable1.Rows[0]["billno"].ToString()), this.con);
            DataTable dataTable2 = new DataTable();
            oleDbDataAdapter2.Fill(dataTable2);
            ReportDocument reportDocument = new ReportDocument();
            string str = "F:/Care You/CareYou/ReportBill.rpt";
            reportDocument.Load(str);
            reportDocument.SetDataSource(dataTable2);
            this.crystalReportViewer1.ReportSource=((object)reportDocument);
            this.crystalReportViewer1.ToolPanelView=((ToolPanelViewType)0);
            this.con.Close();
        }

        private void txtbillno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            this.button1.PerformClick();
        }

        private void txtbillno_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
            if ((int)e.KeyChar == 8 || char.IsNumber(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.con.Open();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM sellmst where billno=" + this.txtbillno.Text, this.con);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter.Fill(dataTable);
            ReportDocument reportDocument = new ReportDocument();
            string str = "F:/Care You/CareYou/ReportBill.rpt";
            reportDocument.Load(str);
            reportDocument.SetDataSource(dataTable);
            this.crystalReportViewer1.ReportSource=((object)reportDocument);
            this.con.Close();
        }
    }
}
