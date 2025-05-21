/*
    Ứng dụng được thiết kế bởi ChanTT và HongHT7
    Phục vụ cho môn học SOF2052 - FPS Đồng Nai
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTIL_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();

        }

        private Form currentFormChild;

        private void openChildForm(Form formChild)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = formChild;
            formChild.TopLevel = false;
            formChild.FormBorderStyle = FormBorderStyle.None;
            formChild.Dock = DockStyle.Fill;
            pnMain.Controls.Add(formChild);
            pnMain.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();


        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //openChildForm(new ResetPassword());
            frmResetPassword reset = new frmResetPassword();
            reset.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //e.Cancel = true;
                Application.Exit();
            }
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            danhMucToolStripMenuItem.Visible = false;
            banHangToolStripMenuItem.Visible = false;
            nhanVienToolStripMenuItem.Visible = false;
            doanhThuToolStripMenuItem.Visible = false;

            this.Hide();
            AuthUtil.user = null;
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void thẻLưuĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTheLuuDong());
        }

       

        private void MainForm_Load(object sender, EventArgs e)
        {
            openChildForm(new frmPhieuBanHang());
        }

        private void VaiTroNhanVien()
        {
            danhMucToolStripMenuItem.Visible = false;
            nhanVienToolStripMenuItem.Visible = false;
            doanhThuToolStripMenuItem.Visible = false;
        }
        

        private void timerSystem_Tick(object sender, EventArgs e)
        {
            string s = "Hệ thống quản lý PolyCafe - "
               + DateTime.Now.ToString("dd/MM/yyyy");
            s = s + " - " + DateTime.Now.ToString("hh:mm:ss tt");
            toolStripTimer.Text = s;
            Text = Text.Substring(1, Text.Length - 1) +
            Text.Substring(0, 1);

        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVien());
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSanPham());
        }

        private void loaiSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmLoaiSanPham());
        }

        private void loaiHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoanhThuLoaiSP());
        }

        private void tkNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoanhThuNhanVien());
        }

        private void phieuBanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPhieuBanHang());
        }
    }
}
