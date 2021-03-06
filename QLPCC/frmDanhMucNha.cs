using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLPCC
{
    public partial class frmDanhMucNha : Form
    {
        string QueryName = "";
        public frmDanhMucNha()
        {
            InitializeComponent();
        }

        private void frmDanhMucNha_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void itemSua_Click(object sender, EventArgs e)
        {
            try
            {
	            frmCapNhatDanhMucNha frm = new frmCapNhatDanhMucNha();
	            frm.DanhMucNha = this;
	            frm.Show();
            }
            catch
            {
                MessageBox.Show("Chưa chọn dòng để sửa !");
            }
        }

        private void itemLietKe_Click(object sender, EventArgs e)
        {
            QueryName = "SELECT_frmDanhMucNha_dgr";
            DatabaseAccess.Select_HasNoParameter(QueryName, dgvDanhMucNha);
            DatabaseAccess.DanhSttDataGridView(dgvDanhMucNha);
            DatabaseAccess.ToMauChanLeDatagridView(dgvDanhMucNha);
        }
    }
}