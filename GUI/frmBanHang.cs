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
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Threading;

namespace GUI
{
	public partial class frmBanHang : Form
	{
		private clsBan_BUS busBan = new clsBan_BUS();
		private List<clsBan_DTO> lsban;
		private clsThucDon_BUS busTD = new clsThucDon_BUS();
		private List<clsThucDon_DTO> lsTD;
		private clsCTHDBan_BUS busCTHD = new clsCTHDBan_BUS();
		private clsCTBan_BUS busCTBan = new clsCTBan_BUS();
		private DataTable lsCTBan = new DataTable();
		private clsCTBan_DTO ctb = new clsCTBan_DTO();
		private clsHoaDonBan_BUS bushd = new clsHoaDonBan_BUS();
		private clsThucDon_DTO td = new clsThucDon_DTO();
		private clsCTHDBan_DTO cthd = new clsCTHDBan_DTO();
		private List<clsLoaiMon_DTO> lsLM = new List<clsLoaiMon_DTO>();
		private clsLoaiMon_BUS buslm = new clsLoaiMon_BUS();
		private clsKhachHang_BUS buskh = new clsKhachHang_BUS();
		private static frmBanHang _Instance = null;
		DataView dtvThucDon = new DataView();
		public delegate void NewHome();
		public event NewHome OnNewHome;
		SqlConnection con = null;
		public static frmBanHang Instance
		{
			get
			{
				if (_Instance == null)
				{
					_Instance = new frmBanHang();
				}
				return _Instance;
			}
		}

		public frmBanHang()
		{
			InitializeComponent();
			try
			{
				SqlClientPermission ss = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
				ss.Demand();
			}
			catch (Exception)
			{

				throw;
			}
			con = busBan.Khoitao();
		}


		private int TimViTriSelectLVI(string maban, ListView lvigiu)
		{
			int vt = 0;
			for (int i = 0; i < lvigiu.Items.Count; i++)
			{
				if (lvigiu.Items[i].SubItems[1].Text == maban)
					vt = i;
			}
			return vt;
		}

		private void GiuViTriConTro(string maban, ListView lvigiu)
		{
			try
			{
				int a = TimViTriSelectLVI(maban, lvigiu);
				lvigiu.Items[a].Selected = true;
				lvigiu.Items[a].Focused = true;
				lblBan.Text = lvigiu.FocusedItem.SubItems[0].Text;
				lviBan_MouseClick(null, null);
			}
			catch { }
		}

		private void ChonViTriDauTrongLVI(ListView lvi)
		{
			try
			{
				lvi.Items[0].Selected = true;
				lvi.Items[0].Focused = true;
				lblBan.Text = lvi.Items[0].SubItems[0].Text;
				LoadDuLieuDGV();
				timerBan.Start();
			}
			catch { }
		}
		public void LoadLVI()
		{

			lviBan.Items.Clear();
			lsban = busBan.LayTatCaDsBan();
			for (int i = 0; i < lsban.Count; i++)
			{
				if (lsban[i].TRANGTHAI != 0)
				{
					ListViewItem lvi = new ListViewItem(lsban[i].TENBAN.ToString().Trim());
					lvi.SubItems.Add(lsban[i].MABAN.ToString());
					lvi.SubItems.Add(lsban[i].TRANGTHAI.ToString());
					lvi.ImageIndex = 0;
					lviBan.Items.Add(lvi);
				}

				if (lviBan.Items[i].SubItems[2].Text == "1")
				{
					lviBan.Items[i].ImageIndex = 0;
				}
				else if (lviBan.Items[i].SubItems[2].Text == "2")
				{
					lviBan.Items[i].ImageIndex = 1;
				}
			}

		}
		public void Form1_OnNewHome()//kiem tra du lieu sql moi lan thay dổi
		{
			ISynchronizeInvoke i = (ISynchronizeInvoke)this;
			if (i.InvokeRequired)//tab
			{
				NewHome dd = new NewHome(Form1_OnNewHome);
				i.BeginInvoke(dd, null);
				return;
			}

			LoadDuLieuLVI();

		}
		private void frmBanHang_Load(object sender, EventArgs e)
		{
			lsLM = buslm.LayTatCaLoaiMon();
			OnNewHome += new NewHome(Form1_OnNewHome);
			cboTheloai_TK.DataSource = lsLM;
			clsLoaiMon_DTO TatCaMon = new clsLoaiMon_DTO();
			TatCaMon.MALOAI = "";
			TatCaMon.TENLOAI = "Tất cả";
			lsLM.Add(TatCaMon);

			cboTheloai_TK.ValueMember = "MALOAI";
			cboTheloai_TK.DisplayMember = "TENLOAI";
			cboTheloai_TK.SelectedValue = TatCaMon.MALOAI;

			LoadDuLieuLVI();
			LoadDuLieuDGVTD();
			ChonViTriDauTrongLVI(lviBan);

			lblTongTien.Text = string.Format("{0:#,###}", TinhTongTien());
			txtTongTien.Text = string.Format("{0:#,###}", TinhTongTien());
			if (dgvBan.Rows.Count <= 0)
			{
				lblTongTien.Text = "0";
				txtTongTien.Text = "0";
			}
			txtMaKH.Text = "KH0000";
			txtSoLuong.Text = "1";
			LoadTrangThaiBanDauKhiChuaLuu();
			chkten.Checked = true;
			chktheloai.Checked = false;
			cboTheloai_TK.Enabled = false;
		}

		public void LoadDuLieuDGVTD()
		{
			lsTD = busTD.LayTatCaDsTD();

			dgvThucDon.AutoGenerateColumns = false;
			dgvThucDon.AutoResizeColumns();
			dgvThucDon.DataSource = lsTD;
		}
		private void LoadDuLieuDGV()
		{
			try
			{
				string mahd = null;
				string maban = lviBan.FocusedItem.SubItems[1].Text;

				clsBan_DTO ban = busBan.LayThongTinBan(maban);
				if (ban.TRANGTHAI == 1)
				{

					mahd = KiemTraHoaDonTrongBanCoTonTaiKhong(maban);
					lsCTBan = busCTHD.LayCTHD(mahd);
					if (dgvBan.Rows.Count > 0)
					{
						lblTongTien.Text = string.Format("{0:#,###}", TinhTongTien());
						txtTongTien.Text = string.Format("{0:#,###}", TinhTongTien());
					}
					else if (dgvBan.Rows.Count >= 0)
					{
						lblTongTien.Text = "0";
						txtTongTien.Text = "0";
					}
				}
				else
				{
					lsCTBan.Clear();

				}

				dgvBan.AutoGenerateColumns = false;
				dgvBan.AutoResizeColumns();
				dgvBan.DataSource = lsCTBan;
			}
			catch { }
		}

