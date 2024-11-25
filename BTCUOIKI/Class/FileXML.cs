using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.Diagnostics;   // Dùng cho Pricess.Start()

namespace BTCUOIKI.Class
{
    class FileXML
    {
        string Conn = @"Data Source=LAPTOP-DIFNPUPB\XUANHOANG; Initial Catalog = QuanLyCuaHangDienThoai; Integrated Security=true";
        //public DataTable HienThi(string duongDan)
        //{
        //    DataTable dt = new DataTable();
        //    string FilePath = Application.StartupPath + "\\" + duongDan;
        //    if (File.Exists(FilePath))
        //    {
        //        FileStream fsReadXML = new FileStream(FilePath, FileMode.Open);
        //        dt.ReadXml(fsReadXML);
        //        fsReadXML.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show("File XML '" + duongDan + "' không tồn tại");
        //    }

        //    return dt;
        //}
        public DataTable HienThi(string file)
        {
            DataTable dt = new DataTable();
            string FilePath = Application.StartupPath + "\\" + file;
            if (File.Exists(FilePath))
            {
                FileStream fsReadXML = new FileStream(FilePath, FileMode.Open);
                dt.ReadXml(fsReadXML);
                fsReadXML.Close();
            }
            else
            {
                MessageBox.Show("File XML '" + file + "' không tồn tại");
            }
            return dt;
        }

