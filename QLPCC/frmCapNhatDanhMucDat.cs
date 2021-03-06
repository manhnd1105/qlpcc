using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLPCC
{
    public partial class frmCapNhatDanhMucDat : Form
    {
        public frmDanhMucDat DanhMucDat;
        string QueryName = "";
        public frmCapNhatDanhMucDat()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            QueryName = "UPDATE_frmCapNhatDanhMucDat";
            string MSQuan = DanhMucDat.dgvDanhMucDat.SelectedRows[0].Cells["MSQuan"].Value.ToString();
            string ID = DanhMucDat.dgvDanhMucDat.SelectedRows[0].Cells["ID"].Value.ToString();
            string[] ParaName = { "TenQuan", "Duong","Tu","Den",
                "VT1","VT2","VT3","VT4",
                "VT_1","VT_2","VT_3","VT_4","MSQuan","ID" };
            string[] ParaValue = { txtTenQuan.Text.Trim(),txtDuong.Text.Trim(),txtTu.Text.Trim(),txtDen.Text.Trim(),
                txtVT1.Text.Trim(),txtVT2.Text.Trim(),txtVT3.Text.Trim(),txtVT4.Text.Trim(),
                txtVT_1.Text.Trim(),txtVT_2.Text.Trim(),txtVT_3.Text.Trim(),txtVT_4.Text.Trim(),MSQuan.Trim(),ID.Trim()};
            DatabaseAccess.Update_HasManyParameter(QueryName, ParaName, ParaValue);
            this.Hide();
            MessageBox.Show("Đã cập nhật, chọn liệt kê để xem danh sách mới !");
        }

        private void frmCapNhatDanhMucDat_Load(object sender, EventArgs e)
        {
            //Cập nhật dữ liệu từ dòng đang chọn ở form danh mục truyền sang
            txtTenQuan.Text = DanhMucDat.dgvDanhMucDat.SelectedRows[0].Cells["TenQuan"].Value.ToString();
            txtDuong.Text = DanhMucDat.dgvDanhMucDat.SelectedRows[0].Cells["Duong"].Value.ToString();
            txtTu.Text = DanhMucDat.dgvDanhMucDat.SelectedRows[0].Cells["Tu"].Value.ToString();
            txtDen.Text = DanhMucDat.dgvDanhMucDat.SelectedRows[0].Cells["Den"].Value.ToString();
            txtVT1.Text = DanhMucDat.dgvDanhMucDat.SelectedRows[0].Cells["VT1"].Value.ToString();
            txtVT2.Text = DanhMucDat.dgvDanhMucDat.SelectedRows[0].Cells["VT2"].Value.ToString();
            txtVT3.Text = DanhMucDat.dgvDanhMucDat.SelectedRows[0].Cells["VT3"].Value.ToString();
            txtVT4.Text = DanhMucDat.dgvDanhMucDat.SelectedRows[0].Cells["VT4"].Value.ToString();
            txtVT_1.Text = DanhMucDat.dgvDanhMucDat.SelectedRows[0].Cells["VT_1"].Value.ToString();
            txtVT_2.Text = DanhMucDat.dgvDanhMucDat.SelectedRows[0].Cells["VT_2"].Value.ToString();
            txtVT_3.Text = DanhMucDat.dgvDanhMucDat.SelectedRows[0].Cells["VT_3"].Value.ToString();
            txtVT_4.Text = DanhMucDat.dgvDanhMucDat.SelectedRows[0].Cells["VT_4"].Value.ToString();
        }
    }
}