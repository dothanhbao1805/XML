using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BTCUOIKI.Class;

namespace QuanLySieuThi.Class
{
    class HeThong
    {
        FileXML Fxml = new FileXML();
        public void TaoXML()
        {
            Fxml.TaoXML("ChiTietHoaDon");
            Fxml.TaoXML("HoaDon");
            Fxml.TaoXML("NhanVien");
            Fxml.TaoXML("KhachHang");
            Fxml.TaoXML("DienThoai");
            Fxml.TaoXML("DanhMucDienThoai");
        }
        void CapNhapTungBang(string tenBang)
        {
            string duongDan = @"" + tenBang + ".xml";
            DataTable table = Fxml.HienThi(duongDan);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string sql = "insert into " + tenBang + " values(";
                for (int j = 0; j < table.Columns.Count - 1; j++)
                {
                    sql += "N'" + table.Rows[i][j].ToString().Trim() + "',";
                }
                sql += "N'" + table.Rows[i][table.Columns.Count - 1].ToString().Trim() + "'";
                sql += ")";
                //MessageBox.Show(sql);
                Fxml.InsertOrUpDateSQL(sql);
            }
        }
        public void CapNhapSQL()
        {
            //Xóa toàn bộ dữ liệu các bảng
            Fxml.InsertOrUpDateSQL("delete from ChiTietHoaDon");
            Fxml.InsertOrUpDateSQL("delete from HoaDon");
            Fxml.InsertOrUpDateSQL("delete from NhanVien");
            Fxml.InsertOrUpDateSQL("delete from KhachHang");
            Fxml.InsertOrUpDateSQL("delete from DienThoai");
            Fxml.InsertOrUpDateSQL("delete from DanhMucDienThoai");

            //Cập nhập toàn bộ dữ liệu các bảng
            CapNhapTungBang("DanhMucDienThoai");
            CapNhapTungBang("NhanVien");
            CapNhapTungBang("KhachHang");
            CapNhapTungBang("DienThoai");
            CapNhapTungBang("HoaDon");
            CapNhapTungBang("ChiTietHoaDon");



        }
    }
}
