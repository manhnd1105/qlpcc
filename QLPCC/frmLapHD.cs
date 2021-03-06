using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Win32;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Collections;

namespace QLPCC
{
    public partial class frmLapHD : Form
    {
        string ID = string.Empty;
        private string QueryName = string.Empty;
        private DataTable MyTable;
        public frmLapHD()
        {
            InitializeComponent();
        }

        #region "Hàm xử lý việc cộng chuỗi dạng số"
        private int removeSpaces(string StringContainSpaces)
        {
            char[] charsToRemove = new char[]{'\r', '\t', '\n', ' '};
            string[] results = StringContainSpaces.Split(charsToRemove);
            StringBuilder transformedString = new StringBuilder();
            foreach (string s in results)
            {
              transformedString.Append(s);
            }
            return int.Parse(transformedString.ToString());
        }
        private string addTwoIntString(string IntString1, string IntString2)
        {
            return Convert.ToString(removeSpaces(IntString1) + removeSpaces(IntString2));
        }
        #endregion
        private void frmTinhPhi_Load(object sender, EventArgs e)
        {
            //1.Load form kích cỡ max màn hình
            this.WindowState = FormWindowState.Maximized;
            //2.Đổ dữ liệu lên các combobox
            //2.1.Đổ lên cbbCapNha
            #region "Do len cbbCapNha, cbbLoaiNha"
            //Tao Dataset va add cac Table du lieu vao cung voi relation
            DataSet ds = new DataSet();
            DataTable CapNha = DatabaseAccess.Select_HasNoParameter("SELECT_DM_CapNha");
            CapNha.TableName = "CapNha";
            DataTable LoaiNha = DatabaseAccess.Select_HasNoParameter("SELECT_DM_LoaiNha");
            LoaiNha.TableName = "LoaiNha";
            ds.Tables.Add(CapNha);
            ds.Tables.Add(LoaiNha);
            ds.Relations.Add("CapNha_LoaiNha", CapNha.Columns["MSCap"], LoaiNha.Columns["MSCap"]);

            //Tao Binding Source
            BindingSource bsCapNha = new BindingSource();
            BindingSource bsLoaiNha = new BindingSource();

            //Bind du lieu tu Dataset vao BindSource CapNha (parent)
            bsCapNha.DataSource = ds;
            bsCapNha.DataMember = "CapNha";

            //Bind du lieu tu BindSource CapNha voi DataMember la relation vao BindSource LoaiNha (child)
            bsLoaiNha.DataSource = bsCapNha;
            bsLoaiNha.DataMember = "CapNha_LoaiNha";

            //Fill du lieu tu BindSource vao Combobox
            cbbCapNha.DisplayMember = "TenCap"; //Gia tri hien ra cho user chon
            cbbCapNha.ValueMember = "MSCap"; //Gia tri thu duoc sau khi user chon
            cbbCapNha.DataSource = bsCapNha;

            cbbLoaiNha.DisplayMember = "LoaiNha";
            cbbLoaiNha.ValueMember = "ID";
            cbbLoaiNha.DataSource = bsLoaiNha;
            #endregion

                //2.2.Đổ lên cbbQuan
            //QueryName = "SELECT_cbbQuan";
            //DatabaseAccess.Select_HasNoParameter(QueryName, cbbQuan, "TenQuan");
            #region "Do len cbbQuan, cbbDuong"
            //Tao Dataset va add cac Table du lieu vao cung voi relation
            ds = new DataSet();
            DataTable Quan = DatabaseAccess.Select_HasNoParameter("SELECT_DM_Quan_NoFilter");
            Quan.TableName = "Quan";
            DataTable Dat = DatabaseAccess.Select_HasNoParameter("SELECT_DM_Dat_NoFilter");
            Dat.TableName = "Dat";
            ds.Tables.Add(Quan);
            ds.Tables.Add(Dat);
            ds.Relations.Add("Quan_Dat", Quan.Columns["MSQuan"], Dat.Columns["MSQuan"]);

            //Tao Binding Source
            BindingSource bsQuan = new BindingSource();
            BindingSource bsDat = new BindingSource();

            //Bind du lieu tu Dataset vao BindSource CapNha (parent)
            bsQuan.DataSource = ds;
            bsQuan.DataMember = "Quan";

            //Bind du lieu tu BindSource CapNha voi DataMember la relation vao BindSource LoaiNha (child)
            bsDat.DataSource = bsQuan;
            bsDat.DataMember = "Quan_Dat";

            //Fill du lieu tu BindSource vao Combobox
            cbbQuan.DisplayMember = "TenQuan"; //Gia tri hien ra cho user chon
            cbbQuan.ValueMember = "MSQuan"; //Gia tri thu duoc sau khi user chon
            cbbQuan.DataSource = bsQuan;

            cbbDuong.DisplayMember = "Duong";
            cbbDuong.ValueMember = "ID";
            cbbDuong.DataSource = bsDat;

            cbbDoanTu.DisplayMember = "Tu";
            cbbDoanTu.ValueMember = "ID";
            cbbDoanTu.DataSource = bsDat;

            cbbDoanDen.DisplayMember = "Den";
            cbbDoanDen.ValueMember = "ID";
            cbbDoanDen.DataSource = bsDat;
            #endregion

                //2.3.Đổ lên cbbLoaiHD_PhiCoDinh
            QueryName = "SELECT_cbbLoaiHDCoDinh";
            DatabaseAccess.Select_HasNoParameter(QueryName, cbbLoaiHD_PhiCoDinh, "LoaiHD");
        }
        #region "Các sự kiện bật tắt groupbox"
        private void rdbPhiTheoGTTS_Click(object sender, EventArgs e)
        {
            grbNha.Enabled = true;
            grbDat.Enabled = true;
            btnTinhPhiCC.Enabled = true;
            grbPhiCoDinh.Enabled = false;
            grbPhiSaoVanBan.Enabled = false;
            resetGroupbox(grbPhiCoDinh);
            resetGroupbox(grbPhiSaoVanBan);

        }

