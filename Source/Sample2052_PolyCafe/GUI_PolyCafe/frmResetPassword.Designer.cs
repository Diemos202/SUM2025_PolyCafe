namespace GUI_PolyCafe
{
    partial class frmResetPassword
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
            txtCPMaNV = new TextBox();
            label3 = new Label();
            txtCPTenNv = new TextBox();
            label4 = new Label();
            txtXacNhanMatKhau = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtMatKhauMoi = new TextBox();
            btnDoiMatKhau = new Button();
            btnThoat = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            btnShow = new Button();
            btnHide = new Button();
            btnShowNew = new Button();
            btnHideNew = new Button();
            btnShowNewA = new Button();
            btnHideNewA = new Button();
            txtMatKhauCu = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(352, 32);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 0;
            label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(56, 123);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã Nhân Viên";
            // 
            // txtCPMaNV
            // 
            txtCPMaNV.Font = new Font("Segoe UI", 12F);
            txtCPMaNV.Location = new Point(59, 144);
            txtCPMaNV.Name = "txtCPMaNV";
            txtCPMaNV.ReadOnly = true;
            txtCPMaNV.Size = new Size(198, 29);
            txtCPMaNV.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(53, 196);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 1;
            label3.Text = "Tên Nhân Viên";
            // 
            // txtCPTenNv
            // 
            txtCPTenNv.Font = new Font("Segoe UI", 12F);
            txtCPTenNv.Location = new Point(56, 217);
            txtCPTenNv.Name = "txtCPTenNv";
            txtCPTenNv.ReadOnly = true;
            txtCPTenNv.Size = new Size(198, 29);
            txtCPTenNv.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(352, 268);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 1;
            label4.Text = "Xác nhận mật khẩu";
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Font = new Font("Segoe UI", 12F);
            txtXacNhanMatKhau.Location = new Point(355, 289);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PasswordChar = '*';
            txtXacNhanMatKhau.Size = new Size(271, 29);
            txtXacNhanMatKhau.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(355, 123);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 1;
            label5.Text = "Mật khẩu cũ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(352, 196);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 1;
            label6.Text = "Mật khẩu mới";
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Font = new Font("Segoe UI", 12F);
            txtMatKhauMoi.Location = new Point(355, 217);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PasswordChar = '*';
            txtMatKhauMoi.Size = new Size(271, 29);
            txtMatKhauMoi.TabIndex = 2;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.BackColor = SystemColors.MenuHighlight;
            btnDoiMatKhau.Font = new Font("Segoe UI", 11F);
            btnDoiMatKhau.ForeColor = Color.White;
            btnDoiMatKhau.Location = new Point(325, 341);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(177, 37);
            btnDoiMatKhau.TabIndex = 3;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = false;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.DarkSalmon;
            btnThoat.Font = new Font("Segoe UI", 11F);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(508, 341);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(177, 37);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.Transparent;
            btnShow.BackgroundImage = Properties.Resources._12_view;
            btnShow.BackgroundImageLayout = ImageLayout.Stretch;
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.ForeColor = Color.Transparent;
            btnShow.Location = new Point(635, 144);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(28, 28);
            btnShow.TabIndex = 5;
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnHide
            // 
            btnHide.BackColor = Color.Transparent;
            btnHide.BackgroundImage = Properties.Resources.hide;
            btnHide.BackgroundImageLayout = ImageLayout.Stretch;
            btnHide.FlatStyle = FlatStyle.Flat;
            btnHide.Font = new Font("Segoe UI", 8F);
            btnHide.ForeColor = Color.Transparent;
            btnHide.Location = new Point(635, 145);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(28, 28);
            btnHide.TabIndex = 4;
            btnHide.UseVisualStyleBackColor = false;
            btnHide.Click += btnHide_Click;
            // 
            // btnShowNew
            // 
            btnShowNew.BackColor = Color.Transparent;
            btnShowNew.BackgroundImage = Properties.Resources._12_view;
            btnShowNew.BackgroundImageLayout = ImageLayout.Stretch;
            btnShowNew.FlatStyle = FlatStyle.Flat;
            btnShowNew.ForeColor = Color.Transparent;
            btnShowNew.Location = new Point(635, 218);
            btnShowNew.Name = "btnShowNew";
            btnShowNew.Size = new Size(28, 28);
            btnShowNew.TabIndex = 5;
            btnShowNew.UseVisualStyleBackColor = false;
            btnShowNew.Click += btnShowNew_Click;
            // 
            // btnHideNew
            // 
            btnHideNew.BackColor = Color.Transparent;
            btnHideNew.BackgroundImage = Properties.Resources.hide;
            btnHideNew.BackgroundImageLayout = ImageLayout.Stretch;
            btnHideNew.FlatStyle = FlatStyle.Flat;
            btnHideNew.Font = new Font("Segoe UI", 8F);
            btnHideNew.ForeColor = Color.Transparent;
            btnHideNew.Location = new Point(635, 218);
            btnHideNew.Name = "btnHideNew";
            btnHideNew.Size = new Size(28, 28);
            btnHideNew.TabIndex = 4;
            btnHideNew.UseVisualStyleBackColor = false;
            btnHideNew.Click += btnHideNew_Click;
            // 
            // btnShowNewA
            // 
            btnShowNewA.BackColor = Color.Transparent;
            btnShowNewA.BackgroundImage = Properties.Resources._12_view;
            btnShowNewA.BackgroundImageLayout = ImageLayout.Stretch;
            btnShowNewA.FlatStyle = FlatStyle.Flat;
            btnShowNewA.ForeColor = Color.Transparent;
            btnShowNewA.Location = new Point(635, 289);
            btnShowNewA.Name = "btnShowNewA";
            btnShowNewA.Size = new Size(28, 28);
            btnShowNewA.TabIndex = 5;
            btnShowNewA.UseVisualStyleBackColor = false;
            btnShowNewA.Click += btnShowNewA_Click;
            // 
            // btnHideNewA
            // 
            btnHideNewA.BackColor = Color.Transparent;
            btnHideNewA.BackgroundImage = Properties.Resources.hide;
            btnHideNewA.BackgroundImageLayout = ImageLayout.Stretch;
            btnHideNewA.FlatStyle = FlatStyle.Flat;
            btnHideNewA.Font = new Font("Segoe UI", 8F);
            btnHideNewA.ForeColor = Color.Transparent;
            btnHideNewA.Location = new Point(635, 289);
            btnHideNewA.Name = "btnHideNewA";
            btnHideNewA.Size = new Size(28, 28);
            btnHideNewA.TabIndex = 4;
            btnHideNewA.UseVisualStyleBackColor = false;
            btnHideNewA.Click += btnHideNewA_Click;
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Font = new Font("Segoe UI", 12F);
            txtMatKhauCu.Location = new Point(358, 145);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.PasswordChar = '*';
            txtMatKhauCu.Size = new Size(271, 29);
            txtMatKhauCu.TabIndex = 2;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(717, 430);
            Controls.Add(btnHideNewA);
            Controls.Add(btnHideNew);
            Controls.Add(btnHide);
            Controls.Add(btnShowNewA);
            Controls.Add(btnShowNew);
            Controls.Add(btnShow);
            Controls.Add(btnThoat);
            Controls.Add(btnDoiMatKhau);
            Controls.Add(txtMatKhauCu);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(txtCPTenNv);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCPMaNV);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "ResetPassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PolyCafe - Đổi Mật Khẩu";
            FormClosing += ResetPassword_FormClosing;
            Load += ResetPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCPMaNV;
        private Label label3;
        private TextBox txtCPTenNv;
        private Label label4;
        private TextBox txtXacNhanMatKhau;
        private Label label5;
        private Label label6;
        private TextBox txtMatKhauMoi;
        private Button btnDoiMatKhau;
        private Button btnThoat;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnShow;
        private Button btnHide;
        private Button btnShowNew;
        private Button btnHideNew;
        private Button btnShowNewA;
        private Button btnHideNewA;
        private TextBox txtMatKhauCu;
    }
}