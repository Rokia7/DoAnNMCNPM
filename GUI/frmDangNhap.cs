using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;
using System.Security.Cryptography;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        frmMain frmmain = new frmMain();
        public static string _User = null;
        public frmDangNhap()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }

        public string GetMD5(string chuoi)
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

        private void XuLyDangNhap()
        {
            string strMaNV = cboNhanVien.SelectedValue.ToString();
            string strMK = GetMD5(txtMatKhau.Text);

            // kiểm tra đã nhập đầy đủ tên ĐN và MK chưa?
            if (strMaNV == "" || strMK == "")
            {
                MessageBox.Show("Bạn chưa nhập Tên đăng nhập hoặc Mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Kiểm tra Tên Đăng Nhập và Mật khẩu đúng không?
            clsNhanVien_BUS bus = new clsNhanVien_BUS();
            if (bus.KiemTraDangNhap(strMaNV, strMK))
            {
                // Xử lý khi đăng nhập thành công
                _User = strMaNV;
                this.Hide();
                clsNhanVien_DTO nv = bus.LayThongTinNhanVien(strMaNV);
                frmmain.XuLyKhiDangNhapThanhCong(nv);
                frmmain.Show();
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Tên Đăng nhập không tồn tại HOẶC Mật khẩu không đúng");
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            
            // Yêu cầu lấy dữ liệu từ CSDL thông qua BUS
            clsNhanVien_BUS bus = new clsNhanVien_BUS();
            List<clsNhanVien_DTO> lsNV = bus.LayDsTatCaNV();
            // Đổ dữ liệu cho cboNhanVien
            cboNhanVien.DataSource = lsNV;
            cboNhanVien.DisplayMember = "HOTENNV";
            cboNhanVien.ValueMember = "MANV";

            lblTitle.Text = "Đăng Nhập";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            XuLyDangNhap();

        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)Keys.Enter == e.KeyChar)
            {
                XuLyDangNhap();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMiniSize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void chkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.UseSystemPasswordChar)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
