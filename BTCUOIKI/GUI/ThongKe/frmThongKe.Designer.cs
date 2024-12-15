namespace BTCUOIKI.GUI.ThongKe
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl_sub_thongke = new System.Windows.Forms.TabControl();
            this.tabPage_doanhthu = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.chart_DoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage_mathangbanchay = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage_mathangsaphet = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.chart_mhbc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_TonKho = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl_sub_thongke.SuspendLayout();
            this.tabPage_doanhthu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhThu)).BeginInit();
            this.tabPage_mathangbanchay.SuspendLayout();
            this.tabPage_mathangsaphet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_mhbc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_TonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_sub_thongke
            // 
            this.tabControl_sub_thongke.Controls.Add(this.tabPage_doanhthu);
            this.tabControl_sub_thongke.Controls.Add(this.tabPage_mathangbanchay);
            this.tabControl_sub_thongke.Controls.Add(this.tabPage_mathangsaphet);
            this.tabControl_sub_thongke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_sub_thongke.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl_sub_thongke.Location = new System.Drawing.Point(0, 0);
            this.tabControl_sub_thongke.Name = "tabControl_sub_thongke";
            this.tabControl_sub_thongke.SelectedIndex = 0;
            this.tabControl_sub_thongke.Size = new System.Drawing.Size(1133, 662);
            this.tabControl_sub_thongke.TabIndex = 2;
            this.tabControl_sub_thongke.SelectedIndexChanged += new System.EventHandler(this.tabControl_sub_thongke_SelectedIndexChanged);
            // 
            // tabPage_doanhthu
            // 
            this.tabPage_doanhthu.Controls.Add(this.label2);
            this.tabPage_doanhthu.Controls.Add(this.chart_DoanhThu);
            this.tabPage_doanhthu.Location = new System.Drawing.Point(4, 31);
            this.tabPage_doanhthu.Name = "tabPage_doanhthu";
            this.tabPage_doanhthu.Size = new System.Drawing.Size(1125, 627);
            this.tabPage_doanhthu.TabIndex = 2;
            this.tabPage_doanhthu.Text = "  Doanh Thu  ";
            this.tabPage_doanhthu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(319, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(489, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "THỐNG KÊ DOANH THU THEO THÁNG";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chart_DoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_DoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_DoanhThu.Legends.Add(legend1);
            this.chart_DoanhThu.Location = new System.Drawing.Point(3, 2);
            this.chart_DoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart_DoanhThu.Name = "chart_DoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_DoanhThu.Series.Add(series1);
            this.chart_DoanhThu.Size = new System.Drawing.Size(1119, 463);
            this.chart_DoanhThu.TabIndex = 2;
            this.chart_DoanhThu.Text = "chart2";
            this.chart_DoanhThu.Click += new System.EventHandler(this.chart2_Click);
            // 
            // tabPage_mathangbanchay
            // 
            this.tabPage_mathangbanchay.Controls.Add(this.chart_mhbc);
            this.tabPage_mathangbanchay.Controls.Add(this.label3);
            this.tabPage_mathangbanchay.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage_mathangbanchay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage_mathangbanchay.Location = new System.Drawing.Point(4, 31);
            this.tabPage_mathangbanchay.Name = "tabPage_mathangbanchay";
            this.tabPage_mathangbanchay.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage_mathangbanchay.Size = new System.Drawing.Size(1125, 627);
            this.tabPage_mathangbanchay.TabIndex = 1;
            this.tabPage_mathangbanchay.Text = "  Mặt Hàng Bán Chạy  ";
            this.tabPage_mathangbanchay.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(539, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "THỐNG KÊ TOP 5 ĐIỆN THOẠI BÁN CHẠY";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabPage_mathangsaphet
            // 
            this.tabPage_mathangsaphet.Controls.Add(this.chart_TonKho);
            this.tabPage_mathangsaphet.Controls.Add(this.label1);
            this.tabPage_mathangsaphet.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage_mathangsaphet.Location = new System.Drawing.Point(4, 31);
            this.tabPage_mathangsaphet.Name = "tabPage_mathangsaphet";
            this.tabPage_mathangsaphet.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage_mathangsaphet.Size = new System.Drawing.Size(1125, 627);
            this.tabPage_mathangsaphet.TabIndex = 0;
            this.tabPage_mathangsaphet.Text = "  Mặt Hàng Sắp Hết  ";
            this.tabPage_mathangsaphet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ MẶT HÀNG TỒN KHO";
            // 
            // chart_mhbc
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_mhbc.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_mhbc.Legends.Add(legend2);
            this.chart_mhbc.Location = new System.Drawing.Point(0, 5);
            this.chart_mhbc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart_mhbc.Name = "chart_mhbc";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_mhbc.Series.Add(series2);
            this.chart_mhbc.Size = new System.Drawing.Size(1125, 483);
            this.chart_mhbc.TabIndex = 6;
            this.chart_mhbc.Text = "chart3";
            // 
            // chart_TonKho
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_TonKho.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_TonKho.Legends.Add(legend3);
            this.chart_TonKho.Location = new System.Drawing.Point(0, 0);
            this.chart_TonKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart_TonKho.Name = "chart_TonKho";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_TonKho.Series.Add(series3);
            this.chart_TonKho.Size = new System.Drawing.Size(1129, 529);
            this.chart_TonKho.TabIndex = 2;
            this.chart_TonKho.Text = "chart1";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 662);
            this.Controls.Add(this.tabControl_sub_thongke);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.tabControl_sub_thongke.ResumeLayout(false);
            this.tabPage_doanhthu.ResumeLayout(false);
            this.tabPage_doanhthu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhThu)).EndInit();
            this.tabPage_mathangbanchay.ResumeLayout(false);
            this.tabPage_mathangbanchay.PerformLayout();
            this.tabPage_mathangsaphet.ResumeLayout(false);
            this.tabPage_mathangsaphet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_mhbc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_TonKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_sub_thongke;
        private System.Windows.Forms.TabPage tabPage_mathangsaphet;
        private System.Windows.Forms.TabPage tabPage_mathangbanchay;
        private System.Windows.Forms.TabPage tabPage_doanhthu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DoanhThu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_mhbc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_TonKho;
    }
}