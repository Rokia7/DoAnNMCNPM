using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class clsNhanVien_DTO
    {
        string _MANV;
        public string MANV
        {
            get { return _MANV; }
            set { _MANV = value; }
        }
        string _HOTENNV;

        public string HOTENNV
        {
            get { return _HOTENNV; }
            set { _HOTENNV = value; }
        }

        
        string _MaCV;

        public string MaCV
        {
            get { return _MaCV; }
            set { _MaCV = value; }
        }

        DateTime _NGAYSINH;

        public DateTime NGAYSINH
        {
            get { return _NGAYSINH; }
            set { _NGAYSINH = value; }
        }
        bool _GIOITINH;

        public bool GIOITINH
        {
            get { return _GIOITINH; }
            set { _GIOITINH = value; }
        }
        string _DIACHI;

        public string DIACHI
        {
            get { return _DIACHI; }
            set { _DIACHI = value; }
        }

        string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }

        string _TENDN;

        public string TENDN
        {
            get { return _TENDN; }
            set { _TENDN = value; }
        }
        string _HINHANH;

        public string HINHANH
        {
            get { return _HINHANH; }
            set { _HINHANH = value; }
        }
        int _TRANGTHAI;

        public int TRANGTHAI
        {
            get { return _TRANGTHAI; }
            set { _TRANGTHAI = value; }
        }
        string _MATKHAU;

        public string MATKHAU
        {
            get { return _MATKHAU; }
            set { _MATKHAU = value; }
        }
    }
}
