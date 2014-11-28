using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLPCC
{
    public partial class frmThemDat : Form
    {
        public frmThemDat()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
	            //L?y ID ?ng v?i tên qu?n dã ch?n
	            string MSQuan = DatabaseAccess.Select_Quan(cbbQuan.Text);
	            //Th?c hi?n luu vào CSDL
	            string[] ParaName_HD =    { "@MSQuan", "@Duong", "@Tu", "@Den", 
	                                        "@VT1", "@VT2", "@VT3", "@VT4", 
	                                        "@VT_1", "@VT_2", "@VT_3", "@VT_4" 
	                        };
	            string[] ParaValue_HD =   { MSQuan, txtDuong.Text, txtTu.Text, txtDen.Text, 
	                                          txtVT1.Text, txtVT2.Text, txtVT3.Text, txtVT4.Text, 
	                                          txtVT_1.Text, txtVT_2.Text, txtVT_3.Text, txtVT_4.Text
	                        };
	            DatabaseAccess.Update_HasManyParameter("INSERT_DM_Dat", ParaName_HD, ParaValue_HD);
                MessageBox.Show("Ðã lưu !");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmThemDat_Load(object sender, EventArgs e)
        {
            DatabaseAccess.Select_HasNoParameter("SELECT_cbbQuan", cbbQuan, "TenQuan");
            DatabaseAccess.Select_HasNoParameter("SELECT_cbbQuan", cbbQuan2, "TenQuan");
            enableGrbDuong();
        }

        private void rbDuong_Click(object sender, EventArgs e)
        {
            enableGrbDuong();
        }

        private void rbQuan_Click(object sender, EventArgs e)
        {
            enableGrbQuan();
        }

        private void rbQuan2_Click(object sender, EventArgs e)
        {
            enableGrbQuan2();
            DatabaseAccess.Select_HasNoParameter("SELECT_cbbQuan", cbbQuan2, "TenQuan");
        }

        private void cbbLuuQuan_Click(object sender, EventArgs e)
        {
            try
            {
	            DatabaseAccess.Update_HasOneParameter("Insert_DM_Quan", "@TenQuan", txtQuan.Text);
                MessageBox.Show("Ðã thêm quận mới !");
	            //C?p nh?t l?i danh sách qu?n
	            DatabaseAccess.Select_HasNoParameter("SELECT_cbbQuan", cbbQuan, "TenQuan");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Loi " + ex.ToString());
            }
        }

        private void enableGrbDuong()
        {
            grbQuan.Enabled = false;
            grbQuan2.Enabled = false;
            grbNhapThongTin.Enabled = true;
        }

        private void enableGrbQuan()
        {
            grbQuan.Enabled = true;
            grbQuan2.Enabled = false;
            grbNhapThongTin.Enabled = false;
        }

        private void enableGrbQuan2()
        {
            grbQuan2.Enabled = true;
            grbQuan.Enabled = false;
            grbNhapThongTin.Enabled = false;
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseAccess.Update_HasOneParameter("DELETE_DM_Quan", "@TenQuan", cbbQuan2.Text);
                MessageBox.Show("Ðã xóa !");
                DatabaseAccess.Select_HasNoParameter("SELECT_cbbQuan", cbbQuan2, "TenQuan");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Loi" + ex.ToString());
            }
        }

        private void txtVT1_KeyPress(object sender, KeyPressEventArgs e)
        {
            DatabaseAccess.AllowDigit(e);
        }

        private void txtVT2_KeyPress(object sender, KeyPressEventArgs e)
        {
            DatabaseAccess.AllowDigit(e);
        }

        private void txtVT3_KeyPress(object sender, KeyPressEventArgs e)
        {
            DatabaseAccess.AllowDigit(e);
        }

        private void txtVT4_KeyPress(object sender, KeyPressEventArgs e)
        {
            DatabaseAccess.AllowDigit(e);
        }

        private void txtVT_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            DatabaseAccess.AllowDigit(e);
        }

        private void txtVT_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            DatabaseAccess.AllowDigit(e);
        }

        private void txtVT_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            DatabaseAccess.AllowDigit(e);
        }

        private void txtVT_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            DatabaseAccess.AllowDigit(e);
        }

    }
}
