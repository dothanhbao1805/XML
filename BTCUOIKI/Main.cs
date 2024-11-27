using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BTCUOIKI.GUI;
using BTCUOIKI.GUI.DienThoai;
using BTCUOIKI.GUI.ThongKe;
namespace BTCUOIKI
{
    public partial class Main : Form
    {
        // Biến lưu form con đang mở
        private Form activeForm = null;

        public Main()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Đảm bảo form Main là MDI container
        }

        // Sự kiện khi nhấn vào button "Hàng hóa" trên menu
        private void btn_hanghoa_AD_Click(object sender, EventArgs e)
        {
           
            // Mở form DanhMucDienThoai
            ActivateButton(sender); // Chuyển màu button khi nhấn
            openChildForm(new DanhMucDienThoai()); // Mở form DanhMucDienThoai
        }

        // Phương thức để tắt màu của các nút trong menu
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(70, 130, 180); // SteelBlue (#4682B4)
                    previousBtn.ForeColor = Color.Gainsboro; // Giữ nguyên màu chữ xám nhạt
                }
            }
        }

        // Phương thức xử lý việc thay đổi màu sắc của nút khi được nhấn
        private Button currentButton;
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#00008B"); // Màu khi nhấn nút
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                }
            }
        }

        // Phương thức mở form con
        public void openChildForm(Form childForm)
        {
            // Nếu có form con hiện tại, đóng nó trước
            if (activeForm != null)
            {
                activeForm.Close();
            }

            // Gán form con mới vào biến activeForm
            activeForm = childForm;

            // Đảm bảo form con sẽ không có viền và tự động giãn vừa với panel
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;  // Đảm bảo form con chiếm toàn bộ không gian panel

            // Thêm form con vào panelChildForm_AD
            panelChildForm_AD.Controls.Add(childForm);
            panelChildForm_AD.Tag = childForm;

            // Hiển thị form con
            childForm.BringToFront();
            childForm.Show();
        }

        // Sự kiện khi nhấn vào mục "Danh Mục" trong menu "Danh Mục

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_thoat_AD_Click(object sender, EventArgs e)
        {

        }

        private void panelChildForm_AD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            btn_hanghoa_AD.PerformClick();
        }

        private void btn_khachhang_AD_Click(object sender, EventArgs e)
        {
            // Mở form DanhMucDienThoai
            ActivateButton(sender);
            openChildForm(new txtthanhtien());

        }

        private void btn_nhanvien_AD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender); // Chuyển màu button khi nhấn
            openChildForm(new frmNhanVien());

        }

        private void btn_thongke_AD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender); // Chuyển màu button khi nhấn
            openChildForm(new KhachHang());
        }

        private void btn_donhang_AD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender); // Chuyển màu button khi nhấn
            openChildForm(new frmHoaDon());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender); // Chuyển màu button khi nhấn
            openChildForm(new frmThongKe());
        }
    }
}
