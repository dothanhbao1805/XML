namespace BTCUOIKI
{
    partial class frmNhanVien
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.MaskedTextBox();
            this.btn_xoa_NV = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_them_NV = new System.Windows.Forms.Button();
            this.lb_them_NV = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage_nhanvien = new System.Windows.Forms.TabPage();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_capnhat_NV = new System.Windows.Forms.Button();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.tabPage_nhanvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 33);
            this.label3.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(360, 210);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(216, 39);
            this.txtSDT.TabIndex = 16;
            this.txtSDT.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btn_xoa_NV
            // 
            this.btn_xoa_NV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa_NV.Location = new System.Drawing.Point(312, 25);
            this.btn_xoa_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa_NV.Name = "btn_xoa_NV";
            this.btn_xoa_NV.Size = new System.Drawing.Size(149, 50);
            this.btn_xoa_NV.TabIndex = 13;
            this.btn_xoa_NV.Text = "Xóa";
            this.btn_xoa_NV.UseVisualStyleBackColor = true;
            this.btn_xoa_NV.Click += new System.EventHandler(this.btn_xoa_NV_Click);
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_load.Location = new System.Drawing.Point(1037, 25);
            this.btn_load.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(149, 50);
            this.btn_load.TabIndex = 16;
            this.btn_load.Text = "Reset";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_them_NV
            // 
            this.btn_them_NV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them_NV.Location = new System.Drawing.Point(61, 25);
            this.btn_them_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them_NV.Name = "btn_them_NV";
            this.btn_them_NV.Size = new System.Drawing.Size(149, 50);
            this.btn_them_NV.TabIndex = 12;
            this.btn_them_NV.Text = "Thêm";
            this.btn_them_NV.UseVisualStyleBackColor = true;
            this.btn_them_NV.Click += new System.EventHandler(this.btn_them_NV_Click);
            // 
            // lb_them_NV
            // 
            this.lb_them_NV.AutoSize = true;
            this.lb_them_NV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_them_NV.ForeColor = System.Drawing.Color.Red;
            this.lb_them_NV.Location = new System.Drawing.Point(17, 294);
            this.lb_them_NV.Name = "lb_them_NV";
            this.lb_them_NV.Size = new System.Drawing.Size(0, 22);
            this.lb_them_NV.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_find);
            this.panel2.Controls.Add(this.txt_find);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSDT);
            this.panel2.Controls.Add(this.lb_them_NV);
            this.panel2.Controls.Add(this.txtDiaChi);
            this.panel2.Controls.Add(this.txtTenNhanVien);
            this.panel2.Controls.Add(this.txtMaNhanVien);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 335);
            this.panel2.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(801, 89);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 39);
            this.txtEmail.TabIndex = 18;
            this.txtEmail.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(656, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Email";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(801, 160);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(185, 89);
            this.txtDiaChi.TabIndex = 13;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(360, 150);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(216, 39);
            this.txtTenNhanVien.TabIndex = 9;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(360, 89);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(216, 39);
            this.txtMaNhanVien.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(215, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 22);
            this.label11.TabIndex = 7;
            this.label11.Text = "Số Điện Thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(656, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(215, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên Nhân Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(215, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(464, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // tabPage_nhanvien
            // 
            this.tabPage_nhanvien.Controls.Add(this.dgvNhanVien);
            this.tabPage_nhanvien.Controls.Add(this.panel3);
            this.tabPage_nhanvien.Controls.Add(this.panel2);
            this.tabPage_nhanvien.Controls.Add(this.label3);
            this.tabPage_nhanvien.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage_nhanvien.Location = new System.Drawing.Point(4, 35);
            this.tabPage_nhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_nhanvien.Name = "tabPage_nhanvien";
            this.tabPage_nhanvien.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_nhanvien.Size = new System.Drawing.Size(1268, 674);
            this.tabPage_nhanvien.TabIndex = 1;
            this.tabPage_nhanvien.Text = "   Nhân Viên   ";
            this.tabPage_nhanvien.UseVisualStyleBackColor = true;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 337);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(1262, 239);
            this.dgvNhanVien.TabIndex = 4;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_preview);
            this.panel3.Controls.Add(this.btn_capnhat_NV);
            this.panel3.Controls.Add(this.btn_xoa_NV);
            this.panel3.Controls.Add(this.btn_load);
            this.panel3.Controls.Add(this.btn_them_NV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 576);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1262, 96);
            this.panel3.TabIndex = 3;
            // 
            // btn_preview
            // 
            this.btn_preview.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_preview.Location = new System.Drawing.Point(801, 25);
            this.btn_preview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(149, 50);
            this.btn_preview.TabIndex = 17;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_capnhat_NV
            // 
            this.btn_capnhat_NV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_capnhat_NV.Location = new System.Drawing.Point(563, 25);
            this.btn_capnhat_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_capnhat_NV.Name = "btn_capnhat_NV";
            this.btn_capnhat_NV.Size = new System.Drawing.Size(149, 50);
            this.btn_capnhat_NV.TabIndex = 14;
            this.btn_capnhat_NV.Text = "Cập Nhật";
            this.btn_capnhat_NV.UseVisualStyleBackColor = true;
            this.btn_capnhat_NV.Click += new System.EventHandler(this.btn_capnhat_NV_Click);
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_nhanvien);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1276, 713);
            this.tabControl_Main.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(693, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tìm kiếm";
            // 
            // txt_find
            // 
            this.txt_find.Location = new System.Drawing.Point(814, 286);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(257, 39);
            this.txt_find.TabIndex = 20;
            // 
            // btn_find
            // 
            this.btn_find.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_find.Location = new System.Drawing.Point(1098, 284);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(130, 41);
            this.btn_find.TabIndex = 21;
            this.btn_find.Text = "Tìm kiếm";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1276, 713);
            this.Controls.Add(this.tabControl_Main);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage_nhanvien.ResumeLayout(false);
            this.tabPage_nhanvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabControl_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtSDT;
        private System.Windows.Forms.Button btn_xoa_NV;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_them_NV;
        private System.Windows.Forms.Label lb_them_NV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage_nhanvien;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_capnhat_NV;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.MaskedTextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.TextBox txt_find;
    }
}

