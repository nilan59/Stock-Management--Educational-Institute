using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Infortec_Stock_Management
{
    public partial class frm_reports : Form
    {
        DBConnect dbc;

        public frm_reports()
        {
            InitializeComponent();
            dbc = new DBConnect();
        }

        //private void frm_reports_Load(object sender, EventArgs e)
        //{
        //    String query = "SELECT * FROM item";
        //    ReportDataSource rds = dbc.getReport(query);


        //    reportViewrMain.Visible = true;


        //    reportViewrMain.ProcessingMode = ProcessingMode.Local;
        //    LocalReport lc = reportViewrMain.LocalReport;
        //    lc.DataSources.Add(rds);

        //    reportViewrMain.LocalReport.Refresh();
        //}
    }
}
