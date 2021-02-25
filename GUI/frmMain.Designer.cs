namespace GUI
{
    partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.mnubarMain = new System.Windows.Forms.MenuStrip();
			this.mnuBanHang = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuQLTD = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuQLNV = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuLoaiMon = new System.Windows.Forms.ToolStripMenuItem();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblHoTen = new System.Windows.Forms.Label();
			this.lblThoiGianHienTai = new System.Windows.Forms.Label();
			this.tsHethong = new System.Windows.Forms.ToolStripDropDownButton();
			this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsTaikhoan = new System.Windows.Forms.ToolStripDropDownButton();
			this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMain = new System.Windows.Forms.ToolStrip();
			this.btnMiniSize = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.mnubarMain.SuspendLayout();
			this.toolStripMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnubarMain
			// 
			this.mnubarMain.AutoSize = false;
			this.mnubarMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.mnubarMain.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.mnubarMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.mnubarMain.ImageScalingSize = new System.Drawing.Size(25, 25);
			this.mnubarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBanHang,
            this.mnuHoaDon,
            this.mnuQuanLy});
			this.mnubarMain.Location = new System.Drawing.Point(0, 41);
			this.mnubarMain.Name = "mnubarMain";
			this.mnubarMain.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.mnubarMain.Size = new System.Drawing.Size(1712, 64);
			this.mnubarMain.TabIndex = 5;
			this.mnubarMain.Text = "mnubarMain";
			this.mnubarMain.Click += new System.EventHandler(this.mnubarMain_Click);
			// 
			// mnuBanHang
			// 
			this.mnuBanHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.mnuBanHang.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.mnuBanHang.Image = global::GUI.Properties.Resources._30_5121;
			this.mnuBanHang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mnuBanHang.Name = "mnuBanHang";
			this.mnuBanHang.Padding = new System.Windows.Forms.Padding(0);
			this.mnuBanHang.Size = new System.Drawing.Size(93, 64);
			this.mnuBanHang.Text = "BÁN HÀNG";
			this.mnuBanHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mnuBanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.mnuBanHang.Click += new System.EventHandler(this.mnuBanHang_Click);
			// 
			// mnuHoaDon
			// 
			this.mnuHoaDon.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.mnuHoaDon.Image = global::GUI.Properties.Resources.hoadon;
			this.mnuHoaDon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mnuHoaDon.Name = "mnuHoaDon";
			this.mnuHoaDon.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
			this.mnuHoaDon.Size = new System.Drawing.Size(94, 64);
			this.mnuHoaDon.Text = "HÓA ĐƠN";
			this.mnuHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mnuHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.mnuHoaDon.Click += new System.EventHandler(this.mnuHoaDon_Click);
			// 
			// mnuQuanLy
			// 
			this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLTD,
            this.mnuQLNV,
            this.mnuKhachHang,
            this.mnuLoaiMon});
			this.mnuQuanLy.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.mnuQuanLy.Image = global::GUI.Properties.Resources.quanly;
			this.mnuQuanLy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mnuQuanLy.Name = "mnuQuanLy";
			this.mnuQuanLy.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
			this.mnuQuanLy.Size = new System.Drawing.Size(87, 64);
			this.mnuQuanLy.Text = "QUẢN LÝ";
			this.mnuQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mnuQuanLy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// mnuQLTD
			// 
			this.mnuQLTD.Image = global::GUI.Properties.Resources.thuc_don;
			this.mnuQLTD.Name = "mnuQLTD";
			this.mnuQLTD.Size = new System.Drawing.Size(278, 34);
			this.mnuQLTD.Text = "THỰC ĐƠN";
			this.mnuQLTD.Click += new System.EventHandler(this.mnuQLTD_Click);
			// 
			// mnuQLNV
			// 
			this.mnuQLNV.Image = global::GUI.Properties.Resources.Profile;
			this.mnuQLNV.Name = "mnuQLNV";
			this.mnuQLNV.Size = new System.Drawing.Size(278, 34);
			this.mnuQLNV.Text = "NHÂN VIÊN";
			this.mnuQLNV.Click += new System.EventHandler(this.mnuQLNV_Click);
			// 
			// mnuKhachHang
			// 
			this.mnuKhachHang.Image = global::GUI.Properties.Resources.nhanvien;
			this.mnuKhachHang.Name = "mnuKhachHang";
			this.mnuKhachHang.Size = new System.Drawing.Size(278, 34);
			this.mnuKhachHang.Text = "QUẢN LÝ KHÁCH HÀNG";
			this.mnuKhachHang.Click += new System.EventHandler(this.qUẢNLÝKHÁCHHÀNGToolStripMenuItem_Click);
			// 
			// mnuLoaiMon
			// 
			this.mnuLoaiMon.Image = global::GUI.Properties.Resources.note;
			this.mnuLoaiMon.Name = "mnuLoaiMon";
			this.mnuLoaiMon.Size = new System.Drawing.Size(278, 34);
			this.mnuLoaiMon.Text = "LOẠI MÓN";
			this.mnuLoaiMon.Click += new System.EventHandler(this.lOẠIMÓNToolStripMenuItem_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lblHoTen
			// 
			this.lblHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblHoTen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHoTen.ForeColor = System.Drawing.Color.Green;
			this.lblHoTen.Location = new System.Drawing.Point(1450, 57);
			this.lblHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblHoTen.Name = "lblHoTen";
			this.lblHoTen.Size = new System.Drawing.Size(256, 35);
			this.lblHoTen.TabIndex = 9;
			this.lblHoTen.Text = "Bạn chưa đăng nhập";
			this.lblHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblHoTen.MouseLeave += new System.EventHandler(this.lblHoTen_MouseLeave);
			this.lblHoTen.MouseHover += new System.EventHandler(this.lblHoTen_MouseHover);
			// 
			// lblThoiGianHienTai
			// 
			this.lblThoiGianHienTai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblThoiGianHienTai.AutoSize = true;
			this.lblThoiGianHienTai.BackColor = System.Drawing.Color.Tan;
			this.lblThoiGianHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblThoiGianHienTai.Location = new System.Drawing.Point(1287, 12);
			this.lblThoiGianHienTai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblThoiGianHienTai.Name = "lblThoiGianHienTai";
			this.lblThoiGianHienTai.Size = new System.Drawing.Size(70, 25);
			this.lblThoiGianHienTai.TabIndex = 13;
			this.lblThoiGianHienTai.Text = "label1";
			this.lblThoiGianHienTai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tsHethong
			// 
			this.tsHethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
			this.tsHethong.Image = global::GUI.Properties.Resources.hethong;
			this.tsHethong.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsHethong.Name = "tsHethong";
			this.tsHethong.Size = new System.Drawing.Size(154, 36);
			this.tsHethong.Text = "Hệ thống";
			// 
			// đăngXuấtToolStripMenuItem
			// 
			this.đăngXuấtToolStripMenuItem.Image = global::GUI.Properties.Resources.Exit;
			this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
			this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
			this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
			this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
			// 
			// tsTaikhoan
			// 
			this.tsTaikhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem});
			this.tsTaikhoan.Image = global::GUI.Properties.Resources.taikhoan;
			this.tsTaikhoan.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsTaikhoan.Name = "tsTaikhoan";
			this.tsTaikhoan.Size = new System.Drawing.Size(156, 36);
			this.tsTaikhoan.Text = "Tài Khoản";
			// 
			// đổiMậtKhẩuToolStripMenuItem
			// 
			this.đổiMậtKhẩuToolStripMenuItem.Image = global::GUI.Properties.Resources.icon_changepass;
			this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
			this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(267, 40);
			this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
			this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
			// 
			// toolStripMain
			// 
			this.toolStripMain.BackColor = System.Drawing.Color.Tan;
			this.toolStripMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHethong,
            this.tsTaikhoan});
			this.toolStripMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.toolStripMain.Location = new System.Drawing.Point(0, 0);
			this.toolStripMain.Name = "toolStripMain";
			this.toolStripMain.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.toolStripMain.Size = new System.Drawing.Size(1712, 41);
			this.toolStripMain.TabIndex = 2;
			this.toolStripMain.Text = "z";
			this.toolStripMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripMain_ItemClicked_1);
			// 
			// btnMiniSize
			// 
			this.btnMiniSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMiniSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(181)))), ((int)(((byte)(153)))));
			this.btnMiniSize.BackgroundImage = global::GUI.Properties.Resources.mini;
			this.btnMiniSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnMiniSize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMiniSize.FlatAppearance.BorderSize = 0;
			this.btnMiniSize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnMiniSize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnMiniSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMiniSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMiniSize.Location = new System.Drawing.Point(1606, 5);
			this.btnMiniSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnMiniSize.Name = "btnMiniSize";
			this.btnMiniSize.Size = new System.Drawing.Size(44, 34);
			this.btnMiniSize.TabIndex = 15;
			this.btnMiniSize.UseVisualStyleBackColor = false;
			this.btnMiniSize.Click += new System.EventHandler(this.btnMiniSize_Click);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(181)))), ((int)(((byte)(153)))));
			this.btnExit.BackgroundImage = global::GUI.Properties.Resources.close1;
			this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(1659, 5);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(44, 34);
			this.btnExit.TabIndex = 16;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// toolTip2
			// 
			this.toolTip2.OwnerDraw = true;
			this.toolTip2.ShowAlways = true;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Green;
			this.label1.Location = new System.Drawing.Point(1292, 57);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 35);
			this.label1.TabIndex = 18;
			this.label1.Text = "Xin chào: ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::GUI.Properties.Resources.toMatiTouKafeSchetsLogocyclonLogoWithBackground;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1712, 992);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnMiniSize);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.lblThoiGianHienTai);
			this.Controls.Add(this.lblHoTen);
			this.Controls.Add(this.mnubarMain);
			this.Controls.Add(this.toolStripMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmMain";
			this.Text = "Phần mềm quản lý quán Cafe YoChe";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.mnubarMain.ResumeLayout(false);
			this.mnubarMain.PerformLayout();
			this.toolStripMain.ResumeLayout(false);
			this.toolStripMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnubarMain;
        private System.Windows.Forms.ToolStripMenuItem mnuBanHang;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuQLTD;
        private System.Windows.Forms.ToolStripMenuItem mnuQLNV;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblThoiGianHienTai;
        private System.Windows.Forms.ToolStripDropDownButton tsHethong;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsTaikhoan;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.Button btnMiniSize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiMon;
    }
}

