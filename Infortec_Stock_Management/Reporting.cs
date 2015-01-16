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
    public partial class Reporting : Form
    {
        DBConnect dbc;
        private int userId = DBConnect.loggedUserID;
        Boolean isDiscriptiveSelected = true;
        public Reporting()
        {
            InitializeComponent();
            dbc = new DBConnect();
        }

        private void Reporting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'infortecstockDataSet5.location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.infortecstockDataSet5.location);
            
            // TODO: This line of code loads data into the 'infortecstockDataSet2.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.infortecstockDataSet2.item);
            // TODO: This line of code loads data into the 'infortecstockDataSet1.located_in' table. You can move, or remove it, as needed.
            this.located_inTableAdapter.Fill(this.infortecstockDataSet1.located_in);
            createDataGridView("default");            
            bindAutoComplete();
            makeCombosinCorrectOrder();

            
        }

        private void makeCombosinCorrectOrder()
        {

            try
            {
                this.locationTableAdapter.FillBy22(this.infortecstockDataSet5.location);
                this.itemTableAdapter.FillBy(this.infortecstockDataSet2.item);
                cmb_filterItem.SelectedIndex = -1;
                cmb_filterLocation.SelectedIndex = -1;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

           
        }

        private void createDataGridView(String filter)
        {
            dgv_real.DataSource = null;
            dgv_real.Columns.Clear();
            dgv_real.Rows.Clear();
            
            string query = "";
            DataSet ds;
         if (filter == "default") {
            query = "select l.name as Location,i.name as Item,p.amount as Quantity from located_in p inner join item i on i.id=p.itemId inner join location l on p.locationId=l.id order by l.name,i.name";
        }else{
            query = "select l.name as Location,i.name as Item,p.amount as Quantity from located_in p inner join item i on i.id=p.itemId inner join location l on p.locationId=l.id  "+filter+" order by l.name,i.name";
        }
            ds = dbc.getDS(query);
            this.dgv_real.DataSource = ds.Tables[0];

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgv_real.Columns.Add(btn);
            btn.HeaderText = "Click & Update";
            btn.Text = "Update";
            btn.Name = "btn_update";
            btn.UseColumnTextForButtonValue = true;

            for (int x = 0; x < dgv_real.ColumnCount-1; x++)
            {
                dgv_real.Columns[x].ReadOnly = true;
                
            }

            dgv_real.Columns[3].ReadOnly = false;
            isDiscriptiveSelected = true;

            txtSearchLocation.Enabled = true;
            txtSearchItem.Enabled = true;
            groupBox1.Enabled = true;
        }
       

        private void nilaSet1BindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {

        }

      

      

        private void dgv_real_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            lbl_locationName.Text = "";
            lbl_itemName.Text = "";
            lbl_itemQuantity.Text = "";
            String itemName = "";

            panel4.Visible = false;

            if (e.ColumnIndex == 3)
            {
                //try
                //{
                    lbl_locationName.Text = dgv_real[0, e.RowIndex].Value.ToString();
                    lbl_itemName.Text = itemName = dgv_real[1, e.RowIndex].Value.ToString();
                    lbl_itemQuantity.Text = "Quantity - "+dgv_real[2, e.RowIndex].Value.ToString();
                    btn_add.Visible = true;
                    btn_deduct.Visible = true;


                    var resman = new System.Resources.ResourceManager("Infortec_Stock_Management.Reporting", System.Reflection.Assembly.GetExecutingAssembly());
                    Bitmap img1 = (Bitmap)resman.GetObject(itemName);// GetString("delete");
                    if (img1 == null)
                    {
                        img1 = Properties.Resources.inventory;
                    }
                    

                    img_pics.Image = img1;//Properties.Resources. //Image.FromFile(@"Images\" + lbl_itemName.Text + ".jpg");

                //}
                //catch (Exception ex)
                //{
                //    showLabel("Error in your data Format", 2);
                //}
                if (lbl_locationName.Text == "")
                {
                    btn_add.Enabled = false;
                    btn_deduct.Enabled = false;
                }

            }
        }

        private void updateDatabase(int location, int item, int amount)
        {
            string query = "";
            if ((location == -2) || (item == -2))
            {
                showLabel("Sorry, You location or item does not exist",2);
            }
            else
            {   
                int currentAmount = (int)dbc.GetSingleVal("SELECT amount FROM located_in WHERE itemId="+item+" AND locationId="+location);                                                          
               // MessageBox.Show("SELECT amount FROM located_in WHERE itemId=" + item + " AND locationId=" + location);
                if(currentAmount == -2){
                    query = String.Format("INSERT INTO located_in values({0},{1},{2})",item,location,amount);
                    //MessageBox.Show("going to insert");
                    dbc.Insert(query);
                    showLabel("Insert Success",1);
                }else if(currentAmount > amount){                    
                    deductFromDb(location, item, amount,currentAmount);
                }else if(currentAmount < amount){
                    addToDb(location, item, amount,currentAmount);
                }else{
                    showLabel("There is nothing to update", 2);
                   
                }
            }
        }

        private void addToDb(int location, int item, int amount,int currentAmount)
        {
            int changeAmount = amount - currentAmount;
            string insertQuery1 = String.Format("INSERT INTO located_in(itemId,locationId,amount) VALUES({0},{1},{2}) ON DUPLICATE KEY UPDATE amount = {3}", item, location, amount, amount);
            dbc.Insert(insertQuery1);

            string insertQuery = String.Format("INSERT INTO addI(userId,itemId,locationId,amount,description) values({0},{1},{2},{3},'{4}')", userId, item, location, changeAmount, "Test Data");
            dbc.Insert(insertQuery);
            showLabel("Adding Success",1);
           // MessageBox.Show("Item Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deductFromDb(int location, int item, int amount, int currentAmount)
        {
            int changeAmount = currentAmount - amount;
            string UpdateQuery = String.Format("UPDATE located_in SET amount= {0} WHERE itemId={1} AND locationId={2}", amount, item, location);
            dbc.Update(UpdateQuery);

            string insertQuery = String.Format("INSERT into deduct(userId,itemId,locationId,amount,description) values({0},{1},{2},{3},'{4}')", userId, item, location, changeAmount, "Test Data");
            dbc.Insert(insertQuery);
            //MessageBox.Show("Item Successfully Deducted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            showLabel("Deduct Success",1);
        }

        private void showLabel(String textVal,int color)
        {
            lbl_success.Visible = false;
            
            if (color == 1)
            {
                MessageBox.Show(textVal, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(textVal, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int getLocationByName(String location){
            string query = "select id from location where name='"+location+"'";
            return dbc.GetSingleVal(query);
        }

        private int getItemByName(String item)
        {
            string query = "select id from item where name='" + item+"'";
            return dbc.GetSingleVal(query);
        }   

        private void txtSearchItem_Click(object sender, EventArgs e)
        {
            txtSearchItem.Clear();
        }

        private void txtSearchLocation_Click(object sender, EventArgs e)
        {
            txtSearchLocation.Clear();
        }

        private void txtSearchItem_Leave(object sender, EventArgs e)
        {
            txtSearchItem.Text = "Search By Item";
        }

        private void txtSearchLocation_Leave(object sender, EventArgs e)
        {
            txtSearchLocation.Text = "Search By Location";
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchItem.Text;

            dgv_real.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgv_real.Rows)
                {
                    row.Selected = false;
                }


                foreach (DataGridViewRow row in dgv_real.Rows)
                {
                   
                    if ((row.Cells[1].Value != null) && (row.Cells[1].Value.ToString().Equals(searchValue, StringComparison.InvariantCultureIgnoreCase)))
                    {
                        row.Selected = true;
                       // break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void txtSearchLocation_TextChanged(object sender, EventArgs e)
        {
            String searchValue = txtSearchLocation.Text;
            dgv_real.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgv_real.Rows)
                {
                   
                    if ((row.Cells[0].Value != null) && (row.Cells[0].Value.ToString().Equals(searchValue, StringComparison.InvariantCultureIgnoreCase)))
                    {
                        row.Selected = true;
                        //break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void cmb_filterLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_filterLocation.SelectedIndex != -1)
            {

                filterAll();
            }
        }

        private void cmb_filterItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_filterItem.SelectedIndex != -1)
            {
                filterAll();

            }
        }

        private void filterAll(){

            string query = "WHERE ";

            if (cmb_filterItem.SelectedIndex != -1)
            {
                query += "i.id=" + cmb_filterItem.SelectedValue.ToString();
                if (cmb_filterLocation.SelectedIndex != -1)
                {
                    query += " AND l.id=" + cmb_filterLocation.SelectedValue.ToString();                     
                }

            }
            else if (cmb_filterLocation.SelectedIndex != -1)
            {
                query += "l.id=" + cmb_filterLocation.SelectedValue.ToString();
                if (cmb_filterItem.SelectedIndex != -1)
                {
                    query += " AND i.id=" + cmb_filterItem.SelectedValue.ToString();
                }
            }

            
            createDataGridView(query);
            btn_showAll.Visible = true;
        }

        private void filterAll(int location,int item)
        {

            string query = "WHERE ";

            if (item != -1)
            {
                query += "i.id=" + item;
                if (location != -1)
                {
                    query += " AND l.id=" + location;
                }

            }
            

            createDataGridView(query);
            btn_showAll.Visible = true;
        }

        private void bindAutoComplete()
        {
            txtSearchItem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearchItem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearchItem.AutoCompleteCustomSource = dbc.getAutoCompleteCollection("item");

            txtSearchLocation.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearchLocation.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearchLocation.AutoCompleteCustomSource = dbc.getAutoCompleteCollection("location");

           
            
        }

        private void btn_showAll_Click(object sender, EventArgs e)
        {
            createDataGridView("default");
            cmb_filterItem.SelectedIndex = -1;
            cmb_filterLocation.SelectedIndex = -1;
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.locationTableAdapter.FillBy1(this.infortecstockDataSet5.location);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy22ToolStripButton_Click(object sender, EventArgs e)
        {
          

        }

        private void fillBy22ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.locationTableAdapter.FillBy22(this.infortecstockDataSet5.location);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void dgv_real_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            showLabel("Error Occured--" + e.ToString(),2);
        }

        private void dgv_real_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void dgv_real_KeyUp(object sender, KeyEventArgs e)
        {
            ////if (e.KeyCode == Keys.Delete)
            ////{
            ////    MessageBox.Show("Delete pressed!");
            ////}
        }

        private void dgv_real_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
            if (DialogResult.Yes == MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
               
                String location = e.Row.Cells[0].Value.ToString();
                String item = e.Row.Cells[1].Value.ToString();
                int amount = Convert.ToInt32(e.Row.Cells[2].Value.ToString());

                int locationId = getLocationByName(location);
                int itemId = getItemByName(item);

                if ((locationId != -2) && (locationId != -2))
                {
                    string query = String.Format("DELETE FROM located_in WHERE itemId={0} AND locationId={1}",itemId,locationId);
                    dbc.Delete(query);
                    e.Cancel = false;

                    string insertQuery = String.Format("INSERT INTO deleteLog(userId,locationId,itemId,description,amount) values({0},{1},{2},'{3}',{4})",userId, locationId, itemId, "Test Data",amount );
                    dbc.Insert(insertQuery);
                   
                    showLabel("Delete Success", 1);
                }
            }
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure about this addition?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int itemId = Convert.ToInt32(cmb_item.SelectedValue);
                int locationId = Convert.ToInt32(cmb_location.SelectedValue);
               
                int amount = Convert.ToInt32(nud_amount.Value);
                
                String description = dbc.ToLiteral(txt_des.Text);

                if (amount > 0)
                {
                    string insertQuery1 = String.Format("INSERT INTO located_in(itemId,locationId,amount) VALUES({0},{1},{2}) ON DUPLICATE KEY UPDATE amount = amount +{3}", itemId, locationId, amount, amount);
                    dbc.Insert(insertQuery1);

                    string insertQuery = String.Format("INSERT INTO addI(userId,itemId,locationId,amount,description) values({0},{1},{2},{3},'{4}')", userId, itemId, locationId, amount, description);
                    dbc.Insert(insertQuery);
                    
                    MessageBox.Show(amount + " items successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nud_amount.Value = 1;
                    txt_des.Text = "";

                    //create dgv
                    filterAll(locationId, itemId);
                }
                else
                {
                    showLabel("You are trying to add 0 items. Please choose a number", 2);
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Are you sure about this addition?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int amount = Convert.ToInt32(nud_quantity.Value);
                int locationId = getLocationByName(lbl_locationName.Text);
                int itemId = getItemByName(lbl_itemName.Text);
                string description =dbc.ToLiteral(txt_description.Text);
                int currentAmount = Convert.ToInt32(lbl_itemQuantity.Text.Substring(10));


                if ((amount > 0) && (itemId != -2) && (locationId != -2))
                {
                    string insertQuery1 = String.Format("INSERT INTO located_in(itemId,locationId,amount) VALUES({0},{1},{2}) ON DUPLICATE KEY UPDATE amount = amount +{3}", itemId, locationId, amount, amount);
                    dbc.Insert(insertQuery1);

                    string insertQuery = String.Format("INSERT INTO addI(userId,itemId,locationId,amount,description) values({0},{1},{2},{3},'{4}')", userId, itemId, locationId, amount, description);
                    dbc.Insert(insertQuery);

                    MessageBox.Show("Item Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    txt_description.Text = "";
                    nud_quantity.Value = 1;

                    lbl_itemQuantity.Text = "Quantity - "+ Convert.ToString(currentAmount + amount);

                    //create data grid
                    filterAll(locationId, itemId);
                }
                else
                {
                    showLabel("Error Occured", 2);
                }
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_deduct_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Are you sure about this deduction?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int amount = Convert.ToInt32(nud_quantity.Value);
                int locationId = getLocationByName(lbl_locationName.Text);
                int itemId = getItemByName(lbl_itemName.Text);
                string description = dbc.ToLiteral(txt_description.Text);
                int currentAmount = Convert.ToInt32(lbl_itemQuantity.Text.Substring(10));


                if ((amount > 0) && (amount <= currentAmount) && (itemId != -2) && (locationId != -2))
                {
                    string insertQuery1 = String.Format("UPDATE located_in set amount=amount-{0} WHERE itemId={1} AND locationId={2}", amount, itemId, locationId);
                    dbc.Insert(insertQuery1);

                    string insertQuery = String.Format("INSERT INTO deduct(userId,itemId,locationId,amount,description) values({0},{1},{2},{3},'{4}')", userId, itemId, locationId, amount, description);
                    dbc.Insert(insertQuery);
                    
                    MessageBox.Show(amount + " " + lbl_itemName.Text + "(s) of " + lbl_locationName.Text + " is successfully issued", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbl_itemQuantity.Text = "Quantity - " + Convert.ToString(currentAmount - amount);
                    txt_description.Text = "";
                    nud_quantity.Value = 1;

                    //create data grid
                    filterAll(locationId, itemId);
                }
                else
                {
                    showLabel("Error in your update", 2);
                }
            }
        }

        private void btn_logs_Click(object sender, EventArgs e)
        {
            frm_log fl = new frm_log();
            fl.Show();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            
        }

        private void nud_amount_Leave(object sender, EventArgs e)
        {
            if (nud_amount.Text == String.Empty)
            {
                nud_amount.Text = "0";
            }
        }

        private void nud_quantity_Leave(object sender, EventArgs e)
        {
            if (nud_quantity.Text == String.Empty)
            {
                nud_quantity.Text = "0";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_viewDgv_Click(object sender, EventArgs e)
        {
            if (isDiscriptiveSelected)
                createSummaryDgv();
            else
                createDataGridView("default");
        }

        private void createSummaryDgv()
        {
            dgv_real.DataSource = null;
            dgv_real.Columns.Clear();
            dgv_real.Rows.Clear();

            string query = "";
            DataSet ds;

            query = "SELECT i.name AS 'Item Name',sum(amount) AS 'Total number of Items' FROM located_in l join item i on l.itemId=i.id group by itemId";
            
            ds = dbc.getDS(query);
            this.dgv_real.DataSource = ds.Tables[0];

          

            for (int x = 0; x < dgv_real.ColumnCount - 1; x++)
            {
                dgv_real.Columns[x].ReadOnly = true;

            }

            txtSearchLocation.Enabled = false;
            txtSearchItem.Enabled = false;
            groupBox1.Enabled = false;

            isDiscriptiveSelected = false;
        }
       
    }
}
