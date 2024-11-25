using BTCUOIKI.Class;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace BTCUOIKI
{
    public partial class frmNhanVien : Form
    {
        NhanVien nv = new NhanVien();
        FileXml Fxml = new FileXml();
        string MaNhanVien, TenNhanVien, DiaChi, SDT, Email;

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThiNhanVien();
        }

        private void btn_them_NV_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDuLieu();

                if (string.IsNullOrWhiteSpace(MaNhanVien) || string.IsNullOrWhiteSpace(TenNhanVien))
                {
                    ShowMessage("Mã nhân viên và tên nhân viên không được để trống!", MessageBoxIcon.Warning);
                    return;
                }

                if (nv.kiemtra(MaNhanVien))
                {
                    ShowMessage("Mã nhân viên đã tồn tại.", MessageBoxIcon.Warning);
                }
                else
                {
                    nv.themNV(MaNhanVien, TenNhanVien, DiaChi, SDT, Email);
                    ShowMessage("Thêm nhân viên thành công!", MessageBoxIcon.Information);
                    HienThiNhanVien();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Đã xảy ra lỗi: {ex.Message}", MessageBoxIcon.Error);
            }
        }

        private void btn_capnhat_NV_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDuLieu();

                if (string.IsNullOrWhiteSpace(MaNhanVien))
                {
                    ShowMessage("Mã nhân viên không được để trống!", MessageBoxIcon.Warning);
                    return;
                }

                nv.suaNV(MaNhanVien, TenNhanVien, DiaChi, SDT, Email);
                ShowMessage("Cập nhật nhân viên thành công!", MessageBoxIcon.Information);
                HienThiNhanVien();
                ClearInputs();
            }
            catch (Exception ex)
            {
                ShowMessage($"Đã xảy ra lỗi: {ex.Message}", MessageBoxIcon.Error);
            }
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = dgvNhanVien.CurrentRow.Index;
                txtMaNhanVien.Text = dgvNhanVien.Rows[d].Cells[0].Value.ToString();
                txtTenNhanVien.Text = dgvNhanVien.Rows[d].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[d].Cells[3].Value.ToString();
                txtSDT.Text = dgvNhanVien.Rows[d].Cells[4].Value.ToString();
                txtEmail.Text = dgvNhanVien.Rows[d].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                ShowMessage($"Đã xảy ra lỗi khi chọn dữ liệu: {ex.Message}", MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_NV_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã nhân viên hiện tại
                LoadDuLieu();

                if (string.IsNullOrWhiteSpace(txtMaNhanVien.Text))
                {
                    ShowMessage("Vui lòng chọn mã nhân viên cần xóa!", MessageBoxIcon.Warning);
                    return;
                }

                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa nhân viên với mã {txtMaNhanVien.Text} không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    // Thực hiện xóa
                    nv.xoaNV(txtMaNhanVien.Text);
                    ShowMessage("Xóa nhân viên thành công!", MessageBoxIcon.Information);

                    // Cập nhật lại danh sách
                    HienThiNhanVien();
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Đã xảy ra lỗi: {ex.Message}", MessageBoxIcon.Error);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\NhanVien.xml";
            try
            {
                System.Diagnostics.Process.Start("Explorer.exe", path);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Chưa có file cần mở trong bin/debug", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvNhanVien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int d = dgvNhanVien.CurrentRow.Index;
            txtMaNhanVien.Text = dgvNhanVien.Rows[d].Cells[0].Value.ToString();
            txtTenNhanVien.Text = dgvNhanVien.Rows[d].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[d].Cells[4].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[d].Cells[2].Value.ToString();
            txtEmail.Text = dgvNhanVien.Rows[d].Cells[3].Value.ToString();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            try
            {
                // Đọc dữ liệu từ file XML
                XmlTextReader reader = new XmlTextReader("NhanVien.xml");
                DataSet ds = new DataSet();
                ds.ReadXml(reader);
                reader.Close();

                if (ds.Tables.Count > 0)
                {
                    DataView dv = new DataView(ds.Tables[0]);

                    // Lọc theo tên nhân viên chứa chuỗi nhập vào, không phân biệt hoa/thường
                    dv.RowFilter = $"TenNV LIKE '%{txt_find.Text}%'";

                    if (dv.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_find.Clear();
                        txt_find.Focus();
                    }
                    else
                    {
                        // Tạo bảng kết quả để hiển thị
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Mã nhân viên");
                        dt.Columns.Add("Họ và tên");                     
                        dt.Columns.Add("Địa chỉ");
                        dt.Columns.Add("Số điện thoại");
                        dt.Columns.Add("Email");

                        // Thêm từng nhân viên tìm được vào bảng
                        foreach (DataRowView row in dv)
                        {
                            object[] list = {
                        row["MaNV"],        // Tên cột từ XML
                        row["TenNV"],       // Tên cột từ XML
                        row["DiaChi"],      // Tên cột từ XML
                        row["SoDienThoai"], // Tên cột từ XML
                        row["Email"]        // Tên cột từ XML
                    };
                            dt.Rows.Add(list);
                        }

                        // Gán kết quả cho DataGridView
                        dgvNhanVien.DataSource = dt;
                        txt_find.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            HienThiNhanVien();
        }

        // Hiển thị dữ liệu nhân viên
        public void HienThiNhanVien()
        {
            try
            {
                DataTable dt = Fxml.HienThi("NhanVien.xml");
                dgvNhanVien.DataSource = dt;
                // Tăng kích thước font chữ cho nội dung các ô
                dgvNhanVien.DefaultCellStyle.Font = new Font("Arial", 14);

                // Tăng kích thước font chữ cho tiêu đề cột
                dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);

                // Tùy chỉnh chiều cao hàng để phù hợp với font chữ lớn hơn
                dgvNhanVien.RowTemplate.Height = 40;

                // Tùy chỉnh chế độ tự động điều chỉnh
                dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tự động giãn cột
            }
            catch (Exception ex)
            {
                ShowMessage($"Đã xảy ra lỗi khi hiển thị dữ liệu: {ex.Message}", MessageBoxIcon.Error);
            }
        }

        // Lấy dữ liệu từ các textbox
        public void LoadDuLieu()
        {
            MaNhanVien = txtMaNhanVien.Text.Trim();
            TenNhanVien = txtTenNhanVien.Text.Trim();
            DiaChi = txtDiaChi.Text.Trim();
            SDT = txtSDT.Text.Trim();
            Email = txtEmail.Text.Trim();
        }

        // Xóa các input
        private void ClearInputs()
        {
            txtMaNhanVien.Text = string.Empty;
            txtTenNhanVien.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtMaNhanVien.Focus();
        }

        // Hiển thị thông báo
        private void ShowMessage(string message, MessageBoxIcon icon)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, icon);
        }
    }
}
