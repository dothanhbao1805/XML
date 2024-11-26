using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BTCUOIKI.GUI.ThongKe
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frmThongKe_Load);
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=LAPTOP-DIFNPUPB\XUANHOANG;Database=QuanLyCuaHangDienThoai;Trusted_Connection=True;";

            // Gọi các hàm hiển thị thống kê
            LoadChartDoanhThu(connectionString);
            LoadChartMatHangBanChay(connectionString);
            LoadChartTonKho(connectionString);
        }

        private void LoadChartDoanhThu(string connectionString)
        {
            string query = @"
                SELECT 
                    MONTH(NgayLap) AS Thang, 
                    SUM(CTHD.SoLuong * CTHD.DonGia) AS DoanhThu
                FROM 
                    HoaDon HD
                INNER JOIN 
                    ChiTietHoaDon CTHD ON HD.MaHD = CTHD.MaHD
                GROUP BY 
                    MONTH(NgayLap)
                ORDER BY 
                    Thang;
            ";

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dataTable);

                    // Hiển thị dữ liệu lên biểu đồ doanh thu
                    chart_DoanhThu.Series.Clear();
                    Series series = new Series("Doanh thu");
                    series.ChartType = SeriesChartType.Column;
                    series.Color = System.Drawing.Color.Green;

                    foreach (DataRow row in dataTable.Rows)
                    {
                        series.Points.AddXY(row["Thang"], row["DoanhThu"]);
                    }

                    chart_DoanhThu.Series.Add(series);
                    chart_DoanhThu.ChartAreas[0].AxisX.Title = "Tháng";
                    chart_DoanhThu.ChartAreas[0].AxisY.Title = "Doanh thu";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void LoadChartMatHangBanChay(string connectionString)
        {
            string query = @"
        SELECT TOP 5 
            DT.TenDT AS DienThoai, 
            SUM(CTHD.SoLuong) AS SoLuongBan
        FROM 
            ChiTietHoaDon CTHD
        INNER JOIN 
            DienThoai DT ON CTHD.MaDT = DT.MaDT
        GROUP BY 
            DT.TenDT
        ORDER BY 
            SoLuongBan DESC;
    ";

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dataTable);

                    // Hiển thị dữ liệu lên biểu đồ mặt hàng bán chạy
                    chart_mhbc.Series.Clear();
                    Series series = new Series("Mặt hàng bán chạy");
                    series.ChartType = SeriesChartType.Pie; // Biểu đồ tròn
                    series.IsValueShownAsLabel = true; // Hiển thị nhãn giá trị (số lượng bán)
                    series.LabelFormat = "#,##0"; // Định dạng số

                    foreach (DataRow row in dataTable.Rows)
                    {
                        DataPoint point = new DataPoint
                        {
                            AxisLabel = row["DienThoai"].ToString(), // Gán tên mặt hàng
                            YValues = new double[] { Convert.ToDouble(row["SoLuongBan"]) } // Gán giá trị số lượng bán
                        };

                        point.Label = $"{row["DienThoai"]} ({row["SoLuongBan"]})"; // Hiển thị tên và số lượng bán
                        series.Points.Add(point);
                    }

                    chart_mhbc.Series.Add(series);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


        private void LoadChartTonKho(string connectionString)
        {
            string query = @"
                SELECT 
                    DT.TenDT AS DienThoai, 
                    DT.SoLuongTon AS SoLuongTon
                FROM 
                    DienThoai DT
                ORDER BY 
                    SoLuongTon ASC;
            ";

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dataTable);

                    // Hiển thị dữ liệu lên biểu đồ tồn kho
                    chart_TonKho.Series.Clear();
                    Series series = new Series("Số lượng tồn kho");
                    series.ChartType = SeriesChartType.Bar; // Biểu đồ cột ngang
                    series.Color = System.Drawing.Color.Orange;

                    foreach (DataRow row in dataTable.Rows)
                    {
                        series.Points.AddXY(row["DienThoai"], row["SoLuongTon"]);
                    }

                    chart_TonKho.Series.Add(series);
                    chart_TonKho.ChartAreas[0].AxisX.Title = "Điện thoại";
                    chart_TonKho.ChartAreas[0].AxisY.Title = "Số lượng tồn kho";
                    chart_TonKho.ChartAreas[0].AxisX.Interval = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
