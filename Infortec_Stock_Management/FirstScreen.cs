using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Infortec_Stock_Management
{
    public partial class frm_firstScreen : Form
    {
        DBConnect dbc;
        public frm_firstScreen()
        {
            InitializeComponent();
            dbc = new DBConnect();         
            
        }


        private void btn_manage_Click(object sender, EventArgs e)
        {
            frm_mainInsert fii = new frm_mainInsert();
            fii.Show();
            this.Hide();
        }

        private void btn_manupilate_Click(object sender, EventArgs e)
        {
            frm_addDeduct fad = new frm_addDeduct();
            fad.Show();
            this.Hide();
        }

        private void FirstScreen_Load(object sender, EventArgs e)
        {

        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            string sqlSel = "";
            int rowCount = 3;
            CreateExcelDoc excell_app = new CreateExcelDoc();
            //creates the main header
            excell_app.createHeaders(1, 3, "By Item and Location", "A1", "C1", 0, "YELLOW", true, 10, "n");
            //creates subheaders
         
            excell_app.addData(2, 1, "Item", "A2", "A2", "10.0%");
            excell_app.addData(2, 2, "Location", "B2", "B2", "10.0%");
            excell_app.addData(2, 3, "Amount", "C2", "C2", "2.0%");


            sqlSel = "SELECT i.name,l.name,li.amount FROM item i join located_in li JOIN location l ON i.id=li.itemId AND l.id=li.locationId";
            List<string>[] list = dbc.SelectReader(sqlSel); 
            int count = 0;

            if (list != null)
            {
                while (list[0].Count > count)
                {
                    excell_app.addData(rowCount, 1, list[0][count], "A" + rowCount, "A" + rowCount, "");
                    excell_app.addData(rowCount, 2, list[1][count], "B" + rowCount, "B" + rowCount, "");
                    excell_app.addData(rowCount, 3, list[2][count], "C" + rowCount, "C" + rowCount, "");
                    rowCount++; count++;
                }
                   
            }
            else
            {
                excell_app.addData(2, 1, "No Data to display", "A3", "B3", "10.0%");
            }

            //second set of data

            excell_app.createHeaders(1, 6, "By Item", "F1", "G1", 0, "YELLOW", true, 10, "n");
            //creates subheaders

            excell_app.addData(2, 6, "Item", "F2", "F2", "10.0%");
            excell_app.addData(2, 7, "Amount", "G2", "G2", "10.0%");


            sqlSel = "SELECT i.name,sum(li.amount) FROM item i join located_in li JOIN location l ON i.id=li.itemId AND l.id=li.locationId GROUP BY i.name";
            list = dbc.SelectReader(sqlSel);
            count = 0; rowCount = 3;

            if (list != null)
            {
                while (list[0].Count > count)
                {
                    excell_app.addData(rowCount, 6, list[0][count], "F" + rowCount, "F" + rowCount, "");
                    excell_app.addData(rowCount, 7, list[1][count], "G" + rowCount, "G" + rowCount, "");
                    rowCount++; count++;
                }

            }
            else
            {
                excell_app.addData(2, 1, "No Data to display", "F3", "G3", "10.0%");
            }
        }

       
    }
}
