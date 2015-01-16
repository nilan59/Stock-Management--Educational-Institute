namespace Infortec_Stock_Management
{
    partial class frm_studyPacks
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
            this.studypacksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infortecstockDataSet10 = new Infortec_Stock_Management.infortecstockDataSet10();
            this.study_packsTableAdapter = new Infortec_Stock_Management.infortecstockDataSet10TableAdapters.study_packsTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_studyLog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_sem2Mgmt = new System.Windows.Forms.Button();
            this.btn_sem2Prog = new System.Windows.Forms.Button();
            this.btn_sem1 = new System.Windows.Forms.Button();
            this.btn_issue = new System.Windows.Forms.Button();
            this.grp_add = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtb_des_add = new System.Windows.Forms.RichTextBox();
            this.nud_add = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_bookAdd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_studyPackData = new System.Windows.Forms.DataGridView();
            this.lbl_completePackage = new System.Windows.Forms.Label();
            this.btn_packIssue = new System.Windows.Forms.Button();
            this.nud_packIssue = new System.Windows.Forms.NumericUpDown();
            this.lbl_howManyPacks = new System.Windows.Forms.Label();
            this.rtb_packsIssue = new System.Windows.Forms.RichTextBox();
            this.lbl_packDes = new System.Windows.Forms.Label();
            this.grp_dynamic = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.studypacksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infortecstockDataSet10)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grp_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studyPackData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_packIssue)).BeginInit();
            this.grp_dynamic.SuspendLayout();
            this.SuspendLayout();
            // 
            // studypacksBindingSource
            // 
            this.studypacksBindingSource.DataMember = "study_packs";
            this.studypacksBindingSource.DataSource = this.infortecstockDataSet10;
            // 
            // infortecstockDataSet10
            // 
            this.infortecstockDataSet10.DataSetName = "infortecstockDataSet10";
            this.infortecstockDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // study_packsTableAdapter
            // 
            this.study_packsTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_studyLog);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 193);
            this.panel2.TabIndex = 19;
            // 
            // btn_studyLog
            // 
            this.btn_studyLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_studyLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_studyLog.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_studyLog.Location = new System.Drawing.Point(298, 73);
            this.btn_studyLog.Name = "btn_studyLog";
            this.btn_studyLog.Size = new System.Drawing.Size(114, 48);
            this.btn_studyLog.TabIndex = 18;
            this.btn_studyLog.Text = "Load log";
            this.btn_studyLog.UseVisualStyleBackColor = false;
            this.btn_studyLog.Click += new System.EventHandler(this.btn_studyLog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_sem2Mgmt);
            this.groupBox1.Controls.Add(this.btn_sem2Prog);
            this.groupBox1.Controls.Add(this.btn_sem1);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(475, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 183);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Issue as a Pack";
            // 
            // btn_sem2Mgmt
            // 
            this.btn_sem2Mgmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sem2Mgmt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sem2Mgmt.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sem2Mgmt.Location = new System.Drawing.Point(11, 127);
            this.btn_sem2Mgmt.Name = "btn_sem2Mgmt";
            this.btn_sem2Mgmt.Size = new System.Drawing.Size(84, 48);
            this.btn_sem2Mgmt.TabIndex = 16;
            this.btn_sem2Mgmt.Text = "Semester 02 Management";
            this.btn_sem2Mgmt.UseVisualStyleBackColor = false;
            this.btn_sem2Mgmt.Click += new System.EventHandler(this.btn_sem2Mgmt_Click);
            // 
            // btn_sem2Prog
            // 
            this.btn_sem2Prog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sem2Prog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sem2Prog.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sem2Prog.Location = new System.Drawing.Point(11, 73);
            this.btn_sem2Prog.Name = "btn_sem2Prog";
            this.btn_sem2Prog.Size = new System.Drawing.Size(84, 48);
            this.btn_sem2Prog.TabIndex = 15;
            this.btn_sem2Prog.Text = "Semester 02  Programming";
            this.btn_sem2Prog.UseVisualStyleBackColor = false;
            this.btn_sem2Prog.Click += new System.EventHandler(this.btn_sem2Prog_Click);
            // 
            // btn_sem1
            // 
            this.btn_sem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sem1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sem1.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sem1.Location = new System.Drawing.Point(11, 19);
            this.btn_sem1.Name = "btn_sem1";
            this.btn_sem1.Size = new System.Drawing.Size(84, 48);
            this.btn_sem1.TabIndex = 14;
            this.btn_sem1.Text = "Semester 01";
            this.btn_sem1.UseVisualStyleBackColor = false;
            this.btn_sem1.Click += new System.EventHandler(this.btn_sem1_Click);
            // 
            // btn_issue
            // 
            this.btn_issue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_issue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_issue.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_issue.Location = new System.Drawing.Point(144, 152);
            this.btn_issue.Name = "btn_issue";
            this.btn_issue.Size = new System.Drawing.Size(75, 23);
            this.btn_issue.TabIndex = 5;
            this.btn_issue.Text = "Issue";
            this.btn_issue.UseVisualStyleBackColor = false;
            this.btn_issue.Click += new System.EventHandler(this.btn_issue_Click);
            // 
            // grp_add
            // 
            this.grp_add.Controls.Add(this.label5);
            this.grp_add.Controls.Add(this.rtb_des_add);
            this.grp_add.Controls.Add(this.nud_add);
            this.grp_add.Controls.Add(this.label2);
            this.grp_add.Controls.Add(this.cmb_bookAdd);
            this.grp_add.Controls.Add(this.label1);
            this.grp_add.Controls.Add(this.btn_issue);
            this.grp_add.Controls.Add(this.btn_add);
            this.grp_add.ForeColor = System.Drawing.Color.Silver;
            this.grp_add.Location = new System.Drawing.Point(13, 24);
            this.grp_add.Name = "grp_add";
            this.grp_add.Size = new System.Drawing.Size(225, 183);
            this.grp_add.TabIndex = 15;
            this.grp_add.TabStop = false;
            this.grp_add.Text = "Add Books";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Description";
            // 
            // rtb_des_add
            // 
            this.rtb_des_add.Location = new System.Drawing.Point(90, 101);
            this.rtb_des_add.Name = "rtb_des_add";
            this.rtb_des_add.Size = new System.Drawing.Size(120, 45);
            this.rtb_des_add.TabIndex = 11;
            this.rtb_des_add.Text = "";
            // 
            // nud_add
            // 
            this.nud_add.Location = new System.Drawing.Point(90, 75);
            this.nud_add.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_add.Name = "nud_add";
            this.nud_add.Size = new System.Drawing.Size(120, 20);
            this.nud_add.TabIndex = 10;
            this.nud_add.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_add.Leave += new System.EventHandler(this.nud_add_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Amount";
            // 
            // cmb_bookAdd
            // 
            this.cmb_bookAdd.DataSource = this.studypacksBindingSource;
            this.cmb_bookAdd.DisplayMember = "name";
            this.cmb_bookAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bookAdd.FormattingEnabled = true;
            this.cmb_bookAdd.Location = new System.Drawing.Point(90, 34);
            this.cmb_bookAdd.Name = "cmb_bookAdd";
            this.cmb_bookAdd.Size = new System.Drawing.Size(121, 21);
            this.cmb_bookAdd.TabIndex = 7;
            this.cmb_bookAdd.ValueMember = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Book";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(63, 152);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgv_studyPackData
            // 
            this.dgv_studyPackData.AllowUserToAddRows = false;
            this.dgv_studyPackData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_studyPackData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_studyPackData.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv_studyPackData.Location = new System.Drawing.Point(663, 0);
            this.dgv_studyPackData.Name = "dgv_studyPackData";
            this.dgv_studyPackData.Size = new System.Drawing.Size(291, 659);
            this.dgv_studyPackData.TabIndex = 18;
            // 
            // lbl_completePackage
            // 
            this.lbl_completePackage.AutoSize = true;
            this.lbl_completePackage.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_completePackage.Location = new System.Drawing.Point(14, 25);
            this.lbl_completePackage.Name = "lbl_completePackage";
            this.lbl_completePackage.Size = new System.Drawing.Size(136, 17);
            this.lbl_completePackage.TabIndex = 0;
            this.lbl_completePackage.Text = "Complete Package with";
            this.lbl_completePackage.Visible = false;
            // 
            // btn_packIssue
            // 
            this.btn_packIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_packIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_packIssue.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_packIssue.Location = new System.Drawing.Point(478, 188);
            this.btn_packIssue.Name = "btn_packIssue";
            this.btn_packIssue.Size = new System.Drawing.Size(120, 42);
            this.btn_packIssue.TabIndex = 11;
            this.btn_packIssue.Text = " Issue as a pack";
            this.btn_packIssue.UseVisualStyleBackColor = false;
            this.btn_packIssue.Visible = false;
            this.btn_packIssue.Click += new System.EventHandler(this.btn_packIssue_Click);
            // 
            // nud_packIssue
            // 
            this.nud_packIssue.Location = new System.Drawing.Point(478, 92);
            this.nud_packIssue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_packIssue.Name = "nud_packIssue";
            this.nud_packIssue.Size = new System.Drawing.Size(120, 20);
            this.nud_packIssue.TabIndex = 12;
            this.nud_packIssue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_packIssue.Visible = false;
            this.nud_packIssue.Leave += new System.EventHandler(this.nud_packIssue_Leave);
            // 
            // lbl_howManyPacks
            // 
            this.lbl_howManyPacks.AutoSize = true;
            this.lbl_howManyPacks.Location = new System.Drawing.Point(383, 94);
            this.lbl_howManyPacks.Name = "lbl_howManyPacks";
            this.lbl_howManyPacks.Size = new System.Drawing.Size(92, 13);
            this.lbl_howManyPacks.TabIndex = 13;
            this.lbl_howManyPacks.Text = "How many packs:";
            this.lbl_howManyPacks.Visible = false;
            // 
            // rtb_packsIssue
            // 
            this.rtb_packsIssue.Location = new System.Drawing.Point(478, 118);
            this.rtb_packsIssue.Name = "rtb_packsIssue";
            this.rtb_packsIssue.Size = new System.Drawing.Size(120, 45);
            this.rtb_packsIssue.TabIndex = 14;
            this.rtb_packsIssue.Text = "";
            this.rtb_packsIssue.Visible = false;
            // 
            // lbl_packDes
            // 
            this.lbl_packDes.AutoSize = true;
            this.lbl_packDes.Location = new System.Drawing.Point(331, 121);
            this.lbl_packDes.Name = "lbl_packDes";
            this.lbl_packDes.Size = new System.Drawing.Size(144, 13);
            this.lbl_packDes.TabIndex = 15;
            this.lbl_packDes.Text = "Student Names / Description";
            this.lbl_packDes.Visible = false;
            // 
            // grp_dynamic
            // 
            this.grp_dynamic.BackColor = System.Drawing.Color.Black;
            this.grp_dynamic.Controls.Add(this.lbl_packDes);
            this.grp_dynamic.Controls.Add(this.rtb_packsIssue);
            this.grp_dynamic.Controls.Add(this.lbl_howManyPacks);
            this.grp_dynamic.Controls.Add(this.nud_packIssue);
            this.grp_dynamic.Controls.Add(this.btn_packIssue);
            this.grp_dynamic.Controls.Add(this.lbl_completePackage);
            this.grp_dynamic.ForeColor = System.Drawing.Color.Silver;
            this.grp_dynamic.Location = new System.Drawing.Point(12, 232);
            this.grp_dynamic.Name = "grp_dynamic";
            this.grp_dynamic.Size = new System.Drawing.Size(645, 415);
            this.grp_dynamic.TabIndex = 20;
            this.grp_dynamic.TabStop = false;
            this.grp_dynamic.Enter += new System.EventHandler(this.grp_dynamic_Enter);
            // 
            // frm_studyPacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(954, 659);
            this.Controls.Add(this.dgv_studyPackData);
            this.Controls.Add(this.grp_dynamic);
            this.Controls.Add(this.grp_add);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "frm_studyPacks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Study Packs";
            this.Load += new System.EventHandler(this.frm_studyPacks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studypacksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infortecstockDataSet10)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grp_add.ResumeLayout(false);
            this.grp_add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studyPackData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_packIssue)).EndInit();
            this.grp_dynamic.ResumeLayout(false);
            this.grp_dynamic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private infortecstockDataSet10 infortecstockDataSet10;
        private System.Windows.Forms.BindingSource studypacksBindingSource;
        private infortecstockDataSet10TableAdapters.study_packsTableAdapter study_packsTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_sem2Mgmt;
        private System.Windows.Forms.Button btn_sem2Prog;
        private System.Windows.Forms.Button btn_sem1;
        private System.Windows.Forms.Button btn_issue;
        private System.Windows.Forms.GroupBox grp_add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtb_des_add;
        private System.Windows.Forms.NumericUpDown nud_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_bookAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_studyPackData;
        private System.Windows.Forms.Button btn_studyLog;
        private System.Windows.Forms.Label lbl_completePackage;
        private System.Windows.Forms.Button btn_packIssue;
        private System.Windows.Forms.NumericUpDown nud_packIssue;
        private System.Windows.Forms.Label lbl_howManyPacks;
        private System.Windows.Forms.RichTextBox rtb_packsIssue;
        private System.Windows.Forms.Label lbl_packDes;
        private System.Windows.Forms.GroupBox grp_dynamic;
    }
}