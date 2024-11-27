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
        string MaHD, MaDT,SoLuong,DonGia;
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
            string filePath = "ChiTietHoaDon.xml";

            // Kiểm tra xem tệp có tồn tại không
            if (!System.IO.File.Exists(filePath))
            {
                MessageBox.Show("Tệp XML không tồn tại.");
                return;
            }

            // Load tệp XML
            XDocument doc = XDocument.Load(filePath);

            var maHDList = doc.Descendants("MaHD").Select(x => x.Value).Distinct().ToList();
            var maDTList = doc.Descendants("MaDT").Select(x => x.Value).Distinct().ToList();

            cbbMaHD.Items.AddRange(maHDList.ToArray());


            cbbMaDT.Items.AddRange(maDTList.ToArray());
        }
        public void HienThiHoaDon()
        {
            try
            {

                DataTable dt = Fxml.HienThi("ChiTietHoaDon.xml");
                dgvChiTietHoaDon.DataSource = dt;
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

                if (string.IsNullOrWhiteSpace(cbbMaHD.Text))
                {
                    ShowMessage("Vui lòng chọn chi tiết hoá đơn cần xóa!", MessageBoxIcon.Warning);
                    return;
                }

                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xoá chi tiết hoá đơn với mã {cbbMaHD.Text} không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    // Thực hiện xóa
                    cthd.xoaCTHD(cbbMaHD.Text);
                    ShowMessage("Xóa chi tiết hoá đơn thành công!", MessageBoxIcon.Information);

                    // Cập nhật lại danh sách
                    HienThiHoaDon();
                }
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
                        dt.Columns.Add("Đơn giá");

                        foreach (DataRowView row in dv)
                        {
                            object[] list = {
                        row["MaHD"],
                        row["MaDT"],
                        row["SoLuong"],
                        row["DonGia"]
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
            txtDonGia.Text = string.Empty;
            cbbMaDT.SelectedIndex = 0;
            cbbMaHD.SelectedIndex = 0;
            txtSoLuong.Focus();

        }
        private void btn_capnhat_KH_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDuLieu();

                if (string.IsNullOrWhiteSpace(MaHD) || string.IsNullOrWhiteSpace(MaDT) )
                {
                    ShowMessage("Mã hoá đơn và mã điện thoại không được để trống!", MessageBoxIcon.Warning);
                    return;
                }
                cthd.suaCTHD(MaHD, MaDT, SoLuong, DonGia);
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

                if (cthd.kiemtra(MaHD))
                {
                    ShowMessage("Mã Hoá đơn đã tồn tại.", MessageBoxIcon.Warning);
                }
                else
                {



                    cthd.themCTHD(MaHD, MaDT, SoLuong, DonGia);
                    ShowMessage("Thêm hoá đơn thành công!", MessageBoxIcon.Information);
                    HienThiHoaDon();
                    ClearInputs();
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
            DonGia = txtDonGia.Text.Trim();
        }
        private void dgvChiTietHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = dgvChiTietHoaDon.CurrentRow.Index;
                cbbMaHD.SelectedItem = dgvChiTietHoaDon.Rows[d].Cells[0].Value.ToString();
                cbbMaDT.SelectedItem = dgvChiTietHoaDon.Rows[d].Cells[1].Value.ToString();
                txtSoLuong.Text = dgvChiTietHoaDon.Rows[d].Cells[2].Value.ToString();

                txtDonGia.Text = dgvChiTietHoaDon.Rows[d].Cells[3].Value.ToString();
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
