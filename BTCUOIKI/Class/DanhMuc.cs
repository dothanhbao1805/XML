using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml;

namespace BTCUOIKI.Class
{
    class DanhMuc
    {
        FileXML Fxml = new FileXML();

        // Kiểm tra sự tồn tại của mã danh mục
        public bool KiemTraMaDM(string MaDM)
        {
            XmlTextReader reader = new XmlTextReader("DanhMucDienThoai.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/DanhMucDienThoai[MaDM='" + MaDM + "']");
            reader.Close();

            return node != null; // Trả về true nếu tìm thấy mã danh mục
        }

        // Thêm mới danh mục
        public void ThemDM(string MaDM, string TenHang)
        {
            string noiDung = "<DanhMucDienThoai>" +
                             "<MaDM>" + MaDM + "</MaDM>" +
                             "<TenHang>" + TenHang + "</TenHang>" +
                             "</DanhMucDienThoai>";
            Fxml.Them("DanhMucDienThoai.xml", noiDung);
        }

        // Sửa danh mục
        public void SuaDM(string MaDM, string TenHang)
        {
            string noiDung = "<MaDM>" + MaDM + "</MaDM>" +
                             "<TenHang>" + TenHang + "</TenHang>";

            Fxml.Sua("DanhMucDienThoai.xml", "DanhMucDienThoai", "MaDM", MaDM, noiDung);
        }

        // Xóa danh mục
        public void XoaDM(string MaDM)
        {
            Fxml.Xoa("DanhMucDienThoai.xml", "DanhMucDienThoai", "MaDM", MaDM);
        }
        public DataTable LoadMaDM()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("DanhMucDienThoai.xml");
            return dt;
        }
    }
}
