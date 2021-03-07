using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class clsCTBan_DAO
    {
        public DataTable LayDSCTBan()
        {
            string sql = string.Format("Select * From CTBAN");
            return clsThaoTacDuLieu.LayBang(sql);
        }
        public DataTable LayCTBan(string maBan)
        {
            string sql = string.Format("Select ctb.MABAN, ctb.MAMON, td.DVT, ctb.SOLUONG, td.GIA, ctb.SOLUONG * td.GIA as THANHTIEN From CTBAN ctb, MON td Where ctb.MABAN = '{0}' AND td.MAMON = ctb.MAMON", maBan);
            return clsThaoTacDuLieu.LayBang(sql);
        }

        public clsCTBan_DTO LayCTBanCTHD(string sql)
        {
            clsCTBan_DTO ctb = new clsCTBan_DTO();

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
                    ctb.MABAN = (string)dr[0]; // (B)
                if (!dr.IsDBNull(1))
                    ctb.MAMON = (string)dr[1];
                if (!dr.IsDBNull(2))
                    ctb.SOLUONG = (int)dr[2];
                
            }
            // 5. đóng kết nối
            clsThaoTacDuLieu.DongKetNoi(con);

            return ctb;
        }

        public bool LapChiTietBan(string BAN_MaBAN, string MAMON, int SoLuong)
        {
            return clsThaoTacDuLieu.ThemMoiDuLieu(string.Format("INSERT INTO CTBAN (MABAN, MAMON, SOLUONG) VALUES ('{0}', '{1}', {2})", BAN_MaBAN, MAMON, SoLuong));
        }

        public bool UpdateChiTietBan(string BAN_MaBAN, string MAMON, int SoLuong)
        {
            return clsThaoTacDuLieu.ThemMoiDuLieu(string.Format("UPDATE CTBAN SET SOLUONG = {2} WHERE MABAN = '{0}' AND MAMON = '{1}'", BAN_MaBAN, MAMON, SoLuong));
        }

        public bool ChuyenBan(string maban)
        {
            return clsThaoTacDuLieu.ThemMoiDuLieu(string.Format("UPDATE CTBAN SET MAMON = @MAMON , SOLUONG = @SOLUONG WHERE MABAN = '{0}'", maban));
        }

        public bool XoaCTB(string maban)
        {
            string sql = string.Format("DELETE CTBAN WHERE MABAN = '{0}'", maban);
            if (clsThaoTacDuLieu.ExecuteNonQuery(sql) > 0)
                return true;
            return false;
        }


        public bool XoaCTHD(string mahd, string manvl)
        {
            throw new NotImplementedException();
        }
    }
}
