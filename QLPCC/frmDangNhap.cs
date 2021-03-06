using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLPCC
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            txtMaDangNhap.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtMaDangNhap.Text=="123123")
            {
                frmMain Main = new frmMain();
                Main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mã đăng nhập không đúng !");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMaDangNhap.Focus();
        }
    }
}