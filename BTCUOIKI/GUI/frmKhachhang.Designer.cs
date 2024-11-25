namespace BTCUOIKI.GUI
{
    partial class frmKhachhang
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
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_capnhat_KH = new System.Windows.Forms.Button();
            this.btn_xoa_KH = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btn_them_KH = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tabPage_khachhang = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_them_KH = new System.Windows.Forms.Label();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.btn_find = new System.Windows.Forms.Button();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_preview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabPage_khachhang.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(321, 64);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(229, 39);
            this.txtMaKH.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(163, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 22);
            this.label15.TabIndex = 4;
            this.label15.Text = "Tên Khách Hàng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(594, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 22);
            this.label14.TabIndex = 3;
            this.label14.Text = "Số Điện Thoại";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(647, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 22);
            this.label13.TabIndex = 2;
            this.label13.Text = "Địa Chỉ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(360, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(362, 33);
            this.label10.TabIndex = 0;
            this.label10.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // btn_capnhat_KH
            // 
            this.btn_capnhat_KH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_capnhat_KH.Location = new System.Drawing.Point(547, 24);
            this.btn_capnhat_KH.Name = "btn_capnhat_KH";
            this.btn_capnhat_KH.Size = new System.Drawing.Size(150, 50);
            this.btn_capnhat_KH.TabIndex = 20;
            this.btn_capnhat_KH.Text = "Cập Nhật";
            this.btn_capnhat_KH.UseVisualStyleBackColor = true;
            this.btn_capnhat_KH.Click += new System.EventHandler(this.btn_capnhat_KH_Click);
            // 
            // btn_xoa_KH
            // 
            this.btn_xoa_KH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa_KH.Location = new System.Drawing.Point(300, 24);
            this.btn_xoa_KH.Name = "btn_xoa_KH";
            this.btn_xoa_KH.Size = new System.Drawing.Size(150, 50);
            this.btn_xoa_KH.TabIndex = 19;
            this.btn_xoa_KH.Text = "Xóa";
            this.btn_xoa_KH.UseVisualStyleBackColor = true;
            this.btn_xoa_KH.Click += new System.EventHandler(this.btn_xoa_KH_Click);
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_load.Location = new System.Drawing.Point(1035, 24);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(150, 50);
            this.btn_load.TabIndex = 22;
            this.btn_load.Text = "Reset";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(321, 132);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(229, 39);
            this.txtTenKH.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(740, 122);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(229, 108);
            this.txtDiaChi.TabIndex = 6;
            // 
            // btn_them_KH
            // 
            this.btn_them_KH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them_KH.Location = new System.Drawing.Point(59, 24);
            this.btn_them_KH.Name = "btn_them_KH";
            this.btn_them_KH.Size = new System.Drawing.Size(150, 50);
            this.btn_them_KH.TabIndex = 18;
            this.btn_them_KH.Text = "Thêm";
            this.btn_them_KH.UseVisualStyleBackColor = true;
            this.btn_them_KH.Click += new System.EventHandler(this.btn_them_KH_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(740, 64);
            this.txtSDT.Mask = "999 000 0000";
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(229, 39);
            this.txtSDT.TabIndex = 10;
            this.txtSDT.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(163, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 22);
            this.label12.TabIndex = 1;
            this.label12.Text = "Mã Khách Hàng";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.Location = new System.Drawing.Point(3, 318);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(1211, 319);
            this.dgvKhachHang.TabIndex = 2;
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellContentClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_preview);
            this.panel6.Controls.Add(this.btn_capnhat_KH);
            this.panel6.Controls.Add(this.btn_xoa_KH);
            this.panel6.Controls.Add(this.btn_load);
            this.panel6.Controls.Add(this.btn_them_KH);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(3, 637);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1211, 95);
            this.panel6.TabIndex = 1;
            // 
            // tabPage_khachhang
            // 
            this.tabPage_khachhang.Controls.Add(this.dgvKhachHang);
            this.tabPage_khachhang.Controls.Add(this.panel6);
            this.tabPage_khachhang.Controls.Add(this.panel5);
            this.tabPage_khachhang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage_khachhang.Location = new System.Drawing.Point(4, 35);
            this.tabPage_khachhang.Name = "tabPage_khachhang";
            this.tabPage_khachhang.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_khachhang.Size = new System.Drawing.Size(1217, 735);
            this.tabPage_khachhang.TabIndex = 2;
            this.tabPage_khachhang.Text = "   Khách Hàng   ";
            this.tabPage_khachhang.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_find);
            this.panel5.Controls.Add(this.txt_find);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtEmail);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txtSDT);
            this.panel5.Controls.Add(this.lb_them_KH);
            this.panel5.Controls.Add(this.txtTenKH);
            this.panel5.Controls.Add(this.txtDiaChi);
            this.panel5.Controls.Add(this.txtMaKH);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1211, 315);
            this.panel5.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(321, 198);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 39);
            this.txtEmail.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(163, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Email";
            // 
            // lb_them_KH
            // 
            this.lb_them_KH.AutoSize = true;
            this.lb_them_KH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_them_KH.Location = new System.Drawing.Point(16, 281);
            this.lb_them_KH.Name = "lb_them_KH";
            this.lb_them_KH.Size = new System.Drawing.Size(0, 22);
            this.lb_them_KH.TabIndex = 9;
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_khachhang);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1225, 774);
            this.tabControl_Main.TabIndex = 2;
            // 
            // btn_find
            // 
            this.btn_find.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_find.Location = new System.Drawing.Point(1049, 262);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(130, 41);
            this.btn_find.TabIndex = 24;
            this.btn_find.Text = "Tìm kiếm";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // txt_find
            // 
            this.txt_find.Location = new System.Drawing.Point(765, 264);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(257, 39);
            this.txt_find.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(644, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tìm kiếm";
            // 
            // btn_preview
            // 
            this.btn_preview.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_preview.Location = new System.Drawing.Point(792, 24);
            this.btn_preview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(149, 50);
            this.btn_preview.TabIndex = 23;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // frmKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 774);
            this.Controls.Add(this.tabControl_Main);
            this.Name = "frmKhachhang";
            this.Text = "frmKhachhang";
            this.Load += new System.EventHandler(this.frmKhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tabPage_khachhang.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabControl_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_capnhat_KH;
        private System.Windows.Forms.Button btn_xoa_KH;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btn_them_KH;
        private System.Windows.Forms.MaskedTextBox txtSDT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TabPage tabPage_khachhang;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lb_them_KH;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_preview;
    }
}