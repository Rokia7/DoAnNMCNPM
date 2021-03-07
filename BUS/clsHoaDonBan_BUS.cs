using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class clsHoaDonBan_BUS
    {
        public DataTable LayDsHD(DateTime tu, DateTime den, string maNV)
        {
            clsHoaDonBan_DAO dao = new clsHoaDonBan_DAO();
            return dao.LayDsHD(tu, den, maNV);
        }

        public DataTable LayDsHD(DateTime tu, DateTime den)
        {
            clsHoaDonBan_DAO dao = new clsHoaDonBan_DAO();
            return dao.LayDsHD(tu, den);
        }

        public string PhatSinhMaHD()
        {
            clsHoaDonBan_DAO dao = new clsHoaDonBan_DAO();
            return dao.PhatSinhMaHD();
        }

        public bool UpdateHoaDon(clsHoaDonBan_DTO hoadon)
        {
            clsHoaDonBan_DAO dao = new clsHoaDonBan_DAO();
            return dao.UpdateHoaDon(hoadon);
        }
        public bool LapHoaDonTamThoi(clsHoaDonBan_DTO hoadon)
        {
            clsHoaDonBan_DAO dao = new clsHoaDonBan_DAO();
            return dao.LapHoaDonTamThoi(hoadon);
        }
        public bool LapHoaDon(clsHoaDonBan_DTO hoadon)
        {
            clsHoaDonBan_DAO dao = new clsHoaDonBan_DAO();
            return dao.LapHoaDon(hoadon);
        }

        public bool CapNhatTrangThai(string mahd, int v)
        {
            clsHoaDonBan_DAO dao = new clsHoaDonBan_DAO();
            return dao.CapNhatTrangThai(mahd,v);
        }

        public bool UpdateCAULENH(string P)
        {
            clsHoaDonBan_DAO dao = new clsHoaDonBan_DAO();
            return dao.UpdateCAULENH(P);
        }

        public clsHoaDonBan_DTO LayThongTinHoaDon(string sql)
        {
            clsHoaDonBan_DAO dao = new clsHoaDonBan_DAO();
            return dao.LayThongTinHoaDon(sql);
        }

        //public DataTable LayDsHDBan(string p)
        //{
        //    clsHoaDonBan_DAO dao = new clsHoaDonBan_DAO();
        //    return dao.LayDsHDBan(p);
        //}

            //public DataTable LayDSHDBAN(string p)
            //{
            //    clsHoaDonBan_DAO dao = new clsHoaDonBan_DAO();
            //    return dao.LayDSHDBAN(p);
            //}

        public DataTable LayDSHDBANCAULENH(string p)
        {
            clsHoaDonBan_DAO dao = new clsHoaDonBan_DAO();
            return dao.LayDSHDBANCAULENH(p);
        }

        public decimal LayDsBan(DateTime tu, DateTime den)
        {
            clsHoaDonBan_DAO dao = new clsHoaDonBan_DAO();
            return dao.LayDsBan(tu, den);
        }

        public DataTable LayDsHDBan(DateTime tu, DateTime den, string maNV)
        {
            clsHoaDonBan_DAO dao = new clsHoaDonBan_DAO();
            return dao.LayDsHDBan(tu, den,maNV);
        }
    }
}
