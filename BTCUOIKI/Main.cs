using BTCUOIKI.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCUOIKI
{
    public partial class Main : Form
    {
        Thread t;
        public Main()
        {
            InitializeComponent();
        }
        private Form activeform = null;
        private void openChildForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm_AD.Controls.Add(childForm);
            panelChildForm_AD.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // xử lí chuyển màu khi click vào button
        private Button currentButton;
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#00008B"); // DarkBlue (màu xanh đậm hơn)
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                }
            }
        }

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


        private void btn_nhanvien_AD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new frmNhanVien());
        }

        private void btn_khachhang_AD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new frmKhachhang());
        }

        private void btn_hanghoa_AD_Click(object sender, EventArgs e)
        {
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btn_hanghoa_AD.PerformClick();
        }
    }
}
