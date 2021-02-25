using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using System.Globalization;
using BUS;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        clsNhanVien_BUS busTTNV = new clsNhanVien_BUS();
        public static string tennv = null;
        public clsNhanVien_DTO USER = null;
        public static string MaNV = null;
        public static string MK = null;
        public static string CV = null;
        //Trạng thái chưa thu gọn...
        int TrangThai = 0;
        int TrangThaiDX = 0;
        int demclick = 0;
        string HinhAnh="";
        string a = "";
        string b = "";
        string c = "";
        string d = "";
        string h = "";
        string f = "";
        string g = "";
        Button btn = new Button();
        PictureBox ax = new PictureBox();
        Label ten = new Label();
        private static frmMain _Instance = null;

        public static frmMain Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new frmMain();
                return frmMain._Instance;
            }
            set { frmMain._Instance = value; }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
            TrangThai = 0;
            demclick = 0;
            a = mnubarMain.Items[0].Text;
            b = mnubarMain.Items[1].Text;
            c = mnubarMain.Items[2].Text;

            ten.Size = lblHoTen.Size;
            ten.Text = lblHoTen.Text;
        }

        public void PhanQuyen(string MaCV)
        {
            //Xét nhân viên phục vụ
            if (MaCV != "1")
            {
                mnuHoaDon.Visible = false;
                mnuQLNV.Visible = false;
                mnuKhachHang.Visible = false;
                mnuQLTD.Visible = false;
                mnuLoaiMon.Visible = false;
            }
            else
			{
                mnuHoaDon.Visible = true;
                mnuQLNV.Visible = true;
                mnuKhachHang.Visible = true;
                mnuQLTD.Visible = true;
                mnuLoaiMon.Visible = true;
            }
        }
        public void XuLyKhiDangNhapThanhCong(clsNhanVien_DTO nv)
        {
            USER = nv;
            // Trạng thái đã đăng nhập thành công
            mnubarMain.Enabled = true;
            //btnDangXuat.Enabled = true;

            // Hiện thị thông tin người đang đăng nhập
            lblHoTen.Text =nv.HOTENNV;

            MK = nv.MATKHAU;
            MaNV = nv.MANV;
            tennv = lblHoTen.Text;
            HinhAnh = nv.HINHANH.ToString();
            //picHinhAnh.Image = busTTNV.ImageCrop(nv.HINHANH, 1);
            //picHinhAnh.ImageLocation = nv.HINHANH;
            CV = nv.MaCV;
            //MessageBox.Show(CV.ToString());
            PhanQuyen(CV);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
               Application.Exit();
           
        }

        private void mnuQLNV_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            //frmQL_NhanVien m_frmQL_NhanVien = frmQL_NhanVien.Instance;
            //m_frmQL_NhanVien.MdiParent = this;
            //m_frmQL_NhanVien.Dock = DockStyle.Fill;
            //m_frmQL_NhanVien.Show();
            //m_frmQL_NhanVien.BringToFront();
            //mnuQuanLy.Text = "QUẢN LÝ (NHÂN VIÊN)";
        }

        private void toolStripMain_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            //frmQL_HoaDon m_frmQL_HoaDon = frmQL_HoaDon.Instance;
            //m_frmQL_HoaDon.MdiParent = this;
            //m_frmQL_HoaDon.Dock = DockStyle.Fill;
            //m_frmQL_HoaDon.Show();
            //m_frmQL_HoaDon.BringToFront();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult ques = MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if (ques == DialogResult.Yes)
            {
                TrangThaiDX = 1;
                Application.Restart();
            }

        }
        private void CloseAllForm()
        {
            foreach (Form con in this.MdiChildren)
            {
                con.Close();
            }
        }
        private  void mnuBanHang_Click(object sender, EventArgs e)
        {
            //frmBanHang m_frmBanHang = frmBanHang.Instance;
            //m_frmBanHang.MdiParent = this;
            //m_frmBanHang.Dock = DockStyle.Fill;
            //m_frmBanHang.Show();
            //m_frmBanHang.BringToFront();
            //m_frmBanHang.LoadDuLieuDGVTD();
        }

        private void BienDoiTrangThai()
        {

            int dong = mnubarMain.Items.Count;
            if (TrangThai == 1)
            {

                for (int i = 0; i < dong; i++)
                {

                    mnubarMain.Items[i].Text = "";


                }
                mnubarMain.Items[dong - 1].Image = GUI.Properties.Resources.morong;
                lblHoTen.Size = new System.Drawing.Size(0, 0);
                lblHoTen.Text = "";
            }
            else
            {
                mnubarMain.Items[0].Text = a;
                mnubarMain.Items[1].Text = b;
                mnubarMain.Items[2].Text = c;
                mnubarMain.Items[dong - 1].Image = GUI.Properties.Resources.thugon;
                lblHoTen.Size = ten.Size;
                lblHoTen.Text = ten.Text;
            }
            mnubarMain.Refresh();
        }
        private void mnuThuGon_Click(object sender, EventArgs e)
        {
            demclick++;
            if (demclick % 2 != 0)
            {
                TrangThai = 1;
                BienDoiTrangThai();
            }
            else
            {
                TrangThai = 0;
                BienDoiTrangThai();
            }
        }

        private void mnuQLTD_Click(object sender, EventArgs e)
        {
            CloseAllForm();
			frmQL_ThucDon m_frmQL_ThucDon = frmQL_ThucDon.Instance;
			m_frmQL_ThucDon.MdiParent = this;
			m_frmQL_ThucDon.Dock = DockStyle.Fill;
			m_frmQL_ThucDon.Show();
			m_frmQL_ThucDon.BringToFront();
			mnuQuanLy.Text = "QUẢN LÝ (THỰC ĐƠN)";
		}

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TrangThaiDX == 0)
            {
                frmXacNhan xacnhan = new frmXacNhan("Bạn có chắc thoát khỏi chương trình ???", "Đồng ý", "Hủy bỏ");
                xacnhan.ShowDialog();
                if (xacnhan.DialogResult == DialogResult.No)
                    e.Cancel = true;
            }
            else
            {
                //Application.Restart();
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
			frmDoiMK doimk = new frmDoiMK();
			doimk.Show();
		}

        private void qUẢNLÝKHÁCHHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            //frmQL_KhachHang m_frmQL_KhachHang = frmQL_KhachHang.Instance;
            //m_frmQL_KhachHang.MdiParent = this;
            //m_frmQL_KhachHang.Dock = DockStyle.Fill;
            //m_frmQL_KhachHang.Show();
            //m_frmQL_KhachHang.BringToFront();
            //mnuQuanLy.Text = "QUẢN LÝ (KHÁCH HÀNG)";
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           btnDangXuat_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CapNhatGio();
        }

        private void CapNhatGio()
        {
            lblThoiGianHienTai.Text = string.Format("{0:hh}", DateTime.Now) + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + " " + DateTime.Now.ToString("tt", CultureInfo.InvariantCulture)+ " Ngày " + DateTime.Now.ToShortDateString();
        }

        private void btnMiniSize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnubarMain_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mnubarMain.Items.Count; i++)
            {
                if (mnubarMain.Items[i].Selected == true)
                {
                    mnubarMain.Items[i].BackColor = Color.FromArgb(179, 215, 243);
                }
                else mnubarMain.Items[i].BackColor = Color.Transparent;

            }
            if (mnubarMain.Items[2].Selected == false)
            {
                mnuQuanLy.Text = "QUẢN LÝ";
            }
        }

        private void lblHoTen_MouseHover(object sender, EventArgs e)
        {
			frmThongTinNVKhiDangNhap dn = new frmThongTinNVKhiDangNhap(HinhAnh, tennv, MaNV);
			dn.Show();
		}

        private void lblHoTen_MouseLeave(object sender, EventArgs e)
        {
			frmThongTinNVKhiDangNhap dn = new frmThongTinNVKhiDangNhap();
			dn.Close();
		}

        private void lOẠIMÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            //frmLoaiMon m_frmLoaiMon = frmLoaiMon.Instance;
            //m_frmLoaiMon.MdiParent = this;
            //m_frmLoaiMon.Dock = DockStyle.Fill;
            //m_frmLoaiMon.Show();
            //m_frmLoaiMon.BringToFront();
            //mnuQuanLy.Text = "QUẢN LÝ (LOẠI MÓN)";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CloseAllForm();
        }
    }
}
