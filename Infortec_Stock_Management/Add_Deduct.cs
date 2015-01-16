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
    public partial class frm_addDeduct : Form
    {
        DBConnect dbc;
        public frm_addDeduct()
        {
            InitializeComponent();
           
        }

        public frm_addDeduct(int itemId,int locationId,int currentAmount)
        {
            InitializeComponent();
           
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void FillDropDownList(string type,ComboBox DropDownName)
        {
            DataTable dt;

            if (type == "item")
            {
                dt = dbc.getTableForCombo("select id,name from item");
            }
            else
            {
                dt = dbc.getTableForCombo("select id,name from location");
            }

            DropDownName.DataSource = dt;
            DropDownName.ValueMember = "id";
            DropDownName.DisplayMember = "name";
        }


        private void frm_addDeduct_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            //int itemId = Convert.ToInt32(cmb_itemA.SelectedValue);
            //int locationId = Convert.ToInt32(cmb_locationA.SelectedValue);
            //int amount = Convert.ToInt32(nud_amountA.Value);
            //String description = rtb_descriptionA.Text;

            //if (amount != 0)
            //{
            //    string insertQuery1 = String.Format("INSERT INTO located_in(itemId,locationId,amount) VALUES({0},{1},{2}) ON DUPLICATE KEY UPDATE amount = amount +{3}", itemId, locationId, amount, amount);
            //    dbc.Insert(insertQuery1);

            //    string insertQuery = String.Format("INSERT INTO addI(userId,itemId,locationId,amount,description) values({0},{1},{2},{3},'{4}')", 1, itemId, locationId, amount, description);
            //    dbc.Insert(insertQuery);
            //    MessageBox.Show("Item Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("You are trying to add 0 items. Please choose a number");
            //}
            //updateBothCombo();
           
        }

        private void btn_deductItem_Click(object sender, EventArgs e)
        {
            
            //int itemId = Convert.ToInt32(cmb_itemD.SelectedValue);
            //int amount = Convert.ToInt32(nud_amountD.Value);
            //String description = rtb_descriptionD.Text;
            //int locationId = Convert.ToInt32(cmb_locationD.SelectedValue);
            //int currentCount = 0;

            //if (amount != 0)
            //{
            //    String selectSql = String.Format("select amount from located_in where locationId={0} AND itemId={1}", locationId, itemId);
            //    currentCount = dbc.GetSingleVal(selectSql);

            //    if (currentCount < 0)
            //    {
            //        MessageBox.Show(String.Format("You don't have any {0} in this location OR a fatel error occured. Try again", cmb_itemD.SelectedValue.ToString()));
            //    }
            //    else if (currentCount < amount)
            //    {
            //        MessageBox.Show(String.Format("You only have {0} items in this location. You cannot deduct {1}.", currentCount, amount));
            //    }
            //    else
            //    {
            //        string UpdateQuery = String.Format("UPDATE located_in SET amount= amount- {0} WHERE itemId={1} AND locationId={2}", amount, itemId, locationId);
            //        dbc.Update(UpdateQuery);

            //        string insertQuery = String.Format("INSERT into deduct(userId,itemId,locationId,amount,description) values({0},{1},{2},{3},'{4}')", 1, itemId, locationId, amount, description);
            //        dbc.Insert(insertQuery);
            //        MessageBox.Show("Item Successfully Deducted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("You are trying to deduct 0 items. Please choose a number");
            //}
            //updateBothCombo();

        }

        private void frm_addDeduct_Load(object sender, EventArgs e)
        {

        }

        private void cmb_itemA_SelectedIndexChanged(object sender, EventArgs e)
        {
            //updateCount(cmb_itemA, lbl_currentA);
            
        }

        private void cmb_itemD_SelectedIndexChanged(object sender, EventArgs e)
        {
            //updateCount(cmb_itemD, lbl_currentD);
        }

       
        private void updateCount(ComboBox cmb,Label lbl)
        {
             int itemId;
             if (cmb.SelectedValue != null)
             {
                 if (int.TryParse(cmb.SelectedValue.ToString(), out itemId))
                 {
                     //itemId = Convert.ToInt32(cmb_itemD.SelectedValue);
                     int amount = dbc.GetSingleVal(String.Format("select sum(amount) from located_in where itemId={0} group by itemId", itemId));
                     amount = ((amount < 0) ? 0 : amount);
                     lbl.Text = " " + amount;
                 }
             }
        }

        private void updateBothCombo()
        {
            //updateCount(cmb_itemA,lbl_currentA);
            //updateCount(cmb_itemD, lbl_currentD);
        }
            
    }
}
