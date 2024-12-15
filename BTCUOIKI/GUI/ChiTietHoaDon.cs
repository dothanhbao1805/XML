using BTCUOIKI.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using BTCUOIKI.Class;
using System.Xml;

namespace BTCUOIKI.GUI
{
    public partial class txtthanhtien : Form
    {
        ChiTietHoaDon cthd = new ChiTietHoaDon();
        FileXML Fxml = new FileXML();
        string MaHD, MaDT, SoLuong;
        public txtthanhtien()
        {
            InitializeComponent();
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\ChiTietHoaDon.xml";
            try
            {
                System.Diagnostics.Process.Start("Explorer.exe", path);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Chưa có file cần mở trong bin/debug", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadComboBox()
        {
            // Đường dẫn tệp XML
            string filePath_HoaDon = "HoaDon.xml";
            string filePath_DT = "DienThoai.xml";

            // Kiểm tra xem tệp có tồn tại không
            if (!System.IO.File.Exists(filePath_HoaDon))
            {
                MessageBox.Show("Tệp XML không tồn tại.");
                return;
            }
            if (!System.IO.File.Exists(filePath_DT))
            {
                MessageBox.Show("Tệp XML không tồn tại.");
                return;
            }

            // Load tệp XML
            XDocument doc1 = XDocument.Load(filePath_HoaDon);
            XDocument doc2 = XDocument.Load(filePath_DT);

            var maHDList = doc1.Descendants("MaHD").Select(x => x.Value).Distinct().ToList();
            var maDTList = doc2.Descendants("MaDT").Select(x => x.Value).Distinct().ToList();

            cbbMaHD.Items.AddRange(maHDList.ToArray());


            cbbMaDT.Items.AddRange(maDTList.ToArray());
        }
        public void HienThiHoaDon()
        {
            try
            {
                // Đọc dữ liệu từ file ChiTietHoaDon.xml
                DataTable dtChiTiet = Fxml.HienThi("ChiTietHoaDon.xml");

                // Đọc dữ liệu từ file DienThoai.xml
                DataTable dtDienThoai = Fxml.HienThi("DienThoai.xml");

                // Thêm cột "Thành Tiền" vào bảng Chi Tiết Hóa Đơn
                dtChiTiet.Columns.Add("ThanhTien", typeof(decimal));

                // Duyệt qua từng dòng và tính toán "Thành Tiền"
                foreach (DataRow row in dtChiTiet.Rows)
                {
                    string maDT = row["MaDT"].ToString();
                    // Tìm đơn giá của sản phẩm trong bảng DienThoai
                    DataRow[] dienThoaiRow = dtDienThoai.Select($"MaDT = '{maDT}'");
                    if (dienThoaiRow.Length > 0)
                    {
                        decimal donGia = Convert.ToDecimal(dienThoaiRow[0]["GiaBan"]);
                        int soLuong = Convert.ToInt32(row["SoLuong"]);

                        // Tính thành tiền
                        row["ThanhTien"] = soLuong * donGia;
                    }
                    else
                    {
                        row["ThanhTien"] = 0; // Nếu không tìm thấy sản phẩm, đặt thành tiền là 0
                    }
                }

                // Gán dữ liệu vào DataGridView
                dgvChiTietHoaDon.DataSource = dtChiTiet;

                // Tăng kích thước font chữ cho nội dung các ô
                dgvChiTietHoaDon.DefaultCellStyle.Font = new Font("Arial", 14);

                // Tăng kích thước font chữ cho tiêu đề cột
                dgvChiTietHoaDon.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);

                // Tùy chỉnh chiều cao hàng để phù hợp với font chữ lớn hơn
                dgvChiTietHoaDon.RowTemplate.Height = 40;

                // Tùy chỉnh chế độ tự động điều chỉnh
                dgvChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tự động giãn cột
            }
            catch (Exception ex)
            {
                ShowMessage($"Đã xảy ra lỗi khi hiển thị dữ liệu: {ex.Message}", MessageBoxIcon.Error);
            }
        }


        private void txtthanhtien_Load(object sender, EventArgs e)
        {
            HienThiHoaDon();
            LoadComboBox();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            HienThiHoaDon();
        }

        private void btn_xoa_KH_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDuLieu();

                if (string.IsNullOrWhiteSpace(MaHD) || string.IsNullOrWhiteSpace(MaDT))
                {
                    ShowMessage("Mã hoá đơn và mã điện thoại không được để trống!", MessageBoxIcon.Warning);
                    return;
                }

                // Tải dữ liệu từ file ChiTietHoaDon.xml
                DataTable dtChiTietHD = Fxml.HienThi("ChiTietHoaDon.xml");

                // Tìm chi tiết hóa đơn cần xóa dựa trên MaHD và MaDT
                DataRow[] rowsChiTietHD = dtChiTietHD.Select($"MaHD = '{MaHD}' AND MaDT = '{MaDT}'");
                if (rowsChiTietHD.Length == 0)
                {
                    ShowMessage("Không tìm thấy chi tiết hóa đơn để xóa!", MessageBoxIcon.Error);
                    return;
                }

                int soLuongCanXoa = Convert.ToInt32(rowsChiTietHD[0]["SoLuong"]);
                // Tải dữ liệu từ file DienThoai.xml
                DataTable dtDienThoai = Fxml.HienThi("DienThoai.xml");

                // Tìm sản phẩm trong DienThoai.xml
                DataRow[] rowsDienThoai = dtDienThoai.Select($"MaDT = '{MaDT}'");
                if (rowsDienThoai.Length == 0)
                {
                    ShowMessage("Không tìm thấy sản phẩm trong dữ liệu!", MessageBoxIcon.Error);
                    return;
                }

                int soLuongTon = Convert.ToInt32(rowsDienThoai[0]["SoLuongTon"]);

                // Cập nhật lại số lượng tồn
                rowsDienThoai[0]["SoLuongTon"] = soLuongTon + soLuongCanXoa;

                // Xóa dòng trong ChiTietHoaDon.xml
                dtChiTietHD.Rows.Remove(rowsChiTietHD[0]);

                // Gọi hàm lưu XML để lưu dữ liệu đã cập nhật
                dtDienThoai.WriteXml("DienThoai.xml", XmlWriteMode.WriteSchema);
                dtChiTietHD.WriteXml("ChiTietHoaDon.xml", XmlWriteMode.WriteSchema);

                ShowMessage("Xóa hoá đơn thành công!", MessageBoxIcon.Information);
                HienThiHoaDon();
                ClearInputs();
            }
            catch (Exception ex)
            {
                ShowMessage($"Đã xảy ra lỗi: {ex.Message}", MessageBoxIcon.Error);
            }
        }


