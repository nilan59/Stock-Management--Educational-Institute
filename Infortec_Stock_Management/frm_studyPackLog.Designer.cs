namespace Infortec_Stock_Management
{
    partial class frm_studyPackLog
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packIssueLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.btn_export = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_studyPackLog = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studyPackLog)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(469, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalLogToolStripMenuItem,
            this.packIssueLogToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // normalLogToolStripMenuItem
            // 
            this.normalLogToolStripMenuItem.Name = "normalLogToolStripMenuItem";
            this.normalLogToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.normalLogToolStripMenuItem.Text = "Normal Log";
            this.normalLogToolStripMenuItem.Click += new System.EventHandler(this.normalLogToolStripMenuItem_Click);
            // 
            // packIssueLogToolStripMenuItem
            // 
            this.packIssueLogToolStripMenuItem.Name = "packIssueLogToolStripMenuItem";
            this.packIssueLogToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.packIssueLogToolStripMenuItem.Text = "Pack Issue Log";
            this.packIssueLogToolStripMenuItem.Click += new System.EventHandler(this.packIssueLogToolStripMenuItem_Click);
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(163, 10);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 20);
            this.dtp_date.TabIndex = 2;
            this.dtp_date.ValueChanged += new System.EventHandler(this.dtp_date_ValueChanged);
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_export.ForeColor = System.Drawing.Color.Silver;
            this.btn_export.Location = new System.Drawing.Point(369, 10);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 23);
            this.btn_export.TabIndex = 3;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp_date);
            this.panel1.Controls.Add(this.btn_export);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 36);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_studyPackLog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 302);
            this.panel2.TabIndex = 5;
            // 
            // dgv_studyPackLog
            // 
            this.dgv_studyPackLog.AllowUserToAddRows = false;
            this.dgv_studyPackLog.AllowUserToDeleteRows = false;
            this.dgv_studyPackLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_studyPackLog.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_studyPackLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_studyPackLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_studyPackLog.Location = new System.Drawing.Point(0, 0);
            this.dgv_studyPackLog.Name = "dgv_studyPackLog";
            this.dgv_studyPackLog.ReadOnly = true;
            this.dgv_studyPackLog.Size = new System.Drawing.Size(469, 302);
            this.dgv_studyPackLog.TabIndex = 2;
            this.dgv_studyPackLog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_studyPackLog_CellContentClick);
            // 
            // frm_studyPackLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 362);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_studyPackLog";
            this.Text = "Study Pack Log";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studyPackLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packIssueLogToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_studyPackLog;
    }
}