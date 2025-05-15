namespace GUI_PolyCafe
{
    partial class frmMainForm
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            heThongToolStripMenuItem = new ToolStripMenuItem();
            doiMatKhauToolStripMenuItem = new ToolStripMenuItem();
            thongTinTaiKhoanToolStripMenuItem = new ToolStripMenuItem();
            dangXuatToolStripMenuItem = new ToolStripMenuItem();
            thoatToolStripMenuItem = new ToolStripMenuItem();
            danhMucToolStripMenuItem = new ToolStripMenuItem();
            loaiSanPhamToolStripMenuItem = new ToolStripMenuItem();
            sanPhamToolStripMenuItem = new ToolStripMenuItem();
            banHangToolStripMenuItem = new ToolStripMenuItem();
            theLuuDongToolStripMenuItem = new ToolStripMenuItem();
            phieuBanHangToolStripMenuItem = new ToolStripMenuItem();
            nhanVienToolStripMenuItem = new ToolStripMenuItem();
            doanhThuToolStripMenuItem = new ToolStripMenuItem();
            loaiHangToolStripMenuItem = new ToolStripMenuItem();
            tkNhanVienToolStripMenuItem = new ToolStripMenuItem();
            huongDanToolStripMenuItem = new ToolStripMenuItem();
            hdSuDungToolStripMenuItem = new ToolStripMenuItem();
            gioiThieuPhanMemToolStripMenuItem = new ToolStripMenuItem();
            timerSystem = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            toolStripTimer = new ToolStripStatusLabel();
            toolStripUserName = new ToolStripStatusLabel();
            pnMain = new Panel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            pnMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Font = new Font("Times New Roman", 12.75F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { heThongToolStripMenuItem, danhMucToolStripMenuItem, banHangToolStripMenuItem, nhanVienToolStripMenuItem, doanhThuToolStripMenuItem, huongDanToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1174, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            heThongToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doiMatKhauToolStripMenuItem, thongTinTaiKhoanToolStripMenuItem, dangXuatToolStripMenuItem, thoatToolStripMenuItem });
            heThongToolStripMenuItem.Image = Properties.Resources.gears;
            heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            heThongToolStripMenuItem.Size = new Size(107, 24);
            heThongToolStripMenuItem.Text = "Hệ Thống";
            // 
            // doiMatKhauToolStripMenuItem
            // 
            doiMatKhauToolStripMenuItem.Image = Properties.Resources.arrows1;
            doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            doiMatKhauToolStripMenuItem.Size = new Size(211, 26);
            doiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            doiMatKhauToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // thongTinTaiKhoanToolStripMenuItem
            // 
            thongTinTaiKhoanToolStripMenuItem.Image = Properties.Resources.information;
            thongTinTaiKhoanToolStripMenuItem.Name = "thongTinTaiKhoanToolStripMenuItem";
            thongTinTaiKhoanToolStripMenuItem.Size = new Size(211, 26);
            thongTinTaiKhoanToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // dangXuatToolStripMenuItem
            // 
            dangXuatToolStripMenuItem.Image = Properties.Resources.exit;
            dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            dangXuatToolStripMenuItem.Size = new Size(211, 26);
            dangXuatToolStripMenuItem.Text = "Đăng xuất";
            dangXuatToolStripMenuItem.Click += dangXuatToolStripMenuItem_Click;
            // 
            // thoatToolStripMenuItem
            // 
            thoatToolStripMenuItem.Image = Properties.Resources.Cross;
            thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            thoatToolStripMenuItem.Size = new Size(211, 26);
            thoatToolStripMenuItem.Text = "Thoát";
            thoatToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // danhMucToolStripMenuItem
            // 
            danhMucToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loaiSanPhamToolStripMenuItem, sanPhamToolStripMenuItem });
            danhMucToolStripMenuItem.Image = Properties.Resources.Library2;
            danhMucToolStripMenuItem.Name = "danhMucToolStripMenuItem";
            danhMucToolStripMenuItem.Size = new Size(109, 24);
            danhMucToolStripMenuItem.Text = "Danh mục";
            // 
            // loaiSanPhamToolStripMenuItem
            // 
            loaiSanPhamToolStripMenuItem.Name = "loaiSanPhamToolStripMenuItem";
            loaiSanPhamToolStripMenuItem.Size = new Size(175, 24);
            loaiSanPhamToolStripMenuItem.Text = "Loại sản phẩm";
            loaiSanPhamToolStripMenuItem.Click += loaiSanPhamToolStripMenuItem_Click;
            // 
            // sanPhamToolStripMenuItem
            // 
            sanPhamToolStripMenuItem.Name = "sanPhamToolStripMenuItem";
            sanPhamToolStripMenuItem.Size = new Size(175, 24);
            sanPhamToolStripMenuItem.Text = "Sản phẩm";
            sanPhamToolStripMenuItem.Click += sanPhamToolStripMenuItem_Click;
            // 
            // banHangToolStripMenuItem
            // 
            banHangToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { theLuuDongToolStripMenuItem, phieuBanHangToolStripMenuItem });
            banHangToolStripMenuItem.Image = Properties.Resources.shoppingcart;
            banHangToolStripMenuItem.Name = "banHangToolStripMenuItem";
            banHangToolStripMenuItem.Size = new Size(102, 24);
            banHangToolStripMenuItem.Text = "Bán hàng";
            // 
            // theLuuDongToolStripMenuItem
            // 
            theLuuDongToolStripMenuItem.Image = Properties.Resources.My_tickets;
            theLuuDongToolStripMenuItem.Name = "theLuuDongToolStripMenuItem";
            theLuuDongToolStripMenuItem.Size = new Size(184, 26);
            theLuuDongToolStripMenuItem.Text = "Thẻ lưu động";
            theLuuDongToolStripMenuItem.Click += thẻLưuĐộngToolStripMenuItem_Click;
            // 
            // phieuBanHangToolStripMenuItem
            // 
            phieuBanHangToolStripMenuItem.Image = Properties.Resources.Ordering;
            phieuBanHangToolStripMenuItem.Name = "phieuBanHangToolStripMenuItem";
            phieuBanHangToolStripMenuItem.Size = new Size(184, 26);
            phieuBanHangToolStripMenuItem.Text = "Phiếu bán hàng";
            phieuBanHangToolStripMenuItem.Click += phieuBanHangToolStripMenuItem_Click;
            // 
            // nhanVienToolStripMenuItem
            // 
            nhanVienToolStripMenuItem.Image = Properties.Resources.Couple;
            nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            nhanVienToolStripMenuItem.Size = new Size(108, 24);
            nhanVienToolStripMenuItem.Text = "Nhân viên";
            nhanVienToolStripMenuItem.Click += nhanVienToolStripMenuItem_Click;
            // 
            // doanhThuToolStripMenuItem
            // 
            doanhThuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loaiHangToolStripMenuItem, tkNhanVienToolStripMenuItem });
            doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            doanhThuToolStripMenuItem.Size = new Size(90, 23);
            doanhThuToolStripMenuItem.Text = "Doanh thu";
            // 
            // loaiHangToolStripMenuItem
            // 
            loaiHangToolStripMenuItem.Name = "loaiHangToolStripMenuItem";
            loaiHangToolStripMenuItem.Size = new Size(145, 24);
            loaiHangToolStripMenuItem.Text = "Loại hàng";
            loaiHangToolStripMenuItem.Click += loaiHangToolStripMenuItem_Click;
            // 
            // tkNhanVienToolStripMenuItem
            // 
            tkNhanVienToolStripMenuItem.Name = "tkNhanVienToolStripMenuItem";
            tkNhanVienToolStripMenuItem.Size = new Size(145, 24);
            tkNhanVienToolStripMenuItem.Text = "Nhân viên";
            tkNhanVienToolStripMenuItem.Click += tkNhanVienToolStripMenuItem_Click;
            // 
            // huongDanToolStripMenuItem
            // 
            huongDanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hdSuDungToolStripMenuItem, gioiThieuPhanMemToolStripMenuItem });
            huongDanToolStripMenuItem.Name = "huongDanToolStripMenuItem";
            huongDanToolStripMenuItem.Size = new Size(94, 23);
            huongDanToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // hdSuDungToolStripMenuItem
            // 
            hdSuDungToolStripMenuItem.Name = "hdSuDungToolStripMenuItem";
            hdSuDungToolStripMenuItem.Size = new Size(220, 24);
            hdSuDungToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // gioiThieuPhanMemToolStripMenuItem
            // 
            gioiThieuPhanMemToolStripMenuItem.Name = "gioiThieuPhanMemToolStripMenuItem";
            gioiThieuPhanMemToolStripMenuItem.Size = new Size(220, 24);
            gioiThieuPhanMemToolStripMenuItem.Text = "Giới thiệu phần mềm";
            // 
            // timerSystem
            // 
            timerSystem.Enabled = true;
            timerSystem.Tick += timerSystem_Tick;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripTimer, toolStripUserName });
            statusStrip1.Location = new Point(0, 645);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1174, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripTimer
            // 
            toolStripTimer.Name = "toolStripTimer";
            toolStripTimer.Size = new Size(57, 17);
            toolStripTimer.Text = "Hệ thống";
            // 
            // toolStripUserName
            // 
            toolStripUserName.ImageAlign = ContentAlignment.MiddleRight;
            toolStripUserName.Name = "toolStripUserName";
            toolStripUserName.Size = new Size(1102, 17);
            toolStripUserName.Spring = true;
            toolStripUserName.Text = "UserName";
            toolStripUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnMain
            // 
            pnMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnMain.BackColor = Color.Transparent;
            pnMain.Controls.Add(statusStrip1);
            pnMain.ForeColor = SystemColors.ControlText;
            pnMain.Location = new Point(0, 28);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1174, 667);
            pnMain.TabIndex = 1;
            pnMain.Paint += pnMain_Paint;
            // 
            // frmMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1174, 695);
            Controls.Add(pnMain);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1190, 734);
            Name = "frmMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang Chủ Poly Cafe";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem heThongToolStripMenuItem;
        private ToolStripMenuItem danhMucToolStripMenuItem;
        private ToolStripMenuItem loaiSanPhamToolStripMenuItem;
        private ToolStripMenuItem sanPhamToolStripMenuItem;
        private ToolStripMenuItem banHangToolStripMenuItem;
        private ToolStripMenuItem theLuuDongToolStripMenuItem;
        private ToolStripMenuItem phieuBanHangToolStripMenuItem;
        private ToolStripMenuItem nhanVienToolStripMenuItem;
        private ToolStripMenuItem doanhThuToolStripMenuItem;
        private ToolStripMenuItem loaiHangToolStripMenuItem;
        private ToolStripMenuItem tkNhanVienToolStripMenuItem;
        private ToolStripMenuItem huongDanToolStripMenuItem;
        private ToolStripMenuItem hdSuDungToolStripMenuItem;
        private ToolStripMenuItem gioiThieuPhanMemToolStripMenuItem;
        private ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private ToolStripMenuItem thongTinTaiKhoanToolStripMenuItem;
        private ToolStripMenuItem thoatToolStripMenuItem;
        private ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.Timer timerSystem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripTimer;
        private ToolStripStatusLabel toolStripUserName;
        private Panel pnMain;
    }
}