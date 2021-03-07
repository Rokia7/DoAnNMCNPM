using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class clsKhachHang_DAO
    {
        public List<clsKhachHang_DTO> LayDsKhachHang()
        {
            string sql = string.Format("SELECT * FROM KHACHHANGTHANTHIET WHERE TRANGTHAI = 1");
            return LayDsKhachHang(sql);
        }

        public List<clsKhachHang_DTO> LayDsKhachHang(string sql)
        {
            List<clsKhachHang_DTO> lsKH = new List<clsKhachHang_DTO>();

            // 1,2. Tạo và mở kết nối
            //sql = string.Format("SELECT MANV, HOTENNV, LUONG, MaCV, THOIGIANLAM, NGAYSINH, GIOITINH, SDT, HINHANH, TRANGTHAI,DIACHI  FROM NHANVIEN WHERE TrangThai = 1");
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            // 3. Tạo đối tượng truy vấn
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            // 4. thực thi cmd và xử lý kết quả
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsKhachHang_DTO kh = new clsKhachHang_DTO();
                if (!dr.IsDBNull(0)) // (A)
                    kh.MAKH = (string)dr[0]; // (B)
                if (!dr.IsDBNull(1))
                    kh.TENKH = (string)dr[1];
             
                if (!dr.IsDBNull(2))
                    kh.GIOITINH = dr.GetBoolean(2); // (C)
                if (!dr.IsDBNull(3))
                    kh.DIACHI = (string)dr[3];
                if (!dr.IsDBNull(4))
                    kh.NGAYSINH = (DateTime)dr[4];
                if (!dr.IsDBNull(5))
                    kh.SDT = (string)dr[5];
                if (!dr.IsDBNull(6))
                    kh.CHIEUKHAU = (float)dr.GetDouble(6);
                lsKH.Add(kh);
                
            }
            // 5. đóng kết nối
            clsThaoTacDuLieu.DongKetNoi(con);

            return lsKH;
        }

        public clsKhachHang_DTO LayThongTinNhanVien(string strMaNV)
        {
            clsKhachHang_DTO kh = new clsKhachHang_DTO();

            // 1,2. Tạo và mở kết nối
            string sql = string.Format("SELECT * FROM KHACHHANGTHANTHIET WHERE MAKH = '{0}'", strMaNV);
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            // 3. Tạo đối tượng truy vấn
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            // 4. thực thi cmd và xử lý kết quả
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (!dr.IsDBNull(0)) // (A)
                    kh.MAKH = (string)dr[0]; // (B)
                if (!dr.IsDBNull(1))
                    kh.TENKH = (string)dr[1];

                if (!dr.IsDBNull(2))
                    kh.GIOITINH = dr.GetBoolean(2); // (C)
                if (!dr.IsDBNull(3))
                    kh.DIACHI = (string)dr[3];
                if (!dr.IsDBNull(4))
                    kh.NGAYSINH = (DateTime)dr[4];
                if (!dr.IsDBNull(5))
                    kh.SDT = (string)dr[5];
                if (!dr.IsDBNull(6))
                    kh.CHIEUKHAU = (float)dr.GetDouble(6);

            }
            // 5. đóng kết nối
            clsThaoTacDuLieu.DongKetNoi(con);

            return kh;
        }



        public string PhatSinhMaNV()
        {
            return clsThaoTacDuLieu.DemDong("KHACHHANGTHANTHIET", "MAKH");
        }

        public bool XoaNV(string MaNV)
        {
            string sql = string.Format("UPDATE KHACHHANGTHANTHIET SET TRANGTHAI = 0 WHERE MAKH = '{0}'", MaNV);
            if (clsThaoTacDuLieu.ExecuteNonQuery(sql) > 0)
                return true;
            return false;
        }

        public List<clsKhachHang_DTO> LayDsTatCaNV()
        {
            string sql = string.Format("SELECT * FROM KHACHHANGTHANTHIET WHERE TRANGTHAI = 1");
            return LayDsKhachHang(sql);
        }

        public List<clsKhachHang_DTO> LayDsNhanVien(string strTen, string strMa, string strGT)
        {
            // Tạo câu truy vấn SQL
            string sql = string.Format("SELECT * FROM KHACHHANGTHANTHIET WHERE TRANGTHAI = 1");
            if (strTen != "-1")
                sql += string.Format(" AND TENKH LIKE N'%{0}%'", strTen);
            if (strMa != "-1")
                sql += string.Format(" AND MAKH LIKE N'%{0}%'", strMa);
            if (strGT != "-1")
            {
                bool gt;
                if (strGT == "Nam")
                    gt = true;
                else
                    gt = false;
                sql += string.Format(" AND GIOITINH = N'{0}'", gt);
            }
         

            return LayDsKhachHang(sql);
        }

        public void ThemNV(clsKhachHang_DTO nv)
        {
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = @"INSERT INTO KHACHHANGTHANTHIET (MAKH, TENKH,NGAYSINH, GIOITINH, SDT,TRANGTHAI,DIACHI,CHIETKHAU) VALUES (@MAKH, @TENKH, @NGAYSINH, @GIOITINH, @SDT, @TRANGTHAI, @DIACHI, @CHIETKHAU)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@MAKH", nv.MAKH);
            cmd.Parameters["@MAKH"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.AddWithValue("@TENKH", nv.TENKH);
            cmd.Parameters["@TENKH"].SqlDbType = SqlDbType.NVarChar;
            

            cmd.Parameters.AddWithValue("@NGAYSINH", nv.NGAYSINH);
            cmd.Parameters["@NGAYSINH"].SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.AddWithValue("@GIOITINH", nv.GIOITINH);
            cmd.Parameters["@GIOITINH"].SqlDbType = SqlDbType.Bit;
            cmd.Parameters.AddWithValue("@SDT", nv.SDT);
            cmd.Parameters["@SDT"].SqlDbType = SqlDbType.NChar;
          
            cmd.Parameters.AddWithValue("@TRANGTHAI", nv.TRANGTHAI);
            cmd.Parameters["@TRANGTHAI"].SqlDbType = SqlDbType.Int;
            cmd.Parameters.AddWithValue("@DIACHI", nv.DIACHI);
            cmd.Parameters["@DIACHI"].SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.AddWithValue("@CHIETKHAU", nv.CHIEUKHAU);
            cmd.Parameters["@CHIETKHAU"].SqlDbType = SqlDbType.Float;
            int kq = cmd.ExecuteNonQuery();
            cmd.Dispose();
            clsThaoTacDuLieu.DongKetNoi(con);
        }

        public bool SuaNV(clsKhachHang_DTO nv)
        {
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = @"UPDATE KHACHHANGTHANTHIET SET TENKH = @TENKH, NGAYSINH = @NGAYSINH, GIOITINH = @GIOITINH, SDT = @SDT,TRANGTHAI = @TRANGTHAI,DIACHI = @DIACHI,CHIETKHAU = @CHIETKHAU WHERE MAKH = @MAKH";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@MAKH", nv.MAKH);
            cmd.Parameters["@MAKH"].SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.AddWithValue("@TENKH", nv.TENKH);
            cmd.Parameters["@TENKH"].SqlDbType = SqlDbType.NVarChar;


            cmd.Parameters.AddWithValue("@NGAYSINH", nv.NGAYSINH);
            cmd.Parameters["@NGAYSINH"].SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.AddWithValue("@GIOITINH", nv.GIOITINH);
            cmd.Parameters["@GIOITINH"].SqlDbType = SqlDbType.Bit;
            cmd.Parameters.AddWithValue("@SDT", nv.SDT);
            cmd.Parameters["@SDT"].SqlDbType = SqlDbType.NChar;

            cmd.Parameters.AddWithValue("@TRANGTHAI", nv.TRANGTHAI);
            cmd.Parameters["@TRANGTHAI"].SqlDbType = SqlDbType.Int;
            cmd.Parameters.AddWithValue("@DIACHI", nv.DIACHI);
            cmd.Parameters["@DIACHI"].SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.AddWithValue("@CHIETKHAU", nv.CHIEUKHAU);
            cmd.Parameters["@CHIETKHAU"].SqlDbType = SqlDbType.Float;
            int kq = cmd.ExecuteNonQuery();
            cmd.Dispose();
            clsThaoTacDuLieu.DongKetNoi(con);
            if (kq == 1)
                return true;
            return false;
        }
    }
}