        private void rdbPhiCoDinh_Click(object sender, EventArgs e)
        {
            grbNha.Enabled = false;
            grbDat.Enabled = false;
            btnTinhPhiCC.Enabled = false;
            //txtTongGTTS.Enabled = false;
            txtTongGTTS.Text = "0";
            grbPhiCoDinh.Enabled = true;
            grbPhiSaoVanBan.Enabled = false;
            //resetGroupbox(grbPhiCC);
            resetGroupbox(grbNha);
            resetGroupbox(grbDat);
            resetGroupbox(grbPhiSaoVanBan);
            //cbbLoaiHD.Text = "";
        }

        private void rdbPhiSaoVanBan_Click(object sender, EventArgs e)
        {
            grbNha.Enabled = false;
            grbDat.Enabled = false;
            //txtTongGTTS.Enabled = false;
            txtTongGTTS.Text = "0";
            btnTinhPhiCC.Enabled = false;
            grbPhiCoDinh.Enabled = false;
            grbPhiSaoVanBan.Enabled = true;
            resetGroupbox(grbNha);
            resetGroupbox(grbDat);
            resetGroupbox(grbPhiCoDinh);
        }

        private void resetGroupbox(GroupBox MyGroupBox)
        {
            for (int i = 0; i < MyGroupBox.Controls.Count; i++)
            {
                Control MyControl = MyGroupBox.Controls[i];
                if ((string)MyControl.Tag == "cbb")
                {
                    MyControl.ResetText();
                }
                if ((string)MyControl.Tag == "txt")
                {
                    MyControl.Text = "";
                }
                if ((string)MyControl.Tag == "txtNo")
                {
                    MyControl.Text = "0";
                }
            }
        }
        #endregion
        #region "Bắt lỗi input"
        private void txtDienTichNha_KeyPress(object sender, KeyPressEventArgs e)
        {
            DatabaseAccess.AllowDigit(e);
        }

        private void txtDienTichDat_KeyPress(object sender, KeyPressEventArgs e)
        {
            DatabaseAccess.AllowDigit(e);
        }

        private void txtSoTrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            DatabaseAccess.AllowDigit(e);
        }

