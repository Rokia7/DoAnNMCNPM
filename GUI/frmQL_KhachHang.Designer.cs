namespace GUI
{
    partial class frmQL_KhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmDoi = new System.Windows.Forms.ToolStripMenuItem();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.chkTen = new System.Windows.Forms.CheckBox();
            this.chkGioiTinh = new System.Windows.Forms.CheckBox();
            this.cboGioiTinhTK = new System.Windows.Forms.ComboBox();
            this.txtTenvaMa = new System.Windows.Forms.TextBox();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtbNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.pboAnhNV = new System.Windows.Forms.PictureBox();
            this.rdoNghi = new System.Windows.Forms.RadioButton();
            this.rdoCon = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.grpDSTD = new System.Windows.Forms.GroupBox();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResetPW = new System.Windows.Forms.Button();
            this.btnDoiTrangThai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboAnhNV)).BeginInit();
            this.grpDSTD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmDoi});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 26);
            // 
            // ctmDoi
            // 
            this.ctmDoi.Name = "ctmDoi";
            this.ctmDoi.Size = new System.Drawing.Size(149, 22);
            this.ctmDoi.Text = "Đổi Trạng Thái";
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.btnLammoi);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Controls.Add(this.chkTen);
            this.grpTimKiem.Controls.Add(this.chkGioiTinh);
            this.grpTimKiem.Controls.Add(this.cboGioiTinhTK);
            this.grpTimKiem.Controls.Add(this.txtTenvaMa);
            this.grpTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.grpTimKiem.ForeColor = System.Drawing.Color.Blue;
            this.grpTimKiem.Location = new System.Drawing.Point(55, 12);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(491, 270);
            this.grpTimKiem.TabIndex = 26;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm Kiếm";
            // 
            // btnLammoi
            // 
            this.btnLammoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLammoi.BackColor = System.Drawing.Color.Transparent;
            this.btnLammoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLammoi.FlatAppearance.BorderSize = 0;
            this.btnLammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLammoi.ForeColor = System.Drawing.Color.Blue;
            this.btnLammoi.Image = global::GUI.Properties.Resources.refresh_page;
            this.btnLammoi.Location = new System.Drawing.Point(336, 160);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(144, 58);
            this.btnLammoi.TabIndex = 25;
            this.btnLammoi.Text = "LÀM MỚI";
            this.btnLammoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLammoi.UseVisualStyleBackColor = false;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.Blue;
            this.btnTimKiem.Image = global::GUI.Properties.Resources.Search1;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.Location = new System.Drawing.Point(186, 160);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(144, 58);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.Text = "TÌM KIẾM ";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // chkTen
            // 
            this.chkTen.AutoSize = true;
            this.chkTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.chkTen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkTen.Location = new System.Drawing.Point(23, 39);
            this.chkTen.Name = "chkTen";
            this.chkTen.Size = new System.Drawing.Size(135, 24);
            this.chkTen.TabIndex = 23;
            this.chkTen.Text = "Tìm mã / Tên ";
            this.chkTen.UseVisualStyleBackColor = true;
            this.chkTen.CheckedChanged += new System.EventHandler(this.chkTen_CheckedChanged);
            // 
            // chkGioiTinh
            // 
            this.chkGioiTinh.AutoSize = true;
            this.chkGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.chkGioiTinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkGioiTinh.Location = new System.Drawing.Point(23, 98);
            this.chkGioiTinh.Name = "chkGioiTinh";
            this.chkGioiTinh.Size = new System.Drawing.Size(165, 24);
            this.chkGioiTinh.TabIndex = 17;
            this.chkGioiTinh.Text = "Tìm theo giới tính";
            this.chkGioiTinh.UseVisualStyleBackColor = true;
            this.chkGioiTinh.CheckedChanged += new System.EventHandler(this.chkGioiTinh_CheckedChanged);
            // 
            // cboGioiTinhTK
            // 
            this.cboGioiTinhTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinhTK.Enabled = false;
            this.cboGioiTinhTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cboGioiTinhTK.ForeColor = System.Drawing.Color.Black;
            this.cboGioiTinhTK.FormattingEnabled = true;
            this.cboGioiTinhTK.Location = new System.Drawing.Point(194, 96);
            this.cboGioiTinhTK.Name = "cboGioiTinhTK";
            this.cboGioiTinhTK.Size = new System.Drawing.Size(286, 28);
            this.cboGioiTinhTK.TabIndex = 15;
            // 
            // txtTenvaMa
            // 
            this.txtTenvaMa.Enabled = false;
            this.txtTenvaMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtTenvaMa.ForeColor = System.Drawing.Color.Black;
            this.txtTenvaMa.Location = new System.Drawing.Point(194, 37);
            this.txtTenvaMa.Name = "txtTenvaMa";
            this.txtTenvaMa.Size = new System.Drawing.Size(286, 26);
            this.txtTenvaMa.TabIndex = 9;
            // 
            // grpThongTin
            // 
            this.grpThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTin.Controls.Add(this.txtSDT);
            this.grpThongTin.Controls.Add(this.label8);
            this.grpThongTin.Controls.Add(this.txtDiaChi);
            this.grpThongTin.Controls.Add(this.label7);
            this.grpThongTin.Controls.Add(this.cboGioiTinh);
            this.grpThongTin.Controls.Add(this.dtbNgaySinh);
            this.grpThongTin.Controls.Add(this.pboAnhNV);
            this.grpThongTin.Controls.Add(this.rdoNghi);
            this.grpThongTin.Controls.Add(this.rdoCon);
            this.grpThongTin.Controls.Add(this.label6);
            this.grpThongTin.Controls.Add(this.btnHuy);
            this.grpThongTin.Controls.Add(this.cboChucVu);
            this.grpThongTin.Controls.Add(this.btnLuu);
            this.grpThongTin.Controls.Add(this.label5);
            this.grpThongTin.Controls.Add(this.label4);
            this.grpThongTin.Controls.Add(this.txtTenNV);
            this.grpThongTin.Controls.Add(this.label3);
            this.grpThongTin.Controls.Add(this.label1);
            this.grpThongTin.Controls.Add(this.label2);
            this.grpThongTin.Controls.Add(this.lblMaNV);
            this.grpThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.Blue;
            this.grpThongTin.Location = new System.Drawing.Point(552, 12);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(739, 270);
            this.grpThongTin.TabIndex = 24;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông Tin Nhân Viên";
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.Location = new System.Drawing.Point(157, 147);
            this.txtSDT.MaxLength = 49;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(352, 21);
            this.txtSDT.TabIndex = 24;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(83, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "SĐT";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.Location = new System.Drawing.Point(157, 85);
            this.txtDiaChi.MaxLength = 49;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(352, 21);
            this.txtDiaChi.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(41, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Trạng Thái";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Location = new System.Drawing.Point(157, 178);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(352, 23);
            this.cboGioiTinh.TabIndex = 20;
            // 
            // dtbNgaySinh
            // 
            this.dtbNgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtbNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbNgaySinh.Location = new System.Drawing.Point(157, 114);
            this.dtbNgaySinh.Name = "dtbNgaySinh";
            this.dtbNgaySinh.Size = new System.Drawing.Size(352, 21);
            this.dtbNgaySinh.TabIndex = 19;
            this.dtbNgaySinh.Value = new System.DateTime(2021, 3, 7, 12, 55, 6, 0);
            // 
            // pboAnhNV
            // 
            this.pboAnhNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboAnhNV.ErrorImage = global::GUI.Properties.Resources.manager;
            this.pboAnhNV.Image = global::GUI.Properties.Resources.manager;
            this.pboAnhNV.Location = new System.Drawing.Point(572, 25);
            this.pboAnhNV.Name = "pboAnhNV";
            this.pboAnhNV.Size = new System.Drawing.Size(143, 107);
            this.pboAnhNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboAnhNV.TabIndex = 18;
            this.pboAnhNV.TabStop = false;
            this.pboAnhNV.Click += new System.EventHandler(this.pboAnhNV_Click);
            // 
            // rdoNghi
            // 
            this.rdoNghi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoNghi.AutoSize = true;
            this.rdoNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNghi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoNghi.Location = new System.Drawing.Point(278, 241);
            this.rdoNghi.Name = "rdoNghi";
            this.rdoNghi.Size = new System.Drawing.Size(104, 19);
            this.rdoNghi.TabIndex = 17;
            this.rdoNghi.TabStop = true;
            this.rdoNghi.Text = "Đã nghỉ việc";
            this.rdoNghi.UseVisualStyleBackColor = true;
            // 
            // rdoCon
            // 
            this.rdoCon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoCon.AutoSize = true;
            this.rdoCon.Checked = true;
            this.rdoCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoCon.Location = new System.Drawing.Point(157, 241);
            this.rdoCon.Name = "rdoCon";
            this.rdoCon.Size = new System.Drawing.Size(107, 19);
            this.rdoCon.TabIndex = 16;
            this.rdoCon.TabStop = true;
            this.rdoCon.Text = "Còn làm việc";
            this.rdoCon.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(65, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Địa chỉ";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.Blue;
            this.btnHuy.Image = global::GUI.Properties.Resources.red_flag;
            this.btnHuy.Location = new System.Drawing.Point(572, 202);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(144, 58);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy [F6]";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cboChucVu
            // 
            this.cboChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChucVu.ForeColor = System.Drawing.Color.Black;
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Items.AddRange(new object[] {
            "Cửa hàng trưởng",
            "Nhân viên"});
            this.cboChucVu.Location = new System.Drawing.Point(157, 209);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(352, 23);
            this.cboChucVu.TabIndex = 13;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.Blue;
            this.btnLuu.Image = global::GUI.Properties.Resources.Save;
            this.btnLuu.Location = new System.Drawing.Point(572, 138);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(144, 58);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu [F7]";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(56, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(47, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày sinh";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.Black;
            this.txtTenNV.Location = new System.Drawing.Point(157, 54);
            this.txtTenNV.MaxLength = 49;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(352, 21);
            this.txtTenNV.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(60, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(20, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // lblMaNV
            // 
            this.lblMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.ForeColor = System.Drawing.Color.Black;
            this.lblMaNV.Location = new System.Drawing.Point(154, 26);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(15, 15);
            this.lblMaNV.TabIndex = 6;
            this.lblMaNV.Text = "0";
            // 
            // grpDSTD
            // 
            this.grpDSTD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDSTD.Controls.Add(this.dgvNV);
            this.grpDSTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.grpDSTD.ForeColor = System.Drawing.Color.Blue;
            this.grpDSTD.Location = new System.Drawing.Point(56, 281);
            this.grpDSTD.Name = "grpDSTD";
            this.grpDSTD.Size = new System.Drawing.Size(1041, 358);
            this.grpDSTD.TabIndex = 25;
            this.grpDSTD.TabStop = false;
            this.grpDSTD.Text = "DS loại món";
            // 
            // dgvNV
            // 
            this.dgvNV.AllowUserToAddRows = false;
            this.dgvNV.AllowUserToDeleteRows = false;
            this.dgvNV.AllowUserToResizeColumns = false;
            this.dgvNV.AllowUserToResizeRows = false;
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNV.ColumnHeadersHeight = 40;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.HOTENNV,
            this.NGAYSINH,
            this.GIOITINH,
            this.TRANGTHAI});
            this.dgvNV.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNV.EnableHeadersVisualStyles = false;
            this.dgvNV.Location = new System.Drawing.Point(3, 22);
            this.dgvNV.MultiSelect = false;
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.ReadOnly = true;
            this.dgvNV.RowHeadersVisible = false;
            this.dgvNV.RowHeadersWidth = 50;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvNV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNV.RowTemplate.Height = 60;
            this.dgvNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNV.Size = new System.Drawing.Size(1035, 333);
            this.dgvNV.TabIndex = 0;
            this.dgvNV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNV_CellFormatting);
            this.dgvNV.SelectionChanged += new System.EventHandler(this.dgvNV_SelectionChanged);
            // 
            // MANV
            // 
            this.MANV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã Nhân Viên";
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            this.MANV.Width = 146;
            // 
            // HOTENNV
            // 
            this.HOTENNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HOTENNV.DataPropertyName = "HOTENNV";
            this.HOTENNV.HeaderText = "Tên Nhân Viên";
            this.HOTENNV.Name = "HOTENNV";
            this.HOTENNV.ReadOnly = true;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.NGAYSINH.DefaultCellStyle = dataGridViewCellStyle2;
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.ReadOnly = true;
            this.NGAYSINH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NGAYSINH.Width = 112;
            // 
            // GIOITINH
            // 
            this.GIOITINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.ReadOnly = true;
            this.GIOITINH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GIOITINH.Width = 101;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            this.TRANGTHAI.HeaderText = "Trạng Thái";
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.ReadOnly = true;
            this.TRANGTHAI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TRANGTHAI.Width = 119;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnResetPW);
            this.groupBox1.Controls.Add(this.btnDoiTrangThai);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(1103, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 359);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Công cụ";
            // 
            // btnResetPW
            // 
            this.btnResetPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnResetPW.ForeColor = System.Drawing.Color.Blue;
            this.btnResetPW.Image = global::GUI.Properties.Resources.synchronize;
            this.btnResetPW.Location = new System.Drawing.Point(22, 220);
            this.btnResetPW.Name = "btnResetPW";
            this.btnResetPW.Size = new System.Drawing.Size(144, 58);
            this.btnResetPW.TabIndex = 10;
            this.btnResetPW.Text = "Đặt lại mật khẩu [F4]";
            this.btnResetPW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetPW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetPW.UseVisualStyleBackColor = true;
            this.btnResetPW.Click += new System.EventHandler(this.btnResetPW_Click);
            // 
            // btnDoiTrangThai
            // 
            this.btnDoiTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDoiTrangThai.ForeColor = System.Drawing.Color.Blue;
            this.btnDoiTrangThai.Image = global::GUI.Properties.Resources.refresh_page;
            this.btnDoiTrangThai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiTrangThai.Location = new System.Drawing.Point(22, 284);
            this.btnDoiTrangThai.Name = "btnDoiTrangThai";
            this.btnDoiTrangThai.Size = new System.Drawing.Size(144, 58);
            this.btnDoiTrangThai.TabIndex = 9;
            this.btnDoiTrangThai.Text = "Đổi Trạng Thái DS [F5]";
            this.btnDoiTrangThai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoiTrangThai.UseVisualStyleBackColor = true;
            this.btnDoiTrangThai.Click += new System.EventHandler(this.btnDoiTrangThai_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.Blue;
            this.btnThem.Image = global::GUI.Properties.Resources.Add;
            this.btnThem.Location = new System.Drawing.Point(22, 28);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(144, 58);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm [F1]";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Image = global::GUI.Properties.Resources.note;
            this.btnSua.Location = new System.Drawing.Point(22, 92);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(144, 58);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa [F2]";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.Blue;
            this.btnXoa.Image = global::GUI.Properties.Resources.Delete;
            this.btnXoa.Location = new System.Drawing.Point(22, 156);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(144, 58);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa [F3]";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmQL_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(181)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1346, 637);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.grpDSTD);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQL_KhachHang";
            this.Text = "frmQL_KhachHang";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQL_KhachHang_FormClosed);
            this.Load += new System.EventHandler(this.frmQL_KhachHang_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboAnhNV)).EndInit();
            this.grpDSTD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctmDoi;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.CheckBox chkTen;
        private System.Windows.Forms.CheckBox chkGioiTinh;
        private System.Windows.Forms.ComboBox cboGioiTinhTK;
        private System.Windows.Forms.TextBox txtTenvaMa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDoiTrangThai;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.RadioButton rdoNghi;
        private System.Windows.Forms.RadioButton rdoCon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.GroupBox grpDSTD;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.DateTimePicker dtbNgaySinh;
        private System.Windows.Forms.PictureBox pboAnhNV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
        private System.Windows.Forms.Button btnResetPW;
    }
}