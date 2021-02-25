using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Security.Cryptography;
namespace GUI
{
    public partial class frmDoiMK : Form
    {
        private static frmDoiMK _Instance = null;
        int TrangThaiDoi = 0; //Chưa đổi || Thất bại
        public frmDoiMK()
        {
            InitializeComponent();
        }
        string ma = frmMain.MaNV;
        string ten = frmMain.tennv;
        public frmDoiMK(clsNhanVien_DTO a)
        {
            ma = a.MANV;
            ten = a.HOTENNV;
            InitializeComponent();
        }
        public static frmDoiMK Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new frmDoiMK();
                }
                return _Instance;
            }
        }

        private void frmDoiMK_Load(object sender, EventArgs e)
        {
            txtTenDN.Text = ten;
        }

        private void frmDoiMK_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
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

        private void btnDoi_Click(object sender, EventArgs e)
        {
            string makaucu = frmMain.MK;
            //MessageBox.Show("Mat khau"+makaucu);
            //MessageBox.Show("mktb" + txtMatKhauCu.Text);
            string mkcu = GetMD5(txtMatKhauCu.Text);
            if (txtMatKhauCu.TextLength == 0 || txtMKmoi.TextLength == 0 || txtMKmoi2.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (mkcu.Trim() == makaucu.Trim())
            {

                if (txtMatKhauCu.Text.Equals(txtMKmoi.Text))
                {
                    MessageBox.Show("Mật Khẩu Cũ Và Mật Khẩu Mới Không Được Trùng Nhau !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (txtMKmoi.Text.Equals(txtMKmoi2.Text))
                {

                    string matkhaumoi = GetMD5(txtMKmoi.Text);
                    string manv = ma;
                    clsNhanVien_BUS bus = new clsNhanVien_BUS();
                    bool kq = bus.DoiMauKhau(manv, matkhaumoi);
                    if (kq)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else
                {
                    MessageBox.Show("Mật khẩu mới và mật khẩu xác nhận không trùng khớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {

                MessageBox.Show("Mật khẩu cũ không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked == true)
            {
                txtMatKhauCu.UseSystemPasswordChar = false;
                txtMKmoi.UseSystemPasswordChar = false;
                txtMKmoi2.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhauCu.UseSystemPasswordChar = true;
                txtMKmoi.UseSystemPasswordChar = true;
                txtMKmoi2.UseSystemPasswordChar = true;
            }
        }

        public int LayTrangThaiDoi()
        {
            return TrangThaiDoi;
        }

        private void frmDoiMK_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

    }
}
