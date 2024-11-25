using BTCUOIKI.Class;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace BTCUOIKI.GUI
{
    public partial class frmKhachhang : Form
    {
        KhachHang kh = new KhachHang();
        FileXml Fxml = new FileXml();
        string MaKhachHang, TenKhachHang, DiaChi, SDT, Email;

        private void btn_xoa_KH_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDuLieu();

                if (string.IsNullOrWhiteSpace(MaKhachHang))
                {
                    ShowMessage("Vui lòng chọn mã khách hàng cần xóa!", MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa khách hàng với mã {MaKhachHang} không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    kh.xoaKH(MaKhachHang);
                    ShowMessage("Xóa khách hàng thành công!", MessageBoxIcon.Information);
                    HienThiKhachHang();
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
                XmlTextReader reader = new XmlTextReader("KhachHang.xml");
                DataSet ds = new DataSet();
                ds.ReadXml(reader);
                reader.Close();

                if (ds.Tables.Count > 0)
                {
                    DataView dv = new DataView(ds.Tables[0]);
                    dv.RowFilter = $"TenKH LIKE '%{txt_find.Text}%'";

                    if (dv.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy khách hàng nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_find.Clear();
                        txt_find.Focus();
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Mã khách hàng");
                        dt.Columns.Add("Họ và tên");
                        dt.Columns.Add("Địa chỉ");
                        dt.Columns.Add("Số điện thoại");
                        dt.Columns.Add("Email");

                        foreach (DataRowView row in dv)
                        {
                            object[] list = {
                                row["MaKH"],
                                row["TenKH"],
                                row["DiaChi"],
                                row["SoDienThoai"],
                                row["Email"]
                            };
                            dt.Rows.Add(list);
                        }

                        dgvKhachHang.DataSource = dt;
                        txt_find.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_capnhat_KH_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDuLieu();

                if (string.IsNullOrWhiteSpace(MaKhachHang))
                {
                    ShowMessage("Mã khách hàng không được để trống!", MessageBoxIcon.Warning);
                    return;
                }

                kh.suaKH(MaKhachHang, TenKhachHang, DiaChi, SDT, Email);
                ShowMessage("Cập nhật khách hàng thành công!", MessageBoxIcon.Information);
                HienThiKhachHang();
                ClearInputs();
            }
            catch (Exception ex)
            {
                ShowMessage($"Đã xảy ra lỗi: {ex.Message}", MessageBoxIcon.Error);
            }
        }

        private void frmKhachhang_Load(object sender, EventArgs e)
        {
            HienThiKhachHang();
        }

        public frmKhachhang()
        {
            InitializeComponent();
        }

        private void btn_them_KH_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDuLieu();

                if (string.IsNullOrWhiteSpace(MaKhachHang) || string.IsNullOrWhiteSpace(TenKhachHang))
                {
                    ShowMessage("Mã khách hàng và tên khách hàng không được để trống!", MessageBoxIcon.Warning);
                    return;
                }

                if (kh.kiemtra(MaKhachHang))
                {
                    ShowMessage("Mã khách hàng đã tồn tại.", MessageBoxIcon.Warning);
                }
                else
                {
                    kh.themKH(MaKhachHang, TenKhachHang, DiaChi, SDT, Email);
                    ShowMessage("Thêm khách hàng thành công!", MessageBoxIcon.Information);
                    HienThiKhachHang();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Đã xảy ra lỗi: {ex.Message}", MessageBoxIcon.Error);
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = dgvKhachHang.CurrentRow.Index; // Lấy chỉ số dòng hiện tại được chọn
            txtMaKH.Text = dgvKhachHang.Rows[d].Cells[0].Value.ToString(); // Gán giá trị Mã khách hàng
            txtTenKH.Text = dgvKhachHang.Rows[d].Cells[1].Value.ToString(); // Gán giá trị Tên khách hàng
            txtSDT.Text = dgvKhachHang.Rows[d].Cells[2].Value.ToString(); // Gán giá trị Số điện thoại
            txtEmail.Text = dgvKhachHang.Rows[d].Cells[3].Value.ToString(); // Gán giá trị Email
            txtDiaChi.Text = dgvKhachHang.Rows[d].Cells[4].Value.ToString(); //
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            HienThiKhachHang();
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\KhachHang.xml";
            try
            {
                System.Diagnostics.Process.Start("Explorer.exe", path);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Chưa có file cần mở trong bin/debug", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void HienThiKhachHang()
        {
            try
            {
                DataTable dt = Fxml.HienThi("KhachHang.xml");
                dgvKhachHang.DataSource = dt;
                dgvKhachHang.DefaultCellStyle.Font = new Font("Arial", 14);
                dgvKhachHang.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
                dgvKhachHang.RowTemplate.Height = 40;
                dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                ShowMessage($"Đã xảy ra lỗi khi hiển thị dữ liệu: {ex.Message}", MessageBoxIcon.Error);
            }
        }

        private void LoadDuLieu()
        {
            MaKhachHang = txtMaKH.Text.Trim();
            TenKhachHang = txtTenKH.Text.Trim();
            DiaChi = txtDiaChi.Text.Trim();
            SDT = txtSDT.Text.Trim();
            Email = txtEmail.Text.Trim();
        }

        private void ClearInputs()
        {
            txtMaKH.Text = string.Empty;
            txtTenKH.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtMaKH.Focus();
        }

        private void ShowMessage(string message, MessageBoxIcon icon)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, icon);
        }
    }
}
