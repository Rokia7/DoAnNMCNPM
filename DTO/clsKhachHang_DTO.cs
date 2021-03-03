using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class clsKhachHang_DTO
    {
        string _MAKH;

        public string MAKH
        {
            get { return _MAKH; }
            set { _MAKH = value; }
        }
        string _TENKH;

        public string TENKH
        {
            get { return _TENKH; }
            set { _TENKH = value; }
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
        DateTime _NGAYSINH;

        public DateTime NGAYSINH
        {
            get { return _NGAYSINH; }
            set { _NGAYSINH = value; }
        }
        string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
        float _CHIEUKHAU;

        public float CHIEUKHAU
        {
            get { return _CHIEUKHAU; }
            set { _CHIEUKHAU = value; }
        }

        int _TRANGTHAI;

        public int TRANGTHAI
        {
            get { return _TRANGTHAI; }
            set { _TRANGTHAI = value; }
        }


    }
}
