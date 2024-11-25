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

namespace BTCUOIKI.GUI.DienThoai
{
    public partial class DanhMucDienThoai : Form
    {
        FileXML Fxml = new FileXML();
        DanhMuc danhMuc = new DanhMuc();

        public DanhMucDienThoai()
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
            // Khi nhấn vào "Danh Mục" không cần làm gì vì đã ở form hiện tại
            MessageBox.Show("Bạn đang ở mục Danh Mục!");
        }

        private void MenuDienThoai_Click(object sender, EventArgs e)
        {
            Main mainForm = Application.OpenForms["Main"] as Main;
            if (mainForm != null)
            {
                mainForm.openChildForm(new DienThoai());
            }
            else
            {
                MessageBox.Show("Không tìm thấy form Main!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void hienthiDanhMuc()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("DanhMucDienThoai.xml");
            dgv_HDT.DataSource = dt;

            // Tăng kích thước font chữ cho nội dung các ô
            dgv_HDT.DefaultCellStyle.Font = new Font("Arial", 14);

            // Tăng kích thước font chữ cho tiêu đề cột
            dgv_HDT.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);

            // Tùy chỉnh chiều cao hàng để phù hợp với font chữ lớn hơn
            dgv_HDT.RowTemplate.Height = 40;

            // Tùy chỉnh chế độ tự động điều chỉnh
            dgv_HDT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tự động giãn cột
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hienthiDanhMuc();
        }

        private void dANHMUCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sự kiện menu Danh Mục được gọi!");
            Main mainForm = (Main)this.MdiParent;
            if (mainForm != null)
            {
                mainForm.openChildForm(new DanhMucDienThoai());  // Mở form DanhMucDienThoai
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (danhMuc.KiemTraMaDM(txtMaDanhMuc.Text) == true)
            {
                MessageBox.Show("Mã hàng đã tồn tại");
            }
            else
            {
                danhMuc.ThemDM(txtMaDanhMuc.Text, txtTenDanhMuc.Text);
                MessageBox.Show("Thêm danh mục thành công");
                hienthiDanhMuc();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            danhMuc.SuaDM(txtMaDanhMuc.Text, txtTenDanhMuc.Text);
            MessageBox.Show("Cập nhật danh mục thành công");
            hienthiDanhMuc();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            danhMuc.XoaDM(txtMaDanhMuc.Text);
            MessageBox.Show("Xóa danh mục thành công");
            hienthiDanhMuc();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            hienthiDanhMuc();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            XmlReader reader = new XmlTextReader("DanhMucDienThoai.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            DataView dv = new DataView(ds.Tables[0]);
            dv.Sort = "MaDM";
            reader.Close(); 
            int index = dv.Find(txtTimKiem.Text);
            if (index == -1)
            {
                MessageBox.Show("Không tìm thấy");
                txtTimKiem.Text = "";
                txtTimKiem.Focus();

            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã Danh Mục");
                dt.Columns.Add("Tên Danh Mục");


                object[] list = { dv[index]["MaDM"], dv[index]["TenHang"]};
                dt.Rows.Add(list);
                dgv_HDT.DataSource = dt;
                txtTimKiem.Text = "";
            }
        }
        private void dgv_HDT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào một hàng hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại dựa trên chỉ số hàng được chọn
                DataGridViewRow row = dgv_HDT.Rows[e.RowIndex];

                // Gán giá trị cột vào các TextBox
                txtMaDanhMuc.Text = row.Cells["MaDM"].Value?.ToString();
                txtTenDanhMuc.Text = row.Cells["TenHang"].Value?.ToString();
            }

        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\DanhMucDienThoai.xml";
            try
            {
                System.Diagnostics.Process.Start("Explorer.exe", path);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Chưa có file cần mở trong bin/debug", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
