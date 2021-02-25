using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class clsThucDon_DAO
    {
        public List<clsThucDon_DTO> LayTatCaDsTD()
        {
            List<clsThucDon_DTO> lsTD = new List<clsThucDon_DTO>();

            // 1,2. Tạo và mở kết nối
            string sql = string.Format("SELECT * FROM MON WHERE TRANGTHAI != 0");
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            // 3. Tạo đối tượng truy vấn
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            // 4. thực thi cmd và xử lý kết quả
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsThucDon_DTO td = new clsThucDon_DTO();
                if (!dr.IsDBNull(0))
                    td.MAMON = (string)dr[0];
                if (!dr.IsDBNull(1))
                    td.TENMON = (string)dr[1];
                if (!dr.IsDBNull(2))
                    td.MALOAI = (string)dr[2];
                if (!dr.IsDBNull(3))
                    td.DVT = (string)dr[3];
                if (!dr.IsDBNull(4))
                    td.GIA= (decimal)dr[4];
                if (!dr.IsDBNull(5))
                    td.TRANGTHAI = (int)dr[5];
                lsTD.Add(td);
            }
            // 5. đóng kết nối
            clsThaoTacDuLieu.DongKetNoi(con);

            return lsTD;
        }

        public DataTable Laytopthucdonbanchaynhat(string loaimon, DateTime tu, DateTime den, int top)
        {
            DataTable dt = new DataTable();
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("SELECT  top({0}) TENMON, SUM(SOLUONG) AS TONG FROM MON, CTHDBan,HOADONBAN WHERE MON.MAMON = CTHDBan.MAMON AND HOADONBAN.MAHD = CTHDBan.MAHD AND HOADONBAN.NGAYXUAT >= @NgayTu AND HOADONBAN.NGAYXUAT <= @NgayDen ",top);
            if (loaimon != "")
                sql += string.Format("AND MON.MALOAI = '{0}'", loaimon);
            sql += string.Format("AND HOADONBAN.TRANGTHAI!=0 GROUP BY TENMON ORDER BY SUM(SOLUONG) DESC");
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

        public DataTable Laytopthucdonbanchaynhat()
        {
            //string sql = string.Format("SELECT * FROM LOAIMON WHERE TRANGTHAI = 1");
            //return LayTatCaDsTD(sql);

            string sql = string.Format("SELECT  top 20 TENMON, SUM(SOLUONG) AS TONG FROM MON, CTHDBan WHERE MON.MAMON = CTHDBan.MAMON GROUP BY TENMON ORDER BY SUM(SOLUONG) DESC");
            return clsThaoTacDuLieu.LayBang(sql);
        }

        public bool CapNhatmon(string mamon)
        {
            string sql = string.Format("UPDATE MON SET MALOAI ='L00' WHERE MAMON = '{0}'", mamon);
            if (clsThaoTacDuLieu.ExecuteNonQuery(sql) > 0)
                return true;
            return false;
        }

        public DataTable LayMonTheoLoaiMon(string maloai)
        {
            string sql = string.Format("SELECT * FROM MON WHERE TRANGTHAI != 0 AND MALOAI='{0}'",maloai);
            return clsThaoTacDuLieu.LayBang(sql);
        }

        public List<clsThucDon_DTO> LayTatCaDsTD(string sql)
        {
            List<clsThucDon_DTO> lsTD = new List<clsThucDon_DTO>();

            // 1,2. Tạo và mở kết nối
            
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            // 3. Tạo đối tượng truy vấn
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            // 4. thực thi cmd và xử lý kết quả
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsThucDon_DTO td = new clsThucDon_DTO();
                if (!dr.IsDBNull(0))
                    td.MAMON = (string)dr[0];
                if (!dr.IsDBNull(1))
                    td.TENMON = (string)dr[1];
                if (!dr.IsDBNull(2))
                    td.MALOAI = (string)dr[2];
                if (!dr.IsDBNull(3))
                    td.DVT = (string)dr[3];
                if (!dr.IsDBNull(4))
                    td.GIA = (decimal)dr[4];
                if (!dr.IsDBNull(5))
                    td.TRANGTHAI = (int)dr[5];
                lsTD.Add(td);
            }
            // 5. đóng kết nối
            clsThaoTacDuLieu.DongKetNoi(con);

            return lsTD;
        }

        public List<clsThucDon_DTO> LayDsThucDon(string strTen, string strLoai, string strtrangthai)
        {
            string sql = string.Format("SELECT * FROM MON WHERE TRANGTHAI != 0");
            if (strTen != "-1")
                sql += string.Format(" AND MAMON LIKE '%{0}%' OR TENMON LIKE  N'%{0}%'", strTen);

            if (strLoai != "-1")
                sql += string.Format(" AND MALOAI LIKE '%{0}%'", strLoai);
            if (strtrangthai != "")
                sql += string.Format(" AND TRANGTHAI  LIKE '{0}'", strtrangthai);
            //else sql = string.Format("SELECT * FROM MON WHERE TRANGTHAI = 1");
            return LayTatCaDsTD(sql);
        }

        public clsThucDon_DTO LayThongTinTD(string maMon)
        {
            clsThucDon_DTO td = new clsThucDon_DTO();
            string sql = string.Format("select * FROM MON WHERE MAMON = '{0}'", maMon);
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                
                if (!dr.IsDBNull(0))
                    td.MAMON = (string)dr[0];
                if (!dr.IsDBNull(1))
                    td.TENMON = (string)dr[1];
                if (!dr.IsDBNull(2))
                    td.MALOAI = (string)dr[2];
                if (!dr.IsDBNull(3))
                    td.DVT = (string)dr[3];
                if (!dr.IsDBNull(4))
                    td.GIA = (decimal)dr[4];
                if (!dr.IsDBNull(5))
                    td.TRANGTHAI = (int)dr[5];
            }
            // 5. đóng kết nối
            clsThaoTacDuLieu.DongKetNoi(con);

            return td;
            
        }


        public List<clsThucDon_DTO> LayDsThucDon(string strTenvaMa,string strLoai)
        {
            // Tạo câu truy vấn SQL
            string sql = string.Format("SELECT * FROM MON WHERE TRANGTHAI != 0");
            if (strTenvaMa != "-1")
                sql += string.Format(" AND MAMON LIKE '%{0}%' OR TENMON LIKE  N'%{0}%'", strTenvaMa);
           
            if (strLoai != "-1")
                sql += string.Format(" AND MALOAI LIKE '%{0}%'",strLoai);
            return LayTatCaDsTD(sql);
        }

        public bool UpdateTrangThai(int tt,string mamon)
        {
            string sql = string.Format("UPDATE MON SET TRANGTHAI = {0} WHERE MAMON = '{1}'", tt, mamon);
            if (clsThaoTacDuLieu.ExecuteNonQuery(sql) > 0)
                return true;
            return false;
        }

        public string PhatSinhMaNV()
        {
            return clsThaoTacDuLieu.DemDong("MON", "MAMON");
        }


        public void ThemTD(clsThucDon_DTO nv)
        {
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = @"INSERT INTO MON (MAMON,TENMON,GIA,MALOAI,DVT,TRANGTHAI) VALUES (@MAMON, @TENMON, @GIA, @MALOAI, @DVT, @TRANGTHAI)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@MAMON", nv.MAMON);
            cmd.Parameters["@MAMON"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.AddWithValue("@TENMON", nv.TENMON);
            cmd.Parameters["@TENMON"].SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.AddWithValue("@GIA", nv.GIA);
            cmd.Parameters["@GIA"].SqlDbType = SqlDbType.Decimal;
            cmd.Parameters.AddWithValue("@MALOAI", nv.MALOAI);
            cmd.Parameters["@MALOAI"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.AddWithValue("@DVT", nv.DVT);
            cmd.Parameters["@DVT"].SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.AddWithValue("@TRANGTHAI", nv.TRANGTHAI);
            cmd.Parameters["@TRANGTHAI"].SqlDbType = SqlDbType.Int;

            int kq = cmd.ExecuteNonQuery();
            cmd.Dispose();
            clsThaoTacDuLieu.DongKetNoi(con);
        }


        public bool SuaNV(clsThucDon_DTO nv)
        {
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = @"UPDATE MON SET TENMON = @TENMON, GIA = @GIA, DVT = @DVT, MALOAI = @MALOAI, TRANGTHAI = @TRANGTHAI WHERE MAMON = @MAMON";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@MAMON", nv.MAMON);
            cmd.Parameters["@MAMON"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.AddWithValue("@TENMON", nv.TENMON);
            cmd.Parameters["@TENMON"].SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.AddWithValue("@GIA", nv.GIA);
            cmd.Parameters["@GIA"].SqlDbType = SqlDbType.Decimal;
            cmd.Parameters.AddWithValue("@MALOAI", nv.MALOAI);
            cmd.Parameters["@MALOAI"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.AddWithValue("@DVT", nv.DVT);
            cmd.Parameters["@DVT"].SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.AddWithValue("@TRANGTHAI", nv.TRANGTHAI);
            cmd.Parameters["@TRANGTHAI"].SqlDbType = SqlDbType.Int;
            int kq = cmd.ExecuteNonQuery();
            cmd.Dispose();
            clsThaoTacDuLieu.DongKetNoi(con);
            if (kq == 1)
                return true;
            return false;
        }

        public bool XoaTD(string mamon)
        {
            string sql = string.Format("UPDATE MON SET TRANGTHAI = 0 WHERE MAMON = '{0}'", mamon);
            if (clsThaoTacDuLieu.ExecuteNonQuery(sql) > 0)
                return true;
            return false;
        }

        public string PhatSinhMaMon()
        {
            return clsThaoTacDuLieu.DemDong("MON", "MAMON");
        }

        public clsThucDon_DTO ThucDonBanChay()
        {
            clsThucDon_DTO td = new clsThucDon_DTO();
            string sql = string.Format("SELECT top 1 COUNT(*) as soluong, MAMON FROM CTHDBan WHERE CTHDBan.MAMON = CTHDBan.MAMON GROUP BY MAMON ORDER BY COUNT(*) desc");
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (!dr.IsDBNull(0))
                    td.Soluongdedungchothongke = (int)dr[0];
                if (!dr.IsDBNull(1))
                    td.MAMON = (string)dr[1];
               
            }
            // 5. đóng kết nối
            clsThaoTacDuLieu.DongKetNoi(con);

            return td;
        }

        public DataTable LaydsTD(string ma)
        {
            string sql = "";
            if (ma != "TC")
            {
                sql = string.Format("SELECT MON.*,TENLOAI FROM MON,LOAIMON WHERE MON.MALOAI=LOAIMON.MALOAI AND MON.TRANGTHAI != 0 AND MON.MALOAI='{0}'", ma);
            }
            else sql = string.Format("SELECT MON.*,TENLOAI FROM MON,LOAIMON WHERE MON.MALOAI=LOAIMON.MALOAI AND MON.TRANGTHAI != 0");
            return clsThaoTacDuLieu.LayBang(sql);
        }

        public DataTable LayTatCaDsThucDonTheoLoai(string MaLoai)
        {
            string sql = "";
            if (MaLoai != "TC")
            {
                sql = string.Format("SELECT MON.*,TENLOAI FROM MON,LOAIMON WHERE MON.MALOAI=LOAIMON.MALOAI AND MON.TRANGTHAI != 0 AND MON.MALOAI='{0}'", MaLoai);
            }
            else sql = string.Format("SELECT MON.*,TENLOAI FROM MON,LOAIMON WHERE MON.MALOAI=LOAIMON.MALOAI AND MON.TRANGTHAI != 0");
            return clsThaoTacDuLieu.LayBang(sql);
        }
    }
}
