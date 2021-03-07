using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class clsCTBan_DTO
    {
        string _MABAN;

        public string MABAN
        {
            get { return _MABAN; }
            set { _MABAN = value; }
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

    }
}
