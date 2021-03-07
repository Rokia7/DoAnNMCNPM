using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class clsCTHDBan_DTO
    {
        string _MABAN;

        public string MABAN
        {
            get { return _MABAN; }
            set { _MABAN = value; }
        }
        string _MAHD;

        public string MAHD
        {
            get { return _MAHD; }
            set { _MAHD = value; }
        }
        string _MAMON;

        public string MAMON
        {
            get { return _MAMON; }
            set { _MAMON = value; }
        }
        int _SOLUONG;

        public int SOLUONG
        {
            get { return _SOLUONG; }
            set { _SOLUONG = value; }
        }

        decimal _GIA;

        public decimal GIA
        {
            get { return _GIA; }
            set { _GIA = value; }
        }

        public string GHICHU
        {
            get
            {
                return _GHICHU;
            }

            set
            {
                _GHICHU = value;
            }
        }

        string _GHICHU;
    }
}
