using QuanLySieuThi.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCUOIKI.GUI
{
    public partial class frmChuyenDoi : Form
    {
        HeThong HT = new HeThong();
        private Main mainForm;
        public frmChuyenDoi(Main main)
        {
            InitializeComponent();
            this.mainForm = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HT.TaoXML();
                MessageBox.Show("Tạo XML thành công");

                // Gọi phương thức EnableAllButtons trên form Main
                mainForm.EnableAllButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                HT.CapNhapSQL();
                MessageBox.Show("Cập nhập SQL server thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
