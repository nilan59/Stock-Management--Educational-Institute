namespace Infortec_Stock_Management
{
    partial class frm_firstScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_firstScreen));
            this.btn_excel = new System.Windows.Forms.Button();
            this.btn_manupilate = new System.Windows.Forms.Button();
            this.btn_manage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_excel
            // 
            this.btn_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excel.ForeColor = System.Drawing.Color.Red;
            this.btn_excel.Image = ((System.Drawing.Image)(resources.GetObject("btn_excel.Image")));
            this.btn_excel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_excel.Location = new System.Drawing.Point(332, 47);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(116, 99);
            this.btn_excel.TabIndex = 14;
            this.btn_excel.Text = " ";
            this.btn_excel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // btn_manupilate
            // 
            this.btn_manupilate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manupilate.ForeColor = System.Drawing.Color.Red;
            this.btn_manupilate.Image = ((System.Drawing.Image)(resources.GetObject("btn_manupilate.Image")));
            this.btn_manupilate.Location = new System.Drawing.Point(182, 47);
            this.btn_manupilate.Name = "btn_manupilate";
            this.btn_manupilate.Size = new System.Drawing.Size(116, 99);
            this.btn_manupilate.TabIndex = 1;
            this.btn_manupilate.Text = "Items";
            this.btn_manupilate.UseVisualStyleBackColor = true;
            this.btn_manupilate.Click += new System.EventHandler(this.btn_manupilate_Click);
            // 
            // btn_manage
            // 
            this.btn_manage.Image = global::Infortec_Stock_Management.Properties.Resources.Folder_Add_icon;
            this.btn_manage.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_manage.Location = new System.Drawing.Point(32, 47);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(116, 99);
            this.btn_manage.TabIndex = 0;
            this.btn_manage.Text = "Enter New Items Users and Locations";
            this.btn_manage.UseVisualStyleBackColor = true;
            this.btn_manage.Click += new System.EventHandler(this.btn_manage_Click);
            // 
            // frm_firstScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 180);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.btn_manupilate);
            this.Controls.Add(this.btn_manage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_firstScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FirstScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_manage;
        private System.Windows.Forms.Button btn_manupilate;
        private System.Windows.Forms.Button btn_excel;
    }
}