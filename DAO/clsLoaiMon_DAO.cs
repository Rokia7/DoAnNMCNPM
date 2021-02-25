using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class clsLoaiMon_DAO
    {
        public List<clsLoaiMon_DTO> LayTatCaLoaiMon()
        {
            string sql = string.Format("SELECT * FROM LOAIMON WHERE TRANGTHAI = 1");
            return LayTatCaLoaiMon(sql);
        }
        public List<clsLoaiMon_DTO> LayTatCaLoaiMon(string sql)
        {
            List<clsLoaiMon_DTO> lsLM = new List<clsLoaiMon_DTO>();

            // 1,2. Tạo và mở kết nối
           //string sql = string.Format("SELECT * FROM LOAIMON where TRANGTHAI=1");
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            // 3. Tạo đối tượng truy vấn
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            // 4. thực thi cmd và xử lý kết quả
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsLoaiMon_DTO lm = new clsLoaiMon_DTO();
                if (!dr.IsDBNull(0))
                    lm.MALOAI = (string)dr[0];
                if (!dr.IsDBNull(1))
                    lm.TENLOAI = (string)dr[1];
                if (!dr.IsDBNull(2))
                    lm.TRANGTHAI = (int)dr[2];

                lsLM.Add(lm);
            }
            // 5. đóng kết nối
            clsThaoTacDuLieu.DongKetNoi(con);

            return lsLM;
        }

        public bool Xoa(string ma)
        {
            string sql = string.Format("UPDATE LOAIMON SET TRANGTHAI = 0 WHERE MALOAI = '{0}'", ma);
            if (clsThaoTacDuLieu.ExecuteNonQuery(sql) > 0)
                return true;
            return false;
        }

        public List<clsLoaiMon_DTO> LayDsloaimon(string strTen, string strMa)
        {
            string sql = string.Format("SELECT * FROM LOAIMON WHERE TRANGTHAI = 1");
            if (strTen != "-1")
                sql += string.Format(" AND TENLOAI LIKE N'%{0}%'", strTen);
            if (strMa != "-1")
                sql += string.Format(" AND MALOAI LIKE N'%{0}%'", strMa);
           

            return LayTatCaLoaiMon(sql);
        }

       
        public SqlConnection Khoitao()
        {
            SqlDependency.Stop(clsThaoTacDuLieu.khoitao());
            SqlDependency.Start(clsThaoTacDuLieu.khoitao());
            SqlConnection con = new SqlConnection(clsThaoTacDuLieu.khoitao());
            return con;
        }

        public bool sualoai(clsLoaiMon_DTO loai)
        {
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = @"UPDATE LOAIMON SET TENLOAI = @TENLOAI, TRANGTHAI = @TRANGTHAI WHERE MALOAI = @MALOAI";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@TENLOAI", loai.TENLOAI);
            cmd.Parameters["@TENLOAI"].SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.AddWithValue("@TRANGTHAI", loai.TRANGTHAI);
            cmd.Parameters["@TRANGTHAI"].SqlDbType = SqlDbType.Int;
            cmd.Parameters.AddWithValue("@MALOAI", loai.MALOAI);
            cmd.Parameters["@MALOAI"].SqlDbType = SqlDbType.NVarChar;
            int kq = cmd.ExecuteNonQuery();
            cmd.Dispose();
            clsThaoTacDuLieu.DongKetNoi(con);
            if (kq == 1)
                return true;
            return false;
        }

        public void themloai(clsLoaiMon_DTO loai)
        {
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = @"INSERT INTO LOAIMON (MALOAI, TENLOAI, TRANGTHAI) VALUES (@MALOAI, @TENLOAI, @TRANGTHAI)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@MALOAI", loai.MALOAI);
            cmd.Parameters["@MALOAI"].SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.AddWithValue("@TENLOAI", loai.TENLOAI);
            cmd.Parameters["@TENLOAI"].SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.AddWithValue("@TRANGTHAI", loai.TRANGTHAI);
            cmd.Parameters["@TRANGTHAI"].SqlDbType = SqlDbType.Int;
           
            int kq = cmd.ExecuteNonQuery();
            cmd.Dispose();
            clsThaoTacDuLieu.DongKetNoi(con);
        }

        public string Phatsinhma()
        {
            return clsThaoTacDuLieu.DemDong("LOAIMON","MALOAI");
        }

        public System.Data.DataTable LayDSLoai()
        {
            string sql = string.Format("SELECT * FROM LOAIMON WHERE TRANGTHAI != 0");
            return clsThaoTacDuLieu.LayBang(sql);
        }

    }
}
