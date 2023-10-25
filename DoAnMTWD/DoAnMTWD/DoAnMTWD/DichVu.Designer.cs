namespace DoAnMTWD
{
    partial class DichVu
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
            this.cbbDichVu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDieuTri = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblDichVu = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.btn_IN = new System.Windows.Forms.Button();
            this.dgv_dichvu = new System.Windows.Forms.DataGridView();
            this.maBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDieuTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichvu)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbDichVu
            // 
            this.cbbDichVu.FormattingEnabled = true;
            this.cbbDichVu.Location = new System.Drawing.Point(635, 65);
            this.cbbDichVu.Name = "cbbDichVu";
            this.cbbDichVu.Size = new System.Drawing.Size(121, 24);
            this.cbbDichVu.TabIndex = 0;
            this.cbbDichVu.SelectedIndexChanged += new System.EventHandler(this.cbbDichVu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dịch Vụ";
            // 
            // dgvDieuTri
            // 
            this.dgvDieuTri.AllowUserToAddRows = false;
            this.dgvDieuTri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDieuTri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDieuTri.Location = new System.Drawing.Point(484, 109);
            this.dgvDieuTri.Name = "dgvDieuTri";
            this.dgvDieuTri.RowHeadersWidth = 51;
            this.dgvDieuTri.RowTemplate.Height = 24;
            this.dgvDieuTri.Size = new System.Drawing.Size(554, 215);
            this.dgvDieuTri.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MaDV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TenDV";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SoLuong";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DVT";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "DonGia";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "TongTien";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(873, 63);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 4;
            // 
            // lblDichVu
            // 
            this.lblDichVu.AutoSize = true;
            this.lblDichVu.Location = new System.Drawing.Point(552, 65);
            this.lblDichVu.Name = "lblDichVu";
            this.lblDichVu.Size = new System.Drawing.Size(50, 16);
            this.lblDichVu.TabIndex = 5;
            this.lblDichVu.Text = "DichVu";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(787, 67);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(64, 16);
            this.lblSoLuong.TabIndex = 6;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // btn_IN
            // 
            this.btn_IN.Location = new System.Drawing.Point(601, 346);
            this.btn_IN.Name = "btn_IN";
            this.btn_IN.Size = new System.Drawing.Size(101, 69);
            this.btn_IN.TabIndex = 7;
            this.btn_IN.Text = "IN";
            this.btn_IN.UseVisualStyleBackColor = true;
            this.btn_IN.Click += new System.EventHandler(this.btn_IN_Click);
            // 
            // dgv_dichvu
            // 
            this.dgv_dichvu.AllowUserToAddRows = false;
            this.dgv_dichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dichvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maBN,
            this.hoten,
            this.ngaykham});
            this.dgv_dichvu.Location = new System.Drawing.Point(12, 109);
            this.dgv_dichvu.Name = "dgv_dichvu";
            this.dgv_dichvu.RowHeadersWidth = 51;
            this.dgv_dichvu.RowTemplate.Height = 24;
            this.dgv_dichvu.Size = new System.Drawing.Size(436, 215);
            this.dgv_dichvu.TabIndex = 8;
            this.dgv_dichvu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dichvu_CellContentClick);
            // 
            // maBN
            // 
            this.maBN.HeaderText = "MaBN";
            this.maBN.MinimumWidth = 6;
            this.maBN.Name = "maBN";
            this.maBN.Width = 125;
            // 
            // hoten
            // 
            this.hoten.HeaderText = "TenBN";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.Width = 125;
            // 
            // ngaykham
            // 
            this.ngaykham.HeaderText = "NgayKham";
            this.ngaykham.MinimumWidth = 6;
            this.ngaykham.Name = "ngaykham";
            this.ngaykham.Width = 125;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(734, 346);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(100, 69);
            this.btn_Them.TabIndex = 9;
            this.btn_Them.Text = "Them";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(863, 346);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 69);
            this.btnRemove.TabIndex = 21;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnMTWD.Properties.Resources.hinh_nen_powerpoint_mau_xanh_da_troi_1_1510385907;
            this.ClientSize = new System.Drawing.Size(1050, 640);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_dichvu);
            this.Controls.Add(this.btn_IN);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblDichVu);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dgvDieuTri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbDichVu);
            this.Name = "DichVu";
            this.Text = "DichVu";
            this.Load += new System.EventHandler(this.DichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDieuTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichvu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbDichVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDieuTri;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblDichVu;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Button btn_IN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridView dgv_dichvu;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykham;
        private System.Windows.Forms.Button btnRemove;
    }
}