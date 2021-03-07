using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class clsCTHDBan_BUS
    {
        public DataTable LayCTHD(string mahd)
        {
            clsCTHDBan_DAO DAO = new clsCTHDBan_DAO();
            return DAO.LayCTHD(mahd);
        }

        public clsCTHDBan_DTO LayCTHDclsCTHDBan_DTO(string sql)
        {
            clsCTHDBan_DAO DAO = new clsCTHDBan_DAO();
            return DAO.LayCTHDclsCTHDBan_DTO(sql);
        }
        public bool LapChiTietHoaDon(string HD_MaHD, string MAMON, int CTHD_SoLuong,decimal gia,string GhiChu)
        {
            clsCTHDBan_DAO dao = new clsCTHDBan_DAO();
            return dao.LapChiTietHoaDon(HD_MaHD, MAMON, CTHD_SoLuong,gia,GhiChu);
        }

        public bool UpdateChiTietHoaDon(string HD_MaHD, string MAMON, int CTHD_SoLuong, decimal gia,string GhiChu)
        {
            clsCTHDBan_DAO dao = new clsCTHDBan_DAO();
            return dao.UpdateChiTietHoaDon(HD_MaHD, MAMON, CTHD_SoLuong, gia,GhiChu);
        }

        public bool LuuGhiChu(string mahd, string mamon, string ghiChu)
        {
            clsCTHDBan_DAO DAO = new clsCTHDBan_DAO();
            return DAO.LuuGhiChu(mahd,mamon,ghiChu);
           
        }

        public DataTable LayCTHDCAULENH(string P)
        {
            clsCTHDBan_DAO DAO = new clsCTHDBan_DAO();
            return DAO.LayCTHDCAULENH(P);
        }

       


        //public DataTable LayDSHDBAN(string p)
        //{
        //    clsCTHDBan_DAO DAO = new clsCTHDBan_DAO();
        //    return DAO.LayCTHD(p);
        //}

        public DataTable LayCTHDBan(string p)
        {
            clsCTHDBan_DAO DAO = new clsCTHDBan_DAO();
            return DAO.LayCTHD(p);
        }


        public bool XoaCTHD(string mahd)
        {
            clsCTHDBan_DAO dao = new clsCTHDBan_DAO();
            return dao.XoaCTHD(mahd);
        }

        public bool XoaCTHDCAULENH(string sql)
        {
            clsCTHDBan_DAO dao = new clsCTHDBan_DAO();
            return dao.XoaCTHDCAULENH(sql);
        }

        public int LayTongSoMon(string mahd)
        {
            clsCTHDBan_DAO dao = new clsCTHDBan_DAO();
            return dao.LayTongSoMon(mahd);
        }

        public decimal LayTongTien(string mahd)
        {
            clsCTHDBan_DAO dao = new clsCTHDBan_DAO();
            return dao.LayTongTien(mahd);
        }

        public bool UpdateSoLuongDaPhaChe(string mahd, string mamon, int soluong)
        {
            clsCTHDBan_DAO dao = new clsCTHDBan_DAO();
            return dao.UpdateSoLuongDaPhaChe(mahd,mamon,soluong);
        }
    }
}
