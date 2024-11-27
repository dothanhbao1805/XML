namespace BTCUOIKI.GUI
{
    partial class frmHoaDon
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_capnhat_KH = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_xoa_KH = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_them_KH = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.cbbMaKH = new System.Windows.Forms.ComboBox();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(237, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 26);
            this.label2.TabIndex = 85;
            this.label2.Text = "Danh sách hoá đơn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_find
            // 
            this.btn_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find.Location = new System.Drawing.Point(392, 206);
            this.btn_find.Margin = new System.Windows.Forms.Padding(2);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(85, 29);
            this.btn_find.TabIndex = 84;
            this.btn_find.Text = "TÌM KIẾM";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // txt_find
            // 
            this.txt_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_find.Location = new System.Drawing.Point(255, 210);
            this.txt_find.Margin = new System.Windows.Forms.Padding(2);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(135, 23);
            this.txt_find.TabIndex = 83;
            this.txt_find.TextChanged += new System.EventHandler(this.txt_find_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(109, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 82;
            this.label4.Text = "TÌM KIẾM ĐƠN HÀNG";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(234, 154);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(173, 26);
            this.txtTongTien.TabIndex = 81;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(112, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 80;
            this.label1.Text = "Tổng tiền";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Location = new System.Drawing.Point(47, 249);
            this.dgvDonHang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.RowHeadersWidth = 62;
            this.dgvDonHang.RowTemplate.Height = 28;
            this.dgvDonHang.Size = new System.Drawing.Size(664, 144);
            this.dgvDonHang.TabIndex = 78;
            this.dgvDonHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(234, 64);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(173, 26);
            this.txtMaHD.TabIndex = 70;
            this.txtMaHD.TextChanged += new System.EventHandler(this.txtMaNhanVien_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(109, 117);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 19);
            this.label15.TabIndex = 69;
            this.label15.Text = "Mã Nhân Viên";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(436, 64);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 19);
            this.label14.TabIndex = 68;
            this.label14.Text = "Mã Khách Hàng";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(448, 115);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 19);
            this.label13.TabIndex = 67;
            this.label13.Text = "Ngày lập";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(112, 69);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 19);
            this.label12.TabIndex = 66;
            this.label12.Text = "Mã hoá đơn";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // btn_capnhat_KH
            // 
            this.btn_capnhat_KH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_capnhat_KH.Location = new System.Drawing.Point(316, 398);
            this.btn_capnhat_KH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_capnhat_KH.Name = "btn_capnhat_KH";
            this.btn_capnhat_KH.Size = new System.Drawing.Size(82, 40);
            this.btn_capnhat_KH.TabIndex = 75;
            this.btn_capnhat_KH.Text = "Cập Nhật";
            this.btn_capnhat_KH.UseVisualStyleBackColor = true;
            this.btn_capnhat_KH.Click += new System.EventHandler(this.btn_capnhat_KH_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_preview.Location = new System.Drawing.Point(554, 398);
            this.btn_preview.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(82, 40);
            this.btn_preview.TabIndex = 76;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_xoa_KH
            // 
            this.btn_xoa_KH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa_KH.Location = new System.Drawing.Point(206, 398);
            this.btn_xoa_KH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_xoa_KH.Name = "btn_xoa_KH";
            this.btn_xoa_KH.Size = new System.Drawing.Size(82, 40);
            this.btn_xoa_KH.TabIndex = 74;
            this.btn_xoa_KH.Text = "Xóa";
            this.btn_xoa_KH.UseVisualStyleBackColor = true;
            this.btn_xoa_KH.Click += new System.EventHandler(this.btn_xoa_KH_Click);
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_load.Location = new System.Drawing.Point(442, 398);
            this.btn_load.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(82, 40);
            this.btn_load.TabIndex = 77;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_them_KH
            // 
            this.btn_them_KH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them_KH.Location = new System.Drawing.Point(76, 398);
            this.btn_them_KH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_them_KH.Name = "btn_them_KH";
            this.btn_them_KH.Size = new System.Drawing.Size(85, 40);
            this.btn_them_KH.TabIndex = 73;
            this.btn_them_KH.Text = "Thêm";
            this.btn_them_KH.UseVisualStyleBackColor = true;
            this.btn_them_KH.Click += new System.EventHandler(this.btn_them_KH_Click);
            // 
            // time
            // 
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.time.Location = new System.Drawing.Point(550, 118);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(161, 20);
            this.time.TabIndex = 86;
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.FormattingEnabled = true;
            this.cbbMaKH.Location = new System.Drawing.Point(550, 64);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(121, 21);
            this.cbbMaKH.TabIndex = 87;
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(234, 115);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(173, 21);
            this.cbbMaNV.TabIndex = 88;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbMaNV);
            this.Controls.Add(this.cbbMaKH);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.txt_find);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDonHang);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_capnhat_KH);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.btn_xoa_KH);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_them_KH);
            this.Name = "frmHoaDon";
            this.Text = "frmDonHang";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_capnhat_KH;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_xoa_KH;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_them_KH;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.ComboBox cbbMaKH;
        private System.Windows.Forms.ComboBox cbbMaNV;
    }
}