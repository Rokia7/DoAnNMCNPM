using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class clsNhanVien_BUS
    {
        public bool KiemTraDangNhap(string strMaNV, string strMK)
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            return dao.KiemTraDangNhap(strMaNV, strMK);
        }
        public Image ImageCrop(string imagePath, int circleSize)//circleSize: kích thước đường viền
        {
            int circleDiameter;
            Bitmap bm = new Bitmap(Image.FromStream(new MemoryStream(File.ReadAllBytes(imagePath))));

            circleDiameter = (bm.Width > bm.Height) ? bm.Height : bm.Width;

            Rectangle cropprect = new Rectangle(0, 0, circleDiameter, circleDiameter); // cắt hình thành hình tròn
            bm = bm.Clone(cropprect, bm.PixelFormat);// sao chép bitmap của mình ra vơi thông số cropprect là nơi mình cắt, sau đó là định dạng hình

            TextureBrush tb = new TextureBrush(bm); // tác dụng như 1 cọ vẽ để vẽ ảnh

            Bitmap final = new Bitmap(circleDiameter, circleDiameter);// đây là cái ảnh cuối cùng mình đưa nó lên chương trình
            Graphics gp = Graphics.FromImage(final);// tạo biến Graphics rồi truyền ảnh vào để ta chỉnh sửa
            gp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // tuốt lại hình cho đẹp
            gp.FillEllipse(tb, 0, 0, circleDiameter, circleDiameter);// vẽ ảnh với thông số tb: là cọ vẽ, 0,0 :là tọa độ bắt đầu vẽ, cùng với chiều rộng và chiều cao bằng nhau nên hình ellipse sẽ thành hình tròn

            gp.DrawEllipse(new Pen(Color.White, (float)(circleSize)), circleSize / 2, circleSize / 2, circleDiameter - circleSize, circleDiameter - circleSize);// vẽ đường tròn với màu trắng kích thước do người dùng truyền vào
            final = new Bitmap(final, new Size(135, 135)); // tạo size mới bằng với size của pictureBox1
            return final;
        }
        public clsNhanVien_DTO LayThongTinNhanVien(string strMaNV)
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            return dao.LayThongTinNhanVien(strMaNV);
        }
        public List<clsNhanVien_DTO> LayDsTatCaNVCon()
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            return dao.LayDsTatCaNVCon();
        }
        public List<clsNhanVien_DTO> LayDsTatCaNVNghi()
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            return dao.LayDsTatCaNVNghi();
        }


        public bool XoaNV(string manv)
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            return dao.XoaNV(manv);
        }

        public bool SuaNV(clsNhanVien_DTO nv)
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            return dao.SuaNV(nv);
        }
        public bool ThemNV(clsNhanVien_DTO nv)
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            return dao.ThemNV(nv);
        }

        public List<clsNhanVien_DTO> LayDsNhanVien(string strTen, string strMa, string strGioiTinh, int intTrangThai)
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            return dao.LayDsNhanVien(strTen, strMa, strGioiTinh, intTrangThai);
        }

        public List<clsNhanVien_DTO> LayDsNhanVien(string sql)
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            return dao.LayDsNhanVien(sql);
        }

        public string PhatSinhMaNV()
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            return dao.PhatSinhMaNV();
        }

        public bool DoiMauKhau(string manv, string matkhaumoi)
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            return dao.DoiMauKhau(manv, matkhaumoi);
        }

        public DataTable LayDsNhanVien()
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            return dao.LayDsNV();
        }

        public double DemSoLuongNhanVien()
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            return dao.DemSoLuongNhanVien();
        }

        public DataTable LayDsNV()
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            return dao.LayDstcNV();
        }

        public DataTable LayDsNVThayDoiCV()
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            return dao.LayDsNVThayDoiCV();
        }

        public bool UpdateCVPhucVu(string manv)
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            return dao.UpdateCVPhucVu(manv);
        }
    }
}