        private void btn_find_Click(object sender, EventArgs e)
        {
            try
            {
                Fxml.TaoXML("ChiTietHoaDon");
                XmlTextReader reader = new XmlTextReader("ChiTietHoaDon.xml");
                DataSet ds = new DataSet();
                ds.ReadXml(reader);
                reader.Close();

                if (ds.Tables.Count > 0)
                {
                    DataView dv = new DataView(ds.Tables[0]);

                    dv.RowFilter = $"MaHD LIKE '%{txt_find.Text}%'";

                    if (dv.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy mã hoá đơn nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_find.Clear();
                        txt_find.Focus();
                    }
                    else
                    {

                        DataTable dt = new DataTable();
                        dt.Columns.Add("Mã đơn hàng");
                        dt.Columns.Add("Mã Điện thoại");
                        dt.Columns.Add("Số lượng");

                        foreach (DataRowView row in dv)
                        {
                            object[] list = {
                        row["MaHD"],
                        row["MaDT"],
                        row["SoLuong"],
                    };
                            dt.Rows.Add(list);
                        }

                        dgvChiTietHoaDon.DataSource = dt;
                        txt_find.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu hoá đơn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputs()
        {
            txtSoLuong.Text = string.Empty;
            cbbMaDT.SelectedIndex = 0;
            cbbMaHD.SelectedIndex = 0;
            txtSoLuong.Focus();

        }
        private void btn_capnhat_KH_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDuLieu();

                if (string.IsNullOrWhiteSpace(MaHD) || string.IsNullOrWhiteSpace(MaDT))
                {
                    ShowMessage("Mã hoá đơn và mã điện thoại không được để trống!", MessageBoxIcon.Warning);
                    return;
                }

                // Tải dữ liệu từ file ChiTietHoaDon.xml
                DataTable dtChiTietHD = Fxml.HienThi("ChiTietHoaDon.xml");

                // Tìm chi tiết hóa đơn cũ dựa trên MaHD và MaDT
                DataRow[] rowsChiTietHD = dtChiTietHD.Select($"MaHD = '{MaHD}' AND MaDT = '{MaDT}'");
                if (rowsChiTietHD.Length == 0)
                {
                    ShowMessage("Không tìm thấy chi tiết hóa đơn để cập nhật!", MessageBoxIcon.Error);
                    return;
                }

                int soLuongCu = Convert.ToInt32(rowsChiTietHD[0]["SoLuong"]);

                // Tính sự thay đổi (delta)
                int delta = Convert.ToInt32(SoLuong) - soLuongCu;

                // Tải dữ liệu từ file DienThoai.xml
                DataTable dtDienThoai = Fxml.HienThi("DienThoai.xml");

                // Tìm sản phẩm trong DienThoai.xml
                DataRow[] rowsDienThoai = dtDienThoai.Select($"MaDT = '{MaDT}'");
                if (rowsDienThoai.Length == 0)
                {
                    ShowMessage("Không tìm thấy sản phẩm trong dữ liệu!", MessageBoxIcon.Error);
                    return;
                }

                int soLuongTon = Convert.ToInt32(rowsDienThoai[0]["SoLuongTon"]);

                // Kiểm tra số lượng tồn có đủ để cập nhật
                if (delta > 0 && soLuongTon < delta)
                {
                    ShowMessage("Không đủ số lượng tồn để cập nhật chi tiết hóa đơn!", MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật số lượng tồn
                rowsDienThoai[0]["SoLuongTon"] = soLuongTon - delta;

                // Gọi hàm lưu XML để lưu dữ liệu đã cập nhật vào file DienThoai.xml
                dtDienThoai.WriteXml("DienThoai.xml", XmlWriteMode.WriteSchema);

                // Cập nhật chi tiết hóa đơn trong dữ liệu
                rowsChiTietHD[0]["SoLuong"] = SoLuong;

                // Gọi hàm lưu XML để lưu dữ liệu đã cập nhật vào file ChiTietHoaDon.xml
                dtChiTietHD.WriteXml("ChiTietHoaDon.xml", XmlWriteMode.WriteSchema);
                // Gọi phương thức sửa chi tiết hóa đơn
                cthd.suaCTHD(MaHD, MaDT, SoLuong);

                ShowMessage("Cập nhật hoá đơn thành công!", MessageBoxIcon.Information);
                HienThiHoaDon();
                ClearInputs();
            }
            catch (Exception ex)
            {
                ShowMessage($"Đã xảy ra lỗi: {ex.Message}", MessageBoxIcon.Error);
            }
        }


        private void btn_them_KH_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDuLieu();

                if (string.IsNullOrWhiteSpace(MaHD) || string.IsNullOrWhiteSpace(MaDT))
                {
                    ShowMessage("Mã hoá đơn và điện thoại không được để trống!", MessageBoxIcon.Warning);
                    return;
                }

                if (cthd.kiemtra(MaHD, MaDT))
                {
                    ShowMessage("Mã Hoá đơn đã tồn tại.", MessageBoxIcon.Warning);
                }
                else
                {
                    // Kiểm tra và cập nhật số lượng tồn
                    DataTable dtDienThoai = Fxml.HienThi("DienThoai.xml");

                    // Tìm sản phẩm theo MaDT
                    DataRow[] rows = dtDienThoai.Select($"MaDT = '{MaDT}'");
                    if (rows.Length > 0)
                    {
                        int soLuongTon = Convert.ToInt32(rows[0]["SoLuongTon"]);
                        if (soLuongTon < Convert.ToInt32(SoLuong))
                        {
                            ShowMessage("Không đủ số lượng tồn để thêm chi tiết hóa đơn!", MessageBoxIcon.Warning);
                            return;
                        }

                        // Giảm số lượng tồn
                        rows[0]["SoLuongTon"] = soLuongTon - Convert.ToInt32(SoLuong);

                        // Lưu thay đổi lại file DienThoai.xml
                        dtDienThoai.WriteXml("DienThoai.xml", XmlWriteMode.WriteSchema);
                        // Thêm chi tiết hóa đơn
                        cthd.themCTHD(MaHD, MaDT, SoLuong);
                        ShowMessage("Thêm hoá đơn thành công!", MessageBoxIcon.Information);

                        // Hiển thị lại hóa đơn và xóa các ô nhập liệu
                        HienThiHoaDon();
                        ClearInputs();
                    }
                    else
                    {
                        ShowMessage("Không tìm thấy sản phẩm trong dữ liệu!", MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Đã xảy ra lỗi: {ex.Message}", MessageBoxIcon.Error);
            }
        }


        public void LoadDuLieu()
        {
            MaHD = cbbMaHD.Text.Trim();
            MaDT = cbbMaDT.Text.Trim();
            SoLuong = txtSoLuong.Text.Trim();
        }
        private void dgvChiTietHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = dgvChiTietHoaDon.CurrentRow.Index;
                cbbMaHD.SelectedItem = dgvChiTietHoaDon.Rows[d].Cells[0].Value.ToString();
                cbbMaDT.SelectedItem = dgvChiTietHoaDon.Rows[d].Cells[1].Value.ToString();
                txtSoLuong.Text = dgvChiTietHoaDon.Rows[d].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                ShowMessage($"Đã xảy ra lỗi khi chọn dữ liệu: {ex.Message}", MessageBoxIcon.Error);
            }
        }
        private void ShowMessage(string message, MessageBoxIcon icon)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, icon);
        }
    }
}