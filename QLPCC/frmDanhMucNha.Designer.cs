namespace QLPCC
{
    partial class frmDanhMucNha
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhMucNha = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsCapNhatDanhMucNha = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemLietKe = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSua = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucNha)).BeginInit();
            this.cmsCapNhatDanhMucNha.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhMucNha);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 633);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả";
            // 
            // dgvDanhMucNha
            // 
            this.dgvDanhMucNha.AllowUserToAddRows = false;
            this.dgvDanhMucNha.AllowUserToDeleteRows = false;
            this.dgvDanhMucNha.AllowUserToResizeRows = false;
            this.dgvDanhMucNha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMucNha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucNha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenCap,
            this.SoTang,
            this.DienTich,
            this.LoaiNha,
            this.ChiTiet,
            this.Gia,
            this.MSCap,
            this.ID});
            this.dgvDanhMucNha.ContextMenuStrip = this.cmsCapNhatDanhMucNha;
            this.dgvDanhMucNha.Location = new System.Drawing.Point(6, 19);
            this.dgvDanhMucNha.MultiSelect = false;
            this.dgvDanhMucNha.Name = "dgvDanhMucNha";
            this.dgvDanhMucNha.ReadOnly = true;
            this.dgvDanhMucNha.RowTemplate.ContextMenuStrip = this.cmsCapNhatDanhMucNha;
            this.dgvDanhMucNha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMucNha.Size = new System.Drawing.Size(996, 603);
            this.dgvDanhMucNha.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // TenCap
            // 
            this.TenCap.DataPropertyName = "TenCap";
            this.TenCap.HeaderText = "Cấp";
            this.TenCap.Name = "TenCap";
            this.TenCap.ReadOnly = true;
            // 
            // SoTang
            // 
            this.SoTang.DataPropertyName = "SoTang";
            this.SoTang.HeaderText = "Số tầng";
            this.SoTang.Name = "SoTang";
            this.SoTang.ReadOnly = true;
            // 
            // DienTich
            // 
            this.DienTich.DataPropertyName = "DienTich";
            this.DienTich.HeaderText = "Diện tích";
            this.DienTich.Name = "DienTich";
            this.DienTich.ReadOnly = true;
            // 
            // LoaiNha
            // 
            this.LoaiNha.DataPropertyName = "LoaiNha";
            this.LoaiNha.HeaderText = "Loại nhà";
            this.LoaiNha.Name = "LoaiNha";
            this.LoaiNha.ReadOnly = true;
            // 
            // ChiTiet
            // 
            this.ChiTiet.DataPropertyName = "ChiTiet";
            this.ChiTiet.HeaderText = "Chi tiết";
            this.ChiTiet.Name = "ChiTiet";
            this.ChiTiet.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá áp";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // MSCap
            // 
            this.MSCap.DataPropertyName = "MSCap";
            this.MSCap.HeaderText = "MSCap";
            this.MSCap.Name = "MSCap";
            this.MSCap.ReadOnly = true;
            this.MSCap.Visible = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // cmsCapNhatDanhMucNha
            // 
            this.cmsCapNhatDanhMucNha.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemLietKe,
            this.itemSua});
            this.cmsCapNhatDanhMucNha.Name = "cmsCapNhatDanhMucNha";
            this.cmsCapNhatDanhMucNha.Size = new System.Drawing.Size(148, 48);
            // 
            // itemLietKe
            // 
            //this.itemLietKe.Image = global::QLPCC.Properties.Resources.BaoCao;
            this.itemLietKe.Name = "itemLietKe";
            this.itemLietKe.Size = new System.Drawing.Size(147, 22);
            this.itemLietKe.Text = "Liệt kê tất cả";
            this.itemLietKe.Click += new System.EventHandler(this.itemLietKe_Click);
            // 
            // itemSua
            // 
            //this.itemSua.Image = global::QLPCC.Properties.Resources.BackUp;
            this.itemSua.Name = "itemSua";
            this.itemSua.Size = new System.Drawing.Size(147, 22);
            this.itemSua.Text = "Sửa";
            this.itemSua.Click += new System.EventHandler(this.itemSua_Click);
            // 
            // frmDanhMucNha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 673);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDanhMucNha";
            this.Text = "Quản lý danh mục nhà";
            this.Load += new System.EventHandler(this.frmDanhMucNha_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucNha)).EndInit();
            this.cmsCapNhatDanhMucNha.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvDanhMucNha;
        private System.Windows.Forms.ContextMenuStrip cmsCapNhatDanhMucNha;
        private System.Windows.Forms.ToolStripMenuItem itemSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.ToolStripMenuItem itemLietKe;

    }
}