using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class frmThongTinNVKhiDangNhap : Form
    {
        private string hinhAnh;
        private string tennv;
        private string maNV;
        clsNhanVien_BUS busTTNV = new clsNhanVien_BUS();
        public frmThongTinNVKhiDangNhap()
        {
            InitializeComponent();
        }

        public frmThongTinNVKhiDangNhap(string hinhAnh, string tennv, string maNV)
        {
            InitializeComponent();
            this.hinhAnh = hinhAnh;
            this.tennv = tennv;
            this.maNV = maNV;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongTinNVKhiDangNhap_Load(object sender, EventArgs e)
        {
            Screen scr = Screen.PrimaryScreen; //đi lấy màn hình chính
            this.Left = (scr.WorkingArea.Width - this.Width)/1;
            this.Top = (scr.WorkingArea.Height - this.Height)/ 8;
            picHinhAnh.Image = busTTNV.ImageCrop(hinhAnh, 1);
            lblma.Text = maNV;
            lblten.Text = tennv;

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult ques = MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if (ques == DialogResult.Yes)
            {
                 int TrangThaiDX = 1;
                Application.Restart();
            }
        }
    }
}
