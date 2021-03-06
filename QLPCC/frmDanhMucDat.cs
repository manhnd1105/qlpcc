using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLPCC
{
    public partial class frmDanhMucDat : Form
    {
        string QueryName = "";
        public frmDanhMucDat()
        {
            InitializeComponent();
        }

        private void frmDanhMucDat_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            DatabaseAccess.Select_HasNoParameter("SELECT_cbbQuan", cbbQuan, "TenQuan");
        }

        private void itemSua_Click(object sender, EventArgs e)
        {
            try
            {
	            frmCapNhatDanhMucDat frm = new frmCapNhatDanhMucDat();
	            frm.DanhMucDat = this;
	            frm.Show();
            }
            catch
            {
                MessageBox.Show("Chưa chọn dòng để sửa !");
            }
        }

        private void itemLietKe_Click(object sender, EventArgs e)
        {
            QueryName = "SELECT_frmDanhMucDat_dgr";
            DatabaseAccess.Select_HasNoParameter(QueryName, dgvDanhMucDat);
            DatabaseAccess.DanhSttDataGridView(dgvDanhMucDat);
            DatabaseAccess.ToMauChanLeDatagridView(dgvDanhMucDat);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            QueryName = "SELECT_frmDanhMucDat_dgr_Quan";
            DatabaseAccess.Select_HasOneParameter(QueryName, dgvDanhMucDat, "@TenQuan", cbbQuan.Text);
            DatabaseAccess.DanhSttDataGridView(dgvDanhMucDat);
            DatabaseAccess.ToMauChanLeDatagridView(dgvDanhMucDat);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemDat frm = new frmThemDat();
            frm.Show();
            this.Hide();
        }

        private void itemXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedID = dgvDanhMucDat.SelectedRows[0].Cells["ID"].Value.ToString();
                DatabaseAccess.Update_HasOneParameter("DELETE_DM_Dat", "@ID", selectedID);

                MessageBox.Show("Đã xóa !");
                BindingSource bsDM_Dat = new BindingSource();
                DatabaseAccess.Select_HasOneParameter("SELECT_frmDanhMucDat_dgr_Quan", bsDM_Dat, "@TenQuan", cbbQuan.Text);
                dgvDanhMucDat.DataSource = bsDM_Dat;
                DatabaseAccess.DanhSttDataGridView(dgvDanhMucDat);
                DatabaseAccess.ToMauChanLeDatagridView(dgvDanhMucDat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Có lỗi xảy ra !" + ex.ToString());
            }
        }
    }
}