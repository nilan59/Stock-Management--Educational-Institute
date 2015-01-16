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
    public partial class frm_mainInsert : Form
    {
        DBConnect dbc;
        int countClicks = 0;
        string activeDgvTable = "";
        int updateCount = 0;

        //enum dgvTables
        //{
        //    1
        //}
        public frm_mainInsert()
        {
            InitializeComponent();
            dbc = new DBConnect();
            //createDataGridView("item");
            //dgv_test.DataSource = dbc.getSource();
            
        }


        private void btn_insertItem_Click(object sender, EventArgs e)
        {
            string name = dbc.ToLiteral(txt_itemName.Text);
            string description = dbc.ToLiteral(rtb_itemDescription.Text);
            string checkQuery = "SELECT count(*) FROM item WHERE name='"+name+"'";
            int value = dbc.GetSingleVal(checkQuery);
            if (value > 0)
            {
                MessageBox.Show("Item already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (name.Length < 3)
            {
                MessageBox.Show("Name too short like your.....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string insertQuery = String.Format("INSERT into item(name,description) values('{0}','{1}')", name, description);
                dbc.Insert(insertQuery);

               
                createDataGridView("item");
                MessageBox.Show("Item Successfully Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_itemName.Clear();
                rtb_itemDescription.Clear();
            }
        }

        

        private void btn_insertLocation_Click(object sender, EventArgs e)
        {
            string location = dbc.ToLiteral(txt_location.Text);
            string checkQuery = "SELECT count(*) FROM location WHERE name='"+location+"'";
            int value = dbc.GetSingleVal(checkQuery);
            if (value > 0 )
            {
                MessageBox.Show("Location already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (location.Length < 3)
            {
                MessageBox.Show("Name too short like your.....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {

                string insertQuery = String.Format("INSERT into location(name) values('{0}')", location);
                dbc.Insert(insertQuery);
                createDataGridView("location");
                
                MessageBox.Show("Location Successfully Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_location.Clear();
            }
            
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                    }

        private void btn_viewLoaction_Click(object sender, EventArgs e)
        {
            createDataGridView("location");
            lbl_heading.Text = "Location";
        }

        private void createDataGridView(String type)
        {
            lbl_heading.Text = type;
            activeDgvTable = type;
            dgv_crud.DataSource = null;
            dgv_crud.Columns.Clear();
            dgv_crud.Rows.Clear();

            string query = "";
            DataSet ds;
            query = "SELECT id, name FROM "+type;          

            ds = dbc.getDS(query);
            this.dgv_crud.DataSource = ds.Tables[0];


            DataGridViewImageColumn btn1 = new DataGridViewImageColumn();
            dgv_crud.Columns.Add(btn1);
            btn1.HeaderText = "Update";
            btn1.Image = Properties.Resources.ico_edit;
            btn1.Name = "btn_update";
            btn1.Width = 20;

            DataGridViewImageColumn btn = new DataGridViewImageColumn();
            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgv_crud.Columns.Add(btn);
            btn.HeaderText = "Delete";
            btn.Image = Properties.Resources.delete;
            btn.Name = "btn_delete";
            btn.Width = 20;

            dgv_crud.Columns[0].Width = 50;

            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //dgv_crud.Columns.Add(btn);
            //btn.HeaderText = "Update";
            //btn.Text = "Update";
            //btn.Name = "btn_update";
            //btn.UseColumnTextForButtonValue = true;

            //dgv_crud.Columns[0].ReadOnly = true;
            //DataGridViewButtonColumn btnDel = new DataGridViewButtonColumn();
            //dgv_crud.Columns.Add(btnDel);
            //btnDel.HeaderText = "Delete User";
            //btnDel.Text = "Delete";
            //btnDel.Name = "btn_delete";
            //btnDel.UseColumnTextForButtonValue = true;

        }

        private void createDataGridView()
        {
            updateCount = 0;
            activeDgvTable = "study_packs";
            dgv_crud.DataSource = null;
            dgv_crud.Columns.Clear();
            dgv_crud.Rows.Clear();

            string query = "";
            DataSet ds;
            query = "SELECT s.id AS ID, s.name AS Book,m.name AS Semester FROM study_packs s JOIN semesters m ON m.id=s.semester";

            ds = dbc.getDS(query);
            this.dgv_crud.DataSource = ds.Tables[0];

            dgv_crud.Columns[0].ReadOnly = true;
            dgv_crud.Columns[1].ReadOnly = true;
            // dgv_crud.Columns[2].ReadOnly = true;

           
            

            dgv_crud.Columns[0].Width = 30;

            DataGridViewImageColumn btn1 = new DataGridViewImageColumn();
            dgv_crud.Columns.Add(btn1);
            btn1.HeaderText = "Update";
            btn1.Image = Properties.Resources.ico_edit;
            btn1.Name = "btn_update";
            btn1.Width = 20;

            DataGridViewImageColumn btn = new DataGridViewImageColumn();
            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgv_crud.Columns.Add(btn);
            btn.HeaderText = "Delete";
            btn.Image = Properties.Resources.delete;
            btn.Name = "btn_delete";
            btn.Width = 20;


        }

        private void btn_viewItem_Click(object sender, EventArgs e)
        {
            createDataGridView("item");
            lbl_heading.Text = "Item";
        }

        private void dgv_crud_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(activeDgvTable == "study_packs"){
                if (countClicks == 0) { createDataGridView(); countClicks++; }

                int id = 0;
                String name = "";
                int sem = 0;
                String query = "";

                
                //String type = lbl_heading.Text.ToLower();

                if (e.ColumnIndex == 4)
                {
                    try
                    {
                        id = Convert.ToInt32(dgv_crud[0, e.RowIndex].Value);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error machan!");
                    }

                    if (id != 0)
                    {
                        if (DialogResult.Yes == MessageBox.Show("This will permanentley delete this book and related data. are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        {
                            query = "DELETE FROM study_packs WHERE id=" + id;
                            dbc.Delete(query);
                            MessageBox.Show("Book successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            createDataGridView();
                        }

                    }
                }
                else if (e.ColumnIndex == 3)
                {
                   
                    if (updateCount > 0) //second time click
                    {
                        try
                        {
                            id = Convert.ToInt32(dgv_crud[0, e.RowIndex].Value);
                            name = dgv_crud[1, e.RowIndex].Value.ToString(); 
                             DataGridViewComboBoxCell dcc = (DataGridViewComboBoxCell) dgv_crud[2, e.RowIndex];
                             if (dcc.Value != null)
                             {
                                 sem = Convert.ToInt32(dcc.Value);
                             } 
                           
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        if (id != 0 && sem != 0)
                        {
                            if (DialogResult.Yes == MessageBox.Show("Are you sure about the update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                            {
                                query = "UPDATE study_packs SET name='" + name + "',semester=" + sem + " WHERE id=" + id;
                                dbc.Update(query);
                                MessageBox.Show("Book successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                createDataGridView();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Please select correct details to update", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {

                        DataGridViewComboBoxColumn cmb1 = new DataGridViewComboBoxColumn();
                       // dgv_crud.Columns.Add(cmb1);
                        DataSet ds1 = dbc.getDS("SELECT id,name FROM semesters");
                        cmb1.DataSource = ds1.Tables[0];
                        cmb1.DisplayMember = "name";
                        cmb1.ValueMember = "id";
                        cmb1.HeaderText = "Edit Semester";
                        cmb1.Name = "cmb_sem";

                        dgv_crud.Columns.Remove(dgv_crud.Columns[2]);
                        dgv_crud.Columns.Insert(2, cmb1);
                        dgv_crud.Columns[1].ReadOnly = false;
                        updateCount++;
                       
                    } 
                }
            

            }else{
            if (countClicks == 0) { createDataGridView(activeDgvTable); countClicks++; }
            int id =0 ;
            String name = "";
            String query = "";
            String type = activeDgvTable;

            try
            {
                id = Convert.ToInt32(dgv_crud[0, e.RowIndex].Value);
                name = dgv_crud[1, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error macho");
            }

            if (id != 0)
            {
                if (e.ColumnIndex == 2)
                {
                    if (name.Length < 4)
                    {
                        //lbl_status.ForeColor = Color.Red;
                        MessageBox.Show("Your " + type + " name is not long enough!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        query = "UPDATE " + type + " SET name='" + name + "' WHERE id=" + id;
                        dbc.Update(query);
                        MessageBox.Show(type + " successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        createDataGridView(type);
                    }
                }else if (e.ColumnIndex == 3)
                {
                    if (id != 0)
                    {
                        if (DialogResult.Yes == MessageBox.Show("This will permanentley delete this "+type+" and all realted logs and information. Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        {
                            query = "DELETE FROM "+type+" WHERE id=" + id;
                            dbc.Delete(query);
                            MessageBox.Show(type+" successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            createDataGridView(type);
                        }

                    }
                }
            }
            }
            
        }

        private void frm_mainInsert_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'infortecstockDataSet13.semesters' table. You can move, or remove it, as needed.
            this.semestersTableAdapter.Fill(this.infortecstockDataSet13.semesters);

        }

        private void btn_bookInsert_Click(object sender, EventArgs e)
        {
            string book = dbc.ToLiteral(txt_bookName.Text);
            int sem = Convert.ToInt32(cmb_semester.SelectedValue);
            string checkQuery = "SELECT count(*) FROM study_packs WHERE name='"+book+"'";
            int value = dbc.GetSingleVal(checkQuery);
            if (value > 0)
            {
                MessageBox.Show("Book already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (book.Length < 3)
            {
                MessageBox.Show("Book Name too short like your.....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string insertQuery = String.Format("INSERT into study_packs(name,semester) values('{0}',{1})", book, sem);
                
                dbc.Insert(insertQuery);
                createDataGridView();
                lbl_heading.Text = "Books";
                
                MessageBox.Show("Book Successfully Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_bookName.Clear();
            }
        }

   

        private void btn_viewBooks_Click(object sender, EventArgs e)
        {
            createDataGridView();
            lbl_heading.Text = "Books";
        }

        private void dgv_crud_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

        private void btn_insertLocation_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_insertItem_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_bookInsert_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_viewLoaction_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_viewItem_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_viewBooks_Click_1(object sender, EventArgs e)
        {

        }
    }
}
