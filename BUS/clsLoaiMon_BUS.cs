using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class clsLoaiMon_BUS
    {
        public List<clsLoaiMon_DTO> LayTatCaLoaiMon()
        {
            clsLoaiMon_DAO dao = new clsLoaiMon_DAO();
            return dao.LayTatCaLoaiMon();
        }

        public System.Data.DataTable LayDSLoai()
        {
            clsLoaiMon_DAO dao = new clsLoaiMon_DAO();
            return dao.LayDSLoai();
        }

        public string Phatsinhma()
        {
            clsLoaiMon_DAO dao = new clsLoaiMon_DAO();
            return dao.Phatsinhma();
        }

        public void themloai(clsLoaiMon_DTO loai)
        {
            clsLoaiMon_DAO dao = new clsLoaiMon_DAO();
            dao.themloai(loai);
        }

        public bool sualoai(clsLoaiMon_DTO loai)
        {
            clsLoaiMon_DAO dao = new clsLoaiMon_DAO();
            return dao.sualoai(loai);
        }

        public bool Xoa(string ma)
        {
            clsLoaiMon_DAO dao = new clsLoaiMon_DAO();
            return dao.Xoa(ma);
        }

        public List<clsLoaiMon_DTO> LayDsloaimon(string strTen, string strMa)
        {
            clsLoaiMon_DAO dao = new clsLoaiMon_DAO();
            return dao.LayDsloaimon(strTen, strMa);
        }
    }
}
