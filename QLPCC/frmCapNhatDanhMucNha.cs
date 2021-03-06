using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLPCC
{
    public partial class frmCapNhatDanhMucNha : Form
    {
        public frmDanhMucNha DanhMucNha;
        string QueryName = "";
        public frmCapNhatDanhMucNha()
        {
            InitializeComponent();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            QueryName = "UPDATE_frmCapNhatDanhMucNha";
            string MSCap = DanhMucNha.dgvDanhMucNha.SelectedRows[0].Cells["MSCap"].Value.ToString();
            string LoaiNha = DanhMucNha.dgvDanhMucNha.SelectedRows[0].Cells["LoaiNha"].Value.ToString();
            string[] ParaName = { "TenCap", "SoTang","DienTich","LoaiNha",
                "ChiTiet","Gia","MSCap","ID" };
            string[] ParaValue = { txtCapNha.Text.Trim(),txtSoTang.Text.Trim(),txtDienTich.Text.Trim(),txtLoaiNha.Text.Trim(),
                txtChiTiet.Text.Trim(),txtGiaAp.Text.Trim(),MSCap.Trim(),LoaiNha.Trim() };
            DatabaseAccess.Update_HasManyParameter(QueryName, ParaName, ParaValue);
            this.Hide();
            MessageBox.Show("Đã cập nhật, chọn liệt kê để xem danh sách mới !");
        }

        private void frmCapNhatDanhMucNha_Load(object sender, EventArgs e)
        {
            //Cập nhật dữ liệu từ dòng đang chọn ở form danh mục truyền sang
            txtCapNha.Text = DanhMucNha.dgvDanhMucNha.SelectedRows[0].Cells["TenCap"].Value.ToString();
            txtSoTang.Text = DanhMucNha.dgvDanhMucNha.SelectedRows[0].Cells["SoTang"].Value.ToString();
            txtGiaAp.Text = DanhMucNha.dgvDanhMucNha.SelectedRows[0].Cells["Gia"].Value.ToString();
            txtLoaiNha.Text = DanhMucNha.dgvDanhMucNha.SelectedRows[0].Cells["LoaiNha"].Value.ToString();
            txtDienTich.Text = DanhMucNha.dgvDanhMucNha.SelectedRows[0].Cells["DienTich"].Value.ToString();
            txtChiTiet.Text = DanhMucNha.dgvDanhMucNha.SelectedRows[0].Cells["ChiTiet"].Value.ToString();
        }
    }
}