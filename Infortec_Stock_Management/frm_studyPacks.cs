using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Infortec_Stock_Management
{
    public partial class frm_studyPacks : Form
    {
        DBConnect dbc = null;
        private int userId = DBConnect.loggedUserID;
        public frm_studyPacks()
        {
            InitializeComponent();
            dbc = new DBConnect();
            loadLog();
            dgv_studyPackData.BringToFront();
            grp_dynamic.SendToBack();
            //lbl
        }

        private void frm_studyPacks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'infortecstockDataSet10.study_packs' table. You can move, or remove it, as needed.
            this.study_packsTableAdapter.Fill(this.infortecstockDataSet10.study_packs);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure?", "Please Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                int book = Convert.ToInt32(cmb_bookAdd.SelectedValue);
                int amount = Convert.ToInt32(nud_add.Value);
                string description = dbc.ToLiteral(rtb_des_add.Text);
                if (book != -1)
                {
                    string queryUpdate = "UPDATE study_packs SET amount = amount+" + amount + " WHERE id=" + book;
                    dbc.Update(queryUpdate);

                    string insertQuery = String.Format("INSERT INTO study_packs_log(userId,bookId,amount,type,description) values({0},{1},{2},'{3}','{4}')", userId, book, amount, "Add", description);
                    dbc.Insert(insertQuery);
                    loadLog();

                    MessageBox.Show("New Book(s) Successfully added");
                    rtb_des_add.Clear();
                }

            }
        }

        private void btn_issue_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure?", "Please Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                int book = Convert.ToInt32(cmb_bookAdd.SelectedValue);
                int amount = Convert.ToInt32(nud_add.Value);
                string description = dbc.ToLiteral(rtb_des_add.Text);

                if (book != -1)
                {
                    string queryRead = "SELECT amount FROM study_packs WHERE id="+book;
                    int currentValue = dbc.GetSingleVal(queryRead);
                    
                    if (currentValue - amount >= 0) {
                        string queryUpdate = "UPDATE study_packs SET amount = amount-" + amount + " WHERE id=" + book;
                        dbc.Update(queryUpdate);

                        string insertQuery = String.Format("INSERT INTO study_packs_log(userId,bookId,amount,type,description) values({0},{1},{2},'{3}','{4}')", userId, book, amount, "Issue", description);
                        dbc.Insert(insertQuery);

                        loadLog();
                        MessageBox.Show("Book(s) successfully issued");
                    }
                    else
                    {
                        MessageBox.Show("Book you selected only have " + currentValue + " books in the stock!", "Not Enough Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btn_sem1_Click(object sender, EventArgs e)
        {
            makeInterface(1);            
        }

        private void createCheckBoxes(int x, int y, string text)
        {
            CheckBox cb = new CheckBox();
            cb.Text = text;
            cb.Location = new Point(x, y);
            cb.CheckState = CheckState.Checked;
            this.grp_dynamic.Controls.Add(cb);
        }

        private void makeInterface(int x)
        {
            btn_packIssue.Visible = true;
            nud_packIssue.Visible = true;
            lbl_howManyPacks.Visible = true;
            lbl_completePackage.Visible = true;
            lbl_packDes.Visible = true;
            rtb_packsIssue.Visible = true;

            for (int ix = this.grp_dynamic.Controls.Count - 1; ix >= 0; ix--)
            {
                if (this.grp_dynamic.Controls[ix] is CheckBox)
                {
                    this.grp_dynamic.Controls[ix].Dispose();
                }
            }


            String query = "SELECT id,name FROM study_packs WHERE semester = "+x;
            DataSet ds = null;
            ds = dbc.getDS(query);
            int yAxis = 60;
            int xAxis = 60;
           

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string item = row[1].ToString();
                createCheckBoxes(xAxis, yAxis, item);
                yAxis += 24;
                
            }

            
           
        }

        private void btn_sem2Prog_Click(object sender, EventArgs e)
        {
            makeInterface(3);
        }

        private void btn_sem2Mgmt_Click(object sender, EventArgs e)
        {
            makeInterface(2);
        }

        private void btn_packIssue_Click(object sender, EventArgs e)
        {
            int noOfPacks = Convert.ToInt32(nud_packIssue.Value);
            ArrayList selectedBoxes = new ArrayList();
            DataSet ds = null;
            string query1 = "SELECT name,amount FROM study_packs WHERE name=";
            string queryUpdate = "UPDATE study_packs SET amount=amount-" + noOfPacks + " WHERE name=";
            string description = dbc.ToLiteral(rtb_packsIssue.Text)+"-->";

            int currentAmount =0;
            bool isError = false;
            String errorVals = "\n";
            int count = 0;

            for (int ix = this.grp_dynamic.Controls.Count - 1; ix >= 0; ix--)
            {
                if (this.grp_dynamic.Controls[ix] is CheckBox)
                {
                    CheckBox cb = (CheckBox) this.grp_dynamic.Controls[ix];
                    if(cb.Checked)
                    {
                        
                        query1 += "'"+cb.Text+"'";
                        query1 += " OR name =";

                        queryUpdate += "'"+cb.Text+"'";
                        queryUpdate += " OR name =";

                        description += cb.Text + " ";
                        count++;
                    }
                    
                }
            }

            if (count > 0)
            {
                query1 = query1.Substring(0, query1.LastIndexOf(" OR name ="));
                queryUpdate = queryUpdate.Substring(0, queryUpdate.LastIndexOf(" OR name ="));

                ds = dbc.getDS(query1);


                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    currentAmount = Convert.ToInt32(row[1]);

                    if (currentAmount - noOfPacks < 0)
                    {
                        isError = true;
                        errorVals += row[0].ToString() + "\n";
                    }
                }

                if (isError)
                {
                    MessageBox.Show("Could not deduct " + noOfPacks + " item packs using selected books.\nAmount of following books are not enough" + errorVals, "Not Enough Books", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Are You Sure about issuing " + noOfPacks + " pack(s)?", "Please Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                    {
                        dbc.Update(queryUpdate);

                        string insertQuery = String.Format("INSERT INTO study_packs_log(userId,bookId,amount,type,description) values({0},{1},{2},'{3}','{4}')", userId, 0, noOfPacks, "Issue Pack", description);
                        dbc.Insert(insertQuery);

                        loadLog();

                        MessageBox.Show("Items Successfully updated");
                    }
                }
            }
            else
            {
                MessageBox.Show("Atleast select one checkbox you idiot!");
            }
        }

        private void nud_packIssue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void studyPackLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_studyPackLog fspl = new frm_studyPackLog();
            fspl.Show();
        }

        private void loadLog()
        {

            dgv_studyPackData.DataSource = null;
            dgv_studyPackData.Columns.Clear();
            dgv_studyPackData.Rows.Clear();

            DataSet ds = null;
            string query = "";


            query = "SELECT p.name AS BOOK,s.name AS Semester,p.amount AS 'Amount Left' FROM study_packs p JOIN semesters s ON s.id=p.semester";


            ds = dbc.getDS(query);
            this.dgv_studyPackData.DataSource = ds.Tables[0];

            dgv_studyPackData.Columns[0].ReadOnly = true;
            dgv_studyPackData.Columns[1].ReadOnly = true;
            dgv_studyPackData.Columns[2].ReadOnly = true;

           
        }

        private void grp_dynamic_Enter(object sender, EventArgs e)
        {

        }

        private void btn_sem1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_sem2Prog_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_sem2Mgmt_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_packIssue_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_issue_Click_1(object sender, EventArgs e)
        {

        }

        private void nud_add_Leave(object sender, EventArgs e)
        {
            if (nud_add.Text == String.Empty)
            {
                nud_add.Text = "0";
            }
        }

        private void nud_issue_Leave(object sender, EventArgs e)
        {
           
        }

        private void nud_packIssue_Leave(object sender, EventArgs e)
        {
           
        }

        private void btn_studyLog_Click(object sender, EventArgs e)
        {
            frm_studyPackLog fspl = new frm_studyPackLog();
            fspl.Show();
        }
    }
}
