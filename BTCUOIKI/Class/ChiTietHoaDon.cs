using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BTCUOIKI.Class
{
    internal class ChiTietHoaDon
    {
        FileXML Fxml = new FileXML();

        // Kiểm tra sự tồn tại của hoá đơn theo mã
        public bool kiemtra(string MaHD, String MaDT)
        {
            XmlTextReader reader = new XmlTextReader("ChiTietHoaDon.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/ChiTietHoaDon[MaHD='" + MaHD + "MaDT=" + MaDT + "']");
            reader.Close();
            return node != null;
        }


        public void themCTHD(string MaHD, string maDT, string SoLuong)
        {

            string noiDung = "<ChiTietHoaDon>" +
                             "<MaHD>" + MaHD + "</MaHD>" +
                             "<MaDT>" + maDT + "</MaDT>" +
                             "<SoLuong>" + SoLuong + "</SoLuong>" +
                             "</ChiTietHoaDon>";
            Fxml.Them("ChiTietHoaDon.xml", noiDung);
        }

        public void suaCTHD(string MaHD, string maDT, string SoLuong)
        {
            string noiDung =
                             "<MaHD>" + MaHD + "</MaHD>" +
                             "<MaDT>" + maDT + "</MaDT>" +
                             "<SoLuong>" + SoLuong + "</SoLuong>";
            Fxml.Sua("ChiTietHoaDon.xml", "ChiTietHoaDon", "MaHD", MaHD, noiDung);
        }

        public void xoaCTHD(string MaHD)
        {
            Fxml.Xoa("ChiTietHoaDon.xml", "ChiTietHoaDon", "MaHD", MaHD);
        }
    }
}