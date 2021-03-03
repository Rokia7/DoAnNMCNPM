using System;

namespace DTO
{
    public class clsHoaDonBan_DTO
    {
        string _MAHDX;

        public string MAHDX
        {
            get { return _MAHDX; }
            set { _MAHDX = value; }
        }

        string _MAKH;

        public string MAKH
        {
            get { return _MAKH; }
            set { _MAKH = value; }
        }
        string _MANV;

        public string MANV
        {
            get { return _MANV; }
            set { _MANV = value; }
        }
        DateTime _NGAYXUAT;

        public DateTime NGAYXUAT
        {
            get { return _NGAYXUAT; }
            set { _NGAYXUAT = value; }
        }
     
        decimal _TONGTIEN;

        public decimal TONGTIEN
        {
            get { return _TONGTIEN; }
            set { _TONGTIEN = value; }
        }
        string _TenNV;

        public string TenNV
        {
            get { return _TenNV; }
            set { _TenNV = value; }
        }

        string _MaBan;

        public string MaBan
        {
            get { return _MaBan; }
            set { _MaBan = value; }
        }

        string _TenBan;

        public string TenBan
        {
            get { return _TenBan; }
            set { _TenBan = value; }
        }

        int _TrangThai;

        public int TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }

        public DateTime GioBatDau
        {
            get
            {
                return _GioBatDau;
            }

            set
            {
                _GioBatDau = value;
            }
        }

        public DateTime GioKetThuc
        {
            get
            {
                return _GioKetThuc;
            }

            set
            {
                _GioKetThuc = value;
            }
        }

        DateTime _GioBatDau;


        DateTime _GioKetThuc;
    }
}
