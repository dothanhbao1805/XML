using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BTCUOIKI.Class
{
    internal class HoaDon
    {
        FileXML Fxml = new FileXML();

        // Kiểm tra sự tồn tại của hoá đơn theo mã
        public bool kiemtra(string MaHD)
        {
            XmlTextReader reader = new XmlTextReader("HoaDon.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/HoaDon[MaHD='" + MaHD + "']");
            reader.Close();
            return node != null;
        }


        public void themHD(string MaHD, string MaKH, string MaNV, DateTime NgayLap, string TongTien)
        {
            string ngayl = NgayLap.ToString("yyyy-MM-ddTHH:mm:ssK");
            string noiDung = "<HoaDon>" +
                             "<MaHD>" + MaHD + "</MaHD>" +
                             "<MaKH>" + MaKH + "</MaKH>" +
                             "<MaNV>" + MaNV + "</MaNV>" +
                             "<NgayLap>" + ngayl + "</NgayLap>" +
                             "<TongTien>" + TongTien + "</TongTien>" +
                             "</HoaDon>";
            Fxml.Them("HoaDon.xml", noiDung);
        }

        public void suaHD(string MaHD, string MaKH, string MaNV, DateTime NgayLap, string TongTien)
        {
            string ngayl = NgayLap.ToString("yyyy-MM-ddTHH:mm:ssK");
            string noiDung = "<MaHD>" + MaHD + "</MaHD>" +
                             "<MaKH>" + MaKH + "</MaKH>" +
                             "<MaNV>" + MaNV + "</MaNV>" +
                             "<NgayLap>" + ngayl + "</NgayLap>" +
                             "<TongTien>" + TongTien + "</TongTien>";
            Fxml.Sua("HoaDon.xml", "HoaDon", "MaHD", MaKH, noiDung);
        }

        public void xoaHD(string MaHD)
        {
            Fxml.Xoa("HoaDon.xml", "HoaDon", "MaHD", MaHD);
        }
    }
}
