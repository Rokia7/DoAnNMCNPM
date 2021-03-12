using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BUS;
using DTO;
using System.Security.Cryptography;

namespace GUI
{
    public partial class frmQL_NhanVien : Form
    {
        public frmQL_NhanVien()
        {
            InitializeComponent();
        }

        private static frmQL_NhanVien _Instance = null;

        public static frmQL_NhanVien Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new frmQL_NhanVien();
                }
                return _Instance;
            }
        }

        private clsNhanVien_BUS busNV = new clsNhanVien_BUS();
        private List<clsNhanVien_DTO> lsnv = new List<clsNhanVien_DTO>();
        private int iTrangThaiDS = 1;
        private bool iAdd = false;
        private bool iUpdate = false;

        private void frmQL_NhanVien_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            LoadDuLieuDGVNV();
            btnLammoi.Enabled = true;
            disabledForm();
        }

        private void LoadDuLieu()
        {
            DataTable tam = new DataTable();
            tam.Columns.Add("MAGT");
            tam.Columns.Add("TENGT");
            tam.Rows.Add(1, "Nam");
            tam.Rows.Add(0, "Nữ");
            tam.Rows.Add("", "Chọn giới tính");

            DataTable tam2 = new DataTable();
            tam2.Columns.Add("MAGT");
            tam2.Columns.Add("TENGT");
            tam2.Rows.Add(1, "Nam");
            tam2.Rows.Add(0, "Nữ");
            tam2.Rows.Add("", "Chọn giới tính");

            DataTable dataCV = new DataTable();
            dataCV.Columns.Add("MACV");
            dataCV.Columns.Add("TENCV");
            dataCV.Rows.Add(1, "Cửa hàng trưởng");
            dataCV.Rows.Add(2, "Nhân viên");

            cboGioiTinh.DataSource = tam;
            cboGioiTinh.ValueMember = "MAGT";
            cboGioiTinh.DisplayMember = "TENGT";
            cboGioiTinh.SelectedIndex = 2;

            cboGioiTinhTK.DataSource = tam2;
            cboGioiTinhTK.ValueMember = "MAGT";
            cboGioiTinhTK.DisplayMember = "TENGT";
            cboGioiTinhTK.SelectedIndex = 2;

            cboChucVu.DataSource = dataCV;
            cboChucVu.ValueMember = "MACV";
            cboChucVu.DisplayMember = "TENCV";
            cboChucVu.SelectedIndex = 1;
        }

        private void LoadDuLieuDGVNV()
        {
            if (iTrangThaiDS == 1)
            {
                LoadDuLieuDGVNVCon();
            }
            else
            {
                LoadDuLieuDGVNVNghi();
            }
        }

        private void LoadDuLieuDGVNVCon()
        {
            lsnv = busNV.LayDsTatCaNVCon();
            dgvNV.AutoGenerateColumns = false;
            dgvNV.AutoResizeColumns();
            dgvNV.DataSource = lsnv;
        }

        private void LoadDuLieuDGVNVNghi()
        {
            lsnv = busNV.LayDsTatCaNVNghi();
            dgvNV.AutoGenerateColumns = false;
            dgvNV.AutoResizeColumns();
            dgvNV.DataSource = lsnv;
        }

        private void chkGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGioiTinh.Checked == true)
            {
                cboGioiTinhTK.Enabled = true;
            }
            else
            {
                cboGioiTinhTK.Enabled = false;
                cboGioiTinhTK.Text = "Chọn giới tính";
            }
        }

        private void chkTen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTen.Checked == true)
            {
                txtTenvaMa.Enabled = true;
            }
            else
            {
                txtTenvaMa.Enabled = false;
                txtTenvaMa.Text = "";
            }
        }

        private void disabledForm()
        {
            iAdd = false;
            iUpdate = false;
            txtTenNV.Enabled = false;
            txtDiaChi.Enabled = false;
            dtbNgaySinh.Enabled = false;
            txtSDT.Enabled = false;
            cboGioiTinh.Enabled = false;
            cboChucVu.Enabled = false;
            rdoCon.Enabled = false;
            rdoNghi.Enabled = false;
            pboAnhNV.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void addForm()
        {
            iAdd = true;
            iUpdate = false;
            lblMaNV.Text = PhatSinhMaNV().ToString();
            enableForm();
        }

        private void updateForm()
        {
            iAdd = false;
            iUpdate = true;
            enableForm();
        }

        private void clearForm()
        {
            lblMaNV.Text = "";
            txtTenNV.Text = "";
            txtDiaChi.Text = "";
            dtbNgaySinh.Value = DateTime.Now;
            txtSDT.Text = "";
            cboGioiTinh.SelectedIndex = 0;
            cboChucVu.SelectedIndex = 1;
            rdoCon.Checked = true;
            rdoNghi.Checked = false;
            pboAnhNV.Image = Properties.Resources.manager;
        }

        private void enableForm()
        {
            txtTenNV.Enabled = true;
            txtDiaChi.Enabled = true;
            dtbNgaySinh.Enabled = true;
            txtSDT.Enabled = true;
            cboGioiTinh.Enabled = true;
            cboChucVu.Enabled = true;
            rdoCon.Enabled = true;
            rdoNghi.Enabled = true;
            pboAnhNV.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void dgvNV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvNV.Columns[e.ColumnIndex].Name == "TRANGTHAI")
            {
                if ((int)e.Value == 1)
                    e.Value = @"Còn";
                else if ((int)e.Value == 0)
                {
                    e.Value = @"Nghỉ";
                    e.CellStyle.BackColor = Color.Red;
                }
            }
            if (dgvNV.Columns[e.ColumnIndex].Name == "GIOITINH")
            {
                if ((Boolean)e.Value)
                    e.Value = @"Nam";
                else
                {
                    e.Value = @"Nữ";
                }
            }
        }

        private void btnDoiTrangThai_Click(object sender, EventArgs e)
        {
            if (iTrangThaiDS == 1)
            {
                iTrangThaiDS = 0;
            }
            else
            {
                iTrangThaiDS = 1;
            }
            btnLammoi_Click(null, null);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                if (btnThem.Enabled == true)
                    btnThem_Click(null, null);
                return true;
            }

            if (keyData == Keys.F2)
            {
                if (btnSua.Enabled == true)
                    btnSua_Click(null, null);
                return true;
            }

            if (keyData == Keys.F3)
            {
                if (btnXoa.Enabled == true)
                    btnXoa_Click(null, null);
                return true;
            }

            if (keyData == Keys.F4)
            {
                if (btnResetPW.Enabled == true)
                    btnResetPW_Click(null, null);
                return true;
            }

            if (keyData == Keys.F5)
            {
                if (btnDoiTrangThai.Enabled == true)
                    btnDoiTrangThai_Click(null, null);
                return true;
            }

            if (keyData == Keys.F6)
            {
                if (btnHuy.Enabled == true)
                    btnHuy_Click(null, null);
                return true;
            }

            if (keyData == Keys.F7)
            {
                if (btnLuu.Enabled == true)
                    btnLuu_Click(null, null);
                return true;
            }


            else return false;
        }

        string tenNV = "";
        string matKhau = "";

        private void dgvNV_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvNV.SelectedRows.Count > 0)
                {
                    // Lấy dòng được chọn
                    disabledForm();
                    DataGridViewRow DongDuocChon = dgvNV.SelectedRows[0];
                    if (DongDuocChon != null)
                    {
                        clsNhanVien_DTO nv = new clsNhanVien_DTO();
                        clsNhanVien_BUS busNV = new clsNhanVien_BUS();
                        nv = busNV.LayThongTinNhanVien(DongDuocChon.Cells["MANV"].Value.ToString());
                        //// Hiển thị các thông tin lên groupbox Thông tin truyện
                        matKhau = nv.MATKHAU.ToString();
                        lblMaNV.Text = DongDuocChon.Cells["MANV"].Value.ToString();
                        tenNV = DongDuocChon.Cells["HOTENNV"].Value.ToString();
                        dtbNgaySinh.Text = nv.NGAYSINH.ToString();
                        txtTenNV.Text = nv.HOTENNV.ToString();
                        cboGioiTinh.SelectedValue = nv.GIOITINH ? 1 : 0;
                        cboChucVu.SelectedValue = nv.MaCV.ToString();
                        txtDiaChi.Text = nv.DIACHI.ToString();
                        txtSDT.Text = nv.SDT.ToString();
                        pboAnhNV.Image = Image.FromFile(@"" + nv.HINHANH.ToString());
                        if (nv.TRANGTHAI == 1)
                            rdoCon.Checked = true;
                        else
                            rdoNghi.Checked = true;
                    }
                }
            }
            catch { }
        }

        private void TimKiem()
        {
            string strTen = "-1";
            string strGT = "-1";
            int intTrangThai = -1;

            if (chkTen.Checked)
            {
                if (txtTenvaMa.Text == "")
                    strTen = "-1";
                else
                    strTen = txtTenvaMa.Text;
            }

            if (chkGioiTinh.Checked)
            {
                if (cboGioiTinhTK.Text.ToString() == "")
                    strGT = "-1";
                else strGT = cboGioiTinhTK.Text.ToString();
            }

            if (iTrangThaiDS != 1 && iTrangThaiDS != 0)
                intTrangThai = -1;
            else
                intTrangThai = iTrangThaiDS;

            List<clsNhanVien_DTO> lsNV = new List<clsNhanVien_DTO>();

            // Gọi lấy dữ từ CSDL
            dgvNV.AutoGenerateColumns = false;
            dgvNV.AutoResizeColumns();

            lsNV = busNV.LayDsNhanVien(strTen, strTen, strGT, intTrangThai);
            //}

            dgvNV.DataSource = lsNV;
        }

        private void pboAnhNV_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pboAnhNV.Image = new Bitmap(open.FileName);
                // image file path  
                pboAnhNV.Text = open.FileName;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clearForm();
            addForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            updateForm();
        }

        private bool XetDieuKienChinhSuaNV()
        {
            bool kq = true;
            string bienbao = "";
            if (txtTenNV.Text == "")
                bienbao += "Tên Nhân Viên \n";
            if (txtDiaChi.Text == "")
                bienbao += "Địa chỉ \n";
            if (txtSDT.Text == "")
                bienbao += "Số điện thoại \n";

            if (bienbao != "")
            {
                MessageBox.Show("Bạn chưa nhập Thông tin: \n" + bienbao + "\n" + "Xin Vui Lòng Nhập Lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kq = false;
            }

            DateTime nowDate = DateTime.Now;

            DateTime birthday = dtbNgaySinh.Value;

            int year = nowDate.Year - birthday.Year;

            if (year < 18)
            {
                MessageBox.Show("Ngày sinh không hợp lệ" + "\n" + "Xin Vui Lòng Nhập Lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kq = false;

            }

            if (iAdd)
            {
                for (int i = 0; i < dgvNV.Rows.Count; i++)
                {
                    if (txtTenNV.Text == dgvNV.Rows[i].Cells["HOTENNV"].Value.ToString())
                    {

                        MessageBox.Show("Tên nhân viên " + txtTenNV.Text + " đã có, bạn hãy kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        kq = false;
                    }
                }
            }

            if (iUpdate)
            {
                if (txtTenNV.Text != tenNV)
                {
                    for (int i = 0; i < dgvNV.Rows.Count; i++)
                    {

                        if (txtTenNV.Text == dgvNV.Rows[i].Cells["HOTENNV"].Value.ToString())
                        {

                            MessageBox.Show("Tên nhân viên " + txtTenNV.Text + " đã có, bạn hãy kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            kq = false;
                        }
                    }
                }
            }

            return kq;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                clsNhanVien_DTO nv = new clsNhanVien_DTO();
                nv.HOTENNV = txtTenNV.Text.ToString();
                nv.GIOITINH = cboGioiTinh.SelectedValue.ToString() == "1" ? true : false;
                nv.MaCV = cboChucVu.SelectedValue.ToString();
                nv.NGAYSINH = dtbNgaySinh.Value;
                nv.SDT = txtSDT.Text.ToString();
                nv.DIACHI = txtDiaChi.Text.ToString();
                nv.TRANGTHAI = rdoCon.Checked ? 1 : 0;
                if (!File.Exists(@"DuLieu\NhanVien\" + lblMaNV.Text + ".jpg"))
                {
                    pboAnhNV.Image.Save(@"DuLieu\NhanVien\" + lblMaNV.Text + ".jpg");
                }
                nv.HINHANH = @"DuLieu\NhanVien\" + lblMaNV.Text + ".jpg";
                nv.MATKHAU = matKhau;


                if (rdoCon.Checked)
                    nv.TRANGTHAI = 1;
                else if (rdoNghi.Checked)
                    nv.TRANGTHAI = 2;

                if (XetDieuKienChinhSuaNV() != false)
                {
                    if (iAdd) // Thêm
                    {
                        nv.MANV = "-1";
                        nv.MANV = lblMaNV.Text != "" ? lblMaNV.Text : PhatSinhMaNV().ToString();
                        nv.MATKHAU = GetMD5("123");

                        bool kq = busNV.ThemNV(nv);

                        disabledForm();
                        if (kq)
                            TimKiem();
                        else
                            MessageBox.Show("Thêm thất bại");

                    }
                    else if (iUpdate) // Sửa
                    {
                        nv.MANV = lblMaNV.Text;
                        bool kq = busNV.SuaNV(nv);

                        disabledForm();
                        if (kq)
                            TimKiem();
                        else
                            MessageBox.Show("Sửa thất bại");

                    }

                    ScrollTo(nv.MANV);
                }
            }
            catch { }
        }

        private void ScrollTo(string ma)
        {

            int idx = -1;
            for (int i = 0; i < dgvNV.Rows.Count; i++)
            {
                if (ma.ToString() == dgvNV.Rows[i].Cells["MANV"].Value.ToString())
                {
                    idx = i;
                    break;
                }
            }

            if (idx == -1 && dgvNV.Rows.Count > 0)
            {
                idx = 0;
                return;
            }

            dgvNV.ClearSelection();
            dgvNV.Rows[idx].Selected = true;
            dgvNV.FirstDisplayedScrollingRowIndex = idx;
        }

        private string PhatSinhMaNV()
        {
            string Auto_MaNV = "NV";
            clsNhanVien_BUS bus = new clsNhanVien_BUS();
            string chuoi = bus.PhatSinhMaNV();

            int count = int.Parse(chuoi.Substring(2)) + 1;
            if (count < 10)
                Auto_MaNV += "000" + count.ToString();
            else if (count < 100)
                Auto_MaNV += "00" + count.ToString();
            else if (count < 1000)
                Auto_MaNV += "0" + count.ToString();
            else if (count < 10000)
                Auto_MaNV += "" + count.ToString();
            else
                Auto_MaNV += count.ToString();
            return Auto_MaNV;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            chkGioiTinh.Checked = false;
            chkTen.Checked = false;
            txtTenvaMa.Text = "";
            LoadDuLieuDGVNV();
        }

        private void btnResetPW_Click(object sender, EventArgs e)
        {
            matKhau = GetMD5("123");
            iAdd = false;
            iUpdate = true;
            btnLuu_Click(null, null);
        }

        private string GetMD5(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }

            return str_md5;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNV = lblMaNV.Text;

            if (maNV != "")
            {
                bool kq = busNV.XoaNV(maNV);

                if (kq)
                    TimKiem();
                else
                    MessageBox.Show("Xóa thất bại");
                disabledForm();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnLammoi_Click(null, null);
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}