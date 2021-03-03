using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class clsKhachHang_BUS
    {
        public List<clsKhachHang_DTO> LayDsKhachHang()
        {
            clsKhachHang_DAO dao = new clsKhachHang_DAO();
            return dao.LayDsKhachHang();
        }

        public clsKhachHang_DTO LayThongTinNhanVien(string strMaNV)
        {
            clsKhachHang_DAO dao = new clsKhachHang_DAO();
            return dao.LayThongTinNhanVien(strMaNV);
        }

        public string PhatSinhMaNV()
        {
            clsKhachHang_DAO dao = new clsKhachHang_DAO();
            return dao.PhatSinhMaNV(); 
        }

        public bool XoaNV(string MaNV)
        {
            clsKhachHang_DAO dao = new clsKhachHang_DAO();
            return dao.XoaNV(MaNV);
        }

        public List<clsKhachHang_DTO> LayDsTatCaNV()
        {
            clsKhachHang_DAO dao = new clsKhachHang_DAO();
            return dao.LayDsTatCaNV();
        }

        public List<clsKhachHang_DTO> LayDsNhanVien(string strTen, string strMa, string strGT)
        {
            clsKhachHang_DAO dao = new clsKhachHang_DAO();
            return dao.LayDsNhanVien(strTen, strMa, strGT);
        }

        public void ThemNV(clsKhachHang_DTO nv)
        {
            clsKhachHang_DAO dao = new clsKhachHang_DAO();
            dao.ThemNV(nv);
        }

        public bool SuaNV(clsKhachHang_DTO nv)
        {
            clsKhachHang_DAO dao = new clsKhachHang_DAO();
            return dao.SuaNV(nv);
        }
    }
}
