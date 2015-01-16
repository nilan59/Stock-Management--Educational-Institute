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
    public partial class parent : Form
    {
        DBConnect dbc;
        frm_mainInsert fii = null;
        Reporting fad = null;
        char[] easter = {'h','e','l','l'};
        int easterCount = 0;
        Boolean panelStatus = true; Boolean isMainPanelEmpty = true;
        int panelWidth = 240; int incremAmount = 10;

 
        public parent()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.Black;

            if (DBConnect.loggedUserLevel == 1)
            {
                this.btn_userReg.Visible = true;
            }
        }

        

        private void initialInsertionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeOpenedWindows();
            frm_mainInsert fmi = new frm_mainInsert();
            fmi.MdiParent = this;            
            fmi.Show();
        }

        private void itemAddDeductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeOpenedWindows();
            fad = new Reporting();
            fad.MdiParent = this;
            fad.Show();
        }

        private void parent_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
            
           
		
           
        }

        private void closeOpenedWindows()
        {
            
        }

       
        private void btn_excel_Click(object sender, EventArgs e)
        {
            dbc = new DBConnect();
              string sqlSel = "";
            int rowCount = 3;
            CreateExcelDoc excell_app = new CreateExcelDoc();
            //creates the main header
            excell_app.createHeaders(1, 3, "By Item and Location", "A1", "C1", 0, "YELLOW", true, 10, "n");
            //creates subheaders
         
            excell_app.addData(2, 1, "Location", "A2", "A2", "10.0%");
            excell_app.addData(2, 2, "Item", "B2", "B2", "10.0%");
            excell_app.addData(2, 3, "Amount", "C2", "C2", "2.0%");


            sqlSel = "SELECT l.name,i.name,li.amount FROM item i join located_in li JOIN location l ON i.id=li.itemId AND l.id=li.locationId ORDER BY l.name";
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

            excell_app.createHeaders(1, 6, "SUMMARY", "F1", "G1", 0, "YELLOW", true, 10, "n");
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

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_studyPack_Click(object sender, EventArgs e)
        {
            frm_studyPacks fsp = new frm_studyPacks();
            loadInPanel(fsp);


        }

        private void btn_userReg_Click(object sender, EventArgs e)
        {
            frm_userRegistration fur = new frm_userRegistration();
            loadInPanel(fur);
        }

        private void btn_manage_Click(object sender, EventArgs e)
        {


            if (fii == null)
            {
                fii = new frm_mainInsert();

            }
            loadInPanel(fii);


        }

        private void btn_manupilate_Click(object sender, EventArgs e)
        {
            Reporting fad1 = new Reporting();
            loadInPanel(fad1);
        }


        private void loadInPanel(Form fsp)
        {
            isMainPanelEmpty = false;
            fsp.TopLevel = false;
            fsp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fsp.Dock = DockStyle.Fill;
            fsp.Visible = true;
            fsp.BringToFront();

           foreach (Control ct in panel_main.Controls)
            {
                panel_main.Controls.Remove(ct);
            }
            panel_main.Controls.Add(fsp);

            foreach (Control tx in fsp.Controls)
            {
                if (tx is TextBox)
                {
                    TextBox tt = (TextBox)tx;

                    tt.BackColor = Color.LightBlue;

                }
                // tx.BackColor = Color.LightBlue;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void parent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void parent_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                   
                
            
        }

        private void parent_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            try
            {
                easter[easterCount] = e.KeyChar;

                if (easter[0] == 'f' && easter[1] == 'u' && easter[2] == 'c' && easter[3] == 'k')
                {
                    if (DialogResult.Ignore == MessageBox.Show("You Fucker", "HIK HIK HIK", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation))
                    {
                        MessageBox.Show("Developed by Nilan Mihindukulasooriya\nDesign by Ushantha Samaraweera\nQuality Assurance by Hasitha Mapalagama\nSupported by Keshawa Wijethunga &\nKasun Weerasooriya & Anu Jayarathnam \nIdea by Gayan Kularatne", "Our Crew", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    
                }
               
                if (easterCount == 3)
                {
                    easterCount = 0;                    
                    this.KeyPress -= new System.Windows.Forms.KeyPressEventHandler(this.parent_KeyPress);
                    this.KeyPreview = false;
                }
                easterCount++;
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_slide_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;

            //if (panel_slide.Width == 0)
            //{
            //    panel_slide.Width = 200;
            //}
            //else if (panel_slide.Width == 200)
            //{
            //    panel_slide.Width = 0;
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //incremAmount = 10;

            if (panelStatus)
            {
                if (this.panel_slide.Width <= 1)
                {
                    this.timer1.Enabled = false;
                    panelStatus = false;
                    this.panel_main.Dock = DockStyle.Fill;
                }

                else
                {

                    this.panel_main.Dock = DockStyle.None;
                    this.panel_slide.Width -= incremAmount;
                    // this.panel_slide.Width = 0;
                    // this.panel_main.Width += incremAmount;



                }
            }
            else
            {
                if (this.panel_slide.Width >= panelWidth)
                {
                    this.timer1.Enabled = false;
                    panelStatus = true;
                    this.panel_main.Dock = DockStyle.Fill;
                }

                else
                {

                    this.panel_main.Dock = DockStyle.None;
                    this.panel_slide.Width += incremAmount;
                    //this.panel_main.Width -= incremAmount;
                    // this.panel_slide.Width = panelWidth;

                }



            }
        }

   

        private void picBoxMain_Click(object sender, EventArgs e)
        {
            isMainPanelEmpty = true;
            foreach (Control ct in panel_main.Controls)
            {
                panel_main.Controls.Remove(ct);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frm_login lg = new frm_login();
            lg.Show();
            this.Hide();
        }

       
    


       
        }
    
}
