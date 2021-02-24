using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace DAO
{
    public class clsThaoTacDuLieu
    {
       // public static string strChuoiKetNoi = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLCHCF;Integrated Security=True";
        private static string strChuoiKetNoi = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public static SqlConnection TaoKetNoi()
        {
            // 1. Tạo đối tượng kết nối
            SqlConnection con = new SqlConnection(strChuoiKetNoi);
            return con;
        }
        public static SqlConnection TaoVaMoKetNoi()
        {
            // 1. Tạo đối tượng kết nối
            SqlConnection con = new SqlConnection(strChuoiKetNoi);
            // 2. Mở kết nối
            con.Open();
            return con;
        }
        public static string khoitao()
        {
            // 1. Tạo đối tượng kết nối
            return strChuoiKetNoi;

        }
        public static void Khoitaosqlketnoi()
        {
            SqlDependency.Stop(strChuoiKetNoi);
            SqlDependency.Start(strChuoiKetNoi);
            SqlConnection con = new SqlConnection(strChuoiKetNoi);
        }
        public static SqlCommand TaoDoiTuongCommand(SqlConnection con, string sql)
        {
            // 3. Tạo đối tượng command
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = con;
            return cmd;
        }
        public static void DongKetNoi(SqlConnection con)
        {
            // 5. đóng kết nối
            con.Close();
        }
        public static int ExecuteNonQuery(string sql)
        {
            SqlConnection con = TaoVaMoKetNoi();
            SqlCommand cmd = TaoDoiTuongCommand(con, sql);
            int kq = cmd.ExecuteNonQuery();
            cmd.Dispose();
            DongKetNoi(con);
            return kq;
        }
        public static int DemSoLuong(string truyvan)
        {
            //Mở kết nối
            SqlConnection conn = TaoVaMoKetNoi();

            //Command
            SqlCommand cmd = TaoDoiTuongCommand(conn, truyvan);

            //Xử lý dữ liệu
            int count = (int)cmd.ExecuteScalar();

            //Đóng kết nối
            DongKetNoi(conn);
            return count;
        }
        public static DataTable LayBang(string sql)
        {
            DataTable dt = new DataTable();
            SqlConnection con = TaoVaMoKetNoi();
            SqlCommand cmd = TaoDoiTuongCommand(con, sql);
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            DongKetNoi(con);
            return dt;
        }

        //public static DataTable Laydulieu(string sql)
        //{
        //    AutoCompleteStringCollection auto2 = new AutoCompleteStringCollection();
        //    SqlConnection con = TaoVaMoKetNoi();
        //    SqlCommand cmd = TaoDoiTuongCommand(con, sql);
        //    SqlDataAdapter da = new SqlDataAdapter(sql, con);
        //    da.Fill(dt);
        //    DongKetNoi(con);
        //    return dt;
        //}

        public static string DemDong(string TenBang, string TenCot)
        {
            //Mở kết nối
            SqlConnection conn = TaoVaMoKetNoi();

            string truyvan = string.Format("SELECT TOP 1 {0} FROM {1} ORDER BY {0} DESC", TenCot, TenBang);
            //Command
            SqlCommand cmd = TaoDoiTuongCommand(conn, truyvan);


            string KetQua = (string)cmd.ExecuteScalar();

            //Đóng kết nối
            DongKetNoi(conn);
            return KetQua;
        }


        public static bool ThemMoiDuLieu(string truyvan)
        {
            bool kq = false;
            SqlConnection conn = TaoVaMoKetNoi();
            SqlCommand cmd = new SqlCommand(truyvan, conn);
            int count = (int)cmd.ExecuteNonQuery();
            if (count > 0)
                kq = true;
            DongKetNoi(conn);
            return kq;
        }

    
    }
}
