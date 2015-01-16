namespace Infortec_Stock_Management
{
    partial class frm_log
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exportPdf = new System.Windows.Forms.Button();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.btn_all = new System.Windows.Forms.Button();
            this.btn_deduct = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_logs = new System.Windows.Forms.DataGridView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_logs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn_exportPdf);
            this.panel1.Controls.Add(this.dtp_date);
            this.panel1.Controls.Add(this.btn_all);
            this.panel1.Controls.Add(this.btn_deduct);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 52);
            this.panel1.TabIndex = 0;
            // 
            // btn_exportPdf
            // 
            this.btn_exportPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_exportPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exportPdf.ForeColor = System.Drawing.Color.Silver;
            this.btn_exportPdf.Location = new System.Drawing.Point(530, 5);
            this.btn_exportPdf.Name = "btn_exportPdf";
            this.btn_exportPdf.Size = new System.Drawing.Size(85, 37);
            this.btn_exportPdf.TabIndex = 4;
            this.btn_exportPdf.Text = "Export";
            this.btn_exportPdf.UseVisualStyleBackColor = false;
            this.btn_exportPdf.Click += new System.EventHandler(this.btn_exportPdf_Click);
            // 
            // dtp_date
            // 
            this.dtp_date.Checked = false;
            this.dtp_date.Location = new System.Drawing.Point(311, 12);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 20);
            this.dtp_date.TabIndex = 3;
            this.dtp_date.ValueChanged += new System.EventHandler(this.dtp_date_ValueChanged);
            // 
            // btn_all
            // 
            this.btn_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_all.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_all.ForeColor = System.Drawing.Color.Silver;
            this.btn_all.Location = new System.Drawing.Point(187, 12);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(75, 23);
            this.btn_all.TabIndex = 2;
            this.btn_all.Text = "All Logs";
            this.btn_all.UseVisualStyleBackColor = false;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // btn_deduct
            // 
            this.btn_deduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_deduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_deduct.ForeColor = System.Drawing.Color.Silver;
            this.btn_deduct.Location = new System.Drawing.Point(93, 12);
            this.btn_deduct.Name = "btn_deduct";
            this.btn_deduct.Size = new System.Drawing.Size(75, 23);
            this.btn_deduct.TabIndex = 1;
            this.btn_deduct.Text = "Deduction";
            this.btn_deduct.UseVisualStyleBackColor = false;
            this.btn_deduct.Click += new System.EventHandler(this.btn_deduct_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.ForeColor = System.Drawing.Color.Silver;
            this.btn_add.Location = new System.Drawing.Point(3, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Addition";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_logs);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 269);
            this.panel2.TabIndex = 1;
            // 
            // dgv_logs
            // 
            this.dgv_logs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_logs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_logs.Location = new System.Drawing.Point(0, 0);
            this.dgv_logs.Name = "dgv_logs";
            this.dgv_logs.Size = new System.Drawing.Size(618, 269);
            this.dgv_logs.TabIndex = 0;
            this.dgv_logs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frm_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 321);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_log";
            this.Text = "Log Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.log_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_logs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Button btn_deduct;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_logs;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Button btn_exportPdf;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}