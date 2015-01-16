namespace Infortec_Stock_Management
{
    partial class frm_mainInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mainInsert));
            this.lbl_heading = new System.Windows.Forms.Label();
            this.semestersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infortecstockDataSet13 = new Infortec_Stock_Management.infortecstockDataSet13();
            this.semestersTableAdapter = new Infortec_Stock_Management.infortecstockDataSet13TableAdapters.semestersTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_semester = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bookName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_bookInsert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtb_itemDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.btn_insertItem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.btn_insertLocation = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_viewBooks = new System.Windows.Forms.Button();
            this.btn_viewItem = new System.Windows.Forms.Button();
            this.btn_viewLoaction = new System.Windows.Forms.Button();
            this.dgv_crud = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.semestersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infortecstockDataSet13)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_crud)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(3, 0);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(39, 20);
            this.lbl_heading.TabIndex = 25;
            this.lbl_heading.Text = "Item";
            // 
            // semestersBindingSource
            // 
            this.semestersBindingSource.DataMember = "semesters";
            this.semestersBindingSource.DataSource = this.infortecstockDataSet13;
            // 
            // infortecstockDataSet13
            // 
            this.infortecstockDataSet13.DataSetName = "infortecstockDataSet13";
            this.infortecstockDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // semestersTableAdapter
            // 
            this.semestersTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 486);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 486);
            this.panel2.TabIndex = 38;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmb_semester);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_bookName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_bookInsert);
            this.groupBox2.ForeColor = System.Drawing.Color.Silver;
            this.groupBox2.Location = new System.Drawing.Point(12, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 155);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insert a new book";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Semester";
            // 
            // cmb_semester
            // 
            this.cmb_semester.BackColor = System.Drawing.Color.White;
            this.cmb_semester.DataSource = this.semestersBindingSource;
            this.cmb_semester.DisplayMember = "name";
            this.cmb_semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_semester.FormattingEnabled = true;
            this.cmb_semester.Location = new System.Drawing.Point(76, 51);
            this.cmb_semester.Name = "cmb_semester";
            this.cmb_semester.Size = new System.Drawing.Size(167, 21);
            this.cmb_semester.TabIndex = 12;
            this.cmb_semester.ValueMember = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-22, -46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Insert Items";
            // 
            // txt_bookName
            // 
            this.txt_bookName.BackColor = System.Drawing.Color.White;
            this.txt_bookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_bookName.Location = new System.Drawing.Point(76, 24);
            this.txt_bookName.Name = "txt_bookName";
            this.txt_bookName.Size = new System.Drawing.Size(167, 13);
            this.txt_bookName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // btn_bookInsert
            // 
            this.btn_bookInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_bookInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_bookInsert.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bookInsert.ForeColor = System.Drawing.Color.Silver;
            this.btn_bookInsert.Location = new System.Drawing.Point(144, 78);
            this.btn_bookInsert.Name = "btn_bookInsert";
            this.btn_bookInsert.Size = new System.Drawing.Size(99, 36);
            this.btn_bookInsert.TabIndex = 6;
            this.btn_bookInsert.Text = "Insert";
            this.btn_bookInsert.UseVisualStyleBackColor = false;
            this.btn_bookInsert.Click += new System.EventHandler(this.btn_bookInsert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtb_itemDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Description);
            this.groupBox1.Controls.Add(this.txt_itemName);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.btn_insertItem);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 171);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert New Item";
            // 
            // rtb_itemDescription
            // 
            this.rtb_itemDescription.BackColor = System.Drawing.Color.White;
            this.rtb_itemDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_itemDescription.Location = new System.Drawing.Point(97, 74);
            this.rtb_itemDescription.Name = "rtb_itemDescription";
            this.rtb_itemDescription.Size = new System.Drawing.Size(146, 42);
            this.rtb_itemDescription.TabIndex = 7;
            this.rtb_itemDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-22, -46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Insert Items";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(18, 74);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(60, 13);
            this.Description.TabIndex = 10;
            this.Description.Text = "Description";
            // 
            // txt_itemName
            // 
            this.txt_itemName.BackColor = System.Drawing.Color.White;
            this.txt_itemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_itemName.Location = new System.Drawing.Point(97, 38);
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(146, 13);
            this.txt_itemName.TabIndex = 8;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(18, 41);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 7;
            this.Name.Text = "Name";
            // 
            // btn_insertItem
            // 
            this.btn_insertItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_insertItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_insertItem.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insertItem.ForeColor = System.Drawing.Color.Silver;
            this.btn_insertItem.Location = new System.Drawing.Point(144, 122);
            this.btn_insertItem.Name = "btn_insertItem";
            this.btn_insertItem.Size = new System.Drawing.Size(99, 32);
            this.btn_insertItem.TabIndex = 6;
            this.btn_insertItem.Text = "Insert";
            this.btn_insertItem.UseVisualStyleBackColor = false;
            this.btn_insertItem.Click += new System.EventHandler(this.btn_insertItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_location);
            this.groupBox3.Controls.Add(this.btn_insertLocation);
            this.groupBox3.ForeColor = System.Drawing.Color.Silver;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 120);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insert a Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-22, -46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Insert Items";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Name";
            // 
            // txt_location
            // 
            this.txt_location.BackColor = System.Drawing.Color.White;
            this.txt_location.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_location.Location = new System.Drawing.Point(59, 41);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(184, 13);
            this.txt_location.TabIndex = 38;
            // 
            // btn_insertLocation
            // 
            this.btn_insertLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_insertLocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_insertLocation.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insertLocation.ForeColor = System.Drawing.Color.Silver;
            this.btn_insertLocation.Location = new System.Drawing.Point(144, 60);
            this.btn_insertLocation.Name = "btn_insertLocation";
            this.btn_insertLocation.Size = new System.Drawing.Size(99, 35);
            this.btn_insertLocation.TabIndex = 6;
            this.btn_insertLocation.Text = "Insert";
            this.btn_insertLocation.UseVisualStyleBackColor = false;
            this.btn_insertLocation.Click += new System.EventHandler(this.btn_insertLocation_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel2.Controls.Add(this.lbl_heading);
            this.flowLayoutPanel2.Controls.Add(this.btn_viewLoaction);
            this.flowLayoutPanel2.Controls.Add(this.btn_viewItem);
            this.flowLayoutPanel2.Controls.Add(this.btn_viewBooks);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.ForeColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(329, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(132, 486);
            this.flowLayoutPanel2.TabIndex = 34;
            // 
            // btn_viewBooks
            // 
            this.btn_viewBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_viewBooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_viewBooks.BackgroundImage")));
            this.btn_viewBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_viewBooks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_viewBooks.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewBooks.Location = new System.Drawing.Point(3, 287);
            this.btn_viewBooks.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.btn_viewBooks.Name = "btn_viewBooks";
            this.btn_viewBooks.Size = new System.Drawing.Size(124, 100);
            this.btn_viewBooks.TabIndex = 37;
            this.btn_viewBooks.Text = "View Books";
            this.btn_viewBooks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_viewBooks.UseVisualStyleBackColor = false;
            this.btn_viewBooks.Click += new System.EventHandler(this.btn_viewBooks_Click);
            // 
            // btn_viewItem
            // 
            this.btn_viewItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_viewItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_viewItem.BackgroundImage")));
            this.btn_viewItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_viewItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_viewItem.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewItem.Location = new System.Drawing.Point(3, 148);
            this.btn_viewItem.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.btn_viewItem.Name = "btn_viewItem";
            this.btn_viewItem.Size = new System.Drawing.Size(124, 106);
            this.btn_viewItem.TabIndex = 36;
            this.btn_viewItem.Text = "View Items";
            this.btn_viewItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_viewItem.UseVisualStyleBackColor = false;
            this.btn_viewItem.Click += new System.EventHandler(this.btn_viewItem_Click);
            // 
            // btn_viewLoaction
            // 
            this.btn_viewLoaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_viewLoaction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_viewLoaction.BackgroundImage")));
            this.btn_viewLoaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_viewLoaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_viewLoaction.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewLoaction.Location = new System.Drawing.Point(3, 23);
            this.btn_viewLoaction.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.btn_viewLoaction.Name = "btn_viewLoaction";
            this.btn_viewLoaction.Size = new System.Drawing.Size(124, 92);
            this.btn_viewLoaction.TabIndex = 35;
            this.btn_viewLoaction.Text = "View Location";
            this.btn_viewLoaction.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_viewLoaction.UseVisualStyleBackColor = false;
            this.btn_viewLoaction.Click += new System.EventHandler(this.btn_viewLoaction_Click);
            // 
            // dgv_crud
            // 
            this.dgv_crud.AllowUserToAddRows = false;
            this.dgv_crud.AllowUserToDeleteRows = false;
            this.dgv_crud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_crud.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_crud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_crud.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv_crud.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgv_crud.Location = new System.Drawing.Point(461, 0);
            this.dgv_crud.Name = "dgv_crud";
            this.dgv_crud.Size = new System.Drawing.Size(460, 486);
            this.dgv_crud.TabIndex = 22;
            this.dgv_crud.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_crud_CellContentClick);
            this.dgv_crud.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_crud_DataError);
            // 
            // frm_mainInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(921, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_crud);
           // this.Name = "frm_mainInsert";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Initial Insert";
            this.Load += new System.EventHandler(this.frm_mainInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.semestersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infortecstockDataSet13)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_crud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_heading;
        private infortecstockDataSet13 infortecstockDataSet13;
        private System.Windows.Forms.BindingSource semestersBindingSource;
        private infortecstockDataSet13TableAdapters.semestersTableAdapter semestersTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btn_viewBooks;
        private System.Windows.Forms.Button btn_viewItem;
        private System.Windows.Forms.Button btn_viewLoaction;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_semester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_bookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_bookInsert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtb_itemDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox txt_itemName;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Button btn_insertItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.Button btn_insertLocation;
        private System.Windows.Forms.DataGridView dgv_crud;
    }
}