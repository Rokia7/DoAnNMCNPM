using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class clsThucDon_DTO
    {
        string _MAMON;

        public string MAMON
        {
            get { return _MAMON; }
            set { _MAMON = value; }
        }
        string _TENMON;

        public string TENMON
        {
            get { return _TENMON; }
            set { _TENMON = value; }
        }
        string _MALOAI;

        public string MALOAI
        {
            get { return _MALOAI; }
            set { _MALOAI = value; }
        }
        string _DVT;

        public string DVT
        {
            get { return _DVT; }
            set { _DVT = value; }
        }
        decimal _GIA;

        public decimal GIA
        {
            get { return _GIA; }
            set { _GIA = value; }
        }

        bool _TINHTRANG;

        public bool TINHTRANG
        {
            get { return _TINHTRANG; }
            set { _TINHTRANG = value; }
        }

        int _TRANGTHAI;

        public int TRANGTHAI
        {
            get { return _TRANGTHAI; }
            set { _TRANGTHAI = value; }
        }

        int soluongdedungchothongke;

        public int Soluongdedungchothongke
        {
            get { return soluongdedungchothongke; }
            set { soluongdedungchothongke = value; }
        }
    }
}
