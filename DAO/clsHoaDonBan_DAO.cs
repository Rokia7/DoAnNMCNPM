using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class clsHoaDonBan_DAO
    {
        public DataTable LayDsHD(DateTime tu, DateTime den, string maNV)
        {
            DataTable dt = new DataTable();
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("SELECT HOADONBAN.*,HOTENNV,TENKH,CHIETKHAU,TENBAN FROM HOADONBAN,NHANVIEN,KHACHHANGTHANTHIET,BAN WHERE HOADONBAN.MAKH=KHACHHANGTHANTHIET.MAKH AND HOADONBAN.MANV=NHANVIEN.MANV AND HOADONBAN.NGAYXUAT >= @NgayTu AND HOADONBAN.NGAYXUAT <= @NgayDen AND BAN.MABAN=HOADONBAN.MABAN AND HOADONBAN.TRANGTHAI != 3 AND HOADONBAN.TRANGTHAI != 0");
            if (maNV != "")
                sql += string.Format(" AND HOADONBAN.MANV = '{0}'", maNV);
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            cmd.Parameters.AddWithValue("@NgayTu", tu);
            cmd.Parameters["@NgayTu"].SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.AddWithValue("@NgayDen", den);
            cmd.Parameters["@NgayDen"].SqlDbType = SqlDbType.DateTime;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            clsThaoTacDuLieu.DongKetNoi(con);
            return dt;
        }

        public bool CapNhatTrangThai(string mahd, int v)
        {
            string sql = string.Format("UPDATE HOADONBAN SET TRANGTHAI = {0} WHERE MAHD = '{1}'", v,mahd);
            if (clsThaoTacDuLieu.ExecuteNonQuery(sql) > 0)
                return true;
            return false;
        }

        public bool UpdateCAULENH(string P)
        {
            string sql = P;
            if (clsThaoTacDuLieu.ExecuteNonQuery(sql) > 0)
                return true;
            return false;
        }

        public string PhatSinhMaHD()
        {
            return clsThaoTacDuLieu.DemDong("HOADONBAN", "MAHD");
        }

        public bool LapHoaDonTamThoi(clsHoaDonBan_DTO hoadon)
        {
            
            string sql = string.Format("INSERT INTO HOADONBAN (MAHD, MANV, NGAYXUAT, TONGTIEN,MABAN,TRANGTHAI,GIOBATDAU) VALUES (@MAHD,@MANV,@NGAYXUAT,@TONGTIEN,@MABAN,@TRANGTHAI,@GIOBATDAU)");
            bool kq = false;
            SqlConnection conn = clsThaoTacDuLieu.TaoVaMoKetNoi();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MAHD", hoadon.MAHDX);
            cmd.Parameters["@MAHD"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.AddWithValue("@TONGTIEN", hoadon.TONGTIEN);
            cmd.Parameters["@TONGTIEN"].SqlDbType = SqlDbType.Decimal;
            cmd.Parameters.AddWithValue("@NGAYXUAT", hoadon.NGAYXUAT);
            cmd.Parameters["@NGAYXUAT"].SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.AddWithValue("@MANV", hoadon.MANV);
            cmd.Parameters["@MANV"].SqlDbType = SqlDbType.VarChar;
            //cmd.Parameters.AddWithValue("@MAKH", hoadon.MAKH);
            //cmd.Parameters["@MAKH"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.AddWithValue("@MABAN", hoadon.MaBan);
            cmd.Parameters["@MABAN"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.AddWithValue("@TRANGTHAI", hoadon.TrangThai);
            cmd.Parameters["@TRANGTHAI"].SqlDbType = SqlDbType.Int;
            cmd.Parameters.AddWithValue("@GIOBATDAU", hoadon.GioBatDau);
            cmd.Parameters["@GIOBATDAU"].SqlDbType = SqlDbType.DateTime;
            //cmd.Parameters.AddWithValue("@GIOKETTHUC", hoadon.GioKetThuc);
            //cmd.Parameters["@GIOKETTHUC"].SqlDbType = SqlDbType.DateTime;

            int count = (int)cmd.ExecuteNonQuery();
            if (count > 0)
                kq = true;
            clsThaoTacDuLieu.DongKetNoi(conn);
            return kq;
        }

        public DataTable LayDsHDBan(DateTime tu, DateTime den, string maNV)
        {
            DataTable dt = new DataTable();
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("SELECT HOADONBAN.*,HOTENNV,TENKH,CHIETKHAU,TENBAN FROM HOADONBAN,NHANVIEN,KHACHHANGTHANTHIET,BAN WHERE HOADONBAN.MAKH=KHACHHANGTHANTHIET.MAKH AND HOADONBAN.MANV=NHANVIEN.MANV AND HOADONBAN.NGAYXUAT >= @NgayTu AND HOADONBAN.NGAYXUAT <= @NgayDen AND BAN.MABAN=HOADONBAN.MABAN AND HOADONBAN.TRANGTHAI =1");
            if (maNV != "")
                sql += string.Format(" AND HOADONBAN.MANV = '{0}'", maNV);
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            cmd.Parameters.AddWithValue("@NgayTu", tu);
            cmd.Parameters["@NgayTu"].SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.AddWithValue("@NgayDen", den);
            cmd.Parameters["@NgayDen"].SqlDbType = SqlDbType.DateTime;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            clsThaoTacDuLieu.DongKetNoi(con);
            return dt;
        }

        public decimal LayDsBan(DateTime tu, DateTime den)
        {
            decimal count = -1;
            string sql = string.Format("SELECT SUM(TONGTIEN) FROM HOADONBAN WHERE HOADONBAN.NGAYXUAT >= @NgayTu AND HOADONBAN.NGAYXUAT <= @NgayDen and TRANGTHAI=1 ");
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            cmd.Parameters.AddWithValue("@NgayTu", tu);
            cmd.Parameters["@NgayTu"].SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.AddWithValue("@NgayDen", den);
            cmd.Parameters["@NgayDen"].SqlDbType = SqlDbType.DateTime;

            try
            {
                count = (decimal)cmd.ExecuteScalar();
                clsThaoTacDuLieu.DongKetNoi(con);
                //if(count==-1)
                return count;
            }
            catch { return 0; }

        }

        public bool UpdateHoaDon(clsHoaDonBan_DTO hoadon)
        {

            string sql = string.Format("UPDATE HOADONBAN SET MAKH = @MAKH,MANV = @MANV, NGAYXUAT = @NGAYXUAT, TONGTIEN = @TONGTIEN,MABAN = @MABAN,TRANGTHAI = @TRANGTHAI,GIOKETTHUC = @GIOKETTHUC WHERE MAHD = @MAHD");
            bool kq = false;
            SqlConnection conn = clsThaoTacDuLieu.TaoVaMoKetNoi();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MAHD", hoadon.MAHDX);
            cmd.Parameters["@MAHD"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.AddWithValue("@TONGTIEN", hoadon.TONGTIEN);
            cmd.Parameters["@TONGTIEN"].SqlDbType = SqlDbType.Decimal;
            cmd.Parameters.AddWithValue("@NGAYXUAT", hoadon.NGAYXUAT);
            cmd.Parameters["@NGAYXUAT"].SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.AddWithValue("@MANV", hoadon.MANV);
            cmd.Parameters["@MANV"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.AddWithValue("@MAKH", hoadon.MAKH);
            cmd.Parameters["@MAKH"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.AddWithValue("@MABAN", hoadon.MaBan);
            cmd.Parameters["@MABAN"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.AddWithValue("@TRANGTHAI", hoadon.TrangThai);
            cmd.Parameters["@TRANGTHAI"].SqlDbType = SqlDbType.Int;
            cmd.Parameters.AddWithValue("@GIOKETTHUC", hoadon.GioKetThuc);
            cmd.Parameters["@GIOKETTHUC"].SqlDbType = SqlDbType.DateTime;

            int count = (int)cmd.ExecuteNonQuery();
            if (count > 0)
                kq = true;
            clsThaoTacDuLieu.DongKetNoi(conn);
            return kq;
        }

        public bool UpdateToanBoHoaDon(clsHoaDonBan_DTO hoadon)
        {

            string sql = string.Format("UPDATE HOADONBAN SET MANV = @MANV, NGAYXUAT = @NGAYXUAT, TONGTIEN = @TONGTIEN,MABAN = @MABAN,TRANGTHAI = @TRANGTHAI,GIOBATDAU = @GIOBATDAU,GIOKETTHUC = @GIOKETTHUC WHERE MAHD = @MAHD");
            bool kq = false;
            SqlConnection conn = clsThaoTacDuLieu.TaoVaMoKetNoi();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MAHD", hoadon.MAHDX);
            cmd.Parameters["@MAHD"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.AddWithValue("@TONGTIEN", hoadon.TONGTIEN);
            cmd.Parameters["@TONGTIEN"].SqlDbType = SqlDbType.Decimal;
            cmd.Parameters.AddWithValue("@NGAYXUAT", hoadon.NGAYXUAT);
            cmd.Parameters["@NGAYXUAT"].SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.AddWithValue("@MANV", hoadon.MANV);
            cmd.Parameters["@MANV"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.AddWithValue("@MAKH", hoadon.MAKH);
            cmd.Parameters["@MAKH"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.AddWithValue("@MABAN", hoadon.MaBan);
            cmd.Parameters["@MABAN"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.AddWithValue("@TRANGTHAI", hoadon.TrangThai);
            cmd.Parameters["@TRANGTHAI"].SqlDbType = SqlDbType.Int;
            cmd.Parameters.AddWithValue("@GIOBATDAU", hoadon.GioBatDau);
            cmd.Parameters["@GIOBATDAU"].SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.AddWithValue("@GIOKETTHUC", hoadon.GioKetThuc);
            cmd.Parameters["@GIOKETTHUC"].SqlDbType = SqlDbType.DateTime;

            int count = (int)cmd.ExecuteNonQuery();
            if (count > 0)
                kq = true;
            clsThaoTacDuLieu.DongKetNoi(conn);
            return kq;
        }
        public bool LapHoaDon(clsHoaDonBan_DTO hoadon)
        {

            string sql = string.Format("INSERT INTO HOADONBAN (MAHD, MANV, NGAYXUAT, TONGTIEN,MABAN,TRANGTHAI,GIOBATDAU) VALUES (@MAHD,@MANV,@NGAYXUAT,@TONGTIEN,@MABAN,@TRANGTHAI,@GIOBATDAU)");
            bool kq = false;
            SqlConnection conn = clsThaoTacDuLieu.TaoVaMoKetNoi();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MAHD", hoadon.MAHDX);
            cmd.Parameters["@MAHD"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.AddWithValue("@TONGTIEN", hoadon.TONGTIEN);
            cmd.Parameters["@TONGTIEN"].SqlDbType = SqlDbType.Decimal;
            cmd.Parameters.AddWithValue("@NGAYXUAT", hoadon.NGAYXUAT);
            cmd.Parameters["@NGAYXUAT"].SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.AddWithValue("@MANV", hoadon.MANV);
            cmd.Parameters["@MANV"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.AddWithValue("@MAKH", hoadon.MAKH);
            cmd.Parameters["@MAKH"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.AddWithValue("@MABAN", hoadon.MaBan);
            cmd.Parameters["@MABAN"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.AddWithValue("@TRANGTHAI", hoadon.TrangThai);
            cmd.Parameters["@TRANGTHAI"].SqlDbType = SqlDbType.Int;
            cmd.Parameters.AddWithValue("@GIOBATDAU", hoadon.GioBatDau);
            cmd.Parameters["@GIOBATDAU"].SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.AddWithValue("@GIOKETTHUC", hoadon.GioKetThuc);
            cmd.Parameters["@GIOKETTHUC"].SqlDbType = SqlDbType.DateTime;

            int count = (int)cmd.ExecuteNonQuery();
            if (count > 0)
                kq = true;
            clsThaoTacDuLieu.DongKetNoi(conn);
            return kq;
        }

        public DataTable LayDsHDBan(string p)
        {
            string sql = string.Format("Select CTHDBan.*,TENMON,TENBAN,CTHDBan.SOLUONG*CTHDBan.GIA AS THANHTIEN FROM CTHDBan,MON,BAN WHERE MAHD='{0}' AND CTHDBan.MAMON=MON.MAMON AND CTHDBan.MABAN=BAN.MABAN", p);
            return clsThaoTacDuLieu.LayBang(sql);
        }

        public DataTable LayDSHDBAN(string p)
        {
            string sql = string.Format("Select CTHDBan.*,TENMON,TENBAN,CTHDBan.SOLUONG*CTHDBan.GIA AS THANHTIEN FROM CTHDBan,MON,BAN WHERE MAHD='{0}' AND CTHDBan.MAMON=MON.MAMON AND CTHDBan.MABAN=BAN.MABAN", p);
            return clsThaoTacDuLieu.LayBang(sql);
        }

        public DataTable LayDSHDBANCAULENH(string p)
        {
            string sql = string.Format(p);
            return clsThaoTacDuLieu.LayBang(sql);
        }



        public DataTable LayDsHD(DateTime tu, DateTime den)
        {
            DataTable dt = new DataTable();
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("SELECT * FROM HOADONBAN WHERE HOADONBAN.NGAYXUAT >= @NgayTu AND HOADONBAN.NGAYXUAT <= @NgayDen AND TRANGTHAI = 1");
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            cmd.Parameters.AddWithValue("@NgayTu", tu);
            cmd.Parameters["@NgayTu"].SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.AddWithValue("@NgayDen", den);
            cmd.Parameters["@NgayDen"].SqlDbType = SqlDbType.DateTime;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            clsThaoTacDuLieu.DongKetNoi(con);
            return dt;
        }

        public clsHoaDonBan_DTO LayThongTinHoaDon(string sql)
        {
            clsHoaDonBan_DTO hd = new clsHoaDonBan_DTO();

            // 1,2. Tạo và mở kết nối
            //string sql = string.Format("SELECT MABAN, MAMON, SOLUONG FROM CTBAN WHERE MABAN = '{0}' AND MAMON = '{1}'", maban, mamon);
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            // 3. Tạo đối tượng truy vấn
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            // 4. thực thi cmd và xử lý kết quả
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (!dr.IsDBNull(0)) // (A)
                    hd.MAHDX = (string)dr[0]; // (B)
                if (!dr.IsDBNull(1))
                    hd.MAKH = (string)dr[1];
                if (!dr.IsDBNull(2))
                    hd.MANV = (string)dr[2];
                if (!dr.IsDBNull(3))
                    hd.NGAYXUAT = (DateTime)dr[3];
                if (!dr.IsDBNull(4))
                    hd.TONGTIEN = (decimal)dr[4];
                if (!dr.IsDBNull(5))
                    hd.MaBan = (string)dr[5];
                if (!dr.IsDBNull(6))
                    hd.TrangThai = (int)dr[6];
                if (!dr.IsDBNull(7))
                    hd.GioBatDau = (DateTime)dr[7];
                if (!dr.IsDBNull(8))
                    hd.GioKetThuc = (DateTime)dr[8];

            }
            // 5. đóng kết nối
            clsThaoTacDuLieu.DongKetNoi(con);

            return hd;
        }

    }
}
