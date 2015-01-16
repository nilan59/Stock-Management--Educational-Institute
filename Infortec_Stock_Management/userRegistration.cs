using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Infortec_Stock_Management
{
    public partial class frm_userRegistration : Form
    {
        DBConnect dbc = null;
        int clickDGV = 0;
        public frm_userRegistration()
        {
            InitializeComponent();
            dbc = new DBConnect();
            createDataGridView();
           
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            lbl_error.ForeColor = Color.Red;

            if (txt_userName.TextLength < 4)
            {
                lbl_error.Text = "User Name should atleast be 4 charactors long!";
            }
            else if (txt_passWord.TextLength < 4)
            {
                lbl_error.Text = "Password should atleast be 4 charactors long!";
            }
            else if (txt_passWord.Text != txt_confirmPassowrd.Text)
            {
                lbl_error.Text = "Passwords do not match!";
            }
            else
            {
                string querySel = "SELECT EXISTS (SELECT 1 FROM user WHERE name='"+txt_userName.Text+"')";
                int val = dbc.GetSingleVal(querySel);
                if (val > 0)
                {
                    lbl_error.Text = "User already exists! Try another name";
                }
                else
                {
                    var md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                    byte[] md5data = md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes (txt_passWord.Text));
                    string hashedPassword = System.Text.Encoding.ASCII.GetString(md5data);
                    hashedPassword = ToLiteral(hashedPassword);
                   
                    int accessLevel = Convert.ToInt32(cmb_levelReg.SelectedValue);
                    

                    String queryIns = "INSERT INTO user(name,password,access_level) VALUES('" + txt_userName.Text + "','" + hashedPassword + "',"+accessLevel+")";
                    dbc.Insert(queryIns);

                    createDataGridView();
                    lbl_error.ForeColor = Color.Green;
                    MessageBox.Show("User Successfully registered","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txt_newPassword.Clear();
                    txt_userName.Clear();
                    txt_passWord.Clear();
                    txt_confirmPassowrd.Clear();
                   // lbl_error.Text = "User Successfully registered";
                    
                }
            }
        }
        private byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        private string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

        private void frm_userRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'infortecstockDataSet12.user_level' table. You can move, or remove it, as needed.
            this.user_levelTableAdapter.Fill(this.infortecstockDataSet12.user_level);
            // TODO: This line of code loads data into the 'infortecstockDataSet11.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.infortecstockDataSet11.user);

        }

        private void createDataGridView()
        {
            dgv_users.DataSource = null;
            dgv_users.Columns.Clear();
            dgv_users.Rows.Clear();

            string query = "";
            DataSet ds;

            query = "SELECT id, name, access_level FROM user";
           
            ds = dbc.getDS(query);
            this.dgv_users.DataSource = ds.Tables[0];

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgv_users.Columns.Add(btn);
            btn.HeaderText = "Click & Update";
            btn.Text = "Update";
            btn.Name = "btn_update";
            btn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btnDel = new DataGridViewButtonColumn();
            dgv_users.Columns.Add(btnDel);
            btnDel.HeaderText = "Delete User";
            btnDel.Text = "Delete";
            btnDel.Name = "btn_delete";
            btnDel.UseColumnTextForButtonValue = true;

            foreach (DataGridViewRow dr in dgv_users.Rows)
            {
                int userId = Convert.ToInt32(dr.Cells[0].Value.ToString());
                if (DBConnect.loggedUserID == userId)
                {
                    //MessageBox.Show(dr.Cells[4].Value.ToString());
                    //dr.Cells[4].ReadOnly = true;
                    //dr.DataGridView.Rows[dr.DataGridView.Rows.Count-1].Cells[4]. = true;

                }
                
            }

           
        }

        private void dgv_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (clickDGV == 0) { createDataGridView(); clickDGV++; }
            string selectedUser = "";
            int selectedUserId = 0;
            int accessLevel = 0;

            if (e.ColumnIndex == 3)
            {
                try
                {
                    selectedUser = dgv_users[1, e.RowIndex].Value.ToString();
                    selectedUserId = Convert.ToInt32(dgv_users[0, e.RowIndex].Value);
                    //accessLevel = Convert.ToInt32(dgv_users[2, e.RowIndex].Value);


                    lbl_updatePasswordError.Text = "";
                    lbl_error.Text = "";
                    grp_updatePassword.Visible = true;
                    grp_updatePassword.Text = "Change Password for " + selectedUser;
                    lbl_userId.Text = selectedUserId.ToString();

                    

                }
                catch (Exception ex)
                {
                    lbl_updatePasswordError.Text = "Error Occured";
                }
              

            }

            if (e.ColumnIndex == 4)
            {
               
                try
                {
                int value = 2;
                selectedUser = dgv_users[1, e.RowIndex].Value.ToString();
                selectedUserId = Convert.ToInt32(dgv_users[0, e.RowIndex].Value);
                accessLevel = Convert.ToInt32(dgv_users[2, e.RowIndex].Value);

                if (DialogResult.Yes == MessageBox.Show("Are You sure about deleteting " + selectedUser, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (accessLevel == 1)
                    {
                        string querySel = "SELECT count(id) FROM user WHERE access_level=1";
                        value = dbc.GetSingleVal(querySel);                        
                    }
                    if (value < 2)
                    {
                        MessageBox.Show("You are the only administrator left. You cannot delete yourself! Please add a new administrator to proceed with your deletion", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string queryDel = "DELETE FROM user WHERE id=" + selectedUserId;
                        dbc.Delete(queryDel);
                        createDataGridView();
                        MessageBox.Show("User Successfully deleted!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                }
                catch (Exception ex)
                {
                    lbl_updatePasswordError.Text = "Error Occured"+ex.Message;
                }
            }
        }

        private void btn_updatePassword_Click(object sender, EventArgs e)
        {
            string newPassword = txt_newPassword.Text;
            string newConfPassword = txt_newConfirmPassword.Text;
            lbl_updatePasswordError.ForeColor = Color.Red;
           

            if (newPassword.Length < 4)
            {
                lbl_updatePasswordError.Text = "Password Length should atleast be 4 charactors";
            }
            else if (newPassword != newConfPassword)
            {
                lbl_updatePasswordError.Text = "Passwords do not match";
            }
            else
            {
                lbl_updatePasswordError.Text = "";
                int selectedId = Convert.ToInt32(lbl_userId.Text);

                var md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] md5data = md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(newPassword));
                string hashedPassword = System.Text.Encoding.ASCII.GetString(md5data);
                int accessLevel = Convert.ToInt32(cmb_levelUpdate.SelectedValue);

                hashedPassword = ToLiteral(hashedPassword);

                string queryUp = "UPDATE user SET password='"+hashedPassword+"', access_level="+accessLevel+" WHERE id="+selectedId;
                dbc.Update(queryUp);

                createDataGridView();
                lbl_updatePasswordError.ForeColor = Color.Green;
                MessageBox.Show("User Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_newPassword.Clear();
                txt_newConfirmPassword.Clear();
                grp_updatePassword.Visible = false;
               
               // lbl_updatePasswordError.Text = "Password Change Successful";
            }
        }

        private string ToLiteral(string input)
        {
            using (var writer = new System.IO.StringWriter())
            {
                using (var provider = CodeDomProvider.CreateProvider("CSharp"))
                {
                    provider.GenerateCodeFromExpression(new CodePrimitiveExpression(input), writer, null);
                    return writer.ToString();
                }
            }
        }

        private void btn_register_Click_1(object sender, EventArgs e)
        {

        }

        private void grp_registerUser_Enter(object sender, EventArgs e)
        {

        }
    }
}
