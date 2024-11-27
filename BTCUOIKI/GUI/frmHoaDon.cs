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
using BTCUOIKI.Class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Xml;
namespace BTCUOIKI.GUI
{
    public partial class frmHoaDon : Form
    {
        HoaDon hd = new HoaDon();
        FileXML Fxml = new FileXML();
        string MaHD, MaKH, MaNV, NgayLap, TongTien;
        public frmHoaDon()
        {
            InitializeComponent();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void HienThiHoaDon()
        {
            try
            {
                DataTable dt = Fxml.HienThi("HoaDon.xml");
                dgvDonHang.DataSource = dt;
                // Tăng kích thước font chữ cho nội dung các ô
                dgvDonHang.DefaultCellStyle.Font = new Font("Arial", 14);

                // Tăng kích thước font chữ cho tiêu đề cột
                dgvDonHang.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);

                // Tùy chỉnh chiều cao hàng để phù hợp với font chữ lớn hơn
                dgvDonHang.RowTemplate.Height = 40;

                // Tùy chỉnh chế độ tự động điều chỉnh
                dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tự động giãn cột
            }
            catch (Exception ex)
            {
                ShowMessage($"Đã xảy ra lỗi khi hiển thị dữ liệu: {ex.Message}", MessageBoxIcon.Error);
            }
        }
        public void LoadDuLieu()
        {
            MaHD = txtMaHD.Text.Trim();
            MaKH = cbbMaKH.Text.Trim();
            MaNV = cbbMaNV.Text.Trim();
            NgayLap = time.Text.Trim();
            TongTien = txtTongTien.Text.Trim();
        }

        private void ClearInputs()
        {
            txtMaHD.Text = string.Empty;
            txtTongTien.Text = string.Empty;
            cbbMaKH.SelectedIndex = 0;
            cbbMaNV.SelectedIndex = 0;
            txtMaHD.Focus();

        }
        private void LoadComboBox()
        {
            // Đường dẫn tệp XML
            string filePath = "HoaDon.xml";

            // Kiểm tra xem tệp có tồn tại không
            if (!System.IO.File.Exists(filePath))
            {
                MessageBox.Show("Tệp XML không tồn tại.");
                return;
            }

            // Load tệp XML
            XDocument doc = XDocument.Load(filePath);

            var maKHList = doc.Descendants("MaKH").Select(x => x.Value).Distinct().ToList();
            var maNVList = doc.Descendants("MaNV").Select(x => x.Value).Distinct().ToList();

            // Đưa dữ liệu vào ComboBox MaKH
            cbbMaKH.Items.AddRange(maKHList.ToArray());

            // Đưa dữ liệu vào ComboBox MaNV
            cbbMaNV.Items.AddRange(maNVList.ToArray());
        }

        private void ShowMessage(string message, MessageBoxIcon icon)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, icon);
        }
        private void btn_find_Click(object sender, EventArgs e)
        {
            try
            {

                XmlTextReader reader = new XmlTextReader("HoaDon.xml");
                DataSet ds = new DataSet();
                ds.ReadXml(reader);
                reader.Close();

                if (ds.Tables.Count > 0)
                {
                    DataView dv = new DataView(ds.Tables[0]);

                    dv.RowFilter = $"MaHD LIKE '%{txt_find.Text}%'";

                    if (dv.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy hoá đơn nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_find.Clear();
                        txt_find.Focus();
                    }
                    else
                    {

                        DataTable dt = new DataTable();
                        dt.Columns.Add("Mã đơn hàng");
                        dt.Columns.Add("Mã khách hàng");
                        dt.Columns.Add("Mã nhân viên");
                        dt.Columns.Add("Ngày lập");
                        dt.Columns.Add("Tổng tiền");

                        foreach (DataRowView row in dv)
                        {
                            object[] list = {
                        row["MaHD"],       
                        row["MaKH"],      
                        row["MaNV"],    
                        row["NgayLap"], 
                        row["TongTien"]      
                    };
                            dt.Rows.Add(list);
                        }

                        dgvDonHang.DataSource = dt;
                        txt_find.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_find_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                try
                {
                    int d = dgvDonHang.CurrentRow.Index;
                    txtMaHD.Text = dgvDonHang.Rows[d].Cells[0].Value.ToString();
                    string ngayLapStr = dgvDonHang.Rows[d].Cells["NgayLap"].Value?.ToString();
                    if (DateTime.TryParse(ngayLapStr, out DateTime ngayLap))
                    {
                        time.Value = ngayLap;
                    }
                    cbbMaKH.SelectedItem = dgvDonHang.Rows[d].Cells[1].Value.ToString();
                    cbbMaNV.SelectedItem = dgvDonHang.Rows[d].Cells[2].Value.ToString();
                    txtTongTien.Text = dgvDonHang.Rows[d].Cells[4].Value.ToString();
                }
                catch (Exception ex)
                {
                    ShowMessage($"Đã xảy ra lỗi khi chọn dữ liệu: {ex.Message}", MessageBoxIcon.Error);
                }
        }

        private void txtTenNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btn_capnhat_KH_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDuLieu();

                if (string.IsNullOrWhiteSpace(MaHD) )
                {
                    ShowMessage("Mã hoá đơn không được để trống!", MessageBoxIcon.Warning);
                    return;
                }
                DateTime.TryParse(NgayLap, out DateTime ngayLap);
                hd.suaHD(MaHD, MaKH, MaNV, ngayLap, TongTien);
                ShowMessage("Cập nhật hoá đơn thành công!", MessageBoxIcon.Information);
                HienThiHoaDon();
                ClearInputs();
            }
            catch (Exception ex)
            {
                ShowMessage($"Đã xảy ra lỗi: {ex.Message}", MessageBoxIcon.Error);
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            HienThiHoaDon();
            LoadComboBox();
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\HoaDon.xml";
            try
            {
                System.Diagnostics.Process.Start("Explorer.exe", path);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Chưa có file cần mở trong bin/debug", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_xoa_KH_Click(object sender, EventArgs e)
        {
            try { 
            LoadDuLieu();

            if (string.IsNullOrWhiteSpace(txtMaHD.Text))
            {
                ShowMessage("Vui lòng chọn hoá đơn cần xóa!", MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xoá hoá đơn với mã {txtMaHD.Text} không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Thực hiện xóa
                hd.xoaHD(txtMaHD.Text);
                ShowMessage("Xóa hoá đơn thành công!", MessageBoxIcon.Information);

                // Cập nhật lại danh sách
                HienThiHoaDon();
            }
        }
            catch (Exception ex)
            {
                ShowMessage($"Đã xảy ra lỗi: {ex.Message}", MessageBoxIcon.Error);}
    }


    

        private void btn_load_Click(object sender, EventArgs e)
        {
            HienThiHoaDon();
        }

        private void btn_them_KH_Click(object sender, EventArgs e)
        {

            try
            {
                LoadDuLieu();

                if (string.IsNullOrWhiteSpace(MaHD) || string.IsNullOrWhiteSpace(MaNV) || string.IsNullOrWhiteSpace(MaKH))
                {
                    ShowMessage("Mã hoá đơn, mã nhân viên và mã khách hàng không được để trống!", MessageBoxIcon.Warning);
                    return;
                }

                if (hd.kiemtra(MaHD))
                {
                    ShowMessage("Mã Hoá đơn đã tồn tại.", MessageBoxIcon.Warning);
                }
                else
                {

                    DateTime.TryParse(NgayLap, out DateTime ngayLap);
                    

                    hd.themHD(MaHD, MaKH, MaNV, ngayLap, TongTien);
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
    }
}
