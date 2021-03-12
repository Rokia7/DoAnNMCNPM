using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class clsNhanVien_DAO
    {
        public bool KiemTraDangNhap(string strMANV, string strMK)
        {
            // Hàm này Kiểm tra xem strMaNV và strMK có đúng với trong CSDL không?
            // Sử dụng ADO.NET với mô hình kết nối
            bool kq = false;
            // 1,2. Tạo và mở kết nối
            string sql = string.Format("SELECT COUNT(*) FROM NHANVIEN WHERE MANV = '{0}' AND MATKHAU = '{1}'", strMANV, strMK);
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            // 3. Tạo đối tượng truy vấn
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            // 4. thực thi cmd và xử lý kết quả
            int iRow = (int)cmd.ExecuteScalar();
            if (iRow == 1)
                kq = true;
            // 5. đóng kết nối
            clsThaoTacDuLieu.DongKetNoi(con);

            return kq;
        }
        public clsNhanVien_DTO LayThongTinNhanVien(string strMaNV)
        {
            clsNhanVien_DTO nv = new clsNhanVien_DTO();

            // 1,2. Tạo và mở kết nối
            string sql = string.Format("SELECT MANV, HOTENNV, MaCV, NGAYSINH,GIOITINH,SDT,HINHANH,TRANGTHAI,DIACHI,MATKHAU FROM NHANVIEN WHERE MANV = '{0}'", strMaNV);
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            // 3. Tạo đối tượng truy vấn
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            // 4. thực thi cmd và xử lý kết quả
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (!dr.IsDBNull(0)) // (A)
                    nv.MANV = (string)dr[0]; // (B)
                if (!dr.IsDBNull(1))
                    nv.HOTENNV = (string)dr[1];
                if (!dr.IsDBNull(2))
                    nv.MaCV = (string)dr[2];

                if (!dr.IsDBNull(3))
                    nv.NGAYSINH = dr.GetDateTime(3);
                if (!dr.IsDBNull(4))
                    nv.GIOITINH = dr.GetBoolean(4); // (C)
                if (!dr.IsDBNull(5))
                    nv.SDT = (string)dr[5];

                if (!dr.IsDBNull(6))
                    nv.HINHANH = dr.GetString(6);
                if (!dr.IsDBNull(7))
                    nv.TRANGTHAI = (int)dr[7]; // (D)
                if (!dr.IsDBNull(8))
                    nv.DIACHI = (string)dr[8];
                if (!dr.IsDBNull(9))
                    nv.MATKHAU = (string)dr[9];

            }
            // 5. đóng kết nối
            clsThaoTacDuLieu.DongKetNoi(con);

            return nv;
        }

        public double DemSoLuongNhanVien()
        {
            string sql = string.Format("SELECT count(*) FROM NHANVIEN WHERE TRANGTHAI = 1");

            return clsThaoTacDuLieu.DemSoLuong(sql);

            //Đóng kết nối

        }

        public DataTable LayDsNVThayDoiCV()
        {
            string sql = string.Format("SELECT * FROM NHANVIEN WHERE TRANGTHAI = 1");
            return clsThaoTacDuLieu.LayBang(sql);
        }

        public DataTable LayDsNV()
        {
            string sql = string.Format("SELECT MANV,LUONG FROM NHANVIEN WHERE TRANGTHAI = 1");
            return clsThaoTacDuLieu.LayBang(sql);
        }

        public List<clsNhanVien_DTO> LayDsTatCaNVCon()
        {
            List<clsNhanVien_DTO> lsNV = new List<clsNhanVien_DTO>();

            // 1,2. Tạo và mở kết nối
            string sql = string.Format("SELECT MANV, HOTENNV, MaCV, NGAYSINH, GIOITINH, SDT, HINHANH, TRANGTHAI,DIACHI  FROM NHANVIEN WHERE TRANGTHAI = 1");
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            // 3. Tạo đối tượng truy vấn
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            // 4. thực thi cmd và xử lý kết quả
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsNhanVien_DTO nv = new clsNhanVien_DTO();
                if (!dr.IsDBNull(0)) // (A)
                    nv.MANV = (string)dr[0]; // (B)
                if (!dr.IsDBNull(1))
                    nv.HOTENNV = (string)dr[1];
                if (!dr.IsDBNull(2))
                    nv.MaCV = (string)dr[2];

                if (!dr.IsDBNull(3))
                    nv.NGAYSINH = dr.GetDateTime(3);
                if (!dr.IsDBNull(4))
                    nv.GIOITINH = dr.GetBoolean(4); // (C)
                if (!dr.IsDBNull(5))
                    nv.SDT = (string)dr[5];

                if (!dr.IsDBNull(6))
                    nv.HINHANH = dr.GetString(6);
                if (!dr.IsDBNull(7))
                    nv.TRANGTHAI = (int)dr[7]; // (D)
                if (!dr.IsDBNull(8))
                    nv.DIACHI = (string)dr[8];
                lsNV.Add(nv);
            }
            // 5. đóng kết nối
            clsThaoTacDuLieu.DongKetNoi(con);

            return lsNV;
        }

        public List<clsNhanVien_DTO> LayDsTatCaNVNghi()
        {
            List<clsNhanVien_DTO> lsNV = new List<clsNhanVien_DTO>();

            // 1,2. Tạo và mở kết nối
            string sql = string.Format("SELECT MANV, HOTENNV, MaCV, NGAYSINH, GIOITINH, SDT, HINHANH, TRANGTHAI,DIACHI  FROM NHANVIEN WHERE TRANGTHAI = 0");
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            // 3. Tạo đối tượng truy vấn
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            // 4. thực thi cmd và xử lý kết quả
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsNhanVien_DTO nv = new clsNhanVien_DTO();
                if (!dr.IsDBNull(0)) // (A)
                    nv.MANV = (string)dr[0]; // (B)
                if (!dr.IsDBNull(1))
                    nv.HOTENNV = (string)dr[1];
                if (!dr.IsDBNull(2))
                    nv.MaCV = (string)dr[2];

                if (!dr.IsDBNull(3))
                    nv.NGAYSINH = dr.GetDateTime(3);
                if (!dr.IsDBNull(4))
                    nv.GIOITINH = dr.GetBoolean(4); // (C)
                if (!dr.IsDBNull(5))
                    nv.SDT = (string)dr[5];

                if (!dr.IsDBNull(6))
                    nv.HINHANH = dr.GetString(6);
                if (!dr.IsDBNull(7))
                    nv.TRANGTHAI = (int)dr[7]; // (D)
                if (!dr.IsDBNull(8))
                    nv.DIACHI = (string)dr[8];
                lsNV.Add(nv);
            }
            // 5. đóng kết nối
            clsThaoTacDuLieu.DongKetNoi(con);

            return lsNV;
        }

        public DataTable LayDstcNV()
        {
            string sql = string.Format("SELECT MANV,LUONG FROM NHANVIEN WHERE TRANGTHAI = 1");
            return clsThaoTacDuLieu.LayBang(sql);
        }

        public bool ThemNV(clsNhanVien_DTO nv)
        {
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = @"INSERT INTO NHANVIEN (MANV, HOTENNV, MaCV, NGAYSINH, GIOITINH, SDT, HINHANH, TRANGTHAI,DIACHI,MATKHAU) VALUES (@MANV, @HOTENNV, @MaCV, @NGAYSINH, @GIOITINH, @SDT, @HINHANH, @TRANGTHAI, @DIACHI, @MATKHAU)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@MANV", nv.MANV);
            cmd.Parameters["@MANV"].SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.AddWithValue("@HOTENNV", nv.HOTENNV);
            cmd.Parameters["@HOTENNV"].SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.AddWithValue("@MaCV", nv.MaCV);
            cmd.Parameters["@MaCV"].SqlDbType = SqlDbType.NVarChar;

            cmd.Parameters.AddWithValue("@NGAYSINH", nv.NGAYSINH);
            cmd.Parameters["@NGAYSINH"].SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.AddWithValue("@GIOITINH", nv.GIOITINH);
            cmd.Parameters["@GIOITINH"].SqlDbType = SqlDbType.Bit;
            cmd.Parameters.AddWithValue("@SDT", nv.SDT);
            cmd.Parameters["@SDT"].SqlDbType = SqlDbType.NChar;
            cmd.Parameters.AddWithValue("@HINHANH", nv.HINHANH);
            cmd.Parameters["@HINHANH"].SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.AddWithValue("@TRANGTHAI", nv.TRANGTHAI);
            cmd.Parameters["@TRANGTHAI"].SqlDbType = SqlDbType.Int;
            cmd.Parameters.AddWithValue("@DIACHI", nv.DIACHI);
            cmd.Parameters["@DIACHI"].SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.AddWithValue("@MATKHAU", nv.MATKHAU);
            cmd.Parameters["@MATKHAU"].SqlDbType = SqlDbType.NVarChar;
            int kq = cmd.ExecuteNonQuery();
            cmd.Dispose();
            clsThaoTacDuLieu.DongKetNoi(con);
            if (kq == 1)
                return true;
            return false;
        }
        public bool SuaNV(clsNhanVien_DTO nv)
        {
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = @"UPDATE NHANVIEN SET HOTENNV = @HOTENNV, MaCV = @MaCV, NGAYSINH = @NGAYSINH, GIOITINH = @GIOITINH, SDT = @SDT, MATKHAU = @MATKHAU, HINHANH = @HINHANH, TRANGTHAI = @TRANGTHAI,DIACHI = @DIACHI WHERE MANV = @MANV";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@HOTENNV", nv.HOTENNV);
            cmd.Parameters["@HOTENNV"].SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.AddWithValue("@MaCV", nv.MaCV);
            cmd.Parameters["@MaCV"].SqlDbType = SqlDbType.NVarChar;

            cmd.Parameters.AddWithValue("@NGAYSINH", nv.NGAYSINH);
            cmd.Parameters["@NGAYSINH"].SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.AddWithValue("@GIOITINH", nv.GIOITINH);
            cmd.Parameters["@GIOITINH"].SqlDbType = SqlDbType.Bit;
            cmd.Parameters.AddWithValue("@SDT", nv.SDT);
            cmd.Parameters["@SDT"].SqlDbType = SqlDbType.NChar;
            cmd.Parameters.AddWithValue("@HINHANH", nv.HINHANH);
            cmd.Parameters["@HINHANH"].SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.AddWithValue("@TRANGTHAI", nv.TRANGTHAI);
            cmd.Parameters["@TRANGTHAI"].SqlDbType = SqlDbType.Int;
            cmd.Parameters.AddWithValue("@DIACHI", nv.DIACHI);
            cmd.Parameters["@DIACHI"].SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.AddWithValue("@MATKHAU", nv.MATKHAU);
            cmd.Parameters["@MATKHAU"].SqlDbType = SqlDbType.NVarChar;

            cmd.Parameters.AddWithValue("@MANV", nv.MANV);
            cmd.Parameters["@MANV"].SqlDbType = SqlDbType.NVarChar;
            int kq = cmd.ExecuteNonQuery();
            cmd.Dispose();
            clsThaoTacDuLieu.DongKetNoi(con);
            if (kq == 1)
                return true;
            return false;
        }
        public bool XoaNV(string manv)
        {
            string sql = string.Format("UPDATE NHANVIEN SET TRANGTHAI = 0 WHERE MANV = '{0}'", manv);
            if (clsThaoTacDuLieu.ExecuteNonQuery(sql) > 0)
                return true;
            return false;
        }

        public bool UpdateCVPhucVu(string manv)
        {
            string sql = string.Format("UPDATE NHANVIEN SET MACV = 3 WHERE MANV = '{0}'", manv);
            if (clsThaoTacDuLieu.ExecuteNonQuery(sql) > 0)
                return true;
            return false;
        }

        public List<clsNhanVien_DTO> LayDsNhanVien()
        {
            string sql = string.Format("SELECT * FROM NHANVIEN WHERE TRANGTHAI = 1");
            return LayDsNhanVien(sql);
        }
        public List<clsNhanVien_DTO> LayDsNhanVien(string strTen, string strMa, string strGioiTinh, int intTrangThai)
        {
            // Tạo câu truy vấn SQL
            string sql = string.Format("SELECT MANV, HOTENNV, MaCV, NGAYSINH, GIOITINH, SDT, HINHANH, TRANGTHAI,DIACHI FROM NHANVIEN WHERE TRANGTHAI = {0}", intTrangThai != -1 ? intTrangThai : 1);
            if (strTen != "-1")
            {
                sql += string.Format(" AND (HOTENNV LIKE N'%{0}%'", strTen);
                sql += string.Format(" OR MANV LIKE '%{0}%')", strMa);
            }
            if (strGioiTinh != "-1")
            {
                bool gt;
                if (strGioiTinh == "Nam")
                    gt = true;
                else
                    gt = false;
                sql += string.Format(" AND GIOITINH = '{0}'", gt);
            }
            return LayDsNhanVien(sql);
        }

        public List<clsNhanVien_DTO> LayDsNhanVien(string sql)
        {
            List<clsNhanVien_DTO> lsNV = new List<clsNhanVien_DTO>();

            // 1,2. Tạo và mở kết nối
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            // 3. Tạo đối tượng truy vấn
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            // 4. thực thi cmd và xử lý kết quả
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsNhanVien_DTO nv = new clsNhanVien_DTO();
                if (!dr.IsDBNull(0)) // (A)
                    nv.MANV = (string)dr[0]; // (B)
                if (!dr.IsDBNull(1))
                    nv.HOTENNV = (string)dr[1];
                if (!dr.IsDBNull(2))
                    nv.MaCV = (string)dr[2];

                if (!dr.IsDBNull(3))
                    nv.NGAYSINH = dr.GetDateTime(3);
                if (!dr.IsDBNull(4))
                    nv.GIOITINH = dr.GetBoolean(4); // (C)
                if (!dr.IsDBNull(5))
                    nv.SDT = (string)dr[5];

                if (!dr.IsDBNull(6))
                    nv.HINHANH = dr.GetString(6);
                if (!dr.IsDBNull(7))
                    nv.TRANGTHAI = (int)dr[7]; // (D)
                if (!dr.IsDBNull(8))
                    nv.DIACHI = (string)dr[8];
                lsNV.Add(nv);
            }
            // 5. đóng kết nối
            clsThaoTacDuLieu.DongKetNoi(con);

            return lsNV;
        }




        public string PhatSinhMaNV()
        {
            return clsThaoTacDuLieu.DemDong("NHANVIEN", "MANV");
        }

        public bool DoiMauKhau(string manv, string matkhaumoi)
        {
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("update NHANVIEN set MATKHAU = @matkhaumoi where MANV = @manv");
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@matkhaumoi", matkhaumoi);
            cmd.Parameters["@matkhaumoi"].SqlDbType = SqlDbType.NChar;
            cmd.Parameters.AddWithValue("@MaNV", manv);
            cmd.Parameters["@MaNV"].SqlDbType = SqlDbType.VarChar;

            int kq = 1;
            if (kq == cmd.ExecuteNonQuery())
            {
                return true;

            }
            clsThaoTacDuLieu.DongKetNoi(con);
            return false;
        }
    }
}