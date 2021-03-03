using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class clsCTBan_BUS
    {
        public DataTable LayDSCTBan()
        {
            clsCTBan_DAO dao = new clsCTBan_DAO();
            return dao.LayDSCTBan();
        }
        public DataTable LayCTBan(string maBan)
        {
            clsCTBan_DAO dao = new clsCTBan_DAO();
            return dao.LayCTBan(maBan);
        }

        public clsCTBan_DTO LayCTBanCTHD(string sql)
        {
            clsCTBan_DAO dao = new clsCTBan_DAO();
            return dao.LayCTBanCTHD(sql);
        }
        public bool LapChiTietBan(string BAN_MaBAN, string MAMON, int SoLuong)
        {
            clsCTBan_DAO dao = new clsCTBan_DAO();
            return dao.LapChiTietBan(BAN_MaBAN, MAMON, SoLuong);
        }
        public bool UpdateChiTietBan(string BAN_MaBAN, string MAMON, int SoLuong)
        {
            clsCTBan_DAO dao = new clsCTBan_DAO();
            return dao.UpdateChiTietBan(BAN_MaBAN, MAMON, SoLuong);
        }
        public bool XoaCTB(string maban)
        {
            clsCTBan_DAO dao = new clsCTBan_DAO();
            return dao.XoaCTB(maban);
        }
        public bool ChuyenBan(string maban)
        {
            clsCTBan_DAO dao = new clsCTBan_DAO();
            return dao.ChuyenBan(maban);
        }
    }
}
