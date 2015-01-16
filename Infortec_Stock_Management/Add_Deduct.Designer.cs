namespace Infortec_Stock_Management
{
    partial class frm_addDeduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_currentA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_amountA = new System.Windows.Forms.NumericUpDown();
            this.rtb_descriptionA = new System.Windows.Forms.RichTextBox();
            this.btn_deductItem = new System.Windows.Forms.Button();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_amountA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_location);
            this.groupBox1.Controls.Add(this.txt_item);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_currentA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nud_amountA);
            this.groupBox1.Controls.Add(this.rtb_descriptionA);
            this.groupBox1.Controls.Add(this.btn_deductItem);
            this.groupBox1.Controls.Add(this.btn_addItem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Item";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Location";
            // 
            // lbl_currentA
            // 
            this.lbl_currentA.AutoSize = true;
            this.lbl_currentA.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_currentA.Location = new System.Drawing.Point(299, 44);
            this.lbl_currentA.Name = "lbl_currentA";
            this.lbl_currentA.Size = new System.Drawing.Size(0, 13);
            this.lbl_currentA.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount";
            // 
            // nud_amountA
            // 
            this.nud_amountA.Location = new System.Drawing.Point(145, 112);
            this.nud_amountA.Name = "nud_amountA";
            this.nud_amountA.Size = new System.Drawing.Size(142, 20);
            this.nud_amountA.TabIndex = 5;
            // 
            // rtb_descriptionA
            // 
            this.rtb_descriptionA.Location = new System.Drawing.Point(145, 147);
            this.rtb_descriptionA.Name = "rtb_descriptionA";
            this.rtb_descriptionA.Size = new System.Drawing.Size(142, 96);
            this.rtb_descriptionA.TabIndex = 4;
            this.rtb_descriptionA.Text = "";
            // 
            // btn_deductItem
            // 
            this.btn_deductItem.Location = new System.Drawing.Point(156, 256);
            this.btn_deductItem.Name = "btn_deductItem";
            this.btn_deductItem.Size = new System.Drawing.Size(75, 23);
            this.btn_deductItem.TabIndex = 2;
            this.btn_deductItem.Text = "Deduct Item";
            this.btn_deductItem.UseVisualStyleBackColor = true;
            this.btn_deductItem.Click += new System.EventHandler(this.btn_deductItem_Click);
            // 
            // btn_addItem
            // 
            this.btn_addItem.Location = new System.Drawing.Point(247, 256);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(75, 23);
            this.btn_addItem.TabIndex = 2;
            this.btn_addItem.Text = "Add Item";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(145, 30);
            this.txt_item.Name = "txt_item";
            this.txt_item.ReadOnly = true;
            this.txt_item.Size = new System.Drawing.Size(142, 20);
            this.txt_item.TabIndex = 10;
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(145, 75);
            this.txt_location.Name = "txt_location";
            this.txt_location.ReadOnly = true;
            this.txt_location.Size = new System.Drawing.Size(142, 20);
            this.txt_location.TabIndex = 11;
            // 
            // frm_addDeduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 344);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_addDeduct";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add and Deduct Items";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_addDeduct_FormClosed);
            this.Load += new System.EventHandler(this.frm_addDeduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_amountA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtb_descriptionA;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_amountA;
        private System.Windows.Forms.Button btn_deductItem;
        private System.Windows.Forms.Label lbl_currentA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.TextBox txt_item;
    }
}