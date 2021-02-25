using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class clsThucDon_BUS
    {
        clsThaoTacDuLieu dl = new clsThaoTacDuLieu();
        public List<clsThucDon_DTO> LayTatCaDsTD()
        {
            clsThucDon_DAO dao = new clsThucDon_DAO();
            return dao.LayTatCaDsTD();
        }
        public clsThucDon_DTO LayThongTinTD(string maMon)
        {
            clsThucDon_DAO DAO = new clsThucDon_DAO();
            return DAO.LayThongTinTD(maMon);
        }

        public List<clsThucDon_DTO> LayDsThucDon(string strTenvaMa, string strLoai)
        {
            clsThucDon_DAO dao = new clsThucDon_DAO();
            return dao.LayDsThucDon(strTenvaMa,strLoai);
        }

        public bool UpdateTrangThai(int tt, string mamon)
        {
            clsThucDon_DAO dao = new clsThucDon_DAO();
            return dao.UpdateTrangThai(tt, mamon);
        }

        public string PhatSinhMaMon()
        {
            clsThucDon_DAO dao = new clsThucDon_DAO();
            return dao.PhatSinhMaMon();
        }

        public DataTable Laytopthucdonbanchaynhat(string loaimon, DateTime tu, DateTime den, int top)
        {
            clsThucDon_DAO dao = new clsThucDon_DAO();
            return dao.Laytopthucdonbanchaynhat(loaimon,tu,den,top);
        }

        public void ThemTD(clsThucDon_DTO nv)
        {
            clsThucDon_DAO dao = new clsThucDon_DAO();
            dao.ThemTD(nv);
        }

        public bool SuaTD(clsThucDon_DTO nv)
        {
            clsThucDon_DAO dao = new clsThucDon_DAO();
            return dao.SuaNV(nv);
        }

        public bool XoaTD(string mamon)
        {
            clsThucDon_DAO dao = new clsThucDon_DAO();
            return dao.XoaTD(mamon);
        }

        public clsThucDon_DTO ThucDonBanChay()
        {
            clsThucDon_DAO dao = new clsThucDon_DAO();
            return dao.ThucDonBanChay();
        }

        public DataTable LaydsTD(string ma)
        {
            clsThucDon_DAO dao = new clsThucDon_DAO();
            return dao.LaydsTD(ma);
        }

        public DataTable LayTatCaDsThucDonTheoLoai(string MaLoai)
        {
            clsThucDon_DAO dao = new clsThucDon_DAO();
            return dao.LayTatCaDsThucDonTheoLoai(MaLoai);
        }

        public List<clsThucDon_DTO> LayDsThucDon(string strTen, string strLoai, string strtrangthai)
        {
            clsThucDon_DAO dao = new clsThucDon_DAO();
            return dao.LayDsThucDon(strTen, strLoai, strtrangthai);
        }

        public DataTable LayMonTheoLoaiMon(string maloai)
        {
            clsThucDon_DAO dao = new clsThucDon_DAO();
            return dao.LayMonTheoLoaiMon(maloai);
        }

        public bool CapNhatmon(string mamon)
        {
            clsThucDon_DAO dao = new clsThucDon_DAO();
            return dao.CapNhatmon(mamon);
        }
    }
}
