using System;
using System.Data;
using System.Xml;


namespace BTCUOIKI.Class
{
    class KhachHangModel
    {
        FileXML Fxml = new FileXML();

        // Kiểm tra sự tồn tại của khách hàng theo mã
        public bool kiemtra(string MaKH)
        {
            XmlTextReader reader = new XmlTextReader("KhachHang.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/KhachHang[MaKH='" + MaKH + "']");
            reader.Close();
            return node != null;
        }

        // Thêm khách hàng mới
        public void themKH(string MaKH, string TenKH, string DiaChi, string SDT, string Email)
        {
            string noiDung = "<KhachHang>" +
                             "<MaKH>" + MaKH + "</MaKH>" +
                             "<TenKH>" + TenKH + "</TenKH>" +
                             "<SoDienThoai>" + SDT + "</SoDienThoai>" +
                             "<Email>" + Email + "</Email>" +
                             "<DiaChi>" + DiaChi + "</DiaChi>" +
                             "</KhachHang>";
            Fxml.Them("KhachHang.xml", noiDung);
        }

        // Sửa thông tin khách hàng
        public void suaKH(string MaKH, string TenKH, string DiaChi, string SDT, string Email)
        {
            string noiDung = "<MaKH>" + MaKH + "</MaKH>" +
                             "<TenKH>" + TenKH + "</TenKH>" +
                             "<SoDienThoai>" + SDT + "</SoDienThoai>" +
                             "<Email>" + Email + "</Email>" +
                             "<DiaChi>" + DiaChi + "</DiaChi>";
            Fxml.Sua("KhachHang.xml", "KhachHang", "MaKH", MaKH, noiDung);
        }

        // Xóa khách hàng
        public void xoaKH(string MaKH)
        {
            Fxml.Xoa("KhachHang.xml", "KhachHang", "MaKH", MaKH);
        }
    }
}
