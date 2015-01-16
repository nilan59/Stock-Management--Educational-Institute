namespace Infortec_Stock_Management
{
    partial class frm_userRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_error = new System.Windows.Forms.Label();
            this.infortecstockDataSet11 = new Infortec_Stock_Management.infortecstockDataSet11();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new Infortec_Stock_Management.infortecstockDataSet11TableAdapters.userTableAdapter();
            this.grp_updatePassword = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_levelUpdate = new System.Windows.Forms.ComboBox();
            this.userlevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infortecstockDataSet12 = new Infortec_Stock_Management.infortecstockDataSet12();
            this.lbl_userId = new System.Windows.Forms.Label();
            this.lbl_updatePasswordError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_newConfirmPassword = new System.Windows.Forms.TextBox();
            this.txt_newPassword = new System.Windows.Forms.TextBox();
            this.btn_updatePassword = new System.Windows.Forms.Button();
            this.grp_registerUser = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_levelReg = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_confirmPassowrd = new System.Windows.Forms.TextBox();
            this.txt_passWord = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.user_levelTableAdapter = new Infortec_Stock_Management.infortecstockDataSet12TableAdapters.user_levelTableAdapter();
            this.dgv_users = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.infortecstockDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.grp_updatePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userlevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infortecstockDataSet12)).BeginInit();
            this.grp_registerUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(12, 227);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 15);
            this.lbl_error.TabIndex = 7;
            // 
            // infortecstockDataSet11
            // 
            this.infortecstockDataSet11.DataSetName = "infortecstockDataSet11";
            this.infortecstockDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.infortecstockDataSet11;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // grp_updatePassword
            // 
            this.grp_updatePassword.Controls.Add(this.label6);
            this.grp_updatePassword.Controls.Add(this.cmb_levelUpdate);
            this.grp_updatePassword.Controls.Add(this.lbl_userId);
            this.grp_updatePassword.Controls.Add(this.lbl_updatePasswordError);
            this.grp_updatePassword.Controls.Add(this.label4);
            this.grp_updatePassword.Controls.Add(this.label5);
            this.grp_updatePassword.Controls.Add(this.txt_newConfirmPassword);
            this.grp_updatePassword.Controls.Add(this.txt_newPassword);
            this.grp_updatePassword.Controls.Add(this.btn_updatePassword);
            this.grp_updatePassword.ForeColor = System.Drawing.Color.Silver;
            this.grp_updatePassword.Location = new System.Drawing.Point(18, 227);
            this.grp_updatePassword.Name = "grp_updatePassword";
            this.grp_updatePassword.Size = new System.Drawing.Size(225, 198);
            this.grp_updatePassword.TabIndex = 9;
            this.grp_updatePassword.TabStop = false;
            this.grp_updatePassword.Text = "Update Password";
            this.grp_updatePassword.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Priviledge Level";
            // 
            // cmb_levelUpdate
            // 
            this.cmb_levelUpdate.DataSource = this.userlevelBindingSource;
            this.cmb_levelUpdate.DisplayMember = "name";
            this.cmb_levelUpdate.FormattingEnabled = true;
            this.cmb_levelUpdate.Location = new System.Drawing.Point(110, 112);
            this.cmb_levelUpdate.Name = "cmb_levelUpdate";
            this.cmb_levelUpdate.Size = new System.Drawing.Size(100, 21);
            this.cmb_levelUpdate.TabIndex = 25;
            this.cmb_levelUpdate.ValueMember = "id";
            // 
            // userlevelBindingSource
            // 
            this.userlevelBindingSource.DataMember = "user_level";
            this.userlevelBindingSource.DataSource = this.infortecstockDataSet12;
            // 
            // infortecstockDataSet12
            // 
            this.infortecstockDataSet12.DataSetName = "infortecstockDataSet12";
            this.infortecstockDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_userId
            // 
            this.lbl_userId.AutoSize = true;
            this.lbl_userId.Location = new System.Drawing.Point(128, 182);
            this.lbl_userId.Name = "lbl_userId";
            this.lbl_userId.Size = new System.Drawing.Size(0, 13);
            this.lbl_userId.TabIndex = 24;
            this.lbl_userId.Visible = false;
            // 
            // lbl_updatePasswordError
            // 
            this.lbl_updatePasswordError.AutoSize = true;
            this.lbl_updatePasswordError.ForeColor = System.Drawing.Color.Red;
            this.lbl_updatePasswordError.Location = new System.Drawing.Point(11, 182);
            this.lbl_updatePasswordError.Name = "lbl_updatePasswordError";
            this.lbl_updatePasswordError.Size = new System.Drawing.Size(0, 13);
            this.lbl_updatePasswordError.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "New Password";
            // 
            // txt_newConfirmPassword
            // 
            this.txt_newConfirmPassword.Location = new System.Drawing.Point(110, 73);
            this.txt_newConfirmPassword.Name = "txt_newConfirmPassword";
            this.txt_newConfirmPassword.PasswordChar = '*';
            this.txt_newConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.txt_newConfirmPassword.TabIndex = 19;
            // 
            // txt_newPassword
            // 
            this.txt_newPassword.Location = new System.Drawing.Point(110, 33);
            this.txt_newPassword.Name = "txt_newPassword";
            this.txt_newPassword.PasswordChar = '*';
            this.txt_newPassword.Size = new System.Drawing.Size(100, 20);
            this.txt_newPassword.TabIndex = 17;
            // 
            // btn_updatePassword
            // 
            this.btn_updatePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_updatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_updatePassword.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatePassword.Location = new System.Drawing.Point(110, 150);
            this.btn_updatePassword.Name = "btn_updatePassword";
            this.btn_updatePassword.Size = new System.Drawing.Size(100, 29);
            this.btn_updatePassword.TabIndex = 20;
            this.btn_updatePassword.Text = "Update Password";
            this.btn_updatePassword.UseVisualStyleBackColor = false;
            this.btn_updatePassword.Click += new System.EventHandler(this.btn_updatePassword_Click);
            // 
            // grp_registerUser
            // 
            this.grp_registerUser.Controls.Add(this.label7);
            this.grp_registerUser.Controls.Add(this.cmb_levelReg);
            this.grp_registerUser.Controls.Add(this.label3);
            this.grp_registerUser.Controls.Add(this.label2);
            this.grp_registerUser.Controls.Add(this.txt_confirmPassowrd);
            this.grp_registerUser.Controls.Add(this.txt_passWord);
            this.grp_registerUser.Controls.Add(this.btn_register);
            this.grp_registerUser.Controls.Add(this.label1);
            this.grp_registerUser.Controls.Add(this.txt_userName);
            this.grp_registerUser.ForeColor = System.Drawing.Color.Silver;
            this.grp_registerUser.Location = new System.Drawing.Point(15, 38);
            this.grp_registerUser.Name = "grp_registerUser";
            this.grp_registerUser.Size = new System.Drawing.Size(228, 183);
            this.grp_registerUser.TabIndex = 10;
            this.grp_registerUser.TabStop = false;
            this.grp_registerUser.Text = "Register User";
            this.grp_registerUser.Enter += new System.EventHandler(this.grp_registerUser_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Priviledge Level";
            // 
            // cmb_levelReg
            // 
            this.cmb_levelReg.DataSource = this.userlevelBindingSource;
            this.cmb_levelReg.DisplayMember = "name";
            this.cmb_levelReg.FormattingEnabled = true;
            this.cmb_levelReg.Location = new System.Drawing.Point(113, 98);
            this.cmb_levelReg.Name = "cmb_levelReg";
            this.cmb_levelReg.Size = new System.Drawing.Size(100, 21);
            this.cmb_levelReg.TabIndex = 36;
            this.cmb_levelReg.ValueMember = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Confirm Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Password";
            // 
            // txt_confirmPassowrd
            // 
            this.txt_confirmPassowrd.Location = new System.Drawing.Point(113, 72);
            this.txt_confirmPassowrd.Name = "txt_confirmPassowrd";
            this.txt_confirmPassowrd.PasswordChar = '*';
            this.txt_confirmPassowrd.Size = new System.Drawing.Size(100, 20);
            this.txt_confirmPassowrd.TabIndex = 32;
            // 
            // txt_passWord
            // 
            this.txt_passWord.Location = new System.Drawing.Point(113, 46);
            this.txt_passWord.Name = "txt_passWord";
            this.txt_passWord.PasswordChar = '*';
            this.txt_passWord.Size = new System.Drawing.Size(100, 20);
            this.txt_passWord.TabIndex = 30;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_register.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(113, 135);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(100, 29);
            this.btn_register.TabIndex = 33;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "User Name";
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(113, 20);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(100, 20);
            this.txt_userName.TabIndex = 29;
            // 
            // user_levelTableAdapter
            // 
            this.user_levelTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_users
            // 
            this.dgv_users.AllowUserToAddRows = false;
            this.dgv_users.AllowUserToDeleteRows = false;
            this.dgv_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_users.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv_users.Location = new System.Drawing.Point(362, 0);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.Size = new System.Drawing.Size(463, 431);
            this.dgv_users.TabIndex = 8;
            this.dgv_users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_users_CellContentClick);
            // 
            // frm_userRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(825, 431);
            this.Controls.Add(this.grp_registerUser);
            this.Controls.Add(this.grp_updatePassword);
            this.Controls.Add(this.dgv_users);
            this.Controls.Add(this.lbl_error);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "frm_userRegistration";
            this.Text = "Register Users";
            this.Load += new System.EventHandler(this.frm_userRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infortecstockDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.grp_updatePassword.ResumeLayout(false);
            this.grp_updatePassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userlevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infortecstockDataSet12)).EndInit();
            this.grp_registerUser.ResumeLayout(false);
            this.grp_registerUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_error;
        private infortecstockDataSet11 infortecstockDataSet11;
        private System.Windows.Forms.BindingSource userBindingSource;
        private infortecstockDataSet11TableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.GroupBox grp_updatePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_newConfirmPassword;
        private System.Windows.Forms.TextBox txt_newPassword;
        private System.Windows.Forms.Button btn_updatePassword;
        private System.Windows.Forms.Label lbl_updatePasswordError;
        private System.Windows.Forms.Label lbl_userId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_levelUpdate;
        private System.Windows.Forms.GroupBox grp_registerUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_levelReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_confirmPassowrd;
        private System.Windows.Forms.TextBox txt_passWord;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_userName;
        private infortecstockDataSet12 infortecstockDataSet12;
        private System.Windows.Forms.BindingSource userlevelBindingSource;
        private infortecstockDataSet12TableAdapters.user_levelTableAdapter user_levelTableAdapter;
        private System.Windows.Forms.DataGridView dgv_users;
    }
}