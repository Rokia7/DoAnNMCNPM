namespace GUI
{
    partial class frmDangNhap
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.cboNhanVien = new System.Windows.Forms.ComboBox();
			this.pnlTitle = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnMiniSize = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.chkHienMK = new System.Windows.Forms.CheckBox();
			this.picGif = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDangNhap = new System.Windows.Forms.Button();
			this.pnlTitle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picGif)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(260, 173);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên Đăng Nhập :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(297, 214);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mật Khẩu :";
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMatKhau.Location = new System.Drawing.Point(400, 210);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.Size = new System.Drawing.Size(220, 26);
			this.txtMatKhau.TabIndex = 4;
			this.txtMatKhau.UseSystemPasswordChar = true;
			this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
			// 
			// cboNhanVien
			// 
			this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboNhanVien.FormattingEnabled = true;
			this.cboNhanVien.Location = new System.Drawing.Point(400, 169);
			this.cboNhanVien.Name = "cboNhanVien";
			this.cboNhanVien.Size = new System.Drawing.Size(220, 28);
			this.cboNhanVien.TabIndex = 6;
			// 
			// pnlTitle
			// 
			this.pnlTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.pnlTitle.AllowDrop = true;
			this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pnlTitle.Controls.Add(this.lblTitle);
			this.pnlTitle.Controls.Add(this.btnMiniSize);
			this.pnlTitle.Controls.Add(this.btnExit);
			this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTitle.Location = new System.Drawing.Point(0, 0);
			this.pnlTitle.Name = "pnlTitle";
			this.pnlTitle.Size = new System.Drawing.Size(680, 34);
			this.pnlTitle.TabIndex = 9;
			this.pnlTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitle_Paint);
			// 
			// lblTitle
			// 
			this.lblTitle.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTitle.Location = new System.Drawing.Point(3, -1);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(288, 33);
			this.lblTitle.TabIndex = 2;
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTitle.Visible = false;
			// 
			// btnMiniSize
			// 
			this.btnMiniSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMiniSize.BackColor = System.Drawing.Color.Transparent;
			this.btnMiniSize.BackgroundImage = global::GUI.Properties.Resources.mini;
			this.btnMiniSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnMiniSize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMiniSize.FlatAppearance.BorderSize = 0;
			this.btnMiniSize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnMiniSize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnMiniSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMiniSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMiniSize.Location = new System.Drawing.Point(612, 1);
			this.btnMiniSize.Name = "btnMiniSize";
			this.btnMiniSize.Size = new System.Drawing.Size(32, 32);
			this.btnMiniSize.TabIndex = 0;
			this.btnMiniSize.UseVisualStyleBackColor = false;
			this.btnMiniSize.Click += new System.EventHandler(this.btnMiniSize_Click);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.BackColor = System.Drawing.Color.Transparent;
			this.btnExit.BackgroundImage = global::GUI.Properties.Resources.close1;
			this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(647, 1);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(32, 32);
			this.btnExit.TabIndex = 0;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// chkHienMK
			// 
			this.chkHienMK.AutoSize = true;
			this.chkHienMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.chkHienMK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.chkHienMK.Location = new System.Drawing.Point(400, 247);
			this.chkHienMK.Name = "chkHienMK";
			this.chkHienMK.Size = new System.Drawing.Size(118, 21);
			this.chkHienMK.TabIndex = 11;
			this.chkHienMK.Text = "Hiện mật khẩu";
			this.chkHienMK.UseVisualStyleBackColor = true;
			this.chkHienMK.CheckedChanged += new System.EventHandler(this.chkHienMK_CheckedChanged);
			// 
			// picGif
			// 
			this.picGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picGif.Image = global::GUI.Properties.Resources.cafe1;
			this.picGif.Location = new System.Drawing.Point(74, 173);
			this.picGif.Name = "picGif";
			this.picGif.Size = new System.Drawing.Size(146, 152);
			this.picGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picGif.TabIndex = 12;
			this.picGif.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = global::GUI.Properties.Resources.backgroud;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 35);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(680, 124);
			this.panel1.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(124, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(544, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "PHẦN MỀM QUẢN LÝ QUÁN CÀ PHÊ YOCHE";
			// 
			// btnDangNhap
			// 
			this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangNhap.Image = global::GUI.Properties.Resources.dangnhap;
			this.btnDangNhap.Location = new System.Drawing.Point(400, 281);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(220, 46);
			this.btnDangNhap.TabIndex = 5;
			this.btnDangNhap.Text = "Đăng Nhập";
			this.btnDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnDangNhap.UseVisualStyleBackColor = true;
			this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
			// 
			// frmDangNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(680, 374);
			this.Controls.Add(this.picGif);
			this.Controls.Add(this.chkHienMK);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnlTitle);
			this.Controls.Add(this.cboNhanVien);
			this.Controls.Add(this.btnDangNhap);
			this.Controls.Add(this.txtMatKhau);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmDangNhap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng Nhập";
			this.Load += new System.EventHandler(this.frmDangNhap_Load);
			this.pnlTitle.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picGif)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMiniSize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkHienMK;
        private System.Windows.Forms.PictureBox picGif;
    }
}