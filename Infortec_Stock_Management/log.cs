using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace Infortec_Stock_Management
{
   
    public partial class frm_log : Form
    {
        DBConnect dbc;
        public frm_log()
        {
            InitializeComponent();
            dbc = new DBConnect();
            dtp_date.Format = DateTimePickerFormat.Custom;
            dtp_date.CustomFormat = "yyyy-MM-dd";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void log_Load(object sender, EventArgs e)
        {
            createDgv("all");
        }

        private void createDgv(string scope)
        {
            string query = "";
            dgv_logs.DataSource = null;
            dgv_logs.Columns.Clear();
            dgv_logs.Rows.Clear();
            string selectHalfQuery = " u.name AS 'User Name',i.name AS 'Item Name',a.amount AS Amount,a.date AS 'Date',a.description AS 'Description',l.name AS 'Location Name' ";
            
            DataSet ds;

            if (scope == "add")
            {
                query = "select "+selectHalfQuery+" from addi a left join location l on l.id=a.locationId left join user u on u.id=a.userId left join item i on i.id=a.itemId order by date ";
            }else if(scope == "deduct"){
                query = "select  " + selectHalfQuery + "  from deduct a left join location l on l.id=a.locationId left join user u on u.id=a.userId left join item i on i.id=a.itemId order by date ";
            }else if(scope.Length == 10){
                query = "select 'add' as Status, " + selectHalfQuery + "  from addi a left join location l on l.id=a.locationId left join user u on u.id=a.userId left join item i on i.id=a.itemId WHERE a.date like '" + scope + "%' union select 'deduct' as Status,u.name,i.name,a.amount,a.date,a.description,l.name from deduct a left join location l on l.id=a.locationId left join user u on u.id=a.userId left join item i on i.id=a.itemId WHERE a.date like '" + scope + "%' order by date ";
            }else{
                query = "select 'add' as Status, " + selectHalfQuery + "  from addi a left join location l on l.id=a.locationId left join user u on u.id=a.userId left join item i on i.id=a.itemId union select 'deduct' as Status,u.name,i.name,a.amount,a.date,a.description,l.name from deduct a left join location l on l.id=a.locationId left join user u on u.id=a.userId left join item i on i.id=a.itemId order by date ";
            }

            ds = dbc.getDS(query);
            this.dgv_logs.DataSource = ds.Tables[0];
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            createDgv("add");
        }

        private void btn_deduct_Click(object sender, EventArgs e)
        {
            createDgv("deduct");
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            createDgv("all");
        }

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {

            
            string date = dtp_date.Text;
          
            date = date.Substring(0, 10);
            createDgv(date);
            
        }

        private void btn_exportPdf_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == folderBrowserDialog1.ShowDialog())
            {
                string folderPath = folderBrowserDialog1.SelectedPath;
                exportPdf(folderPath);
            }

            
        }

   

        private void exportPdf(string folderPath)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dgv_logs.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dgv_logs.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dgv_logs.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                }
            }

            //Exporting to PDF
           
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);

            }
            String dateT = DateTime.Now.ToString("yyyy_MM_dd_h_mm_tt");
            
            using (FileStream stream = new FileStream(folderPath + "Infortec_Stock_Report_" + dateT + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
                MessageBox.Show("File " + "Infortec_Stock_Report_" + dateT + ".pdf Successfully Exported to " + folderPath, "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
