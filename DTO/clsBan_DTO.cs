using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class clsBan_DTO
    {
        string _MABAN;

        public string MABAN
        {
            get { return _MABAN; }
            set { _MABAN = value; }
        }
        string _TENBAN;

        public string TENBAN
        {
            get { return _TENBAN; }
            set { _TENBAN = value; }
        }

        int _TRANGTHAI;

        public int TRANGTHAI
        {
            get { return _TRANGTHAI; }
            set { _TRANGTHAI = value; }
        }


    }
}
