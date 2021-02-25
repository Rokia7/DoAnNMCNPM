namespace GUI
{
    partial class frmQL_ThucDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.rdoHet = new System.Windows.Forms.RadioButton();
            this.rdoCon = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.cboLoaiMon = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaMon = new System.Windows.Forms.Label();
            this.grpDSTD = new System.Windows.Forms.GroupBox();
            this.dgvTD = new System.Windows.Forms.DataGridView();
            this.MAMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIÁ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAIMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmDoi = new System.Windows.Forms.ToolStripMenuItem();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.chkTen = new System.Windows.Forms.CheckBox();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.chktinhtrang = new System.Windows.Forms.CheckBox();
            this.chkLoai = new System.Windows.Forms.CheckBox();
            this.cboloaimontk = new System.Windows.Forms.ComboBox();
            this.txtTenvaMa = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpThongTin.SuspendLayout();
            this.grpDSTD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTD)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpThongTin
            // 
            this.grpThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTin.Controls.Add(this.rdoHet);
            this.grpThongTin.Controls.Add(this.rdoCon);
            this.grpThongTin.Controls.Add(this.label6);
            this.grpThongTin.Controls.Add(this.btnHuy);
            this.grpThongTin.Controls.Add(this.cboLoaiMon);
            this.grpThongTin.Controls.Add(this.btnLuu);
            this.grpThongTin.Controls.Add(this.txtDVT);
            this.grpThongTin.Controls.Add(this.label5);
            this.grpThongTin.Controls.Add(this.label4);
            this.grpThongTin.Controls.Add(this.txtGia);
            this.grpThongTin.Controls.Add(this.txtTenMon);
            this.grpThongTin.Controls.Add(this.label3);
            this.grpThongTin.Controls.Add(this.label1);
            this.grpThongTin.Controls.Add(this.label2);
            this.grpThongTin.Controls.Add(this.lblMaMon);
            this.grpThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.Blue;
            this.grpThongTin.Location = new System.Drawing.Point(560, 19);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(739, 278);
            this.grpThongTin.TabIndex = 4;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông Tin Món";
            // 
            // rdoHet
            // 
            this.rdoHet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoHet.AutoSize = true;
            this.rdoHet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoHet.Location = new System.Drawing.Point(226, 229);
            this.rdoHet.Name = "rdoHet";
            this.rdoHet.Size = new System.Drawing.Size(57, 28);
            this.rdoHet.TabIndex = 17;
            this.rdoHet.TabStop = true;
            this.rdoHet.Text = "Hết";
            this.rdoHet.UseVisualStyleBackColor = true;
            // 
            // rdoCon
            // 
            this.rdoCon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoCon.AutoSize = true;
            this.rdoCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoCon.Location = new System.Drawing.Point(157, 229);
            this.rdoCon.Name = "rdoCon";
            this.rdoCon.Size = new System.Drawing.Size(63, 28);
            this.rdoCon.TabIndex = 16;
            this.rdoCon.TabStop = true;
            this.rdoCon.Text = "Còn";
            this.rdoCon.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(22, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Trạng Thái";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.Blue;
            this.btnHuy.Image = global::GUI.Properties.Resources.red_flag;
            this.btnHuy.Location = new System.Drawing.Point(572, 148);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(144, 58);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy [F3]";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cboLoaiMon
            // 
            this.cboLoaiMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLoaiMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cboLoaiMon.ForeColor = System.Drawing.Color.Black;
            this.cboLoaiMon.FormattingEnabled = true;
            this.cboLoaiMon.Location = new System.Drawing.Point(157, 191);
            this.cboLoaiMon.Name = "cboLoaiMon";
            this.cboLoaiMon.Size = new System.Drawing.Size(352, 28);
            this.cboLoaiMon.TabIndex = 13;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.Blue;
            this.btnLuu.Image = global::GUI.Properties.Resources.Save;
            this.btnLuu.Location = new System.Drawing.Point(572, 80);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(144, 58);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu [F5]";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtDVT
            // 
            this.txtDVT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDVT.AutoCompleteCustomSource.AddRange(new string[] {
            "Ly",
            "Lon"});
            this.txtDVT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDVT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtDVT.ForeColor = System.Drawing.Color.Black;
            this.txtDVT.Location = new System.Drawing.Point(157, 151);
            this.txtDVT.MaxLength = 30;
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(352, 26);
            this.txtDVT.TabIndex = 12;
            this.txtDVT.TextChanged += new System.EventHandler(this.txtDVT_TextChanged);
            this.txtDVT.Leave += new System.EventHandler(this.txtDVT_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(36, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Loại Món";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(26, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Đơn vị tính";
            // 
            // txtGia
            // 
            this.txtGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtGia.ForeColor = System.Drawing.Color.Black;
            this.txtGia.Location = new System.Drawing.Point(157, 107);
            this.txtGia.MaxLength = 15;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(352, 26);
            this.txtGia.TabIndex = 10;
            this.txtGia.TextChanged += new System.EventHandler(this.txtGia_TextChanged);
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // txtTenMon
            // 
            this.txtTenMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtTenMon.ForeColor = System.Drawing.Color.Black;
            this.txtTenMon.Location = new System.Drawing.Point(157, 69);
            this.txtTenMon.MaxLength = 49;
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(352, 26);
            this.txtTenMon.TabIndex = 8;
            this.txtTenMon.Leave += new System.EventHandler(this.txtTenMon_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(86, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Món";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(37, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên Món";
            // 
            // lblMaMon
            // 
            this.lblMaMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblMaMon.ForeColor = System.Drawing.Color.Black;
            this.lblMaMon.Location = new System.Drawing.Point(153, 34);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(19, 20);
            this.lblMaMon.TabIndex = 6;
            this.lblMaMon.Text = "0";
            // 
            // grpDSTD
            // 
            this.grpDSTD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDSTD.Controls.Add(this.dgvTD);
            this.grpDSTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.grpDSTD.ForeColor = System.Drawing.Color.Blue;
            this.grpDSTD.Location = new System.Drawing.Point(64, 303);
            this.grpDSTD.Name = "grpDSTD";
            this.grpDSTD.Size = new System.Drawing.Size(1041, 358);
            this.grpDSTD.TabIndex = 5;
            this.grpDSTD.TabStop = false;
            this.grpDSTD.Text = "DS loại món";
            // 
            // dgvTD
            // 
            this.dgvTD.AllowUserToAddRows = false;
            this.dgvTD.AllowUserToDeleteRows = false;
            this.dgvTD.AllowUserToResizeColumns = false;
            this.dgvTD.AllowUserToResizeRows = false;
            this.dgvTD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTD.ColumnHeadersHeight = 40;
            this.dgvTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAMON,
            this.TENMON,
            this.GIÁ,
            this.LOAIMON,
            this.DVT,
            this.TRANGTHAI});
            this.dgvTD.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTD.EnableHeadersVisualStyles = false;
            this.dgvTD.Location = new System.Drawing.Point(3, 22);
            this.dgvTD.MultiSelect = false;
            this.dgvTD.Name = "dgvTD";
            this.dgvTD.ReadOnly = true;
            this.dgvTD.RowHeadersVisible = false;
            this.dgvTD.RowHeadersWidth = 50;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvTD.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTD.RowTemplate.Height = 60;
            this.dgvTD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTD.Size = new System.Drawing.Size(1035, 333);
            this.dgvTD.TabIndex = 0;
            this.dgvTD.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTD_CellFormatting);
            this.dgvTD.SelectionChanged += new System.EventHandler(this.dgvTD_SelectionChanged);
            // 
            // MAMON
            // 
            this.MAMON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MAMON.DataPropertyName = "MAMON";
            this.MAMON.HeaderText = "Mã Món";
            this.MAMON.Name = "MAMON";
            this.MAMON.ReadOnly = true;
            this.MAMON.Width = 97;
            // 
            // TENMON
            // 
            this.TENMON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENMON.DataPropertyName = "TENMON";
            this.TENMON.HeaderText = "Tên Món";
            this.TENMON.Name = "TENMON";
            this.TENMON.ReadOnly = true;
            // 
            // GIÁ
            // 
            this.GIÁ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GIÁ.DataPropertyName = "GIA";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "#,## VNĐ";
            this.GIÁ.DefaultCellStyle = dataGridViewCellStyle5;
            this.GIÁ.HeaderText = "Giá";
            this.GIÁ.Name = "GIÁ";
            this.GIÁ.ReadOnly = true;
            this.GIÁ.Width = 62;
            // 
            // LOAIMON
            // 
            this.LOAIMON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LOAIMON.DataPropertyName = "MALOAI";
            this.LOAIMON.HeaderText = "Loại Món";
            this.LOAIMON.Name = "LOAIMON";
            this.LOAIMON.ReadOnly = true;
            this.LOAIMON.Width = 107;
            // 
            // DVT
            // 
            this.DVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "ĐVT";
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            this.DVT.Width = 69;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            this.TRANGTHAI.HeaderText = "Trạng Thái";
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.ReadOnly = true;
            this.TRANGTHAI.Width = 119;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmDoi});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 26);
            // 
            // ctmDoi
            // 
            this.ctmDoi.Name = "ctmDoi";
            this.ctmDoi.Size = new System.Drawing.Size(151, 22);
            this.ctmDoi.Text = "Đổi Trạng Thái";
            this.ctmDoi.Click += new System.EventHandler(this.ctmDoi_Click);
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.btnLammoi);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Controls.Add(this.chkTen);
            this.grpTimKiem.Controls.Add(this.cboTinhTrang);
            this.grpTimKiem.Controls.Add(this.chktinhtrang);
            this.grpTimKiem.Controls.Add(this.chkLoai);
            this.grpTimKiem.Controls.Add(this.cboloaimontk);
            this.grpTimKiem.Controls.Add(this.txtTenvaMa);
            this.grpTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.grpTimKiem.ForeColor = System.Drawing.Color.Blue;
            this.grpTimKiem.Location = new System.Drawing.Point(63, 19);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(491, 278);
            this.grpTimKiem.TabIndex = 12;
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
            this.btnLammoi.Location = new System.Drawing.Point(336, 168);
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
            this.btnTimKiem.Location = new System.Drawing.Point(186, 168);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(144, 58);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.Text = "TÌM KIẾM ";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // chkTen
            // 
            this.chkTen.AutoSize = true;
            this.chkTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.chkTen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkTen.Location = new System.Drawing.Point(29, 27);
            this.chkTen.Name = "chkTen";
            this.chkTen.Size = new System.Drawing.Size(135, 24);
            this.chkTen.TabIndex = 23;
            this.chkTen.Text = "Tìm mã / Tên ";
            this.chkTen.UseVisualStyleBackColor = true;
            this.chkTen.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrang.Enabled = false;
            this.cboTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cboTinhTrang.ForeColor = System.Drawing.Color.Black;
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Location = new System.Drawing.Point(220, 112);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(260, 28);
            this.cboTinhTrang.TabIndex = 22;
            this.cboTinhTrang.SelectedValueChanged += new System.EventHandler(this.cboTinhTrang_SelectedValueChanged);
            // 
            // chktinhtrang
            // 
            this.chktinhtrang.AutoSize = true;
            this.chktinhtrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.chktinhtrang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chktinhtrang.Location = new System.Drawing.Point(29, 114);
            this.chktinhtrang.Name = "chktinhtrang";
            this.chktinhtrang.Size = new System.Drawing.Size(179, 24);
            this.chktinhtrang.TabIndex = 21;
            this.chktinhtrang.Text = "Tìm theo trạng thái";
            this.chktinhtrang.UseVisualStyleBackColor = true;
            this.chktinhtrang.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkLoai
            // 
            this.chkLoai.AutoSize = true;
            this.chkLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.chkLoai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkLoai.Location = new System.Drawing.Point(29, 70);
            this.chkLoai.Name = "chkLoai";
            this.chkLoai.Size = new System.Drawing.Size(169, 24);
            this.chkLoai.TabIndex = 17;
            this.chkLoai.Text = "Tìm theo loại món";
            this.chkLoai.UseVisualStyleBackColor = true;
            this.chkLoai.CheckedChanged += new System.EventHandler(this.chkLoai_CheckedChanged);
            // 
            // cboloaimontk
            // 
            this.cboloaimontk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboloaimontk.Enabled = false;
            this.cboloaimontk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cboloaimontk.ForeColor = System.Drawing.Color.Black;
            this.cboloaimontk.FormattingEnabled = true;
            this.cboloaimontk.Location = new System.Drawing.Point(220, 68);
            this.cboloaimontk.Name = "cboloaimontk";
            this.cboloaimontk.Size = new System.Drawing.Size(260, 28);
            this.cboloaimontk.TabIndex = 15;
            this.cboloaimontk.SelectedValueChanged += new System.EventHandler(this.cboloaimontk_SelectedValueChanged);
            // 
            // txtTenvaMa
            // 
            this.txtTenvaMa.Enabled = false;
            this.txtTenvaMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtTenvaMa.ForeColor = System.Drawing.Color.Black;
            this.txtTenvaMa.Location = new System.Drawing.Point(220, 26);
            this.txtTenvaMa.Name = "txtTenvaMa";
            this.txtTenvaMa.Size = new System.Drawing.Size(260, 26);
            this.txtTenvaMa.TabIndex = 9;
            this.txtTenvaMa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTenvaMa_KeyUp);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.Blue;
            this.btnXoa.Image = global::GUI.Properties.Resources.Delete;
            this.btnXoa.Location = new System.Drawing.Point(21, 188);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(144, 58);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa [F4]";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Image = global::GUI.Properties.Resources.note;
            this.btnSua.Location = new System.Drawing.Point(21, 116);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(144, 58);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa [F6]";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.Blue;
            this.btnThem.Image = global::GUI.Properties.Resources.Add;
            this.btnThem.Location = new System.Drawing.Point(21, 48);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(144, 58);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm [F1]";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(1111, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 362);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Công cụ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Image = global::GUI.Properties.Resources.refresh_page;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(21, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 58);
            this.button1.TabIndex = 9;
            this.button1.Text = "Đổi Trạng Thái [F7]";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ctmDoi_Click);
            // 
            // frmQL_ThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(181)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1362, 673);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.grpDSTD);
            this.Controls.Add(this.grpThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQL_ThucDon";
            this.Text = "frmQL_ThucDon";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQL_ThucDon_FormClosed);
            this.Load += new System.EventHandler(this.frmQL_ThucDon_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDSTD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTD)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.ComboBox cboLoaiMon;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.GroupBox grpDSTD;
        private System.Windows.Forms.DataGridView dgvTD;
        private System.Windows.Forms.RadioButton rdoHet;
        private System.Windows.Forms.RadioButton rdoCon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.ComboBox cboloaimontk;
        private System.Windows.Forms.TextBox txtTenvaMa;
        private System.Windows.Forms.CheckBox chkLoai;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctmDoi;
        private System.Windows.Forms.CheckBox chktinhtrang;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkTen;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIÁ;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAIMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
    }
}