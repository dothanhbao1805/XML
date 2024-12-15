using BTCUOIKI.GUI;
using System;
using System.Windows.Forms;
using BTCUOIKI.Class;
using BTCUOIKI.GUI.DienThoai;

namespace BTCUOIKI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangNhap());
        }
    }
}
