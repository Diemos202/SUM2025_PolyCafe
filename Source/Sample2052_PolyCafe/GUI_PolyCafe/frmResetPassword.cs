using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PolyCafe;
using UTIL_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class frmResetPassword : Form
    {
        BUSNhanVien busNhanVien = new BUSNhanVien();
        public frmResetPassword()
        {
            InitializeComponent();
            btnShow.BringToFront();
            btnShowNew.BringToFront();
            btnShowNewA.BringToFront();
        }

        private void ResetPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    e.Cancel = true;
            //}
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
           
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
           
        }

        private void btnShowNewA_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHideNewA_Click(object sender, EventArgs e)
        {
           
        }

        private void btnShowNew_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHideNew_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
           
        }
    }
}