        public void TaoXML(string bang)
        {
            try
            {
                SqlConnection con = new SqlConnection(Conn);
                con.Open();
                string sql = "SELECT * FROM " + bang; // Lấy dữ liệu từ bảng
                SqlDataAdapter ad = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable(bang);
                ad.Fill(dt); // Điền dữ liệu vào DataTable

                if (dt.Rows.Count > 0)
                {
                    string filePath = Application.StartupPath + "\\" + bang + ".xml";

                    // Ghi dữ liệu vào file XML
                    dt.WriteXml(filePath, XmlWriteMode.WriteSchema);

                    // Hiển thị thông báo đường dẫn file đã tạo
                    
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu trong bảng: " + bang, "Thông báo");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo XML: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //public void TaoXMLTaiKhoan()
        //{
        //    SqlConnection conn = new SqlConnection(Conn);
        //    conn.Open();
        //    SqlDataAdapter ad = new SqlDataAdapter("Select * from TaiKhoan", conn);
        //    DataTable dt = new DataTable("TaiKhoan");
        //    ad.Fill(dt);
        //    dt.WriteXml(Application.StartupPath + "\\TaiKhoan.xml", XmlWriteMode.WriteSchema);

        //}
        //public void TaoXMLNhanVien()
        //{
        //    SqlConnection conn = new SqlConnection(Conn);
        //    conn.Open();
        //    SqlDataAdapter ad = new SqlDataAdapter("Select * from NhanVien", conn);
        //    DataTable dt = new DataTable("NhanVien");
        //    ad.Fill(dt);
        //    dt.WriteXml(Application.StartupPath + "\\NhanVien.xml", XmlWriteMode.WriteSchema);

        //}
        //public void TaoXMLHang()
        //{
        //    SqlConnection conn = new SqlConnection(Conn);
        //    conn.Open();
        //    SqlDataAdapter ad = new SqlDataAdapter("Select * from Hang", conn);
        //    DataTable dt = new DataTable("Hang");
        //    ad.Fill(dt);
        //    dt.WriteXml(Application.StartupPath + "\\Hang.xml", XmlWriteMode.WriteSchema);

        //}
        //public void TaoXMLPhieuNhap()
        //{
        //    SqlConnection conn = new SqlConnection(Conn);
        //    conn.Open();
        //    SqlDataAdapter ad = new SqlDataAdapter("Select * from PhieuNhap", conn);
        //    DataTable dt = new DataTable("PhieuNhap");
        //    ad.Fill(dt);
        //    dt.WriteXml(Application.StartupPath + "\\PhieuNhap.xml", XmlWriteMode.WriteSchema);

        //}
        //public void TaoXMLChamCong()
        //{
        //    SqlConnection conn = new SqlConnection(Conn);
        //    conn.Open();
        //    SqlDataAdapter ad = new SqlDataAdapter("Select * from ChamCong", conn);
        //    DataTable dt = new DataTable("ChamCong");
        //    ad.Fill(dt);
        //    dt.WriteXml(Application.StartupPath + "\\ChamCong.xml", XmlWriteMode.WriteSchema);

        //}
        //public void TaoXMLHoaDon()
        //{
        //    SqlConnection conn = new SqlConnection(Conn);
        //    conn.Open();
        //    SqlDataAdapter ad = new SqlDataAdapter("Select * from HoaDon", conn);
        //    DataTable dt = new DataTable("HoaDon");
        //    ad.Fill(dt);
        //    dt.WriteXml(Application.StartupPath + "\\HoaDon.xml", XmlWriteMode.WriteSchema);

        //}
        //public void TaoXMLChiTietHoaDon()
        //{
        //    SqlConnection conn = new SqlConnection(Conn);
        //    conn.Open();
        //    SqlDataAdapter ad = new SqlDataAdapter("Select * from ChiTietHoaDon", conn);
        //    DataTable dt = new DataTable("ChiTietHoaDon");
        //    ad.Fill(dt);
        //    dt.WriteXml(Application.StartupPath + "\\ChiTietHoaDon.xml", XmlWriteMode.WriteSchema);

        //}
        public void Them(string duongDan, string noiDung)
        {
            XmlTextReader reader = new XmlTextReader(duongDan);
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            reader.Close();
            XmlNode currNode;
            XmlDocumentFragment docFrag = doc.CreateDocumentFragment();
            docFrag.InnerXml = noiDung;
            currNode = doc.DocumentElement;
            currNode.InsertAfter(docFrag, currNode.LastChild);
            doc.Save(duongDan);
        }
        public void Xoa(string duongDan, string tenFileXML, string xoaTheoTruong, string giaTriTruong)
        {
            string fileName = Application.StartupPath + "\\" + duongDan;
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNode nodeCu = doc.SelectSingleNode("NewDataSet/" + tenFileXML + "[" + xoaTheoTruong + "='" + giaTriTruong + "']");
            doc.DocumentElement.RemoveChild(nodeCu);
            doc.Save(fileName);
        }

        public void Sua(string duongDan, string tenFile, string suaTheoTruong, string giaTriTruong, string noiDung)
        {

            XmlTextReader reader = new XmlTextReader(duongDan);
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            reader.Close();
            XmlNode oldHang;
            XmlElement root = doc.DocumentElement;
            oldHang = root.SelectSingleNode("/NewDataSet/" + tenFile + "[" + suaTheoTruong + "='" + giaTriTruong + "']");
            XmlElement newhang = doc.CreateElement(tenFile);
            newhang.InnerXml = noiDung;
            root.ReplaceChild(newhang, oldHang);
            doc.Save(duongDan);
        }
        public string LayGiaTri(string duongDan, string truongA, string giaTriA, string truongB)
        {
            string giatriB = "";
            DataTable dt = new DataTable();
            dt = HienThi(duongDan);
            int soDongNhanVien = dt.Rows.Count;
            for (int i = 0; i < soDongNhanVien; i++)
            {
                if (dt.Rows[i][truongA].ToString().Trim().Equals(giaTriA))
                {
                    giatriB = dt.Rows[i][truongB].ToString();
                    return giatriB;
                }
            }
            return giatriB;
        }
        public void DoiMatKhau(string nguoiDung, string matKhau)
        {
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(Application.StartupPath + "\\TaiKhoan.xml");
            XmlNode node1 = doc1.SelectSingleNode("NewDataSet/TaiKhoan[MaNhanVien = '" + nguoiDung + "']");
            if (node1 != null)
            {
                node1.ChildNodes[1].InnerText = matKhau;
                doc1.Save(Application.StartupPath + "\\TaiKhoan.xml");
            }
        }
        public void TimKiemXSLT(string data, string tenFileXML, string tenfileXSLT)
        {

            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("\\" + tenfileXSLT + ".xslt");
            // Create the XsltArgumentList.
            XsltArgumentList argList = new XsltArgumentList();
            // Calculate the discount date.
            argList.AddParam("Data", "", data);
            // Create an XmlWriter to write the output.             
            XmlWriter writer = XmlWriter.Create("\\" + tenFileXML + ".html");
            // Transform the file.
            xslt.Transform(new XPathDocument("\\" + tenFileXML + ".xml"), argList, writer);
            writer.Close();
            System.Diagnostics.Process.Start("\\" + tenFileXML + ".html");

        }
        public void InsertOrUpDateSQL(string sql)
        {
            SqlConnection con = new SqlConnection(Conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void TaoFileXMLNeuChuaTonTai(string filePath)
        {
            // Đường dẫn đầy đủ đến tệp XML
            string fullPath = Application.StartupPath + "\\" + filePath;

            if (!File.Exists(fullPath))
            {
                try
                {
                    // Kết nối cơ sở dữ liệu
                    string connectionString = "Server=localhost;Database=QuanLyCuaHangDienThoai;Trusted_Connection=True;";
                    string query = "SELECT MaDT, TenDT, MaDM, GiaBan, SoLuongTon, MoTa FROM DienThoai";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);  // Lấy dữ liệu từ SQL vào DataTable

                        // Tạo một tệp XML cơ bản
                        XmlDocument doc = new XmlDocument();
                        XmlElement root = doc.CreateElement("NewDataSet");
                        doc.AppendChild(root);

                        // Thêm dữ liệu từ DataTable vào XML
                        foreach (DataRow row in dt.Rows)
                        {
                            // Tạo phần tử "DienThoai" cho mỗi dòng dữ liệu
                            XmlElement dienThoaiElement = doc.CreateElement("DienThoai");

                            // Tạo các phần tử con cho từng cột trong DataTable
                            XmlElement maDT = doc.CreateElement("MaDT");
                            maDT.InnerText = row["MaDT"].ToString();
                            dienThoaiElement.AppendChild(maDT);

                            XmlElement tenDT = doc.CreateElement("TenDT");
                            tenDT.InnerText = row["TenDT"].ToString();
                            dienThoaiElement.AppendChild(tenDT);

                            XmlElement maDM = doc.CreateElement("MaDM");
                            maDM.InnerText = row["MaDM"].ToString();
                            dienThoaiElement.AppendChild(maDM);

                            XmlElement giaBan = doc.CreateElement("GiaBan");
                            giaBan.InnerText = row["GiaBan"].ToString();
                            dienThoaiElement.AppendChild(giaBan);

                            XmlElement soLuongTon = doc.CreateElement("SoLuongTon");
                            soLuongTon.InnerText = row["SoLuongTon"].ToString();
                            dienThoaiElement.AppendChild(soLuongTon);

                            XmlElement moTa = doc.CreateElement("MoTa");
                            moTa.InnerText = row["MoTa"].ToString();
                            dienThoaiElement.AppendChild(moTa);

                            // Thêm phần tử "DienThoai" vào root
                            root.AppendChild(dienThoaiElement);
                        }

                        // Lưu tệp XML
                        doc.Save(fullPath);

                        MessageBox.Show("Tệp XML '" + filePath + "' đã được tạo thành công với dữ liệu từ cơ sở dữ liệu.", "Thông báo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tạo tệp XML: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tệp XML đã tồn tại.", "Thông báo");
            }
        }

    }
}
