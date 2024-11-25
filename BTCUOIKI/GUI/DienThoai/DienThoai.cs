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
using System.Xml;
using System.Windows.Forms;
using System.Reflection;


namespace BTCUOIKI.GUI.DienThoai
{
    public partial class DienThoai : Form
    {
        FileXML Fxml = new FileXML();
        DienThoaiModel dienThoai = new DienThoaiModel();
        DanhMuc danhMuc = new DanhMuc();   
        public DienThoai()
        {
            InitializeComponent();
            this.MdiParent = Application.OpenForms["Main"];
            InitializeMenu(); // Gọi phương thức tạo menu
        }
        private void InitializeMenu()
        {
            // Tạo MenuStrip mới
            MenuStrip menuStrip = new MenuStrip
            {
                Font = new Font("Segoe UI", 14), // Tăng kích thước font
                Padding = new Padding(10, 10, 10, 10) // Tăng chiều cao
            };

            // Tạo menu "Danh Mục" và "Điện Thoại"
            ToolStripMenuItem menuDanhMuc = new ToolStripMenuItem("Danh Mục");
            ToolStripMenuItem menuDienThoai = new ToolStripMenuItem("Điện Thoại");

            // Gắn sự kiện Click
            menuDanhMuc.Click += MenuDanhMuc_Click;
            menuDienThoai.Click += MenuDienThoai_Click;

            // Thêm mục con vào MenuStrip
            menuStrip.Items.Add(menuDanhMuc);
            menuStrip.Items.Add(menuDienThoai);

            // Gán MenuStrip vào form
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }
        private void MenuDanhMuc_Click(object sender, EventArgs e)
        {
            Main mainForm = Application.OpenForms["Main"] as Main;
            if (mainForm != null)
            {
                mainForm.openChildForm(new DanhMucDienThoai());
            }
            else
            {
                MessageBox.Show("Không tìm thấy form Main!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuDienThoai_Click(object sender, EventArgs e)
        {
            // Khi nhấn vào "Danh Mục" không cần làm gì vì đã ở form hiện tại
            MessageBox.Show("Bạn đang ở mục Điện Thoại!");
        }

        public void hienthiDienThoai()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("DienThoai.xml");
            dgv_DT.DataSource = dt;

            // Tăng kích thước font chữ cho nội dung các ô
            dgv_DT.DefaultCellStyle.Font = new Font("Arial", 12);

            // Tăng kích thước font chữ cho tiêu đề cột
            dgv_DT.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);

            // Tùy chỉnh chiều cao hàng để phù hợp với font chữ lớn hơn
            dgv_DT.RowTemplate.Height = 40;

            // Tùy chỉnh chế độ tự động điều chỉnh
            dgv_DT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tự động giãn cột
        }


        private void DienThoai_Load(object sender, EventArgs e)
        {
            cbBoxMaDanhMuc.DataSource = danhMuc.LoadMaDM();
            cbBoxMaDanhMuc.DisplayMember = "TenHang";
            cbBoxMaDanhMuc.ValueMember = "MaDM";
            hienthiDienThoai(); 
        }
        private void dgv_DT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào một hàng hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại dựa trên chỉ số hàng được chọn
                DataGridViewRow row = dgv_DT.Rows[e.RowIndex];

                // Gán giá trị cột vào các TextBox
                txtMaDienThoai.Text = row.Cells["MaDT"].Value?.ToString();
                txtTenDienThoai.Text = row.Cells["TenDT"].Value?.ToString();
                cbBoxMaDanhMuc.Text = row.Cells["MaDM"].Value?.ToString();
                txtGiaBan.Text = row.Cells["GiaBan"].Value?.ToString();
                txtSoLuongTon.Text = row.Cells["SoLuongTon"].Value?.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value?.ToString();

                // Lấy đường dẫn ảnh từ cột "Anh"
                string imagePath = row.Cells["Anh"].Value?.ToString();

                // Kiểm tra nếu đường dẫn ảnh không rỗng và tệp tồn tại
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    // Hiển thị ảnh trong PictureBox
                    picAnh.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // Nếu không có ảnh hợp lệ, hiển thị ảnh mặc định (nếu có)
                    picAnh.Image = null; // Hoặc bạn có thể thay bằng một ảnh mặc định
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu mã điện thoại đã tồn tại
            if (dienThoai.KiemTraMaDT(txtMaDienThoai.Text))
            {
                MessageBox.Show("Mã điện thoại đã tồn tại");
                return;
            }

            // Khai báo biến để chuyển đổi
            decimal giaBan;
            int soLuongTon;

            // Kiểm tra và chuyển đổi `txtGiaBan.Text` sang `decimal`
            if (!decimal.TryParse(txtGiaBan.Text, out giaBan))
            {
                MessageBox.Show("Giá bán phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra và chuyển đổi `txtSoLuongTon.Text` sang `int`
            if (!int.TryParse(txtSoLuongTon.Text, out soLuongTon))
            {
                MessageBox.Show("Số lượng tồn phải là số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thêm điện thoại
            dienThoai.ThemDT(
                txtMaDienThoai.Text,               // Mã điện thoại
                txtTenDienThoai.Text,              // Tên điện thoại
                cbBoxMaDanhMuc.SelectedValue.ToString(), // Mã danh mục
                giaBan,                            // Giá bán đã chuyển đổi
                soLuongTon,                        // Số lượng tồn đã chuyển đổi
                txtMoTa.Text,
                txtAnh.Text                     // Mô tả
            );

            // Hiển thị thông báo và cập nhật danh sách
            MessageBox.Show("Thêm điện thoại thành công!");
            hienthiDienThoai();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra nếu mã điện thoại đã tồn tại
            if (dienThoai.KiemTraMaDT(txtMaDienThoai.Text))
            {
                MessageBox.Show("Mã điện thoại đã tồn tại");
                return;
            }

            // Khai báo biến để chuyển đổi
            decimal giaBan;
            int soLuongTon;

            // Kiểm tra và chuyển đổi `txtGiaBan.Text` sang `decimal`
            if (!decimal.TryParse(txtGiaBan.Text, out giaBan))
            {
                MessageBox.Show("Giá bán phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra và chuyển đổi `txtSoLuongTon.Text` sang `int`
            if (!int.TryParse(txtSoLuongTon.Text, out soLuongTon))
            {
                MessageBox.Show("Số lượng tồn phải là số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thêm điện thoại
            dienThoai.ThemDT(
                txtMaDienThoai.Text,               // Mã điện thoại
                txtTenDienThoai.Text,              // Tên điện thoại
                cbBoxMaDanhMuc.SelectedValue.ToString(), // Mã danh mục
                giaBan,                            // Giá bán đã chuyển đổi
                soLuongTon,                        // Số lượng tồn đã chuyển đổi
                txtMoTa.Text,                      // Mô tả
                txtAnh.Text
            );

            // Hiển thị thông báo và cập nhật danh sách
            MessageBox.Show("Thêm điện thoại thành công!");
            hienthiDienThoai();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Khai báo biến để chuyển đổi
            decimal giaBan;
            int soLuongTon;

            // Kiểm tra và chuyển đổi `txtGiaBan.Text` sang `decimal`
            if (!decimal.TryParse(txtGiaBan.Text, out giaBan))
            {
                MessageBox.Show("Giá bán phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra và chuyển đổi `txtSoLuongTon.Text` sang `int`
            if (!int.TryParse(txtSoLuongTon.Text, out soLuongTon))
            {
                MessageBox.Show("Số lượng tồn phải là số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sửa thông tin điện thoại
             dienThoai.SuaDT(
                txtMaDienThoai.Text,               // Mã điện thoại
                txtTenDienThoai.Text,              // Tên điện thoại
                cbBoxMaDanhMuc.SelectedValue.ToString(), // Mã danh mục
                giaBan,                            // Giá bán đã chuyển đổi
                soLuongTon,                        // Số lượng tồn đã chuyển đổi
                txtMoTa.Text,                      // Mô tả
                txtAnh.Text                        // Đường dẫn ảnh
            );

            // Hiển thị thông báo và cập nhật danh sách
            MessageBox.Show("Cập nhật điện thoại thành công!");
            hienthiDienThoai();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dienThoai.XoaDT(txtMaDienThoai.Text);
            MessageBox.Show("Xóa danh mục thành công");
            hienthiDienThoai();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            hienthiDienThoai();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\DienThoai.xml";
            try
            {
                System.Diagnostics.Process.Start("Explorer.exe", path);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Chưa có file cần mở trong bin/debug", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Đọc file XML và tạo DataSet
            XmlReader reader = new XmlTextReader("DienThoai.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            reader.Close();

            // Kiểm tra xem bảng dữ liệu có dữ liệu không
            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong file XML!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo DataView từ bảng đầu tiên trong DataSet
            DataView dv = new DataView(ds.Tables[0]);

            // Thiết lập bộ lọc để tìm kiếm theo một phần tên điện thoại
            string keyword = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTimKiem.Focus();
                return;
            }

            // Sử dụng RowFilter để tìm kiếm các dòng có chứa từ khóa
            dv.RowFilter = $"TenDT LIKE '%{keyword}%'";

            // Nếu không tìm thấy kết quả
            if (dv.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp!");
                txtTimKiem.Text = "";
                txtTimKiem.Focus();
                return;
            }

            // Tạo DataTable để hiển thị kết quả
            DataTable dt = new DataTable();
            dt.Columns.Add("MaDT");
            dt.Columns.Add("TenDT");
            dt.Columns.Add("MaDM");
            dt.Columns.Add("GiaBan");
            dt.Columns.Add("SoLuongTon");
            dt.Columns.Add("MoTa");

            // Thêm các dòng tìm thấy vào DataTable
            foreach (DataRowView row in dv)
            {
                dt.Rows.Add(row["MaDT"], row["TenDT"], row["MaDM"], row["GiaBan"], row["SoLuongTon"], row["MoTa"]);
            }

            // Hiển thị kết quả trong DataGridView
            dgv_DT.DataSource = dt;
            txtTimKiem.Text = "";
        }
    }
}
