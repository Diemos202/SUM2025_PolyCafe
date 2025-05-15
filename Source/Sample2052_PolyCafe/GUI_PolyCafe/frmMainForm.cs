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
            CheckPermission();

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
        }

       

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void VaiTroNhanVien()
        {
            danhMucToolStripMenuItem.Visible = false;
            nhanVienToolStripMenuItem.Visible = false;
            doanhThuToolStripMenuItem.Visible = false;
        }
        private void CheckPermission()
        {
            if (AuthUtil.IsLogin())
            {
                toolStripUserName.Text = AuthUtil.user.HoTen;
                danhMucToolStripMenuItem.Visible = true;
                banHangToolStripMenuItem.Visible = true;
                nhanVienToolStripMenuItem.Visible = true;
                doanhThuToolStripMenuItem.Visible = true;
                if (AuthUtil.user.VaiTro == false)
                {
                    VaiTroNhanVien();
                }
            }
            else
            {
                heThongToolStripMenuItem.Visible = true; // Xác định xem điều khiển có hiển thị trên giao diện hay không.
                dangXuatToolStripMenuItem.Enabled = false; // Xác định xem điều khiển có thể tương tác hay không.
                thongTinTaiKhoanToolStripMenuItem.Enabled = false;
                danhMucToolStripMenuItem.Visible = false;
                banHangToolStripMenuItem.Visible = false;
                nhanVienToolStripMenuItem.Visible = false;
                doanhThuToolStripMenuItem.Visible = false;
            }
        }

        private void timerSystem_Tick(object sender, EventArgs e)
        {
            string s = "Hệ thống quản lý PolyCafe - "
               + DateTime.Now.ToString("dd/MM/yyyy");
            s = s + " - " + DateTime.Now.ToString("hh:mm:ss tt");
            toolStripTimer.Text = s;
           
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void loaiSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void loaiHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void tkNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void phieuBanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
