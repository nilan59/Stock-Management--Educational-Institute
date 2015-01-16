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
    public partial class frm_studyPackLog : Form
    {
        DBConnect dbc = null;
        public frm_studyPackLog()
        {
            InitializeComponent();
            dbc = new DBConnect();
            loadLog("");
            dtp_date.Format = DateTimePickerFormat.Custom;
            dtp_date.CustomFormat = "yyyy-MM-dd";
        }

        private void loadLog(string type)
        {

            dgv_studyPackLog.DataSource = null;
            dgv_studyPackLog.Columns.Clear();
            dgv_studyPackLog.Rows.Clear();

            DataSet ds = null;
            string query = "";

            if (type == "pack") { 
                query = "SELECT u.name AS User,l.type AS TYPE,l.amount AS Amount,l.date AS 'Transaction Date',l.description AS Description FROM study_packs_log l LEFT JOIN user u ON u.id=l.userId WHERE l.bookId =0 ";
            }
           else{
                query = "SELECT u.name AS User,s.name AS Book,l.type AS Type,l.amount AS Amount,l.date AS 'Transaction Date',l.description AS Description FROM study_packs_log l LEFT JOIN user u ON u.id=l.userId JOIN study_packs s ON s.id=l.bookId";
            }

            ds = dbc.getDS(query);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (dr[0].ToString() == "")
                {
                    dr[0] = " Anonymous";
                }
            }
            this.dgv_studyPackLog.DataSource = ds.Tables[0];
        }

        private void normalLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadLog("");
        }

        private void packIssueLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadLog("pack");
        }

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            string date = dtp_date.Text;

            date = date.Substring(0, 10);
            loadLog("");
        }

        private void btn_export_Click(object sender, EventArgs e)
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
            PdfPTable pdfTable = new PdfPTable(dgv_studyPackLog.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dgv_studyPackLog.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dgv_studyPackLog.Rows)
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
         
            using (FileStream stream = new FileStream(folderPath + "Infortec_StudyPack_Report_" + dateT + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
                MessageBox.Show("File " + "Infortec_StudyPack_Report_" + dateT + ".pdf Successfully Exported to " + folderPath, "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgv_studyPackLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

