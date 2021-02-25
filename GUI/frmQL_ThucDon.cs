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
    public partial class frmQL_ThucDon : Form
    {
        public frmQL_ThucDon()
        {
            InitializeComponent();
        }



        private static frmQL_ThucDon _Instance = null;

        public static frmQL_ThucDon Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new frmQL_ThucDon();
                }
                return _Instance;
            }
        }

        private clsThucDon_BUS bustd = new clsThucDon_BUS();
        private List<clsThucDon_DTO> lstd = new List<clsThucDon_DTO>();
        private clsLoaiMon_BUS buslm = new clsLoaiMon_BUS();
        private List<clsLoaiMon_DTO> lslm = new List<clsLoaiMon_DTO>();
        private List<clsLoaiMon_DTO> lslmm = new List<clsLoaiMon_DTO>();
        private int iTrangThai = 0;
        private void frmQL_ThucDon_Load(object sender, EventArgs e)
        {
            try
            {
                lslm = buslm.LayTatCaLoaiMon();
                lslmm = buslm.LayTatCaLoaiMon();
                LoadDuLieu();
                LoadDuLieuDGV();
                btnLammoi.Enabled = true;
            }
            catch { }
        }


        private string chuyendoichuthuongthanhchuhoa()
        {
            string kq = ""; 
                string s = txtTenMon.Text.ToString().Trim();
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

        private void LoadDuLieu()
        {
            
            cboloaimontk.Enabled = false;

            DataTable tam = new DataTable();
            tam.Columns.Add("MATT");
            tam.Columns.Add("TENTT");
            tam.Rows.Add(2, "Hết");
            tam.Rows.Add(1, "Còn");
            tam.Rows.Add("", "Chọn tình trạng");

            cboTinhTrang.DataSource = tam;
            cboTinhTrang.ValueMember = "MATT";
            cboTinhTrang.DisplayMember = "TENTT";
            cboTinhTrang.SelectedIndex = 2;

            cboLoaiMon.DataSource = lslm;
            
            cboLoaiMon.ValueMember = "MALOAI";
            cboLoaiMon.DisplayMember = "TENLOAI";
            

            cboloaimontk.DataSource = lslmm;
            clsLoaiMon_DTO loaimon_DTO = new clsLoaiMon_DTO();
            loaimon_DTO.MALOAI = "-1";
            loaimon_DTO.TENLOAI = "Chọn loại món";
            lslmm.Add(loaimon_DTO);
            cboloaimontk.ValueMember = "MALOAI";
            cboloaimontk.DisplayMember = "TENLOAI";
            cboloaimontk.SelectedValue = loaimon_DTO.MALOAI;
        }
        private void LamMoiDGV()
        {
            List<clsThucDon_DTO> lsmoi = new List<clsThucDon_DTO>();
            dgvTD.DataSource = lsmoi;
        }
        private void LoadDuLieuDGV()
        {
            lstd = bustd.LayTatCaDsTD();
            dgvTD.AutoGenerateColumns = false;
            dgvTD.AutoResizeColumns();
            dgvTD.DataSource = lstd;
        }

        private void dgvTD_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvTD.Columns[e.ColumnIndex].Name == "LOAIMON")
            {
                try
                {
                    clsLoaiMon_DTO cv = lslm.First(u => u.MALOAI == e.Value.ToString());
                    e.Value = cv.TENLOAI;
                }
                catch { }
            }
            if (dgvTD.Columns[e.ColumnIndex].Name == "TRANGTHAI")
            {
                if ((int)e.Value == 1)
                    e.Value = @"Còn";
                else if ((int)e.Value == 2)
                {
                    e.Value = @"Hết";
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }
        string laytenmon = "";
        private void dgvTD_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTD.SelectedRows.Count > 0)
                {
                    // Lấy dòng được chọn
                    TrangThaiXem();
                    DataGridViewRow DongDuocChon = dgvTD.SelectedRows[0];
                    if (DongDuocChon != null)
                    {
                        clsThucDon_DTO ttnv = new clsThucDon_DTO();
                        clsThucDon_BUS busTTNV = new clsThucDon_BUS();
                        ttnv = busTTNV.LayThongTinTD(DongDuocChon.Cells["MAMON"].Value.ToString());
                        //// Hiển thị các thông tin lên groupbox Thông tin truyện
                        lblMaMon.Text = DongDuocChon.Cells["MAMON"].Value.ToString();
                        laytenmon = DongDuocChon.Cells[1].Value.ToString();
                        txtDVT.Text = ttnv.DVT.ToString();
                        txtGia.Text = string.Format("{0:#,###}", ttnv.GIA);
                        txtTenMon.Text = ttnv.TENMON.ToString();
                        cboLoaiMon.SelectedValue = ttnv.MALOAI.ToString();
                        if (ttnv.TRANGTHAI == 1)
                            rdoCon.Checked = true;
                        else
                            rdoHet.Checked = true;
                    }
                }
            }
            catch { }
        }
        private void TimKiem()
        {
            string strTen = "-1";
            string strLoai = "-1";
            string strtrangthai = "";

            if (chkTen.Checked)
            {
                if (txtTenvaMa.Text == "")
                    strTen = "-1";
                else
                strTen = txtTenvaMa.Text;
            }

            if (chkLoai.Checked)
            {
                if (cboloaimontk.SelectedValue.ToString() == "")
                    strLoai = "-1";
                else strLoai = cboloaimontk.SelectedValue.ToString();
            }

            if (chktinhtrang.Checked)
            {
                strtrangthai = cboTinhTrang.SelectedValue.ToString();
            }
            List<clsThucDon_DTO> lsNV = new List<clsThucDon_DTO>();
            
                //if (txtTenvaMa.Text == "")
                //    lsNV = bustd.LayTatCaDsTD();
                //else
                //{
                    // Gọi lấy dữ từ CSDL
                    dgvTD.AutoGenerateColumns = false;
                    dgvTD.AutoResizeColumns();

                    lsNV = bustd.LayDsThucDon(strTen,strLoai,strtrangthai);
                //}
            
             dgvTD.DataSource = lsNV;
        }

        private void chkLoai_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLoai.Checked)
                cboloaimontk.Enabled = true;
            else
            {
                cboloaimontk.Text = "Chọn loại món";
                cboloaimontk.Enabled = false;
            }
        }

        private void cboloaimontk_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TimKiem();
            }
            catch { }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                TimKiem();
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            iTrangThai = 1;
            dgvTD.Enabled = false;
            TrangThaiThem();
    
        }

        private int GiuDong(string maMON, DataGridView x, string tencot)
        {
            int dong = 0;
            for (int i = 0; i < x.Rows.Count; i++)
            {
                if (maMON == x.Rows[i].Cells[tencot].Value.ToString())
                    dong = i;
            }
            return dong;
        }
        private void ctmDoi_Click(object sender, EventArgs e)
        {
            int dong = 0;
            if (dgvTD.SelectedRows.Count > 0)
            {
                DataGridViewRow DongDuocChon = dgvTD.SelectedRows[0];
                string mamon = DongDuocChon.Cells["MAMON"].Value.ToString();
                if ((int)DongDuocChon.Cells["TRANGTHAI"].Value == 2)
                {
                    if (bustd.UpdateTrangThai(1, mamon) == true)
                        MessageBox.Show("Đổi Trạng thái --- Còn --- thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Lỗi");
                }
                else
                {
                    if (bustd.UpdateTrangThai(2, mamon) == true)
                        MessageBox.Show("Đổi Trạng thái --- Hết --- thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Lỗi");
                }
                dong = GiuDong(mamon, dgvTD, "MAMON");
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn món", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            LamMoiDGV();
            LoadDuLieuDGV();
            dgvTD.Rows[dong].Selected = true;
            dgvTD.FirstDisplayedScrollingRowIndex = dong;
        }

        private bool XetDieuKienChinhSuaNV()
        {
            bool kq = true;
            string bienbao = "";
            if (txtTenMon.Text == "")
                bienbao += "Tên Món \n";
            if (txtGia.Text == "")
                bienbao += "Giá \n";
            if (txtDVT.Text == "")
                bienbao += "Đơn vị tính \n";
            if (bienbao != "")
            {
                MessageBox.Show("Bạn chưa nhập Thông tin: \n" + bienbao + "\n" + "Xin Vui Lòng Nhập Lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kq = false;
            }
            if (iTrangThai == 1)
            {
                for (int i = 0; i < dgvTD.Rows.Count; i++)
                {
                    if (txtTenMon.Text == dgvTD.Rows[i].Cells[1].Value.ToString())
                    {

                        MessageBox.Show("Món " + txtTenMon.Text + " đã có, bạn hãy kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        kq = false;
                    }
                }
            }
            if (iTrangThai == 2)
            {
                if (txtTenMon.Text != laytenmon)
                {
                    for (int i = 0; i < dgvTD.Rows.Count; i++)
                    {

                        if (txtTenMon.Text == dgvTD.Rows[i].Cells[1].Value.ToString())
                        {

                            MessageBox.Show("Món " + txtTenMon.Text + " đã có, bạn hãy kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            kq = false;
                        }
                    }
                }
            }

            return kq;
        }


        private void TrangThaiXem()
        {
            grpThongTin.Enabled = false;
            grpTimKiem.Enabled = true;
            btnLammoi.Enabled = true;
          

            btnLuu.Enabled = false;
            //btnLammoi.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }


        private void TrangThaiSua()
        {
            grpThongTin.Enabled = true;
            grpTimKiem.Enabled = false;
            //btnLammoi.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void TrangThaiThem()
        {
            grpThongTin.Enabled = true;
            grpTimKiem.Enabled = false;
            txtDVT.Clear();
            txtGia.Clear();
            dgvTD.ClearSelection();
            button1.Enabled = false;
            txtTenMon.Clear();
            lblMaMon.Text = PhatSinhMaMon();
            btnLammoi.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            
            btnHuy.Enabled = true;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            iTrangThai = 2;
            dgvTD.Enabled = false;
            button1.Enabled = false;
            TrangThaiSua();
         
        }


        private string PhatSinhMaMon()
        {
            string Auto_MaMon = "M";
            clsThucDon_BUS bus = new clsThucDon_BUS();
            string chuoi = bus.PhatSinhMaMon();
            //count = chuoi + 1;
            int count = int.Parse(chuoi.Substring(2)) + 1;
            if (count < 10)
                Auto_MaMon += "00" + count.ToString();
            else if (count < 100)
                Auto_MaMon += "0" + count.ToString();
            else if (count < 1000)
                Auto_MaMon += "" + count.ToString();
            else
                Auto_MaMon += count.ToString();
            return Auto_MaMon;
        }

        private void ScrollTo(string ma)
        {

            int idx = -1;
            for (int i = 0; i < dgvTD.Rows.Count; i++)
            {
                if (ma.ToString() == dgvTD.Rows[i].Cells["MAMON"].Value.ToString())
                {
                    idx = i;
                    break;
                }
            }

            if (idx == -1 && dgvTD.Rows.Count > 0)
            {
                idx = 0;
                return;
            }

            dgvTD.ClearSelection();
            dgvTD.Rows[idx].Selected = true;
            dgvTD.FirstDisplayedScrollingRowIndex = idx;
        }
        private bool kiemtrathongtin()
        {
            bool kq = true;
            string str = "";
            if(txtTenMon.Text=="")
            {
                str = "Tên món";
            }
            if(txtDVT.Text=="")
            {
                str = "DVT";
            }
            if(txtGia.Text=="")
            {
                str = "Gia";
            }
            if(str!="")
            {
                str = "Bạn chưa nhập" + str + "\n";
                return kq = false;
            }
            return kq;
        }
        private void TrangThaiTXSXong()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            //btnLammoi.Enabled = false;
            dgvTD.Enabled = true;
            btnHuy.Enabled = false;
            button1.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                clsThucDon_DTO td = new clsThucDon_DTO();
                td.TENMON = txtTenMon.Text.ToString();
                td.MALOAI = cboLoaiMon.SelectedValue.ToString();
                td.GIA = decimal.Parse(txtGia.Text);

                td.DVT = txtDVT.Text;
                if (rdoCon.Checked)
                    td.TRANGTHAI = 1;
                else if (rdoHet.Checked)
                    td.TRANGTHAI = 2;
                //td.TRANGTHAI = 1;
                if (XetDieuKienChinhSuaNV() != false)
                {
                    if (iTrangThai == 1) // Thêm
                    {
                        td.MAMON = "-1";
                        td.MAMON = PhatSinhMaMon().ToString();

                        bustd.ThemTD(td);

                        if (td.MAMON != "-1")
                            TimKiem();
                        else
                            MessageBox.Show("Thêm thất bại");
                        TrangThaiXem();

                    }
                    else if (iTrangThai == 2) // Sửa
                    {
                        td.MAMON = lblMaMon.Text;
                        bool kq = bustd.SuaTD(td);

                        if (kq)
                            TimKiem();
                        else
                            MessageBox.Show("Sửa thất bại");
                        TrangThaiXem();

                    }
                    ScrollTo(td.MAMON);
                    TrangThaiTXSXong();
                }
                
            }
            catch { XetDieuKienChinhSuaNV().ToString(); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Bạn muốn xóa Món \"{0}\" không?", lblMaMon.Text),
            "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Xử lý xóa
                string Mamon = lblMaMon.Text;
                bool kq = bustd.XoaTD(Mamon);
                if (kq)
                    TimKiem();
                else
                    MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TrangThaiXem();
            if (iTrangThai == 2)
                dgvTD_SelectionChanged(sender, e);
            else
            {
                dgvTD.Rows[0].Selected = true;
                dgvTD_SelectionChanged(sender, e);
            }
            TrangThaiTXSXong();
        }

        private void frmQL_ThucDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double GiaNhap = double.Parse(txtGia.Text.Replace(",", ""));
                txtGia.Text = GiaNhap.ToString("0,00.##");
                txtGia.Select(txtGia.TextLength, 0);
            }
            catch (Exception) { return; }
            {

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
            if (keyData == Keys.F7)
            {
                if (button1.Enabled == true)
                    ctmDoi_Click(null, null);
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTen.Checked == true)
            {
                txtTenvaMa.Enabled = true;
            }
            else
            {
                txtTenvaMa.Enabled = false;
                txtTenvaMa.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chktinhtrang.Checked == true)
            {
                cboTinhTrang.Enabled = true;
            }
            else
            {
                cboTinhTrang.Enabled = false;
                cboTinhTrang.Text = "Chọn tình trạng";
            }
        }

        private void txtTenvaMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            TimKiem();
        }

        private void cboloaimontk_SelectedValueChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void cboTinhTrang_SelectedValueChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            chkLoai.Checked = false;
            chkTen.Checked = false;
            chktinhtrang.Checked = false;
            TimKiem();
        }

        private void txtTenvaMa_KeyUp(object sender, KeyEventArgs e)
        {
            TimKiem();
        }

        private void txtTenMon_Leave(object sender, EventArgs e)
        {
            txtTenMon.Text = chuyendoichuthuongthanhchuhoa().ToString();
        }

        private void txtDVT_Leave(object sender, EventArgs e)
        {

        }

        private void txtDVT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