        private void txtSoBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            DatabaseAccess.AllowDigit(e);
        }

        private void txtThuLao_KeyPress(object sender, KeyPressEventArgs e)
        {
            DatabaseAccess.AllowDigit(e);
        }

        private void txtTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            DatabaseAccess.AllowDigit(e);
        }

        private void txtGiaTriNha_KeyPress(object sender, KeyPressEventArgs e)
        {
            DatabaseAccess.AllowDigit(e);
        }

        private void txtGiaTriDat_KeyPress(object sender, KeyPressEventArgs e)
        {
            DatabaseAccess.AllowDigit(e);
        }

        private void txtTongGTTS_KeyPress(object sender, KeyPressEventArgs e)
        {
            DatabaseAccess.AllowDigit(e);
        }

        private void txtPhiTheoGTTS_KeyPress(object sender, KeyPressEventArgs e)
        {


            DatabaseAccess.AllowDigit(e);

        }

        private void txtThuLao_Validated(object sender, EventArgs e)
        {
            validTien(txtThuLao, true);
        }

        private void txtTien_Validated(object sender, EventArgs e)
        {
            validTien(txtTien, true);
        }

        private void validTien(TextBox MyTxtBox, bool makeStandard)
        {
            if (MyTxtBox.Text == null || MyTxtBox.Text == "")
            {
                MyTxtBox.Text = "0";
            }
            //Nếu muốn quy chuẩn số tiền (có dấu phẩy phân cách) thì tiến hành makeStandard là true
            if (makeStandard)
            {
                Double Tien = Double.Parse(MyTxtBox.Text);
                MyTxtBox.Text = Tien.ToString("#,#", System.Globalization.CultureInfo.InvariantCulture);
            }
        }

        private void txtPhiTheoGTTS_Validated(object sender, EventArgs e)
        {
            validTien(txtPhiTheoGTTS, false);
        }

        private void txtGiaTriNha_Validated(object sender, EventArgs e)
        {
            validTien(txtGiaTriNha, false);
        }

        private void txtGiaTriDat_Validated(object sender, EventArgs e)
        {
            validTien(txtGiaTriDat, false);
        }

        private void txtTongTienNop_Validated(object sender, EventArgs e)
        {
            //validTien(txtTongTienNop, false);
        }
        #endregion
        #region "Hàm tính phí công chứng"
        private Double TinhPhiCC(Double Phi)
        {
            Double P = 0;
            if (Phi < 100000000)
            {
                P = 100000;
            }
            else if ((Phi >= 100000000) && (Phi <= 1000000000))
            {
                P = 0.001 * Phi;
            }
            else if ((Phi >= 1000000000) && (Phi <= 5000000000))
            {
                P = 0.0007 * (Phi - 1000000000) + 1000000;
            }
            else if ((Phi >= 5000000000))
            {
                P = 0.0005 * (Phi - 5000000000) + 3800000;
                
            }
            if (P > 10000000)
            {
                P = 10000000;
            }
            return P;
        }
        private long TinhPhiSaoVanBan(int SoTrang, int SoBan)
        {
            long Phi = 0;
            if (SoTrang * SoBan < 3)
            {
                Phi = SoTrang * 5000 * SoBan;
            }
            else
            {
                Phi = 10000 + 3000 * (SoTrang * SoBan - 2);
            }
            if (Phi > 100000)
            {
                Phi = 100000 * SoBan;
            }
            return (Phi);
        }
        private Double LamTronTien(Double Tien)
        {
            Double Tien_return = 0;
            try
            {
	            string Tien_string = Tien.ToString();
	            int Length = Tien_string.Length - 3;
	
	            string Tien_segment = Tien_string.Substring(Length, 3);
	            Tien_string = Tien_string.Remove(Length);
	            Tien_string = Tien_string.Insert(Length, "000");
	            Tien_return = Double.Parse(Tien_string);
	            if (Double.Parse(Tien_segment) >= 500)
	            {
	
	                Tien_return = Tien_return + 1000;
	
	            }
            }
            catch
            {
            	
            }
            return (Tien_return);
        }
        #endregion
        #region "Các sự kiện click"
        

        private void btnTinhPhiCC_Click(object sender, EventArgs e)
        {
            try
            {
                Double TongGTTS;
	            if (txtTien.Text == "0" || txtTien.Text == null || txtTien.Text == "")
	            {
		            TongGTTS = (Double.Parse(txtGiaTriNha.Text) + Double.Parse(txtGiaTriDat.Text));

	            } 
	            else
	            {
                    TongGTTS = Double.Parse(txtTien.Text);
	            }
                txtTongGTTS.Text = TongGTTS.ToString("#,#", System.Globalization.CultureInfo.InvariantCulture);
                Double PhiCongChung = TinhPhiCC(TongGTTS);
                txtPhiTheoGTTS.Text = PhiCongChung.ToString("#,#", System.Globalization.CultureInfo.InvariantCulture);
                txtThuLao.Focus();
            }
            catch
            {
                MessageBox.Show("Chưa nhập Tổng giá trị tài sản !");
            }
        }

        private void btnTinhTongTien_Click(object sender, EventArgs e)
        {
            if (txtPhiTheoGTTS.Text == null || txtPhiTheoGTTS.Text == "")
            {
                MessageBox.Show("Chưa nhập phí công chứng !");
            }
            else if (txtThuLao.Text == "" || txtThuLao.Text == null || txtThuLao.Text == "0")
            {
                Double TongTienNop_ChuaLamTron = Double.Parse(txtPhiTheoGTTS.Text);
                Double TongTienNop = LamTronTien(TongTienNop_ChuaLamTron);
                txtTongTienNop.Text = TongTienNop.ToString("#,#", System.Globalization.CultureInfo.InvariantCulture);
                txtThuLao.Text = "0";
            }
            else
            {
                Double TongTienNop_ChuaLamTron = Double.Parse(txtPhiTheoGTTS.Text) + Double.Parse(txtThuLao.Text);
                Double TongTienNop = LamTronTien(TongTienNop_ChuaLamTron);
                txtTongTienNop.Text = TongTienNop.ToString("#,#", System.Globalization.CultureInfo.InvariantCulture);
            }
            validTien(txtTongGTTS, false);
            validTien(txtTien, false);
            validTien(txtPhiTheoGTTS, false);
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            frmLapHD TP = new frmLapHD();
            TP.MdiParent = Application.OpenForms["frmMain"];
            TP.Show();
        }
        #endregion
        #region "Các sự kiện load dữ liệu ra label khi user chọn xong combobox"
        //private void cbbCapNha_Leave(object sender, EventArgs e)
        //{
        //    lblCapNha.Text = "";
        //    //Load mô tả về cấp nhà lên label
        //    DataTable MyTable1 = new DataTable();
        //    QueryName = "SELECT_lblCapNha";
        //    DatabaseAccess.Select_HasOneParameter(QueryName, MyTable1, "TenCap", cbbCapNha.Text);
        //    lblCapNha.Text = MyTable1.Rows[0]["SoTang"].ToString();
        //}

        //private void cbbLoaiNha_Leave(object sender, EventArgs e)
        //{
        //    //Load mô tả về loại nhà lên label
        //    DataTable MyTable2 = new DataTable();
        //    QueryName = "SELECT_lblLoaiNha";
        //    string[] ParaName = { "TenCap", "LoaiNha" };
        //    string[] ParaValue = { cbbCapNha.Text, cbbLoaiNha.Text };
        //    DatabaseAccess.Select_HasManyParameter(QueryName, MyTable2, ParaName, ParaValue);
        //    lblLoaiNha.Text = MyTable2.Rows[0][0].ToString();
        //}
        #endregion

        private void txtGiaApNha_Enter(object sender, EventArgs e)
        {
            try
            {
                updateGiaApNha();
            }
            catch
            {
                MessageBox.Show("Chưa chọn cấp nhà hay loại nhà !");
            }
        }

        private void txtGiaTriNha_Enter(object sender, EventArgs e)
        {
            try
            {
                int GiaApNha = removeSpaces(txtGiaApNha.Text);
                Decimal KhauHao = Convert.ToDecimal(cbbKhauHao.Text);
                Decimal DienTich = Convert.ToDecimal(txtDienTichNha.Text);
                long GiaTriNha = (long)(GiaApNha * (1 - KhauHao) * DienTich);
                txtGiaTriNha.Text = GiaTriNha.ToString("#,#", System.Globalization.CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("Chưa chọn giá áp hoặc diện tích nhà !");
            }
        }

        private void cbbDoanTu_Enter(object sender, EventArgs e)
        {

        }

        private void cbbDoanDen_Enter(object sender, EventArgs e)
        {

        }

        private void txtGiaTriDat_Enter(object sender, EventArgs e)
        {
            try
            {
                int GiaApDat = removeSpaces(txtGiaApDat.Text);
                Decimal DienTich = Convert.ToDecimal(txtDienTichDat.Text);
                long GiaTriDat = (long)(GiaApDat * DienTich);
                txtGiaTriDat.Text = GiaTriDat.ToString("#,#", System.Globalization.CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("Chưa chọn giá áp hay diện tích đất !");
            }
        }

        private void txtPhiSaoVanBan_Enter(object sender, EventArgs e)
        {
            try
            {
                long PhiSaoVanBan = TinhPhiSaoVanBan(int.Parse(txtSoTrang.Text), int.Parse(txtSoBan.Text));
                txtPhiSaoVanBan.Text = PhiSaoVanBan.ToString("#,#", System.Globalization.CultureInfo.InvariantCulture);
                txtPhiTheoGTTS.Text = txtPhiSaoVanBan.Text;
            }
            catch
            {
                MessageBox.Show("Chưa chọn số trang hoặc văn bản !");
            }
        }

        private void txtPhiCoDinh_Enter(object sender, EventArgs e)
        {
            if (cbbLoaiHD_PhiCoDinh.Text == "" || cbbLoaiHD_PhiCoDinh.Text == null)
            {
                MessageBox.Show("Chưa chọn loại HĐ !");
            }
            else
            {
                MyTable = new DataTable();
                QueryName = "SELECT_txtPhiCoDinh";
                DatabaseAccess.Select_HasOneParameter(QueryName, MyTable, "LoaiHD", cbbLoaiHD_PhiCoDinh.Text);
                txtPhiCoDinh.Text = MyTable.Rows[0][0].ToString();
                txtPhiTheoGTTS.Text = txtPhiCoDinh.Text;
                txtThuLao.Focus();
            }
        }

        private void txtGiaApDat_Enter(object sender, EventArgs e)
        {
            try
            {
                DataTable MyTable = new DataTable();
                QueryName = "SELECT_txtGiaApDat_";
                //Xử lý string QueryName theo vị trí đất và loại đất
                if (rdbDatO.Checked == true) //Loại đất là đất ở
                {
                    QueryName = QueryName + cbbViTri.Text;
                }
                else //Loại đất là đất kinh doanh phi nông nghiệp
                {
                    QueryName = QueryName + cbbViTri.Text.Insert(2, "_");
                }
                //Xử lý string QueryName khi xảy ra TH không có đoạn từ đoạn đến hoặc chỉ có đoạn từ
                if (cbbDoanTu.Text == "") //Không có đoạn từ, đoạn đến
                {
                    string[] ParaName = { "TenQuan", "Duong" };
                    string[] ParaValue = { cbbQuan.Text.Trim(), cbbDuong.Text.Trim() };
                    DatabaseAccess.Select_HasManyParameter(QueryName, MyTable, ParaName, ParaValue);
                }
                else if (cbbDoanDen.Text == "") //Chỉ có đoạn từ
                {
                    QueryName = QueryName + "_Tu";
                    string[] ParaName = { "TenQuan", "Duong", "Tu" };
                    string[] ParaValue = { cbbQuan.Text.Trim(), cbbDuong.Text.Trim(), cbbDoanTu.Text.Trim() };
                    DatabaseAccess.Select_HasManyParameter(QueryName, MyTable, ParaName, ParaValue);
                }
                else //Có cả đoạn từ và đoạn đến
                {
                    QueryName = QueryName + "_Tu_Den";
                    string[] ParaName = { "TenQuan", "Duong", "Tu", "Den" };
                    string[] ParaValue = { cbbQuan.Text.Trim(), cbbDuong.Text.Trim(), cbbDoanTu.Text.Trim(), cbbDoanDen.Text.Trim() };
                    DatabaseAccess.Select_HasManyParameter(QueryName, MyTable, ParaName, ParaValue);
                }
                txtGiaApDat.Text = MyTable.Rows[0][0].ToString();
            }
            catch
            {
                MessageBox.Show("Chưa chọn dữ liệu quận, đường, đoạn đường đầy đủ !");
            }
        }

        private void updateGiaApNha()
        {
            try
            {
                DataTable MyTable = new DataTable();
                QueryName = "SELECT_txtGiaApNha";
                string[] ParaName = { "LoaiNha", "TenCap" };
                string[] ParaValue = { cbbLoaiNha.Text, cbbCapNha.Text };
                DatabaseAccess.Select_HasManyParameter(QueryName, MyTable, ParaName, ParaValue);
                txtGiaApNha.Text = MyTable.Rows[0][0].ToString();
            }
            catch (System.Exception ex)
            {
                ex.Message.ToString();
                //MessageBox.Show(ex.ToString());
            }
        }


        private void cbbDoanTu_Click(object sender, EventArgs e)
        {
            if (cbbQuan.Text.Trim() == "" || cbbDuong.Text.Trim() == "" || cbbQuan.Text == null || cbbDuong.Text == null)
            {
                MessageBox.Show("Chưa chọn quận hoặc đường !");
            }
            else
            {
                QueryName = "SELECT_cbbTu";
                string[] ParaName = { "TenQuan", "Duong" };
                string[] ParaValue = { cbbQuan.Text, cbbDuong.Text };
                DatabaseAccess.Select_HasManyParameter(QueryName, cbbDoanTu, "Tu", ParaName, ParaValue);
            }
        }

        private void cbbDoanDen_Click(object sender, EventArgs e)
        {
            if (cbbQuan.Text.Trim() == "" || cbbDuong.Text.Trim() == "" || cbbQuan.Text == null || cbbDuong.Text == null)
            {
                MessageBox.Show("Chưa chọn quận hoặc đường !");
            }
            else
            {
                QueryName = "SELECT_cbbDen";
                string[] ParaName = { "TenQuan", "Duong" };
                string[] ParaValue = { cbbQuan.Text, cbbDuong.Text };
                DatabaseAccess.Select_HasManyParameter(QueryName, cbbDoanDen, "Den", ParaName, ParaValue);
            }
        }
    }
}