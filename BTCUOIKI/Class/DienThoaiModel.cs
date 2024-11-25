using System;
using System.Collections.Generic;
using System.Xml;

namespace BTCUOIKI.Class
{
    internal class DienThoaiModel
    {
        FileXML Fxml = new FileXML();

        // Kiểm tra sự tồn tại của mã điện thoại
        public bool KiemTraMaDT(string MaDT)
        {
            XmlTextReader reader = new XmlTextReader("DienThoai.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/DienThoai[MaDT='" + MaDT + "']");
            reader.Close();

            return node != null; // Trả về true nếu tìm thấy mã điện thoại
        }

        // Thêm mới điện thoại
        public void ThemDT(string MaDT, string TenDT, string MaDM, decimal GiaBan, int SoLuongTon, string MoTa,string Anh)
        {
            string noiDung = "<DienThoai>" +
                             "<MaDT>" + MaDT + "</MaDT>" +
                             "<TenDT>" + TenDT + "</TenDT>" +
                             "<MaDM>" + MaDM + "</MaDM>" +
                             "<GiaBan>" + GiaBan.ToString("F2") + "</GiaBan>" +
                             "<SoLuongTon>" + SoLuongTon + "</SoLuongTon>" +
                             "<MoTa>" + MoTa + "</MoTa>" +
                             "<Anh>" + Anh + "</Anh>" +
                             "</DienThoai>";

            Fxml.Them("DienThoai.xml", noiDung);
        }

        // Sửa điện thoại
        public void SuaDT(string MaDT, string TenDT, string MaDM, decimal GiaBan, int SoLuongTon, string MoTa,string Anh)
        {
            string noiDung = "<MaDT>" + MaDT + "</MaDT>" +
                             "<TenDT>" + TenDT + "</TenDT>" +
                             "<MaDM>" + MaDM + "</MaDM>" +
                             "<GiaBan>" + GiaBan.ToString("F2") + "</GiaBan>" +
                             "<SoLuongTon>" + SoLuongTon + "</SoLuongTon>" +
                             "<MoTa>" + MoTa + "</MoTa>" +
                             "<Anh>" + Anh +"</Anh>";
            Fxml.Sua("DienThoai.xml", "DienThoai", "MaDT", MaDT, noiDung);
        }

        // Xóa điện thoại
        public void XoaDT(string MaDT)
        {
            Fxml.Xoa("DienThoai.xml", "DienThoai", "MaDT", MaDT);
        }
    }
}
