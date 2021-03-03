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

namespace GUI
{
    public partial class frmLoaiMon : Form
    {
        public List<clsLoaiMon_DTO> lsLoaiMon;
        public clsLoaiMon_BUS LoaiMon_bus = new clsLoaiMon_BUS();
        public clsLoaiMon_BUS laytrangthai_bus = new clsLoaiMon_BUS();
        private int iTrangthai = 0;

        private static frmLoaiMon _Instance = null;

        public static frmLoaiMon Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new frmLoaiMon();
                }

                return _Instance;
            }
        }

        //public DataView loaimon_TK = null;
        public frmLoaiMon()
        {
            InitializeComponent();
        }

        private void frmLoaiMon_Load(object sender, EventArgs e)
        {
            try
            {
                LoadLoaiMon();
                trangthaixong();
            }
            catch { }

        }
        private void LoadLoaiMon()
        {
            lsLoaiMon = LoaiMon_bus.LayTatCaLoaiMon();
            dgvLoaiMon.AutoGenerateColumns = false;
            dgvLoaiMon.DataSource = lsLoaiMon;
        }

        private void dgvLoaiMon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        string laytenmon = "";
        private void dgvLoaiMon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoaiMon.SelectedRows.Count > 0)
            {
                DataGridViewRow Dongduocchon = dgvLoaiMon.SelectedRows[0];
                if (Dongduocchon != null)
                {
                    txtmaloai.Text = Dongduocchon.Cells["colMALOAI"].Value.ToString();
                    txttenloai.Text = Dongduocchon.Cells["colTENLOAI"].Value.ToString();
                    laytenmon= Dongduocchon.Cells["colTENLOAI"].Value.ToString(); 
                }
            }
        }
        private string phatsinhmaloai()
        {
            string auto = "L";
            clsLoaiMon_BUS bus = new clsLoaiMon_BUS();
            string chuoi = bus.Phatsinhma();
            // MessageBox.Show(chuoi.ToString());
            int count = int.Parse(chuoi.Substring(1)) + 1;
            //MessageBox.Show(count.ToString());
            if (count < 10)
                auto += "0" + count.ToString();
            else
                auto += "" + count.ToString();

            return auto;

        }
        private void Trangthaisua()
        {
            txtmaloai.Enabled = false;
            txttenloai.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            dgvLoaiMon.Enabled = false;
            grbTimKiem.Enabled = false;
        }
        private void trangthaithem()
        {
            Trangthaisua();
            txttenloai.Clear();
            dgvLoaiMon.ClearSelection();
            txttenloai.Focus();
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            txtmaloai.Text = phatsinhmaloai();
        }
        private void trangthaixem()
        {
            btnSua.Enabled = true;
            txtmaloai.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            dgvLoaiMon.Enabled = true;
            grbTimKiem.Enabled = true;

        }
        private void trangthaixong()
        {
            btnLuu.Enabled = false; ;
            btnHuy.Enabled = false;
            txtmaloai.Enabled = false;
            txttenloai.Enabled = false;
            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            iTrangthai = 1;
            trangthaithem();


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            trangthaixem();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtmaloai.Enabled = false;
            txttenloai.Enabled = false;
            dgvLoaiMon.Rows[0].Selected=true;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            iTrangthai = 2;
            Trangthaisua();
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }
        private void xetdieukien()
        {
            if(txttenloai.Text.ToString()=="")
            {
                MessageBox.Show("Bạn chưa nhập tên loại");
            }
        }
        private void ScrollTo(string ma)
        {

            int idx = -1;
            for (int i = 0; i < dgvLoaiMon.Rows.Count; i++)
            {
                if (ma.ToString() == dgvLoaiMon.Rows[i].Cells["colMALOAI"].Value.ToString())
                {
                    idx = i;
                    break;
                }
            }

            if (idx == -1 && dgvLoaiMon.Rows.Count > 0)
            {
                idx = 0;
                return;
            }

            dgvLoaiMon.ClearSelection();
            dgvLoaiMon.Rows[idx].Selected = true;
            dgvLoaiMon.FirstDisplayedScrollingRowIndex = idx;
        }
        private bool kiemtradulieu()
        {
            bool kq = true;
            if (iTrangthai == 1)
            {
                for (int i = 0; i < dgvLoaiMon.Rows.Count; i++)
                {
                    if (txttenloai.Text == dgvLoaiMon.Rows[i].Cells[1].Value.ToString())
                    {

                        MessageBox.Show("Tên loại " + txttenloai.Text + " đã có, bạn hãy kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        kq = false;
                    }
                }
            }
            if (iTrangthai == 2)
            {
                if (txttenloai.Text != laytenmon)
                {
                    for (int i = 0; i < dgvLoaiMon.Rows.Count; i++)
                    {

                        if (txttenloai.Text == dgvLoaiMon.Rows[i].Cells[1].Value.ToString())
                        {

                            MessageBox.Show("Món " + txttenloai.Text + " đã có, bạn hãy kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                clsLoaiMon_DTO loai = new clsLoaiMon_DTO();

                loai.TENLOAI = txttenloai.Text.ToString();
                loai.TRANGTHAI = 1;
                if (txttenloai.Text != "")
                {
                    if (kiemtradulieu() != false)
                    {

                        if (iTrangthai == 1)
                    {

                        loai.MALOAI = "-1";
                        loai.MALOAI = txtmaloai.Text.ToString();
                        LoaiMon_bus.themloai(loai);
                        if (loai.MALOAI != "-1")
                        {
                            LoadLoaiMon();
                            trangthaixong();
                        }
                        else MessageBox.Show("Thêm thất bại");
                        trangthaixem();



                    }
                    else if (iTrangthai == 2)
                    {
                        loai.MALOAI = txtmaloai.Text.ToString();
                        bool kq = LoaiMon_bus.sualoai(loai);
                        if (kq)
                        {
                            LoadLoaiMon();
                            trangthaixong();
                        }
                        else
                            MessageBox.Show("Thêm thất bại");
                        trangthaixem();
                        trangthaixong();
                    }
                    ScrollTo(loai.MALOAI);
                }
                }

                else MessageBox.Show("Bạn chưa nhập tên loại");
            }
            catch { }

            //trangthaixong();
        }
        private void UpdatekhixoaLoaiMon()
        {
            string maloai = txtmaloai.Text;
            string mamon = "";
            //string maloaicanupdate = "L00";
            bool kq = false;
            DataTable dt = new DataTable();
            clsThucDon_BUS BusMon = new clsThucDon_BUS();
            dt = BusMon.LayMonTheoLoaiMon(maloai);
            //dataGridView1.DataSource = dt;
            for(int i=0;i<dt.Rows.Count;i++)
            {
                mamon = dt.Rows[i].Field<string>("MAMON").ToString();
                kq = BusMon.CapNhatmon(mamon);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string Maloai = txtmaloai.Text;
                if (txtmaloai.Text != "L00")
                {
                    if (MessageBox.Show(string.Format("Bạn muốn xóa  \"{0}\" không?", txttenloai.Text),
                  "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Xử lý xóa
                        string Ma = txtmaloai.Text;
                        bool kq = LoaiMon_bus.Xoa(Ma);

                        if (kq)
                        {
                            UpdatekhixoaLoaiMon();
                            LoadLoaiMon();

                        }
                        //TimKiem();
                        else
                            MessageBox.Show("Xóa thất bại");
                    }
                }
                else MessageBox.Show("Bạn không thể xóa loại này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }

        public void TimKiem()
        {
            
            string strMa = "-1";
            if (chkMaLoai.Checked)
            {
                if (txtMaTK.Text == "")
                {
                    strMa = "-1";
                }
                else
                    strMa = txtMaTK.Text;
            }
            string strTen = "-1";
            if (chkTenLoai.Checked)
                if (txttenloai.Text == "")
                {
                    strTen = "-1";
                }
                else
                    strTen = txtTenTK.Text;
         

            // Gọi lấy dữ từ CSDL
            dgvLoaiMon.AutoGenerateColumns = false;
            dgvLoaiMon.AutoResizeColumns();
            List<clsLoaiMon_DTO> lslm = new List<clsLoaiMon_DTO>();

            lslm = LoaiMon_bus.LayDsloaimon(strTen, strMa);
            dgvLoaiMon.AutoGenerateColumns = false;
            dgvLoaiMon.DataSource = lslm;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            TimKiem();
            chkMaLoai.Checked = false;
            chkTenLoai.Checked = false;
        }

        private void chkMaLoai_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMaLoai.Checked)
            {
                txtMaTK.Enabled = true;

            }
            else
            {
                txtMaTK.Enabled = false;
                txtMaTK.Clear();
            }
        }

        private void chkTenLoai_CheckedChanged(object sender, EventArgs e)
        {
            if(chkTenLoai.Checked)
            {
                txtTenTK.Enabled = true;
            }
            else
            {
                txtTenTK.Enabled = false;
                txtTenTK.Clear();
            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                if (btnThem.Enabled == true)
                    btnThem_Click(null, null);
                return true;
            }
            
            else if (keyData == Keys.F3)
            {
                if (btnHuy.Enabled == true)
                    btnHuy_Click(null, null);
                return true;
            }
            else if (keyData == Keys.F6)
            {
                if (btnSua.Enabled == true)
                    btnSua_Click(null, null);
                return true;
            }
            else if (keyData == Keys.F4)
            {
                if (btnXoa.Enabled == true)
                    btnXoa_Click(null, null);
                return true;
            }
            else if (keyData == Keys.F5)
            {
                if (btnLuu.Enabled == true)
                    btnLuu_Click(null, null);
                return true;
            }

            else return false;
        }
        private void frmLoaiMon_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }
        private string chuyendoichuthuongthanhchuhoa()
        {
            string kq = "";
            string s = txttenloai.Text.ToString().Trim();
            try
            {
                int i = 0;
                s = s.ToLower();
                while (i != s.Length)
                {
                    if (s[i] == ' ' && s[i + 1] == ' ')
                    {
                        s = s.Remove(i + 1, 1);
                        i = 0;
                    }
                    i++;
                }
                string p = s[0].ToString();//Lấy ký tự đầu tiên
                p = p.ToUpper();// in hoa chữ đầu tiên
                s = s.Remove(0, 1);//Xóa 1 ký thường tự đầu tiên
                s = s.Insert(0, p);//Thêm chữ In hoa vị trí đầu tiên và giá trị là p

                return kq = s;
            }
            catch { return kq; }

        }
        private void txttenloai_Leave(object sender, EventArgs e)
        {
            txttenloai.Text = chuyendoichuthuongthanhchuhoa().ToString();
        }
    }
}
