namespace GUI_PolyCafe
{
    partial class frmChiTietPhieu
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
            label1 = new Label();
            label2 = new Label();
            lbChuSoHuu = new Label();
            label3 = new Label();
            lbMaPhieu = new Label();
            label4 = new Label();
            lbNgayLap = new Label();
            dgrChiTiet = new DataGridView();
            groupBox1 = new GroupBox();
            label9 = new Label();
            txtPhanTram = new TextBox();
            txtThanhTien = new TextBox();
            txtGiamGia = new TextBox();
            txtDichVu = new TextBox();
            txtTong = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dgrSanPham = new DataGridView();
            btnThemChiTiet = new Button();
            btnXoaChiTiet = new Button();
            ((System.ComponentModel.ISupportInitialize)dgrChiTiet).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrSanPham).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(323, 7);
            label1.Name = "label1";
            label1.Size = new Size(365, 37);
            label1.TabIndex = 2;
            label1.Text = "CHI TIẾT PHIẾU BÁN HÀNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(46, 64);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 3;
            label2.Text = "Chủ Sở Hữu:";
            // 
            // lbChuSoHuu
            // 
            lbChuSoHuu.AutoSize = true;
            lbChuSoHuu.Font = new Font("Segoe UI", 11F);
            lbChuSoHuu.ForeColor = Color.Maroon;
            lbChuSoHuu.Location = new Point(153, 64);
            lbChuSoHuu.Name = "lbChuSoHuu";
            lbChuSoHuu.Size = new Size(70, 20);
            lbChuSoHuu.TabIndex = 3;
            lbChuSoHuu.Text = "Mã Phiếu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(417, 64);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "Mã Phiếu:";
            // 
            // lbMaPhieu
            // 
            lbMaPhieu.AutoSize = true;
            lbMaPhieu.Font = new Font("Segoe UI", 11F);
            lbMaPhieu.ForeColor = Color.Maroon;
            lbMaPhieu.Location = new Point(507, 64);
            lbMaPhieu.Name = "lbMaPhieu";
            lbMaPhieu.Size = new Size(70, 20);
            lbMaPhieu.TabIndex = 3;
            lbMaPhieu.Text = "Mã Phiếu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(739, 64);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày Lập:";
            // 
            // lbNgayLap
            // 
            lbNgayLap.AutoSize = true;
            lbNgayLap.Font = new Font("Segoe UI", 11F);
            lbNgayLap.ForeColor = Color.Maroon;
            lbNgayLap.Location = new Point(829, 64);
            lbNgayLap.Name = "lbNgayLap";
            lbNgayLap.Size = new Size(70, 20);
            lbNgayLap.TabIndex = 3;
            lbNgayLap.Text = "Mã Phiếu";
            // 
            // dgrChiTiet
            // 
            dgrChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrChiTiet.Location = new Point(10, 115);
            dgrChiTiet.Margin = new Padding(3, 2, 3, 2);
            dgrChiTiet.Name = "dgrChiTiet";
            dgrChiTiet.RowHeadersWidth = 51;
            dgrChiTiet.Size = new Size(457, 299);
            dgrChiTiet.TabIndex = 4;
            dgrChiTiet.CellEndEdit += dgrChiTiet_CellEndEdit;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtPhanTram);
            groupBox1.Controls.Add(txtThanhTien);
            groupBox1.Controls.Add(txtGiamGia);
            groupBox1.Controls.Add(txtDichVu);
            groupBox1.Controls.Add(txtTong);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(10, 421);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(457, 131);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Thanh Toán";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(138, 63);
            label9.Name = "label9";
            label9.Size = new Size(17, 15);
            label9.TabIndex = 3;
            label9.Text = "%";
            // 
            // txtPhanTram
            // 
            txtPhanTram.Location = new Point(86, 60);
            txtPhanTram.Margin = new Padding(3, 2, 3, 2);
            txtPhanTram.Name = "txtPhanTram";
            txtPhanTram.Size = new Size(46, 23);
            txtPhanTram.TabIndex = 2;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(86, 95);
            txtThanhTien.Margin = new Padding(3, 2, 3, 2);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(354, 23);
            txtThanhTien.TabIndex = 1;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(180, 60);
            txtGiamGia.Margin = new Padding(3, 2, 3, 2);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.ReadOnly = true;
            txtGiamGia.Size = new Size(260, 23);
            txtGiamGia.TabIndex = 1;
            // 
            // txtDichVu
            // 
            txtDichVu.Location = new Point(313, 24);
            txtDichVu.Margin = new Padding(3, 2, 3, 2);
            txtDichVu.Name = "txtDichVu";
            txtDichVu.ReadOnly = true;
            txtDichVu.Size = new Size(127, 23);
            txtDichVu.TabIndex = 1;
            // 
            // txtTong
            // 
            txtTong.Location = new Point(86, 22);
            txtTong.Margin = new Padding(3, 2, 3, 2);
            txtTong.Name = "txtTong";
            txtTong.ReadOnly = true;
            txtTong.Size = new Size(161, 23);
            txtTong.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 100);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 0;
            label8.Text = "Thành Tiền:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 63);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 0;
            label7.Text = "Giảm Giá";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(253, 27);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 0;
            label6.Text = "Dịch Vụ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 24);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 0;
            label5.Text = "Tổng :";
            // 
            // dgrSanPham
            // 
            dgrSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrSanPham.Location = new Point(548, 115);
            dgrSanPham.Margin = new Padding(3, 2, 3, 2);
            dgrSanPham.Name = "dgrSanPham";
            dgrSanPham.ReadOnly = true;
            dgrSanPham.RowHeadersWidth = 51;
            dgrSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrSanPham.Size = new Size(426, 444);
            dgrSanPham.TabIndex = 6;
            dgrSanPham.CellDoubleClick += dgrSanPham_CellDoubleClick;
            // 
            // btnThemChiTiet
            // 
            btnThemChiTiet.Location = new Point(480, 220);
            btnThemChiTiet.Margin = new Padding(3, 2, 3, 2);
            btnThemChiTiet.Name = "btnThemChiTiet";
            btnThemChiTiet.Size = new Size(53, 22);
            btnThemChiTiet.TabIndex = 7;
            btnThemChiTiet.Text = "<<";
            btnThemChiTiet.UseVisualStyleBackColor = true;
            btnThemChiTiet.Click += btnThemChiTiet_Click;
            // 
            // btnXoaChiTiet
            // 
            btnXoaChiTiet.Location = new Point(479, 293);
            btnXoaChiTiet.Margin = new Padding(3, 2, 3, 2);
            btnXoaChiTiet.Name = "btnXoaChiTiet";
            btnXoaChiTiet.Size = new Size(53, 22);
            btnXoaChiTiet.TabIndex = 7;
            btnXoaChiTiet.Text = ">>";
            btnXoaChiTiet.UseVisualStyleBackColor = true;
            btnXoaChiTiet.Click += btnXoaChiTiet_Click;
            // 
            // frmChiTietPhieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(984, 561);
            Controls.Add(btnXoaChiTiet);
            Controls.Add(btnThemChiTiet);
            Controls.Add(dgrSanPham);
            Controls.Add(groupBox1);
            Controls.Add(dgrChiTiet);
            Controls.Add(lbNgayLap);
            Controls.Add(label4);
            Controls.Add(lbMaPhieu);
            Controls.Add(label3);
            Controls.Add(lbChuSoHuu);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmChiTietPhieu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmChiTietPhieu";
            Load += frmChiTietPhieu_Load;
            ((System.ComponentModel.ISupportInitialize)dgrChiTiet).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbChuSoHuu;
        private Label label3;
        private Label lbMaPhieu;
        private Label label4;
        private Label lbNgayLap;
        private DataGridView dgrChiTiet;
        private GroupBox groupBox1;
        private DataGridView dgrSanPham;
        private Button btnThemChiTiet;
        private Button btnXoaChiTiet;
        private Label label6;
        private Label label5;
        private TextBox txtThanhTien;
        private TextBox txtGiamGia;
        private TextBox txtDichVu;
        private TextBox txtTong;
        private Label label8;
        private Label label7;
        private Label label9;
        private TextBox txtPhanTram;
    }
}