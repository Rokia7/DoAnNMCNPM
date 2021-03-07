using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class clsBan_BUS
    {
      

        public List<clsBan_DTO> LayTatCaDsBan()
        {
            clsBan_DAO dao = new clsBan_DAO();
            return dao.LayTatCaDsBan();
        }
        public clsBan_DTO LayThongTinBanTruyVan(string sql)
        {
            clsBan_DAO dao = new clsBan_DAO();
            return dao.LayThongTinBanTruyVan(sql);
        }

        public clsBan_DTO LayThongTinBan(string maban)
        {
            clsBan_DAO dao = new clsBan_DAO();
            return dao.LayThongTinBan(maban);
        }
        public bool ThemBan(string maban, string tenban)
        {
            clsBan_DAO dao = new clsBan_DAO();
            return dao.ThemBan(maban,tenban);
        }


        public bool MoBan(string maban)
        {
            clsBan_DAO dao = new clsBan_DAO();
            return dao.MoBan(maban);
        }

        public List<clsBan_DTO> LayDsBanDaCoMon()
        {
            clsBan_DAO dao = new clsBan_DAO();
            return dao.LayDsBanDaCoMon();
        }

        public bool HuyBan(string maban)
        {
            clsBan_DAO dao = new clsBan_DAO();
            return dao.HuyBan(maban);
        }

        public bool XoaBan(string maban)
        {
            clsBan_DAO dao = new clsBan_DAO();
            return dao.XoaBan(maban);
        }

        public string PhatSinhMaBan()
        {
            clsBan_DAO dao = new clsBan_DAO();
            return dao.PhatSinhMaBan();
        }
        public List<clsBan_DTO> LayTatCaDsBan(string sql)
        {
            clsBan_DAO dao = new clsBan_DAO();
            return dao.LayTatCaDsBan(sql);
        }

        public SqlConnection Khoitao()
        {
            clsLoaiMon_DAO dao = new clsLoaiMon_DAO();
            return dao.Khoitao();
        }

        public DataTable LayDSBan(SqlConnection con, Action<object, SqlNotificationEventArgs> de_OnChange)
        {
            clsBan_DAO dao = new clsBan_DAO();
            return dao.LayDSBan(con, de_OnChange);
        }

        public DataTable LayDanhSachBanchophache(SqlConnection con, Action<object, SqlNotificationEventArgs> de_OnChange)
        {
            clsBan_DAO dao = new clsBan_DAO();
            return dao.LayDanhSachBanchophache(con, de_OnChange);
        }
    }
}
