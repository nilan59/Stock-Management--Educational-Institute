namespace Infortec_Stock_Management
{
    partial class parent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(parent));
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.panel_slide = new System.Windows.Forms.Panel();
            this.picBoxMain = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_manupilate = new System.Windows.Forms.Button();
            this.btn_manage = new System.Windows.Forms.Button();
            this.btn_userReg = new System.Windows.Forms.Button();
            this.btn_studyPack = new System.Windows.Forms.Button();
            this.btn_excel = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_oneButton = new System.Windows.Forms.Panel();
            this.btn_slide = new System.Windows.Forms.Button();
            this.tt_logout = new System.Windows.Forms.ToolTip(this.components);
            this.panel_slide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_oneButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.Coral;
            this.lbl_welcome.Location = new System.Drawing.Point(14, 187);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(0, 20);
            this.lbl_welcome.TabIndex = 4;
            // 
            // panel_slide
            // 
            this.panel_slide.BackColor = System.Drawing.Color.Black;
            this.panel_slide.Controls.Add(this.picBoxMain);
            this.panel_slide.Controls.Add(this.pictureBox2);
            this.panel_slide.Controls.Add(this.btn_manupilate);
            this.panel_slide.Controls.Add(this.btn_manage);
            this.panel_slide.Controls.Add(this.btn_userReg);
            this.panel_slide.Controls.Add(this.btn_studyPack);
            this.panel_slide.Controls.Add(this.btn_excel);
            this.panel_slide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_slide.Location = new System.Drawing.Point(0, 0);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(240, 688);
            this.panel_slide.TabIndex = 23;
            // 
            // picBoxMain
            // 
            this.picBoxMain.BackColor = System.Drawing.Color.Transparent;
            this.picBoxMain.Image = global::Infortec_Stock_Management.Properties.Resources.inforteclogo;
            this.picBoxMain.Location = new System.Drawing.Point(10, 19);
            this.picBoxMain.Name = "picBoxMain";
            this.picBoxMain.Size = new System.Drawing.Size(227, 47);
            this.picBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMain.TabIndex = 27;
            this.picBoxMain.TabStop = false;
            this.picBoxMain.Click += new System.EventHandler(this.picBoxMain_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(84, 572);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            this.tt_logout.SetToolTip(this.pictureBox2, "Log out");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btn_manupilate
            // 
            this.btn_manupilate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_manupilate.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manupilate.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_manupilate.Image = ((System.Drawing.Image)(resources.GetObject("btn_manupilate.Image")));
            this.btn_manupilate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manupilate.Location = new System.Drawing.Point(7, 101);
            this.btn_manupilate.Name = "btn_manupilate";
            this.btn_manupilate.Size = new System.Drawing.Size(227, 59);
            this.btn_manupilate.TabIndex = 30;
            this.btn_manupilate.Text = "Update Items";
            this.btn_manupilate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt_logout.SetToolTip(this.btn_manupilate, "Add or Remove Items");
            this.btn_manupilate.UseVisualStyleBackColor = false;
            this.btn_manupilate.Click += new System.EventHandler(this.btn_manupilate_Click);
            // 
            // btn_manage
            // 
            this.btn_manage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_manage.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_manage.Image = ((System.Drawing.Image)(resources.GetObject("btn_manage.Image")));
            this.btn_manage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manage.Location = new System.Drawing.Point(6, 215);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(228, 59);
            this.btn_manage.TabIndex = 29;
            this.btn_manage.Text = "Settings";
            this.btn_manage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt_logout.SetToolTip(this.btn_manage, "New items, locations and study packs");
            this.btn_manage.UseVisualStyleBackColor = false;
            this.btn_manage.Click += new System.EventHandler(this.btn_manage_Click);
            // 
            // btn_userReg
            // 
            this.btn_userReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_userReg.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userReg.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_userReg.Image = ((System.Drawing.Image)(resources.GetObject("btn_userReg.Image")));
            this.btn_userReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_userReg.Location = new System.Drawing.Point(6, 273);
            this.btn_userReg.Name = "btn_userReg";
            this.btn_userReg.Size = new System.Drawing.Size(228, 59);
            this.btn_userReg.TabIndex = 32;
            this.btn_userReg.Text = " User Management";
            this.btn_userReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt_logout.SetToolTip(this.btn_userReg, "Add Remove Change passwords of users");
            this.btn_userReg.UseVisualStyleBackColor = false;
            this.btn_userReg.Visible = false;
            this.btn_userReg.Click += new System.EventHandler(this.btn_userReg_Click);
            // 
            // btn_studyPack
            // 
            this.btn_studyPack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_studyPack.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_studyPack.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_studyPack.Image = ((System.Drawing.Image)(resources.GetObject("btn_studyPack.Image")));
            this.btn_studyPack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_studyPack.Location = new System.Drawing.Point(7, 157);
            this.btn_studyPack.Name = "btn_studyPack";
            this.btn_studyPack.Size = new System.Drawing.Size(227, 59);
            this.btn_studyPack.TabIndex = 31;
            this.btn_studyPack.Text = " Update Study Packs";
            this.btn_studyPack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt_logout.SetToolTip(this.btn_studyPack, "Add or Remove all books or study packs");
            this.btn_studyPack.UseVisualStyleBackColor = false;
            this.btn_studyPack.Click += new System.EventHandler(this.btn_studyPack_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excel.ForeColor = System.Drawing.Color.Red;
            this.btn_excel.Image = ((System.Drawing.Image)(resources.GetObject("btn_excel.Image")));
            this.btn_excel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_excel.Location = new System.Drawing.Point(0, 0);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(240, 10);
            this.btn_excel.TabIndex = 17;
            this.btn_excel.Text = " Export to Excel";
            this.btn_excel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Visible = false;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Black;
            this.panel_main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_main.BackgroundImage")));
            this.panel_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(264, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(912, 688);
            this.panel_main.TabIndex = 24;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_oneButton
            // 
            this.panel_oneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_oneButton.Controls.Add(this.btn_slide);
            this.panel_oneButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_oneButton.Location = new System.Drawing.Point(240, 0);
            this.panel_oneButton.Name = "panel_oneButton";
            this.panel_oneButton.Size = new System.Drawing.Size(24, 688);
            this.panel_oneButton.TabIndex = 27;
            // 
            // btn_slide
            // 
            this.btn_slide.BackColor = System.Drawing.Color.Maroon;
            this.btn_slide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_slide.ForeColor = System.Drawing.Color.White;
            this.btn_slide.Image = ((System.Drawing.Image)(resources.GetObject("btn_slide.Image")));
            this.btn_slide.Location = new System.Drawing.Point(0, 254);
            this.btn_slide.Name = "btn_slide";
            this.btn_slide.Size = new System.Drawing.Size(24, 244);
            this.btn_slide.TabIndex = 27;
            this.tt_logout.SetToolTip(this.btn_slide, "Hide and Show Navigation Bar");
            this.btn_slide.UseVisualStyleBackColor = false;
            this.btn_slide.Click += new System.EventHandler(this.btn_slide_Click);
            // 
            // parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1176, 688);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_oneButton);
            this.Controls.Add(this.panel_slide);
            this.Controls.Add(this.lbl_welcome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "parent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Infortec International - Stock Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.parent_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.parent_FormClosed);
            this.Load += new System.EventHandler(this.parent_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.parent_KeyPress);
            this.panel_slide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_oneButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Panel panel_slide;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picBoxMain;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_manupilate;
        private System.Windows.Forms.Button btn_manage;
        private System.Windows.Forms.Button btn_userReg;
        private System.Windows.Forms.Button btn_studyPack;
        private System.Windows.Forms.Panel panel_oneButton;
        private System.Windows.Forms.Button btn_slide;
        private System.Windows.Forms.ToolTip tt_logout;
    }
}