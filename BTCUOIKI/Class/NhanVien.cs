using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BTCUOIKI.Class
{
    class NhanVien
    {
        FileXML Fxml = new FileXML();
        public bool kiemtra(string MaNhanVien)
        {
            XmlTextReader reader = new XmlTextReader("NhanVien.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/NhanVien[MaNhanVien='" + MaNhanVien + "']");
            reader.Close();
            bool kq = true;
            if (node != null)
            {
                return kq = true;
            }
            else
            {
                return kq = false;
            }

        }
        public void themNV(string MaNhanVien, string TenNhanVien, string DiaChi, string SDT, string Email)
        {
            string noiDung = "<NhanVien>" +
                    "<MaNV>" + MaNhanVien + "</MaNV>" +
                    "<TenNV>" + TenNhanVien + "</TenNV>" +
                    "<SoDienThoai>" + SDT + "</SoDienThoai>" +
                    "<Email>" + Email + "</Email>" +
                    "<DiaChi>" + DiaChi + "</DiaChi>" +
                    "</NhanVien>";
            Fxml.Them("NhanVien.xml", noiDung);
        }
        public void suaNV(string MaNhanVien, string TenNhanVien, string DiaChi, string SDT, string Email)
        {

            string noiDung = "<MaNV>" + MaNhanVien + "</MaNV>" +
                    "<TenNV>" + TenNhanVien + "</TenNV>" +
                    "<SoDienThoai>" + SDT + "</SoDienThoai>" +
                    "<Email>" + Email + "</Email>" +
                    "<DiaChi>" + DiaChi + "</DiaChi>";
            Fxml.Sua("NhanVien.xml", "NhanVien", "MaNV", MaNhanVien, noiDung);


        }
        public void xoaNV(string MaNhanVien)
        {
            Fxml.Xoa("NhanVien.xml", "NhanVien", "MaNV", MaNhanVien);
        }
    }
}