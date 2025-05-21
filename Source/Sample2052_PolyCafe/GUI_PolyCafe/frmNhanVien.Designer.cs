namespace GUI_PolyCafe
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
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnSearchNhanVien = new Button();
            txttimKiemNhanVien = new TextBox();
            dgrDanhSachNV = new DataGridView();
            label2 = new Label();
            txtMaNhanVien = new TextBox();
            label3 = new Label();
            txtHoTen = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtMatKhau = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtXacNhanMK = new TextBox();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            rbDeActive = new RadioButton();
            rbActive = new RadioButton();
            label8 = new Label();
            rbQuanLy = new RadioButton();
            rbNhanVien = new RadioButton();
            btnMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachNV).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(517, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 37);
            label1.TabIndex = 0;
            label1.Text = "NHÂN VIÊN";
            label1.Resize += label1_Resize;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnSearchNhanVien);
            groupBox2.Controls.Add(txttimKiemNhanVien);
            groupBox2.Controls.Add(dgrDanhSachNV);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(369, 76);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(793, 533);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Nhân Viên";
            // 
            // btnSearchNhanVien
            // 
            btnSearchNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchNhanVien.FlatStyle = FlatStyle.Flat;
            btnSearchNhanVien.Image = Properties.Resources.find;
            btnSearchNhanVien.Location = new Point(750, 16);
            btnSearchNhanVien.Name = "btnSearchNhanVien";
            btnSearchNhanVien.Size = new Size(37, 23);
            btnSearchNhanVien.TabIndex = 2;
            btnSearchNhanVien.UseVisualStyleBackColor = true;
            // 
            // txttimKiemNhanVien
            // 
            txttimKiemNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txttimKiemNhanVien.Location = new Point(536, 16);
            txttimKiemNhanVien.Name = "txttimKiemNhanVien";
            txttimKiemNhanVien.Size = new Size(213, 23);
            txttimKiemNhanVien.TabIndex = 1;
            // 
            // dgrDanhSachNV
            // 
            dgrDanhSachNV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgrDanhSachNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrDanhSachNV.Location = new Point(6, 50);
            dgrDanhSachNV.Name = "dgrDanhSachNV";
            dgrDanhSachNV.RowHeadersWidth = 51;
            dgrDanhSachNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrDanhSachNV.Size = new Size(781, 477);
            dgrDanhSachNV.TabIndex = 0;
            dgrDanhSachNV.CellDoubleClick += dgrDanhSachNV_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(6, 50);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã Nhân Viên";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Font = new Font("Segoe UI", 12F);
            txtMaNhanVien.Location = new Point(124, 47);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.ReadOnly = true;
            txtMaNhanVien.Size = new Size(211, 29);
            txtMaNhanVien.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(6, 104);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 0;
            label3.Text = "Họ và Tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 12F);
            txtHoTen.Location = new Point(124, 96);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(211, 29);
            txtHoTen.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(6, 155);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 0;
            label4.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(124, 147);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(211, 29);
            txtEmail.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(7, 208);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 0;
            label5.Text = "Mật Khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 12F);
            txtMatKhau.Location = new Point(124, 200);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(211, 29);
            txtMatKhau.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(6, 258);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 0;
            label6.Text = "Xác Nhận Mật Khẩu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(6, 313);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 0;
            label7.Text = "Vai Trò";
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Font = new Font("Segoe UI", 12F);
            txtXacNhanMK.Location = new Point(124, 250);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.Size = new Size(211, 29);
            txtXacNhanMK.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.Window;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.Image = Properties.Resources.plus;
            btnThem.Location = new Point(7, 419);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(81, 41);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(rbQuanLy);
            groupBox1.Controls.Add(rbNhanVien);
            groupBox1.Controls.Add(btnMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtXacNhanMK);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaNhanVien);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(12, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 533);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // panel1
            // 
            panel1.Controls.Add(rbDeActive);
            panel1.Controls.Add(rbActive);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(0, 341);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 33);
            panel1.TabIndex = 5;
            // 
            // rbDeActive
            // 
            rbDeActive.AutoSize = true;
            rbDeActive.Font = new Font("Segoe UI", 10F);
            rbDeActive.ForeColor = Color.Maroon;
            rbDeActive.Location = new Point(255, 4);
            rbDeActive.Name = "rbDeActive";
            rbDeActive.Size = new Size(99, 23);
            rbDeActive.TabIndex = 8;
            rbDeActive.Text = "Tạm Ngưng";
            rbDeActive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            rbActive.AutoSize = true;
            rbActive.BackColor = Color.Transparent;
            rbActive.Checked = true;
            rbActive.Font = new Font("Segoe UI", 9F);
            rbActive.ForeColor = Color.Maroon;
            rbActive.Location = new Point(124, 5);
            rbActive.Name = "rbActive";
            rbActive.Size = new Size(114, 19);
            rbActive.TabIndex = 7;
            rbActive.TabStop = true;
            rbActive.Text = "Đang Hoạt Động";
            rbActive.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(6, 8);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 6;
            label8.Text = "Trạng Thái";
            // 
            // rbQuanLy
            // 
            rbQuanLy.AutoSize = true;
            rbQuanLy.Font = new Font("Segoe UI", 9F);
            rbQuanLy.ForeColor = Color.Maroon;
            rbQuanLy.Location = new Point(255, 309);
            rbQuanLy.Name = "rbQuanLy";
            rbQuanLy.Size = new Size(68, 19);
            rbQuanLy.TabIndex = 4;
            rbQuanLy.Text = "Quản Lý";
            rbQuanLy.UseVisualStyleBackColor = true;
            // 
            // rbNhanVien
            // 
            rbNhanVien.AutoSize = true;
            rbNhanVien.Checked = true;
            rbNhanVien.Font = new Font("Segoe UI", 9F);
            rbNhanVien.ForeColor = Color.Maroon;
            rbNhanVien.Location = new Point(124, 309);
            rbNhanVien.Name = "rbNhanVien";
            rbNhanVien.Size = new Size(80, 19);
            rbNhanVien.TabIndex = 4;
            rbNhanVien.TabStop = true;
            rbNhanVien.Text = "Nhân Viên";
            rbNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnMoi
            // 
            btnMoi.BackColor = SystemColors.Window;
            btnMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMoi.Image = Properties.Resources.rotate;
            btnMoi.Location = new Point(261, 419);
            btnMoi.Name = "btnMoi";
            btnMoi.Size = new Size(84, 41);
            btnMoi.TabIndex = 3;
            btnMoi.Text = "Mới";
            btnMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMoi.UseVisualStyleBackColor = false;
            btnMoi.Click += btnMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.Window;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.Image = Properties.Resources.remove;
            btnXoa.Location = new Point(175, 419);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 41);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.Window;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.Image = Properties.Resources.edit;
            btnSua.Location = new Point(94, 419);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 41);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1174, 642);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmNhanVien";
            Text = "PolyCafe - Quản Lý Nhân Viên";
            Load += frmNhanVien_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachNV).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnThem;
        private GroupBox groupBox2;
        private DataGridView dgrDanhSachNV;
        private Button btnSearchNhanVien;
        private TextBox txttimKiemNhanVien;
        private Label label2;
        private TextBox txtMaNhanVien;
        private Label label3;
        private TextBox txtHoTen;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtMatKhau;
        private Label label6;
        private Label label7;
        private TextBox txtXacNhanMK;
        private GroupBox groupBox1;
        private Button btnSua;
        private Button btnMoi;
        private Button btnXoa;
        private RadioButton rbQuanLy;
        private RadioButton rbNhanVien;
        private Panel panel1;
        private RadioButton rbDeActive;
        private RadioButton rbActive;
        private Label label8;
    }
}