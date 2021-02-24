using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class clsBan_DAO
    {

        public List<clsBan_DTO> LayTatCaDsBan()
        {
            List<clsBan_DTO> lsBan = new List<clsBan_DTO>();

            // 1,2. Tạo và mở kết nối
            string sql = string.Format("SELECT * FROM BAN WHERE TRANGTHAI != 0 ");
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            // 3. Tạo đối tượng truy vấn
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            // 4. thực thi cmd và xử lý kết quả
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsBan_DTO b = new clsBan_DTO();
                if (!dr.IsDBNull(0))
                    b.MABAN = (string)dr[0];
                if (!dr.IsDBNull(1))
                    b.TENBAN = (string)dr[1];
                if (!dr.IsDBNull(2))
                    b.TRANGTHAI = (int)dr[2];
                lsBan.Add(b);
            }
            // 5. đóng kết nối
            clsThaoTacDuLieu.DongKetNoi(con);

            return lsBan;
        }

        public List<clsBan_DTO> LayDsBanDaCoMon()
        {
            List<clsBan_DTO> lsBan = new List<clsBan_DTO>();

            // 1,2. Tạo và mở kết nối
            string sql = string.Format("SELECT * FROM BAN WHERE TRANGTHAI = 1 ");
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            // 3. Tạo đối tượng truy vấn
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            // 4. thực thi cmd và xử lý kết quả
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsBan_DTO b = new clsBan_DTO();
                if (!dr.IsDBNull(0))
                    b.MABAN = (string)dr[0];
                if (!dr.IsDBNull(1))
                    b.TENBAN = (string)dr[1];
                if (!dr.IsDBNull(2))
                    b.TRANGTHAI = (int)dr[2];
                lsBan.Add(b);
            }
            // 5. đóng kết nối
            clsThaoTacDuLieu.DongKetNoi(con);

            return lsBan;
        }

        public DataTable LayDSBan(SqlConnection con, Action<object, SqlNotificationEventArgs> de_OnChange)
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("SELECT   MABAN, TENBAN, TRANGTHAI  from dbo.BAN  WHERE TRANGTHAI != 0", con);
            cmd.Notification = null;

            SqlDependency de = new SqlDependency(cmd);
            de.OnChange += new OnChangeEventHandler(de_OnChange);

            //dt = ToDataTable<clsLoaiMon_DTO>(lsLoaiMon);
            dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            //dataGridView1.DataSource = dt;
            //MessageBox.Show("abc");
            return dt;
        }

        public DataTable LayDanhSachBanchophache(SqlConnection con, Action<object, SqlNotificationEventArgs> de_OnChange)
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("SELECT   MABAN, TENBAN, TRANGTHAI  from dbo.BAN  WHERE TRANGTHAI = 1", con);
            cmd.Notification = null;

            SqlDependency de = new SqlDependency(cmd);
            de.OnChange += new OnChangeEventHandler(de_OnChange);

            //dt = ToDataTable<clsLoaiMon_DTO>(lsLoaiMon);
            dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            //dataGridView1.DataSource = dt;
            //MessageBox.Show("abc");
            return dt;
        }

        public List<clsBan_DTO> LayTatCaDsBan(string sql)
        {
            List<clsBan_DTO> lsBan = new List<clsBan_DTO>();

            // 1,2. Tạo và mở kết nối
            //string sql = string.Format("SELECT * FROM DMBAN");
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            // 3. Tạo đối tượng truy vấn
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            // 4. thực thi cmd và xử lý kết quả
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsBan_DTO b = new clsBan_DTO();
                if (!dr.IsDBNull(0))
                    b.MABAN = (string)dr[0];
                if (!dr.IsDBNull(1))
                    b.TENBAN = (string)dr[1];
                if (!dr.IsDBNull(2))
                    b.TRANGTHAI = (int)dr[2];
                lsBan.Add(b);
            }
            // 5. đóng kết nối
            clsThaoTacDuLieu.DongKetNoi(con);

            return lsBan;
        }

        public clsBan_DTO LayThongTinBanTruyVan(string sql)
        {
            clsBan_DTO b = new clsBan_DTO();
            //string sql = string.Format("SELECT * FROM DMBAN WHERE TTXOA = 1");
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            // 3. Tạo đối tượng truy vấn
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            // 4. thực thi cmd và xử lý kết quả
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                if (!dr.IsDBNull(0))
                    b.MABAN = (string)dr[0];
                if (!dr.IsDBNull(1))
                    b.TENBAN = (string)dr[1];
                if (!dr.IsDBNull(2))
                    b.TRANGTHAI = (int)dr[2];

            }
            // 5. đóng kết nối
            clsThaoTacDuLieu.DongKetNoi(con);

            return b;
        }


        public clsBan_DTO LayThongTinBan(string maban)
        {
            clsBan_DTO b = new clsBan_DTO();
            string sql = string.Format("SELECT * FROM BAN WHERE TRANGTHAI != 0 AND MABAN = '{0}'",maban);
            SqlConnection con = clsThaoTacDuLieu.TaoVaMoKetNoi();
            // 3. Tạo đối tượng truy vấn
            SqlCommand cmd = clsThaoTacDuLieu.TaoDoiTuongCommand(con, sql);
            // 4. thực thi cmd và xử lý kết quả
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                if (!dr.IsDBNull(0))
                    b.MABAN = (string)dr[0];
                if (!dr.IsDBNull(1))
                    b.TENBAN = (string)dr[1];
                if (!dr.IsDBNull(2))
                    b.TRANGTHAI = (int)dr[2];
                
            }
            // 5. đóng kết nối
            clsThaoTacDuLieu.DongKetNoi(con);

            return b;
        }

        public bool ThemBan(string maban, string tenban)
        {
            return clsThaoTacDuLieu.ThemMoiDuLieu(string.Format("INSERT INTO BAN (MABAN, TENBAN,TRANGTHAI) VALUES ('{0}','{1}',2)", maban, tenban));
        }

        public bool MoBan(string maban)
        {
            return clsThaoTacDuLieu.ThemMoiDuLieu(string.Format("UPDATE BAN SET TRANGTHAI = 1 WHERE MABAN = '{0}'",maban));
        }

        public bool HuyBan(string maban)
        {
            return clsThaoTacDuLieu.ThemMoiDuLieu(string.Format("UPDATE BAN SET TRANGTHAI = 2 WHERE MABAN = '{0}'", maban));
        }

        public bool XoaBan(string maban)
        {
            return clsThaoTacDuLieu.ThemMoiDuLieu(string.Format("UPDATE BAN SET TRANGTHAI = 0 WHERE MABAN = '{0}'", maban));
        }
     

        public string PhatSinhMaBan()
        {
            return clsThaoTacDuLieu.DemDong("BAN", "MABAN");
        }
    }
}
