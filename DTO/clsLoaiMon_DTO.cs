using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class clsLoaiMon_DTO
    {
        string _MALOAI;

        public string MALOAI
        {
            get { return _MALOAI; }
            set { _MALOAI = value; }
        }
        string _TENLOAI;

        public string TENLOAI
        {
            get { return _TENLOAI; }
            set { _TENLOAI = value; }
        }

        public int TRANGTHAI
        {
            get
            {
                return tRANGTHAI;
            }

            set
            {
                tRANGTHAI = value;
            }
        }

        private int tRANGTHAI;

    }
}
