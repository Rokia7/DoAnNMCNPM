using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class clsCTHDBan_DAO
    {
        public DataTable LayCTHD(string mahd)
        {
            string sql = string.Format("Select CTHDBan.*,TENMON,TENBAN,MON.DVT,CTHDBan.SOLUONG*CTHDBan.GIA AS THANHTIEN FROM CTHDBan,MON,BAN,HOADONBAN WHERE CTHDBan.MAHD ='{0}' AND CTHDBan.MAMON=MON.MAMON AND HOADONBAN.MAHD = CTHDBan.MAHD AND HOADONBAN.MABAN=BAN.MABAN", mahd);
            return clsThaoTacDuLieu.LayBang(sql);
        }
        public DataTable LayCTHDCAULENH(string P)
        {
            string sql = P;
            return clsThaoTacDuLieu.LayBang(sql);
        }

        public clsCTHDBan_DTO LayCTHDclsCTHDBan_DTO(string sql)
        {
            clsCTHDBan_DTO ctb = new clsCTHDBan_DTO();

            // 1,2. Tạo và mở kết nối
            //string sql = string.Format("SELECT MABAN, MAMON, SOLUONG,GHICHU FROM CTBAN WHERE MABAN = '{0}' AND MAMON = '{1}'", maban, mamon);
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            // 3. Tạo đối tượng truy vấn
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            // 4. thực thi cmd và xử lý kết quả
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (!dr.IsDBNull(0)) // (A)
                    ctb.MAHD = (string)dr[0]; // (B)
                if (!dr.IsDBNull(1))
                    ctb.MAMON = (string)dr[1];
                if (!dr.IsDBNull(2))
                    ctb.GIA = (decimal)dr[2];
                if (!dr.IsDBNull(3))
                    ctb.SOLUONG = (int)dr[3];
                if (!dr.IsDBNull(4))
                    ctb.GHICHU = (string)dr[4];


            }
            // 5. đóng kết nối
            clsThaoTacDuLieu.DongKetNoi(con);

            return ctb;
        }

        public bool LuuGhiChu(string mahd,string mamon, string ghiChu)
        {
            return clsThaoTacDuLieu.ThemMoiDuLieu(string.Format("UPDATE CTHDBan SET GHICHU = N'{0}' WHERE MAHD = '{1}' AND MAMON = '{2}'", ghiChu, mahd, mamon));
        }

        public bool LapChiTietHoaDon(string HD_MaHD, string MAMON, int CTHD_SoLuong, decimal gia,string GhiChu)
        {
            return clsThaoTacDuLieu.ThemMoiDuLieu(string.Format("INSERT INTO CTHDBan (MAHD,MAMON, SOLUONG,GIA,GHICHU) VALUES ('{0}', '{1}', {2}, {3}, '{4}')", HD_MaHD,MAMON, CTHD_SoLuong, gia,GhiChu));
        }

        public int LayTongSoMon(string mahd)
        {
            int count;
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("select SUM(SOLUONG) from CTHDBan WHERE MAHD='{0}'", mahd);
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);

            try
            {
                count = (int)cmd.ExecuteScalar();
                //Đóng kết nối
                clsThaoTacDuLieu.DongKetNoi(con);
                return count;
            }
            catch { return count = 0; }
        }

        public bool UpdateSoLuongDaPhaChe(string mahd, string mamon, int soluong)
        {
            return clsThaoTacDuLieu.ThemMoiDuLieu(string.Format("UPDATE CTHDBan SET SOLUONGDAPHACHE = {2} WHERE MAHD = '{0}' AND MAMON = '{1}'", mahd, mamon,soluong));
        }

        public decimal LayTongTien(string mahd)
        {
            decimal count;
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("select SUM(SOLUONG*GIA) from CTHDBan WHERE MAHD='{0}'", mahd);
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);

            try
            {
                count = (decimal)cmd.ExecuteScalar();
                //Đóng kết nối
                clsThaoTacDuLieu.DongKetNoi(con);
                return count;
            }
            catch { return count = 0; }
        }

        public bool UpdateChiTietHoaDon(string HD_MaHD, string MAMON, int CTHD_SoLuong, decimal gia,string GhiChu)
        {
            return clsThaoTacDuLieu.ThemMoiDuLieu(string.Format("UPDATE CTHDBan SET SOLUONG = {2}, GHICHU='{4}', GIA = {3} WHERE MAHD = '{0}' AND MAMON = '{1}'", HD_MaHD, MAMON, CTHD_SoLuong, gia,GhiChu));
        }

        public bool XoaCTHD(string mahd)
        {
            string sql = string.Format("DELETE CTHDBan WHERE MAHD = '{0}'", mahd);
            if (clsThaoTacDuLieu.ExecuteNonQuery(sql) > 0)
                return true;
            return false;
        }

        public bool XoaCTHDCAULENH(string sql)
        {
            if (clsThaoTacDuLieu.ExecuteNonQuery(sql) > 0)
                return true;
            return false;
        }

    }
}
