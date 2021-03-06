using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLPCC
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        #region "Các sự kiện click menu"
        private void itemDanhMucNha_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            frmDanhMucNha childForm = new frmDanhMucNha();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void itemDanhMucDat_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            frmDanhMucDat childForm = new frmDanhMucDat();
            childForm.MdiParent = this;
            childForm.Show();
        }

        //private void itemDanhMucHD_Click(object sender, EventArgs e)
        //{
        //    foreach (System.Windows.Forms.Form frm in this.MdiChildren)
        //    {
        //        frm.Close();
        //    }
        //    frmDanhMucHD childForm = new frmDanhMucHD();
        //    childForm.MdiParent = this;
        //    childForm.Show();
        //}

        //private void itemKiemTra_Click(object sender, EventArgs e)
        //{
        //    foreach (System.Windows.Forms.Form frm in this.MdiChildren)
        //    {
        //        frm.Close();
        //    }
        //    frmKiemTra childForm = new frmKiemTra();
        //    childForm.MdiParent = this;
        //    childForm.Show();
        //}

        private void itemTinhPhi_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            frmLapHD childForm = new frmLapHD();
            childForm.MdiParent = this;
            childForm.Show();
        }

        //private void itemBaoCao_Click(object sender, EventArgs e)
        //{
        //    foreach (System.Windows.Forms.Form frm in this.MdiChildren)
        //    {
        //        frm.Close();
        //    }
        //    frmBaoCao childForm = new frmBaoCao();
        //    childForm.MdiParent = this;
        //    childForm.Show();
        //}

        private void itemGioiThieu_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            frmGioiThieu childForm = new frmGioiThieu();
            childForm.MdiParent = this;
            childForm.Show();
        }
        private void itemThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region "Các sự kiện click tool menu"
        private void tsbThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbTinhPhi_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            frmLapHD TP = new frmLapHD();
            TP.MdiParent = this;
            TP.Show();
        }

        private void tsbDanhMucNha_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            frmDanhMucNha DM = new frmDanhMucNha();
            DM.MdiParent = this;
            DM.Show();
        }

        private void tsbDanhMucDat_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            frmDanhMucDat DM = new frmDanhMucDat();
            DM.MdiParent = this;
            DM.Show();
        }

        private void tsbThemDuong_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            frmThemDat DM = new frmThemDat();
            DM.MdiParent = this;
            DM.Show();
        }
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLapHD frm = new frmLapHD();
            frm.MdiParent = this;
            frm.Show();
        }

    }
}
