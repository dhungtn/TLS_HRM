﻿namespace QLNhanSu
{
    partial class fThemloaicong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemloaicong));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaloaicong = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHesoluong = new DevExpress.XtraEditors.TextEdit();
            this.txtTenloaicong = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.image_no_hesoluong = new System.Windows.Forms.PictureBox();
            this.image_yes_hesoluong = new System.Windows.Forms.PictureBox();
            this.image_no_tenloaicong = new System.Windows.Forms.PictureBox();
            this.image_yes_tenloaicong = new System.Windows.Forms.PictureBox();
            this.image_no_maloaicong = new System.Windows.Forms.PictureBox();
            this.image_yes_maloaicong = new System.Windows.Forms.PictureBox();
            this.btThem = new DevExpress.XtraEditors.DropDownButton();
            this.btDong = new DevExpress.XtraEditors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaloaicong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenloaicong.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_no_hesoluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_yes_hesoluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_no_tenloaicong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_yes_tenloaicong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_no_maloaicong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_yes_maloaicong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại công:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMaloaicong
            // 
            this.txtMaloaicong.Location = new System.Drawing.Point(111, 21);
            this.txtMaloaicong.Name = "txtMaloaicong";
            this.txtMaloaicong.Size = new System.Drawing.Size(100, 20);
            this.txtMaloaicong.TabIndex = 1;
            this.txtMaloaicong.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaloaicong_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "hệ số tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên loại công:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(47, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "THÊM LOẠI CÔNG";
            // 
            // txtHesoluong
            // 
            this.txtHesoluong.Location = new System.Drawing.Point(111, 95);
            this.txtHesoluong.Name = "txtHesoluong";
            this.txtHesoluong.Size = new System.Drawing.Size(100, 20);
            this.txtHesoluong.TabIndex = 3;
            this.txtHesoluong.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHesoluong_KeyUp);
            // 
            // txtTenloaicong
            // 
            this.txtTenloaicong.Location = new System.Drawing.Point(111, 58);
            this.txtTenloaicong.Name = "txtTenloaicong";
            this.txtTenloaicong.Size = new System.Drawing.Size(100, 20);
            this.txtTenloaicong.TabIndex = 2;
            this.txtTenloaicong.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTenloaicong_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.image_no_hesoluong);
            this.groupBox1.Controls.Add(this.image_yes_hesoluong);
            this.groupBox1.Controls.Add(this.image_no_tenloaicong);
            this.groupBox1.Controls.Add(this.image_yes_tenloaicong);
            this.groupBox1.Controls.Add(this.image_no_maloaicong);
            this.groupBox1.Controls.Add(this.image_yes_maloaicong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenloaicong);
            this.groupBox1.Controls.Add(this.txtMaloaicong);
            this.groupBox1.Controls.Add(this.txtHesoluong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(25, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 136);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // image_no_hesoluong
            // 
            this.image_no_hesoluong.Image = ((System.Drawing.Image)(resources.GetObject("image_no_hesoluong.Image")));
            this.image_no_hesoluong.Location = new System.Drawing.Point(215, 96);
            this.image_no_hesoluong.Name = "image_no_hesoluong";
            this.image_no_hesoluong.Size = new System.Drawing.Size(19, 18);
            this.image_no_hesoluong.TabIndex = 130;
            this.image_no_hesoluong.TabStop = false;
            // 
            // image_yes_hesoluong
            // 
            this.image_yes_hesoluong.Image = ((System.Drawing.Image)(resources.GetObject("image_yes_hesoluong.Image")));
            this.image_yes_hesoluong.Location = new System.Drawing.Point(215, 96);
            this.image_yes_hesoluong.Name = "image_yes_hesoluong";
            this.image_yes_hesoluong.Size = new System.Drawing.Size(19, 18);
            this.image_yes_hesoluong.TabIndex = 129;
            this.image_yes_hesoluong.TabStop = false;
            // 
            // image_no_tenloaicong
            // 
            this.image_no_tenloaicong.Image = ((System.Drawing.Image)(resources.GetObject("image_no_tenloaicong.Image")));
            this.image_no_tenloaicong.Location = new System.Drawing.Point(215, 59);
            this.image_no_tenloaicong.Name = "image_no_tenloaicong";
            this.image_no_tenloaicong.Size = new System.Drawing.Size(19, 18);
            this.image_no_tenloaicong.TabIndex = 128;
            this.image_no_tenloaicong.TabStop = false;
            // 
            // image_yes_tenloaicong
            // 
            this.image_yes_tenloaicong.Image = ((System.Drawing.Image)(resources.GetObject("image_yes_tenloaicong.Image")));
            this.image_yes_tenloaicong.Location = new System.Drawing.Point(215, 59);
            this.image_yes_tenloaicong.Name = "image_yes_tenloaicong";
            this.image_yes_tenloaicong.Size = new System.Drawing.Size(19, 18);
            this.image_yes_tenloaicong.TabIndex = 127;
            this.image_yes_tenloaicong.TabStop = false;
            // 
            // image_no_maloaicong
            // 
            this.image_no_maloaicong.Image = ((System.Drawing.Image)(resources.GetObject("image_no_maloaicong.Image")));
            this.image_no_maloaicong.Location = new System.Drawing.Point(215, 22);
            this.image_no_maloaicong.Name = "image_no_maloaicong";
            this.image_no_maloaicong.Size = new System.Drawing.Size(19, 18);
            this.image_no_maloaicong.TabIndex = 126;
            this.image_no_maloaicong.TabStop = false;
            // 
            // image_yes_maloaicong
            // 
            this.image_yes_maloaicong.Image = ((System.Drawing.Image)(resources.GetObject("image_yes_maloaicong.Image")));
            this.image_yes_maloaicong.Location = new System.Drawing.Point(215, 22);
            this.image_yes_maloaicong.Name = "image_yes_maloaicong";
            this.image_yes_maloaicong.Size = new System.Drawing.Size(19, 18);
            this.image_yes_maloaicong.TabIndex = 125;
            this.image_yes_maloaicong.TabStop = false;
            // 
            // btThem
            // 
            this.btThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btThem.ImageOptions.Image")));
            this.btThem.Location = new System.Drawing.Point(25, 179);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(112, 23);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btDong
            // 
            this.btDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btDong.ImageOptions.Image")));
            this.btDong.Location = new System.Drawing.Point(153, 179);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(112, 23);
            this.btDong.TabIndex = 5;
            this.btDong.Text = "Đóng";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // frmThemloaicong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 225);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmThemloaicong.IconOptions.Icon")));
            this.IconOptions.Image = global::QLNhanSu.Properties.Resources.Designbolts_Ios8_Cirtangle_Concept_Game_Center_128;
            this.MaximizeBox = false;
            this.Name = "frmThemloaicong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm loại công";
            this.Load += new System.EventHandler(this.fThemloaicong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaloaicong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenloaicong.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_no_hesoluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_yes_hesoluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_no_tenloaicong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_yes_tenloaicong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_no_maloaicong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_yes_maloaicong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtMaloaicong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtHesoluong;
        private DevExpress.XtraEditors.TextEdit txtTenloaicong;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.DropDownButton btThem;
        private DevExpress.XtraEditors.DropDownButton btDong;
        private System.Windows.Forms.PictureBox image_yes_maloaicong;
        private System.Windows.Forms.PictureBox image_no_maloaicong;
        private System.Windows.Forms.PictureBox image_no_hesoluong;
        private System.Windows.Forms.PictureBox image_yes_hesoluong;
        private System.Windows.Forms.PictureBox image_no_tenloaicong;
        private System.Windows.Forms.PictureBox image_yes_tenloaicong;
    }
}