		public void LoadDuLieuLVI()
		{
			try
			{
				DataTable dt = new DataTable();
				dt = busBan.LayDSBan(con, de_OnChange);
				List<clsBan_DTO> list = new List<clsBan_DTO>();
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					clsBan_DTO ban = new clsBan_DTO();
					ban.MABAN = dt.Rows[i]["MABAN"].ToString();
					ban.TENBAN = dt.Rows[i]["TENBAN"].ToString();
					ban.TRANGTHAI = int.Parse(dt.Rows[i]["TRANGTHAI"].ToString());
					list.Add(ban);
				}

				lviBan.Items.Clear();
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].TRANGTHAI != 0)
					{
						ListViewItem lvi = new ListViewItem(list[i].TENBAN.ToString().Trim());
						lvi.SubItems.Add(list[i].MABAN.ToString());
						lvi.SubItems.Add(list[i].TRANGTHAI.ToString());
						lvi.ImageIndex = 0;
						lviBan.Items.Add(lvi);
					}



					if (lviBan.Items[i].SubItems[2].Text == "1")
					{
						lviBan.Items[i].ImageIndex = 0;
					}
					else if (lviBan.Items[i].SubItems[2].Text == "2")
					{
						lviBan.Items[i].ImageIndex = 1;
					}

				}

				if (maban != "")
				{
					GiuViTriConTro(maban, lviBan);
				}

			}
			catch
			{
			}

		}
		public void de_OnChange(object sender, SqlNotificationEventArgs e)
		{
			SqlDependency de = sender as SqlDependency;
			de.OnChange -= de_OnChange;

			if (OnNewHome != null)
			{
				OnNewHome();
			}
		}

		private decimal TinhTongTien()
		{
			decimal tt = 0;
			for (int i = 0; i < dgvBan.Rows.Count; i++)
			{
				tt += decimal.Parse(dgvBan["colTHANHTIEN", i].Value.ToString());
			}

			return tt;
		}

		private void lviBan_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				LoadTrangThaiBanDauKhiChuaLuu();
				if (lviBan.Items.Count > 0)
				{
					for (int i = 0; i < lviBan.Items.Count; i++)
					{

						if (lviBan.Items[i].Selected == true)
						{
							lviBan.Items[i].BackColor = Color.FromArgb(200, 113, 55);
							lviBan.Items[i].SubItems[0].ForeColor = Color.White;

						}
						else
						{
							lviBan.Items[i].BackColor = Color.White;
							lviBan.Items[i].SubItems[0].ForeColor = Color.Black;
						}
					}


					lblBan.Text = lviBan.FocusedItem.SubItems[0].Text;


					try
					{
						LoadDuLieuDGV();

					}
					catch { }
					timerBan.Start();
				}



			}
			catch { }

			LoadTrangThaiBanDauKhiChuaLuu();
			lblTongTien.Text = string.Format("{0:#,###}", TinhTongTien());
			txtTongTien.Text = string.Format("{0:#,###}", TinhTongTien());

		}



		private void dgvBan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvBan.Rows.Count > 0)
			{
				for (int i = 0; i < dgvBan.Rows.Count; i++)
				{
					dgvBan.Rows[i].Cells["colSTT"].Value = i + 1;
				}

				if (dgvBan.Columns[e.ColumnIndex].Name == "colTENMON")
				{
					clsThucDon_DTO cv = lsTD.First(u => u.MAMON == e.Value.ToString());
					e.Value = cv.TENMON;
				}
			}
		}
		private clsThucDon_DTO GetA()
		{
			clsThucDon_DTO a = new clsThucDon_DTO();
			if (dgvThucDon.RowCount > 0)
			{
				int b = dgvThucDon.CurrentRow.Index;
				string ma = dgvThucDon.Rows[b].Cells["MAMON"].Value.ToString();
				a = busTD.LayThongTinTD(ma);

			}
			return a;
		}
		public void ThemMonMoi(string mahd)
		{
			try
			{
				clsThucDon_DTO a = GetA();
				DataRow d = lsCTBan.NewRow();
				d["MAMON"] = a.MAMON;
				d["DVT"] = a.DVT;
				d["GIA"] = a.GIA;
				d["SOLUONG"] = int.Parse(txtSoLuong.Text);
				d["THANHTIEN"] = a.GIA * int.Parse(txtSoLuong.Text);
				lsCTBan.Rows.Add(d);

				clsCTHDBan_DTO cthdb = new clsCTHDBan_DTO();
				cthdb.MAMON = a.MAMON;
				cthdb.MAHD = mahd;
				cthdb.SOLUONG = int.Parse(txtSoLuong.Text);
				cthdb.GIA = decimal.Parse(a.GIA.ToString());
				cthdb.GHICHU = "";
				busCTHD.LapChiTietHoaDon(cthdb.MAHD, cthdb.MAMON, cthdb.SOLUONG, cthdb.GIA, cthdb.GHICHU);

			}
			catch
			{
				MessageBox.Show("Kiểm tra thông tin số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		private string PhatSinhMaHD()
		{
			string Auto_MaHD = "HD";
			clsHoaDonBan_BUS bus = new clsHoaDonBan_BUS();
			string chuoi = bus.PhatSinhMaHD();
			int count = int.Parse(chuoi.Substring(2)) + 1;
			if (count < 10)
				Auto_MaHD += "000" + count.ToString();
			else if (count < 100)
				Auto_MaHD += "00" + count.ToString();
			else if (count < 1000)
				Auto_MaHD += "0" + count.ToString();
			else
				Auto_MaHD += count.ToString();
			return Auto_MaHD;
		}

		private string PhatSinhMaBan()
		{
			string Auto_MaBan = "B";
			clsBan_BUS bus = new clsBan_BUS();
			string chuoi = bus.PhatSinhMaBan();
			int count = int.Parse(chuoi.Substring(1)) + 1;
			if (count < 10)
				Auto_MaBan += "0" + count.ToString();
			else
				Auto_MaBan += count.ToString();
			return Auto_MaBan;
		}

		private string KiemTraHoaDonTrongBanCoTonTaiKhong(string maban)
		{
			string mahd = null;
			DataTable dshd = new DataTable();
			dshd = bushd.LayDSHDBANCAULENH(string.Format("SELECT * FROM HOADONBAN WHERE TRANGTHAI = 3 AND MABAN = '{0}'", maban));

			for (int i = 0; i < dshd.Rows.Count; i++)
			{
				if (maban == dshd.Rows[i].Field<string>("MABAN").ToString())
				{
					mahd = dshd.Rows[i].Field<string>("MAHD").ToString();
					break;
				}
				else
				{

				}
			}
			return mahd;
		}
		private void btnLuu_Click(object sender, EventArgs e)
		{
			try
			{
				string mabandangchon = lviBan.FocusedItem.SubItems[1].Text.ToString();
				if (dgvBan.RowCount < 1)
				{
					MessageBox.Show("Không có món nào được sử dụng\nVui lòng kiểm tra lại chi tiết bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{

					string mahdkt = null;
					mahdkt = KiemTraHoaDonTrongBanCoTonTaiKhong(mabandangchon);
					if (mahdkt != null)
					{
						DataTable sa = new DataTable();
						sa = busCTHD.LayCTHDCAULENH(string.Format("SELECT * FROM CTHDBan WHERE MAHD = '{0}'", mahdkt));

						busCTHD.XoaCTHD(mahdkt);
						int n = dgvBan.Rows.Count;

						for (int i = 0; i < n; i++)
						{
							bool kq = true;
							DataGridViewRow r = dgvBan.SelectedRows[0];
							clsCTHDBan_DTO cthdb = new clsCTHDBan_DTO();
							cthdb.MAMON = r.Cells[1].Value.ToString();
							cthdb.MAHD = mahdkt;
							cthdb.SOLUONG = (int)r.Cells[4].Value;
							cthdb.GIA = (decimal)r.Cells[3].Value;

							cthdb.GHICHU = r.Cells[6].Value.ToString();

							for (int j = 0; j < sa.Rows.Count; j++)
							{
								string x = sa.Rows[j].Field<string>("MAHD").ToString();
								string b = sa.Rows[j].Field<string>("MAMON").ToString();
								if ((mahdkt == x) && (cthdb.MAMON == b))
								{
									kq = false;
								}
							}
							if (kq == true)
							{
								busCTHD.LapChiTietHoaDon(cthdb.MAHD, cthdb.MAMON, cthdb.SOLUONG, cthdb.GIA, cthdb.GHICHU);
							}
							else
							{
								busCTHD.UpdateChiTietHoaDon(cthdb.MAHD, cthdb.MAMON, cthdb.SOLUONG, cthdb.GIA, cthdb.GHICHU);

							}
							dgvBan.Rows.RemoveAt(0);
						}
					}
					else
					{
						MessageBox.Show("Bàn chưa mở nên không lưu được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch
			{
				MessageBox.Show("Bạn chưa chọn bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			LoadDuLieuDGV();

		}


		private void ResetForm(Control Parent)
		{
			foreach (Control mycontrols in Parent.Controls)
			{
				if (mycontrols is TextBox)
				{
					(mycontrols as TextBox).Text = string.Empty;
				}
				else if (mycontrols is DateTimePicker)
				{
					(mycontrols as DateTimePicker).Value = DateTime.Now;
				}
				else if (mycontrols is ComboBox)
				{
					(mycontrols as ComboBox).SelectedIndex = -1;
				}
				else if (mycontrols is RadioButton)
				{
					(mycontrols as RadioButton).Checked = false;
				}
			}
		}

		private clsHoaDonBan_DTO GanGiaTriChoHoaDon(string mahd)
		{
			clsHoaDonBan_DTO hd = new clsHoaDonBan_DTO();
			DataTable dshd = new DataTable();
			dshd = bushd.LayDSHDBANCAULENH(string.Format("SELECT * FROM HOADONBAN WHERE MAHD = '{0}'", mahd));
			for (int i = 0; i < 1; i++)
			{
				hd.MAHDX = dshd.Rows[i].Field<string>("MAHD").ToString();
				hd.TONGTIEN = dshd.Rows[i].Field<decimal>("TONGTIEN");
				hd.MAKH = dshd.Rows[i].Field<string>("MAKH");
				hd.MANV = dshd.Rows[i].Field<string>("MANV");
				hd.NGAYXUAT = dshd.Rows[i].Field<DateTime>("NGAYXUAT");

				hd.MaBan = dshd.Rows[i].Field<string>("MABAN");
				hd.TrangThai = dshd.Rows[i].Field<int>("TRANGTHAI");
				hd.GioKetThuc = dshd.Rows[i].Field<DateTime>("GIOKETTHUC");
				hd.GioBatDau = dshd.Rows[i].Field<DateTime>("GIOBATDAU");
			}
			return hd;
		}
		private void btnThanhToan_Click(object sender, EventArgs e)
		{
			try
			{
				if (decimal.Parse(txtTienKhachDua.Text.ToString()) >= decimal.Parse(lblTongTien.Text.ToString()) || txtTienKhachDua.Text.ToString() == 0.ToString())
				{
					if (dgvBan.Rows.Count > 0)
					{
						if (MessageBox.Show("Bạn có muốn thanh toán", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
						{
							if (dgvBan.Rows.Count > 0)
							{

								DataTable ctb = new DataTable();
								string maban = lviBan.FocusedItem.SubItems[1].Text;
								string mahd = null;
								mahd = KiemTraHoaDonTrongBanCoTonTaiKhong(maban);
								if (mahd != null)
								{
									ctb = busCTHD.LayCTHD(mahd);

									clsCTHDBan_DTO cthd = new clsCTHDBan_DTO();
									clsHoaDonBan_DTO hd = new clsHoaDonBan_DTO();
									int n = dgvBan.Rows.Count;
									hd.MAHDX = mahd;
									hd.TONGTIEN = Convert.ToDecimal(lblTongTien.Text);
									hd.MAKH = txtMaKH.Text;
									hd.MANV = frmDangNhap._User.ToString().Trim();
									hd.NGAYXUAT = (DateTime)System.DateTime.Now;
									hd.TenBan = lviBan.FocusedItem.SubItems[0].Text;
									hd.MaBan = maban;
									//hd.TrangThai = xntt.LayTrangThaiHoaDon(); todo
									hd.GioKetThuc = ((DateTime)System.DateTime.Now);
									bool kq = false;
									kq = bushd.UpdateHoaDon(hd);
									if (kq == true)
									{
										clsHoaDonBan_DTO showhd = GanGiaTriChoHoaDon(mahd);
										showhd.TenNV = frmMain.tennv;
										showhd.TenBan = hd.TenBan;
										showhd.TrangThai = hd.TrangThai;
										if (txtTienGiamGia.Text == "")
											txtTienGiamGia.Text = "0";
										//frmBaoCaoHDBan hdban = new frmBaoCaoHDBan(showhd, decimal.Parse(txtTongTien.Text), int.Parse(lblphantram.Text), decimal.Parse(txtTienGiamGia.Text));
										//hdban.ShowDialog();

									}


								}

								HuyBan();
								lblTongTien.Text = "0";
								txtTongTien.Text = "0";
							}
						}
					}
					else
					{
						MessageBox.Show("Bàn này chưa thể thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("Tiền khách đưa không được nhỏ hơn tiền thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch
			{
				MessageBox.Show("Bàn này chưa thể thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ctmTaoBan_Click(object sender, EventArgs e)
		{
			//todo
			//string mabandangchon = lviBan.FocusedItem.SubItems[1].Text;
			//string maban = PhatSinhMaBan();
			//frmThemBan frm_TB = new frmThemBan(maban);
			//frm_TB.ShowDialog();
			//if (frm_TB.DialogResult == DialogResult.Yes)
			//{
			//	bool kq2 = false;
			//	string tenban = null;
			//	tenban = frm_TB.LayTenBan();
			//	clsBan_DTO laytenban = new clsBan_DTO();
			//	laytenban = busBan.LayThongTinBanTruyVan(string.Format("SELECT * FROM BAN WHERE TRANGTHAI != 0 AND TENBAN = '{0}'", tenban));

			//	if (laytenban.TENBAN == null)
			//	{
			//		kq2 = busBan.ThemBan(maban, tenban); ;
			//		if (kq2 == true)
			//		{
			//			MessageBox.Show("Thêm bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//		}
			//		LoadDuLieuLVI();
			//		GiuViTriConTro(maban, lviBan);
			//		LoadDuLieuDGV();
			//		txtTongTien.Text = "0";
			//		lblTongTien.Text = "0";
			//	}
			//	else
			//	{
			//		MessageBox.Show("Bàn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//		LoadDuLieuLVI();
			//		GiuViTriConTro(mabandangchon, lviBan);
			//	}
			//}
			//else
			//{
			//	LoadDuLieuLVI();
			//	GiuViTriConTro(mabandangchon, lviBan);
			//}
		}

		private void frmBanHang_FormClosed(object sender, FormClosedEventArgs e)
		{
			_Instance = null;
		}

		private void dgvThucDon_DoubleClick(object sender, EventArgs e)
		{
			try
			{
				LoadTrangThaiBanDauKhiChuaLuu();
				LoadTrangThaiBanDauKhiChuaLuu();
				string tenbanchuamo = lviBan.FocusedItem.SubItems[0].Text;
				if (lviBan.FocusedItem.SubItems[2].Text != "1")
				{
					frmXacNhan xacnhan = new frmXacNhan(tenbanchuamo + " chưa mở,bạn có muốn mở không ???", "Đồng ý", "Hủy bỏ");
					xacnhan.ShowDialog();
					if (xacnhan.DialogResult == DialogResult.Yes)
					{
						ctmMoBan_Click(sender, e);
					}

				}
				else
				{
					string mahdkt = null;
					mahdkt = KiemTraHoaDonTrongBanCoTonTaiKhong(lviBan.FocusedItem.SubItems[1].Text);

					if (GetA().TRANGTHAI == 2)
					{
						MessageBox.Show("Món này đã hết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

					}
					else
					{
						if (dgvBan.Rows.Count > 0)
						{
							if (GetA().TRANGTHAI == 2)
							{
								MessageBox.Show("Món này đã hết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							else
							{


								bool kq = false;
								int idx = 0;
								for (int i = 0; i < dgvBan.RowCount; i++)
								{
									int b = dgvThucDon.CurrentRow.Index;
									if (dgvThucDon.Rows[b].Cells[1].Value.ToString() == dgvBan.Rows[i].Cells[1].Value.ToString())
									{
										kq = true;
										idx = i;
									}
								}

								if (kq == true)
								{
									try
									{

										int sl = (int)dgvBan.Rows[idx].Cells[4].Value + int.Parse(txtSoLuong.Text);
										dgvBan.Rows[idx].Cells[4].Value = sl;
										decimal tt = sl * (decimal)dgvBan.Rows[idx].Cells[3].Value;
										dgvBan.Rows[idx].Cells[5].Value = tt;

										clsCTHDBan_DTO cthdb = new clsCTHDBan_DTO();
										cthdb.MAMON = dgvBan.Rows[idx].Cells[1].Value.ToString();
										cthdb.MAHD = mahdkt;
										cthdb.SOLUONG = sl;
										cthdb.GIA = (decimal)dgvBan.Rows[idx].Cells[3].Value;
										cthdb.GHICHU = "";

										busCTHD.UpdateChiTietHoaDon(cthdb.MAHD, cthdb.MAMON, cthdb.SOLUONG, cthdb.GIA, cthdb.GHICHU);

									}
									catch
									{
										MessageBox.Show("Kiểm tra thông tin số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

									}

								}
								else
								{
									ThemMonMoi(mahdkt);

								}
							}
						}
						else
						{
							ThemMonMoi(mahdkt);
						}
					}
				}

				dgvBan.DataSource = lsCTBan;
				txtSoLuong.Text = "1";
				lblTongTien.Text = string.Format("{0:#,###}", TinhTongTien());
				txtTongTien.Text = string.Format("{0:#,###}", TinhTongTien());
			}
			catch { }
		}
		string maban = "";
		string tenban = "";
		private void ctmMoBan_Click(object sender, EventArgs e)
		{
			string trangthaiban = lviBan.FocusedItem.SubItems[2].Text;
			maban = lviBan.FocusedItem.SubItems[1].Text;
			tenban = lviBan.FocusedItem.SubItems[0].Text;


			if (trangthaiban == "2")
			{
				busBan.MoBan(maban);

				clsHoaDonBan_DTO hd = new clsHoaDonBan_DTO();
				hd.MAHDX = PhatSinhMaHD();

				hd.GioBatDau = (DateTime)System.DateTime.Now;
				hd.TONGTIEN = 0;
				hd.MANV = frmDangNhap._User.ToString().Trim();
				hd.NGAYXUAT = (DateTime)System.DateTime.Now;
				hd.TenBan = tenban;
				hd.MaBan = maban;
				hd.TrangThai = 3; /* Trạng thái hóa đơn lúc mở bàn là trạng thái hóa đơn đang sử dụng*/

				bool kq = false;
				kq = bushd.LapHoaDonTamThoi(hd);

			}
			else if (trangthaiban == "1")
			{
				MessageBox.Show("Bàn đã mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			LoadDuLieuLVI();
			LoadDuLieuDGV();
		}

		private void HuyBan()
		{
			string trangthaiban = lviBan.FocusedItem.SubItems[2].Text;
			string maban = lviBan.FocusedItem.SubItems[1].Text;
			string tenban = lviBan.FocusedItem.SubItems[0].Text;
			if (trangthaiban == "1")
			{

				busBan.HuyBan(maban);
			}
			else
			{
				MessageBox.Show("Bàn này chưa mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


			LoadDuLieuDGV();
			LoadDuLieuLVI();
			GiuViTriConTro(maban, lviBan);
		}
		private void ctmxoaban_Click(object sender, EventArgs e)
		{
			try
			{
				string trangthaiban = lviBan.FocusedItem.SubItems[2].Text;
				maban = lviBan.FocusedItem.SubItems[1].Text;
				tenban = lviBan.FocusedItem.SubItems[0].Text;
				string mahd = null;
				mahd = KiemTraHoaDonTrongBanCoTonTaiKhong(maban);
				if (trangthaiban == "1")
				{
					if (mahd != null)
					{
						frmXacNhan xacnhan = new frmXacNhan("Bạn có muốn hủy bàn " + tenban + " không ???", "Đồng ý", "Hủy bỏ");
						xacnhan.ShowDialog();
						if (xacnhan.DialogResult == DialogResult.Yes)
						{
							busBan.HuyBan(maban);
							bushd.CapNhatTrangThai(mahd, 0); /*Hủy hóa đơn*/
						}
					}
				}
				else if (trangthaiban == "2")
				{
					MessageBox.Show("Bàn này chưa mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}
				LoadDuLieuLVI();
				GiuViTriConTro(maban, lviBan);

				LoadDuLieuDGV();
				txtTongTien.Text = "0";
				lblTongTien.Text = "0";
			}
			catch
			{
				MessageBox.Show("Bạn chưa chọn bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}




		}


		private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			dgvThucDon_DoubleClick(sender, e);
		}

		private void btnGiam_Click(object sender, EventArgs e)
		{
			try
			{
				dgvBan_DoubleClick(sender, e);
			}
			catch
			{
				MessageBox.Show("Kiểm tra thông tin món cần giảm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void dgvBan_DoubleClick(object sender, EventArgs e)
		{
			LoadTrangThaiBanDauKhiChuaLuu();
			if (dgvBan.Rows.Count > 0)
			{
				string mahdkt = null;
				mahdkt = KiemTraHoaDonTrongBanCoTonTaiKhong(lviBan.FocusedItem.SubItems[1].Text);

				int idx = dgvBan.CurrentRow.Index;
				try
				{
					int sl = (int)dgvBan.Rows[idx].Cells[4].Value - int.Parse(txtSoLuong.Text);
					dgvBan.Rows[idx].Cells[4].Value = sl;
					decimal tt = sl * (decimal)dgvBan.Rows[idx].Cells[3].Value;
					dgvBan.Rows[idx].Cells[5].Value = tt;

					clsCTHDBan_DTO cthdb = new clsCTHDBan_DTO();
					cthdb.MAMON = dgvBan.Rows[idx].Cells[1].Value.ToString();
					cthdb.MAHD = mahdkt;
					cthdb.SOLUONG = sl;
					cthdb.GIA = (decimal)dgvBan.Rows[idx].Cells[3].Value;
					cthdb.GHICHU = dgvBan.Rows[idx].Cells[6].Value.ToString();
					busCTHD.UpdateChiTietHoaDon(cthdb.MAHD, cthdb.MAMON, cthdb.SOLUONG, cthdb.GIA, cthdb.GHICHU);

					if (sl == 0 || sl < 0)
					{
						dgvBan.Rows.RemoveAt(dgvBan.CurrentRow.Index);
						busCTHD.XoaCTHDCAULENH(string.Format("DELETE CTHDBan WHERE MAHD = '{0}' AND MAMON = '{1}'", cthdb.MAHD, cthdb.MAMON));
					}

				}
				catch
				{
					MessageBox.Show("Kiểm tra thông tin món cần giảm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}


			}


			dgvBan.DataSource = lsCTBan;
			txtSoLuong.Text = "1";
			lblTongTien.Text = string.Format("{0:#,###}", TinhTongTien());
			txtTongTien.Text = string.Format("{0:#,###}", TinhTongTien());
		}

		private void SapXePlaiSTT()
		{
			for (int i = 1; i <= dgvBan.Rows.Count; i++)
			{
				dgvBan["colSTT", i - 1].Value = (i < 10 ? i.ToString() : i.ToString());
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{

		}

		private void btnTaoBan_Click(object sender, EventArgs e)
		{
			ctmTaoBan_Click(sender, e);
		}

		private void btnHuyBan_Click(object sender, EventArgs e)
		{
			ctmxoaban_Click(sender, e);
		}

		private void cmsBan_MouseClick(object sender, MouseEventArgs e)
		{

		}

		private void btnMoBan_Click(object sender, EventArgs e)
		{
			ctmMoBan_Click(sender, e);
		}

		private void btnChuyenban_Click(object sender, EventArgs e)
		{
			try
			{
				string tenb = lviBan.FocusedItem.SubItems[0].Text;
				string mab = lviBan.FocusedItem.SubItems[1].Text;
				string trangthai = lviBan.FocusedItem.SubItems[2].Text;

				int BienSoSanh = SoSanhDGVvaCTBan(dgvBan, mab);
				if (trangthai == "1")
				{

					//todo
					///* 1: Là sosanhdung ,2: Là so sánh sai, 3: Chưa gọi món nên chưa có chi tiết bàn*/
					//frmChuyenBan cb = new frmChuyenBan(tenb);
					//cb.ShowDialog();
					//if (cb.DialogResult == DialogResult.Yes)
					//{
					//	string mabancanchuyen = cb.GiaTriBanDeChuyen();
					//	maban = mabancanchuyen;
					//	string mahd = KiemTraHoaDonTrongBanCoTonTaiKhong(mab);
					//	if (BienSoSanh == 1 || BienSoSanh == 3)
					//	{
					//		bushd.UpdateCAULENH(string.Format("UPDATE HOADONBAN SET MABAN = '{0}' WHERE MAHD = '{1}'", mabancanchuyen, mahd));
					//		busBan.MoBan(mabancanchuyen);
					//		HuyBan();
					//		LoadDuLieuLVI();
					//		GiuViTriConTro(mabancanchuyen, lviBan);
					//		LoadDuLieuDGV();
					//	}
					//	else
					//	{
					//		MessageBox.Show("Bạn phải lưu trước khi thực hiện thao tác này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

					//	}
					//}



				}
				else if (trangthai == "2")
				{
					MessageBox.Show("Bàn chưa mở nên không chuyển được !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}
				else
				{
					MessageBox.Show("Bàn không tồn tại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}

				if (BienSoSanh != 2)
				{
					LoadDuLieuDGV();
				}
			}
			catch
			{
				MessageBox.Show("Bạn chưa chọn bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void btnGopBan_Click(object sender, EventArgs e)
		{
			try
			{
				string tenb = lviBan.FocusedItem.SubItems[0].Text;
				string mab = lviBan.FocusedItem.SubItems[1].Text;
				string trangthai = lviBan.FocusedItem.SubItems[2].Text;
				int BienSoSanh = SoSanhDGVvaCTBan(dgvBan, mab);
				if (trangthai == "1")
				{
					//todo
					//frmGopBan gb = new frmGopBan(tenb, mab);
					//gb.ShowDialog();
					//if (gb.DialogResult == DialogResult.Yes)
					//{
					//	string mabancangop = gb.GiaTriBanDeGop();
					//	maban = mabancangop;
					//	if (BienSoSanh == 1)
					//	{
					//		string mahd = null;
					//		mahd = KiemTraHoaDonTrongBanCoTonTaiKhong(mab);
					//		string mahdbancangop;
					//		mahdbancangop = KiemTraHoaDonTrongBanCoTonTaiKhong(mabancangop);
					//		DataTable dulieubandaluu = new DataTable();
					//		dulieubandaluu = busCTHD.LayCTHD(mahd);
					//		if (dulieubandaluu.Rows.Count > 0)
					//		{
					//			bool kq = false;

					//			int n = dulieubandaluu.Rows.Count;

					//			for (int i = 0; i < n; i++)
					//			{

					//				clsCTHDBan_DTO ct = new clsCTHDBan_DTO();
					//				ct.MAHD = mahdbancangop;
					//				ct.MAMON = dulieubandaluu.Rows[i].Field<string>("MAMON").ToString();
					//				ct.SOLUONG = dulieubandaluu.Rows[i].Field<int>("SOLUONG");
					//				ct.GIA = dulieubandaluu.Rows[i].Field<decimal>("GIA");
					//				ct.GHICHU = dulieubandaluu.Rows[i].Field<string>("GHICHU");

					//				try
					//				{

					//					kq = busCTHD.LapChiTietHoaDon(ct.MAHD, ct.MAMON, ct.SOLUONG, ct.GIA, ct.GHICHU);
					//				}
					//				catch
					//				{
					//					clsCTHDBan_DTO ctb = new clsCTHDBan_DTO();
					//					ctb = busCTHD.LayCTHDclsCTHDBan_DTO(string.Format("SELECT * FROM CTHDBan WHERE MAHD = '{0}' AND MAMON = '{1}'", ct.MAHD, ct.MAMON));
					//					if (ctb.GHICHU != "" && ct.GHICHU != "")
					//					{
					//						busCTHD.UpdateChiTietHoaDon(ct.MAHD, ct.MAMON, ctb.SOLUONG + ct.SOLUONG, ctb.GIA, ctb.GHICHU + "," + ct.GHICHU);
					//					}
					//					else busCTHD.UpdateChiTietHoaDon(ct.MAHD, ct.MAMON, ctb.SOLUONG + ct.SOLUONG, ctb.GIA, ctb.GHICHU + ct.GHICHU);
					//				}
					//			}

					//			MessageBox.Show("Gộp bàn thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


					//			HuyBan();
					//			bushd.CapNhatTrangThai(mahd, 0);
					//			LoadDuLieuLVI();
					//			GiuViTriConTro(maban, lviBan);
					//			LoadDuLieuDGV();
					//		}
					//	}
					//	else if (BienSoSanh == 3)
					//	{
					//		HuyBan();
					//		string mahd = KiemTraHoaDonTrongBanCoTonTaiKhong(mab);
					//		bushd.CapNhatTrangThai(mahd, 0);
					//		LoadDuLieuLVI();
					//		GiuViTriConTro(mabancangop, lviBan);
					//		MessageBox.Show("Gộp bàn thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					//		LoadDuLieuDGV();
					//	}
					//	else
					//	{
					//		MessageBox.Show("Bạn phải lưu trước khi thực hiện thao tác này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					//	}
					//}

				}
				else
				{
					MessageBox.Show("Bàn chưa mở nên không gộp được !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				if (BienSoSanh != 2) /*Chưa lưu thì khỏi load*/
				{
					LoadDuLieuDGV();
				}

			}
			catch
			{
				MessageBox.Show("Bạn chưa chọn bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		public void TimKiem()
		{
			string strTen = "-1";
			string strMa = "-1";

			if (chkten.Checked)
			{
				if (txtTen_TK.Text == "")
					strTen = "-1";
				else
					strTen = txtTen_TK.Text;
			}

			if (chktheloai.Checked)
			{
				if (cboTheloai_TK.SelectedValue.ToString() == "")
					strMa = "-1";
				else
					strMa = cboTheloai_TK.SelectedValue.ToString();
			}

			// Gọi lấy dữ từ CSDL
			dgvThucDon.AutoGenerateColumns = false;
			dgvThucDon.AutoResizeColumns();
			List<clsThucDon_DTO> lsTD = new List<clsThucDon_DTO>();
			lsTD = busTD.LayDsThucDon(strTen, strMa);
			dgvThucDon.DataSource = lsTD;
		}

		private void bntTimKiem_Click(object sender, EventArgs e)
		{
			TimKiem();
		}

		private void ctmXoaB_Click(object sender, EventArgs e)
		{
			string maban = lviBan.FocusedItem.SubItems[1].Text;
			string tenban = lviBan.FocusedItem.SubItems[0].Text;
			frmXacNhan xacnhan = new frmXacNhan("Bạn có muốn xóa bàn " + tenban + " không ???", "Đồng ý", "Hủy bỏ");
			xacnhan.ShowDialog();

			if (xacnhan.DialogResult == DialogResult.Yes)
			{
				string mahd = KiemTraHoaDonTrongBanCoTonTaiKhong(maban);
				busBan.XoaBan(maban);
				if (mahd != null)
					bushd.CapNhatTrangThai(mahd, 0);
			}
			LoadDuLieuLVI();
			GiuViTriConTro(lviBan.Items[0].SubItems[1].Text, lviBan);
			LoadDuLieuDGV();
		}

		private void chkten_CheckedChanged(object sender, EventArgs e)
		{
			if (chkten.Checked)
				txtTen_TK.Enabled = true;
			else
				txtTen_TK.Enabled = false;
		}

		private void chktheloai_CheckedChanged(object sender, EventArgs e)
		{
			if (chktheloai.Checked)
				cboTheloai_TK.Enabled = true;
			else
				cboTheloai_TK.Enabled = false;
		}

		private void btnChonKH_Click(object sender, EventArgs e)
		{
			try
			{

				//todo
				//frmChonKH chon = new frmChonKH();
				//chon.ShowDialog();
				//if (chon.DialogResult == DialogResult.Yes)
				//{
				//	LoadTrangThaiBanDauKhiChuaLuu();
				//	txtMaKH.Text = chon.LayMaKH();
				//	txtTenKH.Text = chon.LayTenKH();
				//	clsKhachHang_DTO kh = new clsKhachHang_DTO();
				//	kh = buskh.LayThongTinNhanVien(chon.LayMaKH());

				//	lblphantram.Text = kh.CHIEUKHAU.ToString();

				//	decimal chietkhau = decimal.Parse(lblphantram.Text) / 100;

				//	decimal tientam = decimal.Parse(txtTongTien.Text) * chietkhau;
				//	txtTienGiamGia.Text = string.Format("{0:#,###}", tientam);
				//	decimal tongtien = decimal.Parse(txtTongTien.Text) - tientam;
				//	lblTongTien.Text = string.Format("{0:#,###}", tongtien);

				//}
			}
			catch { }
		}

		protected override bool ProcessDialogKey(Keys keyData)
		{
			if (keyData == Keys.F1)
			{
				btnMoBan_Click(null, null);
				return true;
			}
			if (keyData == Keys.F2)
			{
				btnHuyBan_Click(null, null);
				return true;
			}
			if (keyData == Keys.F3)
			{
				btnChuyenban_Click(null, null);
				return true;
			}
			if (keyData == Keys.F4)
			{
				btnGopBan_Click(null, null);
				return true;
			}
			if (keyData == Keys.F5)
			{
				btnTachban_Click(null, null);
				return true;
			}
			if (keyData == Keys.F6)
			{
				btnTachBill_Click(null, null);
				return true;
			}
			if (keyData == Keys.F7)
			{
				btnTaoBan_Click(null, null);
				return true;
			}
			if (keyData == Keys.F8)
			{
				btnXoa_Click(null, null);
				return true;
			}
			if (keyData == Keys.F10)
			{
				btnThanhToan_Click(null, null);
				return true;
			}



			if (keyData == Keys.NumPad0)
			{
				btn0_Click(null, null);
				return true;
			}
			if (keyData == Keys.NumPad1)
			{
				btn1_Click(null, null);
				return true;
			}
			if (keyData == Keys.NumPad2)
			{
				btn2_Click(null, null);
				return true;
			}
			if (keyData == Keys.NumPad3)
			{
				btn3_Click(null, null);
				return true;
			}
			if (keyData == Keys.NumPad4)
			{
				btn4_Click(null, null);
				return true;
			}
			if (keyData == Keys.NumPad4)
			{
				btn5_Click(null, null);
				return true;
			}
			if (keyData == Keys.NumPad4)
			{
				btn6_Click(null, null);
				return true;
			}
			if (keyData == Keys.NumPad4)
			{
				btn7_Click(null, null);
				return true;
			}
			if (keyData == Keys.NumPad4)
			{
				btn8_Click(null, null);
				return true;
			}
			if (keyData == Keys.NumPad4)
			{
				btn9_Click(null, null);
				return true;
			}
			if (keyData == Keys.Back)
			{
				btnSoXoa_Click(null, null);
				return true;
			}
			else return false;
		}

		private void LoadTrangThaiBanDauKhiChuaLuu()
		{
			txtMaKH.Text = "KH0000";
			clsKhachHang_DTO kh = new clsKhachHang_DTO();
			kh = buskh.LayThongTinNhanVien(txtMaKH.Text);
			txtTenKH.Text = kh.TENKH.ToString();
			lblphantram.Text = kh.CHIEUKHAU.ToString();
			txtTienGiamGia.Text = "0";

			txtTienKhachDua.Text = "0";
			txtTienTraKhach.Text = "0";
		}
		private void tabQLBan_Click(object sender, EventArgs e)
		{

		}

		private void txtSoLuong_TextChanged(object sender, EventArgs e)
		{
			if (txtSoLuong.Text != "")
			{

				if (int.Parse(txtSoLuong.Text) == 0)
				{
					MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtSoLuong.Text = "1";
				}
			}
		}

		private void btnTachban_Click(object sender, EventArgs e)
		{
			try
			{
				//todo
				//string tenb = lviBan.FocusedItem.SubItems[0].Text;
				//string mab = lviBan.FocusedItem.SubItems[1].Text;
				//string trangthai = lviBan.FocusedItem.SubItems[2].Text;
				//string mahd = "1";
				//mahd = KiemTraHoaDonTrongBanCoTonTaiKhong(mab);
				//frmTachBan cb = new frmTachBan(mahd, tenb, mab);
				//if (trangthai == "1")
				//{
				//	cb.ShowDialog();
				//	if (cb.DialogResult == DialogResult.Yes)
				//	{
				//		LoadDuLieuLVI();
				//		GiuViTriConTro(cb.LayBanDaDuocChuyen(), lviBan);
				//		LoadDuLieuDGV();
				//		lblTongTien.Text = string.Format("{0:#,###}", TinhTongTien());
				//		txtTongTien.Text = string.Format("{0:#,###}", TinhTongTien());
				//	}
				//}
				//else if (trangthai == "2")
				//{
				//	MessageBox.Show("Bàn chưa mở nên không tách được !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//}
				//else
				//{
				//	MessageBox.Show("Bàn không tồn tại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//}


			}
			catch
			{
				MessageBox.Show("Bạn chưa chọn bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private int SoSanhDGVvaCTBan(DataGridView dgv, string maban)
		{
			/*1: So sánh đúng, 2: So sánh sai , 3: Chưa gọi món nên chưa có chi tiết bàn*/
			int kq = 2;
			try
			{
				string mahd = null;
				mahd = KiemTraHoaDonTrongBanCoTonTaiKhong(maban);
				if (mahd != null)
				{
					DataTable dulieubandaluu = new DataTable();
					dulieubandaluu = busCTHD.LayCTHD(mahd);

					if (dulieubandaluu.Rows.Count == 0 && dgv.Rows.Count == 0)
					{
						kq = 3;
					}
					else if (dgv.Rows.Count == dulieubandaluu.Rows.Count)
					{
						for (int i = 0; i < dgv.Rows.Count; i++)
						{
							if ((int)dgv.Rows[i].Cells["colSOLUONG"].Value == dulieubandaluu.Rows[i].Field<int>("SOLUONG"))
							{
								kq = 1;
							}
							else
							{
								kq = 2;
							}
						}
					}
				}
			}
			catch
			{
				if (dgv.Rows.Count > 0)
				{
					kq = 2;
				}
				else
				{
					kq = 3;
				}
			}
			return kq;
		}

		private void btnTachBill_Click(object sender, EventArgs e)
		{
			try
			{

				//todo
				//string tenb = lviBan.FocusedItem.SubItems[0].Text;
				//string mab = lviBan.FocusedItem.SubItems[1].Text;
				//string trangthai = lviBan.FocusedItem.SubItems[2].Text;
				//string mahd = "1";
				//mahd = KiemTraHoaDonTrongBanCoTonTaiKhong(mab);
				//frmTachBill cb = new frmTachBill(mahd, mab, tenb);
				//if (trangthai == "1")
				//{
				//	cb.ShowDialog();
				//	if (cb.DialogResult == DialogResult.Yes)
				//	{
				//		LoadDuLieuLVI();
				//		GiuViTriConTro(mab, lviBan);
				//		LoadDuLieuDGV();
				//	}
				//}
				//else if (trangthai == "2")
				//{
				//	MessageBox.Show("Bàn chưa mở nên không tách được !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//}
				//else
				//{
				//	MessageBox.Show("Bàn không tồn tại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//}


			}
			catch
			{
				MessageBox.Show("Bạn chưa chọn bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void txtTen_TK_KeyDown(object sender, KeyEventArgs e)
		{
		}

		private void txtTen_TK_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		private void txtTen_TK_KeyUp(object sender, KeyEventArgs e)
		{
			TimKiem();
		}

		private void chktheloai_CheckedChanged_1(object sender, EventArgs e)
		{
			if (chktheloai.Checked)
				cboTheloai_TK.Enabled = true;
			else
				cboTheloai_TK.Enabled = false;
		}

		private void cboTheloai_TK_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void cboTheloai_TK_SelectedValueChanged(object sender, EventArgs e)
		{
			TimKiem();
		}

		private void txtChietKhau_TextChanged(object sender, EventArgs e)
		{

		}

		private void btn0_Click(object sender, EventArgs e)
		{
			if (txtTienKhachDua.Text == "0")
			{
				txtTienKhachDua.Clear();
			}
			txtTienKhachDua.Text = txtTienKhachDua.Text + "0";
		}

		private void btn1_Click(object sender, EventArgs e)
		{

			if (txtTienKhachDua.Text == "0")
			{
				txtTienKhachDua.Clear();
			}
			txtTienKhachDua.Text = txtTienKhachDua.Text + "1";

		}

		private void btn2_Click(object sender, EventArgs e)
		{

			if (txtTienKhachDua.Text == "0")
			{
				txtTienKhachDua.Clear();
			}
			txtTienKhachDua.Text = txtTienKhachDua.Text + "2";

		}

		private void btn3_Click(object sender, EventArgs e)
		{

			if (txtTienKhachDua.Text == "0")
			{
				txtTienKhachDua.Clear();
			}
			txtTienKhachDua.Text = txtTienKhachDua.Text + "3";

		}

		private void btn4_Click(object sender, EventArgs e)
		{

			if (txtTienKhachDua.Text == "0")
			{
				txtTienKhachDua.Clear();
			}
			txtTienKhachDua.Text = txtTienKhachDua.Text + "4";

		}

		private void btn5_Click(object sender, EventArgs e)
		{

			if (txtTienKhachDua.Text == "0")
			{
				txtTienKhachDua.Clear();
			}
			txtTienKhachDua.Text = txtTienKhachDua.Text + "5";

		}

		private void btn6_Click(object sender, EventArgs e)
		{

			if (txtTienKhachDua.Text == "0")
			{
				txtTienKhachDua.Clear();
			}

		}

		private void btn7_Click(object sender, EventArgs e)
		{

			if (txtTienKhachDua.Text == "0")
			{
				txtTienKhachDua.Clear();
			}
			txtTienKhachDua.Text = txtTienKhachDua.Text + "7";

		}

		private void btn8_Click(object sender, EventArgs e)
		{

			if (txtTienKhachDua.Text == "0")
			{
				txtTienKhachDua.Clear();
			}
			txtTienKhachDua.Text = txtTienKhachDua.Text + "8";

		}

		private void btn9_Click(object sender, EventArgs e)
		{

			if (txtTienKhachDua.Text == "0")
			{
				txtTienKhachDua.Clear();
			}
			txtTienKhachDua.Text = txtTienKhachDua.Text + "9";

		}

		private void btnSoXoa_Click(object sender, EventArgs e)
		{

			if (txtTienKhachDua.Text.Length > 1)
			{
				string chuoitam = txtTienKhachDua.Text;
				chuoitam = chuoitam.Substring(0, chuoitam.Length - 1);
				txtTienKhachDua.Text = chuoitam;
			}
			else
			{
				txtTienKhachDua.Text = "0";
			}

		}

		private void txtTienKhachDua_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (txtTienKhachDua.Text != "")
			{
				decimal S = decimal.Parse(txtTienKhachDua.Text);
				txtTienKhachDua.Text = string.Format("{0:#,###}", S);
			}

		}

		private void txtTienKhachDua_KeyDown(object sender, KeyEventArgs e)
		{
			if (txtTienKhachDua.Text != "")
			{
				decimal S = decimal.Parse(txtTienKhachDua.Text);
				txtTienKhachDua.Text = string.Format("{0:#,###}", S);
			}
		}

		private void txtTienKhachDua_KeyUp(object sender, KeyEventArgs e)
		{

		}

		private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (txtTienKhachDua.Text != "")
				{

					decimal tienkhachtra = decimal.Parse(txtTienKhachDua.Text) - decimal.Parse(lblTongTien.Text);
					txtTienTraKhach.Text = string.Format("{0:#,###}", tienkhachtra);
				}
				if (txtTienKhachDua.Text.ToString() == 0.ToString())
				{
					txtTienTraKhach.Text = 0.ToString();
				}
			}
			catch { }
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void timerBan_Tick(object sender, EventArgs e)
		{
			try
			{
				string mab = lviBan.FocusedItem.SubItems[1].Text;
				string mahd = null;
				mahd = KiemTraHoaDonTrongBanCoTonTaiKhong(mab);
				if (mahd != null)
				{
					clsHoaDonBan_DTO hd = new clsHoaDonBan_DTO();
					hd = bushd.LayThongTinHoaDon(string.Format("SELECT * FROM HOADONBAN WHERE MAHD = '{0}'", mahd));
					DateTime ngaymuon = Convert.ToDateTime(hd.GioBatDau);
					DateTime ngaytra = Convert.ToDateTime(System.DateTime.Now);
					TimeSpan Time = ngaytra - ngaymuon;

					lblThoiGianBan.Text = Time.Days.ToString() + " Ngày    " + Time.Hours.ToString() + " : " + Time.Minutes.ToString() + " : " + Time.Seconds.ToString();
				}
				else
				{
					lblThoiGianBan.Text = "0";
				}
			}
			catch
			{
				ChonViTriDauTrongLVI(lviBan);
			}
		}

		private void lviBan_MouseClick(object sender, MouseEventArgs e)
		{

			for (int i = 0; i < lviBan.Items.Count; i++)
			{

				if (lviBan.Items[i].Selected == true)
				{
					lviBan.Items[i].Selected = false;
					lviBan.Items[i].BackColor = Color.FromArgb(200, 113, 55);
					lviBan.Items[i].SubItems[0].ForeColor = Color.White;
				}
				else
				{
					lviBan.Items[i].BackColor = Color.White;
					lviBan.Items[i].SubItems[0].ForeColor = Color.Black;
				}
			}


		}

		private void lviBan_KeyUp(object sender, KeyEventArgs e)
		{

			for (int i = 0; i < lviBan.Items.Count; i++)
			{

				if (lviBan.Items[i].Selected == true)
				{
					lviBan.Items[i].Selected = false;
					lviBan.Items[i].BackColor = Color.FromArgb(200, 113, 55);
					lviBan.Items[i].SubItems[0].ForeColor = Color.White;

				}
				else
				{
					lviBan.Items[i].BackColor = Color.White;
					lviBan.Items[i].SubItems[0].ForeColor = Color.Black;
				}
			}

		}

		private void dgvThucDon_Click(object sender, EventArgs e)
		{
			dgvBan.ClearSelection();
		}

		private void dgvThucDon_DataSourceChanged(object sender, EventArgs e)
		{
		}

		private void dgvThucDon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{

			for (int i = 0; i < dgvThucDon.Rows.Count; i++)
			{
				if (dgvThucDon.Rows[i].Cells[4].Value.ToString() == 2.ToString())
				{

					string a = dgvThucDon.Rows[i].Cells[0].Value.ToString();
					decimal b = decimal.Parse(dgvThucDon.Rows[i].Cells[3].Value.ToString());
					if (e.Value.ToString() == a)
						dgvThucDon.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;

				}
			}
		}

		private void dgvBan_Click(object sender, EventArgs e)
		{
			dgvThucDon.ClearSelection();
		}

		private void btnGhiChu_Click(object sender, EventArgs e)
		{
			try
			{
				string MAMON = "";
				string TenGhiChu = "";
				int vt = dgvBan.CurrentRow.Index;

				if (dgvBan.Rows.Count > 0)
				{
					MAMON = dgvBan.Rows[vt].Cells["colTENMON"].Value.ToString();
					TenGhiChu = dgvBan.Rows[vt].Cells["colGhiChu"].Value.ToString();


				}
				string mahd = "";
				string maban = lviBan.FocusedItem.SubItems[1].Text;
				mahd = KiemTraHoaDonTrongBanCoTonTaiKhong(maban);
				//todo
				//frmGhiChuChiTietHoaDon GhiChu = new frmGhiChuChiTietHoaDon(mahd, MAMON, TenGhiChu);
				//GhiChu.ShowDialog();
				//if (GhiChu.DialogResult == DialogResult.Yes)
				//{
				//	LoadDuLieuDGV();
				//}
			}
			catch { }
		}
	}
}
