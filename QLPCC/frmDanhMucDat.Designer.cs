namespace QLPCC
{
    partial class frmDanhMucDat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhMucDat));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhMucDat = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Den = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VT3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VT4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VT_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VT_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VT_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VT_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsCapNhatDanhMucDat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemLietKe = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSua = new System.Windows.Forms.ToolStripMenuItem();
            this.itemXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.grbKiemTra = new System.Windows.Forms.GroupBox();
            this.cbbQuan = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucDat)).BeginInit();
            this.cmsCapNhatDanhMucDat.SuspendLayout();
            this.grbKiemTra.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhMucDat);
            this.groupBox1.Location = new System.Drawing.Point(4, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 583);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả";
            // 
            // dgvDanhMucDat
            // 
            this.dgvDanhMucDat.AllowUserToAddRows = false;
            this.dgvDanhMucDat.AllowUserToDeleteRows = false;
            this.dgvDanhMucDat.AllowUserToResizeRows = false;
            this.dgvDanhMucDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMucDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenQuan,
            this.Duong,
            this.Tu,
            this.Den,
            this.VT1,
            this.VT2,
            this.VT3,
            this.VT4,
            this.VT_1,
            this.VT_2,
            this.VT_3,
            this.VT_4,
            this.MSQuan,
            this.ID});
            this.dgvDanhMucDat.ContextMenuStrip = this.cmsCapNhatDanhMucDat;
            this.dgvDanhMucDat.Location = new System.Drawing.Point(6, 19);
            this.dgvDanhMucDat.MultiSelect = false;
            this.dgvDanhMucDat.Name = "dgvDanhMucDat";
            this.dgvDanhMucDat.ReadOnly = true;
            this.dgvDanhMucDat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvDanhMucDat.RowTemplate.ContextMenuStrip = this.cmsCapNhatDanhMucDat;
            this.dgvDanhMucDat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMucDat.Size = new System.Drawing.Size(996, 556);
            this.dgvDanhMucDat.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // TenQuan
            // 
            this.TenQuan.DataPropertyName = "TenQuan";
            this.TenQuan.HeaderText = "Quận";
            this.TenQuan.Name = "TenQuan";
            this.TenQuan.ReadOnly = true;
            // 
            // Duong
            // 
            this.Duong.DataPropertyName = "Duong";
            this.Duong.HeaderText = "Đường";
            this.Duong.Name = "Duong";
            this.Duong.ReadOnly = true;
            // 
            // Tu
            // 
            this.Tu.DataPropertyName = "Tu";
            this.Tu.HeaderText = "Đoạn từ";
            this.Tu.Name = "Tu";
            this.Tu.ReadOnly = true;
            // 
            // Den
            // 
            this.Den.DataPropertyName = "Den";
            this.Den.HeaderText = "Đến";
            this.Den.Name = "Den";
            this.Den.ReadOnly = true;
            // 
            // VT1
            // 
            this.VT1.DataPropertyName = "VT1";
            this.VT1.HeaderText = "VT1 - Đất ở";
            this.VT1.Name = "VT1";
            this.VT1.ReadOnly = true;
            // 
            // VT2
            // 
            this.VT2.DataPropertyName = "VT2";
            this.VT2.HeaderText = "VT2 - Đất ở";
            this.VT2.Name = "VT2";
            this.VT2.ReadOnly = true;
            // 
            // VT3
            // 
            this.VT3.DataPropertyName = "VT3";
            this.VT3.HeaderText = "VT3 - Đất ở";
            this.VT3.Name = "VT3";
            this.VT3.ReadOnly = true;
            // 
            // VT4
            // 
            this.VT4.DataPropertyName = "VT4";
            this.VT4.HeaderText = "VT4 - Đất ở";
            this.VT4.Name = "VT4";
            this.VT4.ReadOnly = true;
            // 
            // VT_1
            // 
            this.VT_1.DataPropertyName = "VT_1";
            this.VT_1.HeaderText = "VT1 - Đất phi NN";
            this.VT_1.Name = "VT_1";
            this.VT_1.ReadOnly = true;
            // 
            // VT_2
            // 
            this.VT_2.DataPropertyName = "VT_2";
            this.VT_2.HeaderText = "VT2 - Đất phi NN";
            this.VT_2.Name = "VT_2";
            this.VT_2.ReadOnly = true;
            // 
            // VT_3
            // 
            this.VT_3.DataPropertyName = "VT_3";
            this.VT_3.HeaderText = "VT3 - Đất phi NN";
            this.VT_3.Name = "VT_3";
            this.VT_3.ReadOnly = true;
            // 
            // VT_4
            // 
            this.VT_4.DataPropertyName = "VT_4";
            this.VT_4.HeaderText = "VT4 - Đất phi NN";
            this.VT_4.Name = "VT_4";
            this.VT_4.ReadOnly = true;
            // 
            // MSQuan
            // 
            this.MSQuan.DataPropertyName = "MSQuan";
            this.MSQuan.HeaderText = "MSQuan";
            this.MSQuan.Name = "MSQuan";
            this.MSQuan.ReadOnly = true;
            this.MSQuan.Visible = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // cmsCapNhatDanhMucDat
            // 
            this.cmsCapNhatDanhMucDat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemLietKe,
            this.itemSua,
            this.itemXoa});
            this.cmsCapNhatDanhMucDat.Name = "cmsCapNhatDanhMucNha";
            this.cmsCapNhatDanhMucDat.Size = new System.Drawing.Size(153, 92);
            // 
            // itemLietKe
            // 
            this.itemLietKe.Name = "itemLietKe";
            this.itemLietKe.Size = new System.Drawing.Size(152, 22);
            this.itemLietKe.Text = "Liệt kê tất cả";
            this.itemLietKe.Click += new System.EventHandler(this.itemLietKe_Click);
            // 
            // itemSua
            // 
            this.itemSua.Name = "itemSua";
            this.itemSua.Size = new System.Drawing.Size(152, 22);
            this.itemSua.Text = "Sửa";
            this.itemSua.Click += new System.EventHandler(this.itemSua_Click);
            // 
            // itemXoa
            // 
            this.itemXoa.Name = "itemXoa";
            this.itemXoa.Size = new System.Drawing.Size(152, 22);
            this.itemXoa.Text = "Xóa";
            this.itemXoa.Click += new System.EventHandler(this.itemXoa_Click);
            // 
            // grbKiemTra
            // 
            this.grbKiemTra.Controls.Add(this.cbbQuan);
            this.grbKiemTra.Controls.Add(this.btnTimKiem);
            this.grbKiemTra.Controls.Add(this.label28);
            this.grbKiemTra.Location = new System.Drawing.Point(4, 3);
            this.grbKiemTra.Name = "grbKiemTra";
            this.grbKiemTra.Size = new System.Drawing.Size(423, 50);
            this.grbKiemTra.TabIndex = 62;
            this.grbKiemTra.TabStop = false;
            this.grbKiemTra.Text = "Lọc thông tin";
            // 
            // cbbQuan
            // 
            this.cbbQuan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbQuan.FormattingEnabled = true;
            this.cbbQuan.Location = new System.Drawing.Point(54, 16);
            this.cbbQuan.Name = "cbbQuan";
            this.cbbQuan.Size = new System.Drawing.Size(257, 27);
            this.cbbQuan.TabIndex = 17;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::QLPCC.Properties.Resources.kexi1;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(327, 15);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 28);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "&Liệt kê";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(6, 19);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(42, 19);
            this.label28.TabIndex = 16;
            this.label28.Text = "Quận";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(868, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(144, 50);
            this.btnThem.TabIndex = 63;
            this.btnThem.Text = "Thêm dữ liệu mới";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmDanhMucDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 673);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbKiemTra);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDanhMucDat";
            this.Text = "Quản lý danh mục đất";
            this.Load += new System.EventHandler(this.frmDanhMucDat_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucDat)).EndInit();
            this.cmsCapNhatDanhMucDat.ResumeLayout(false);
            this.grbKiemTra.ResumeLayout(false);
            this.grbKiemTra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvDanhMucDat;
        private System.Windows.Forms.ContextMenuStrip cmsCapNhatDanhMucDat;
        private System.Windows.Forms.ToolStripMenuItem itemSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Den;
        private System.Windows.Forms.DataGridViewTextBoxColumn VT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn VT3;
        private System.Windows.Forms.DataGridViewTextBoxColumn VT4;
        private System.Windows.Forms.DataGridViewTextBoxColumn VT_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VT_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn VT_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn VT_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.ToolStripMenuItem itemLietKe;
        private System.Windows.Forms.GroupBox grbKiemTra;
        private System.Windows.Forms.ComboBox cbbQuan;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ToolStripMenuItem itemXoa;
    }
}