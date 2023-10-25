namespace DoAnMTWD
{
    partial class frmToaThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToaThuoc));
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbbThuoc = new System.Windows.Forms.ComboBox();
            this.dgvToaThuoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgv_BenhNhanToaThuoc = new System.Windows.Forms.DataGridView();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BenhNhanToaThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(671, 448);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(82, 59);
            this.btnInHoaDon.TabIndex = 38;
            this.btnInHoaDon.Text = "In";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(553, 448);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 59);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(605, 90);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(84, 22);
            this.numericUpDown1.TabIndex = 33;
            // 
            // cbbThuoc
            // 
            this.cbbThuoc.FormattingEnabled = true;
            this.cbbThuoc.Location = new System.Drawing.Point(441, 90);
            this.cbbThuoc.Name = "cbbThuoc";
            this.cbbThuoc.Size = new System.Drawing.Size(121, 24);
            this.cbbThuoc.TabIndex = 32;
            this.cbbThuoc.SelectedIndexChanged += new System.EventHandler(this.cbbThuoc_SelectedIndexChanged);
            // 
            // dgvToaThuoc
            // 
            this.dgvToaThuoc.AllowUserToOrderColumns = true;
            this.dgvToaThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToaThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvToaThuoc.Location = new System.Drawing.Point(441, 120);
            this.dgvToaThuoc.Name = "dgvToaThuoc";
            this.dgvToaThuoc.RowHeadersWidth = 51;
            this.dgvToaThuoc.RowTemplate.Height = 24;
            this.dgvToaThuoc.Size = new System.Drawing.Size(691, 322);
            this.dgvToaThuoc.TabIndex = 31;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MaThuoc";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tenthuoc";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "MoTa";
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
            this.Column5.HeaderText = "SL";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "DonGia";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Tổng tiền";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(441, 448);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(92, 59);
            this.btnRemove.TabIndex = 39;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgv_BenhNhanToaThuoc
            // 
            this.dgv_BenhNhanToaThuoc.AllowUserToAddRows = false;
            this.dgv_BenhNhanToaThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BenhNhanToaThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBN,
            this.HoTen,
            this.NgayKham});
            this.dgv_BenhNhanToaThuoc.Location = new System.Drawing.Point(9, 120);
            this.dgv_BenhNhanToaThuoc.Name = "dgv_BenhNhanToaThuoc";
            this.dgv_BenhNhanToaThuoc.RowHeadersWidth = 51;
            this.dgv_BenhNhanToaThuoc.RowTemplate.Height = 24;
            this.dgv_BenhNhanToaThuoc.Size = new System.Drawing.Size(399, 387);
            this.dgv_BenhNhanToaThuoc.TabIndex = 40;
            // 
            // MaBN
            // 
            this.MaBN.HeaderText = "MaBN";
            this.MaBN.MinimumWidth = 6;
            this.MaBN.Name = "MaBN";
            this.MaBN.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "HoTen";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
            // 
            // NgayKham
            // 
            this.NgayKham.HeaderText = "NgayKham";
            this.NgayKham.MinimumWidth = 6;
            this.NgayKham.Name = "NgayKham";
            this.NgayKham.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 32);
            this.label1.TabIndex = 41;
            this.label1.Text = "Toa Thuốc";
            // 
            // frmToaThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1144, 574);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_BenhNhanToaThuoc);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cbbThuoc);
            this.Controls.Add(this.dgvToaThuoc);
            this.Name = "frmToaThuoc";
            this.Text = "ToaThuoc";
            this.Load += new System.EventHandler(this.ToaThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BenhNhanToaThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cbbThuoc;
        private System.Windows.Forms.DataGridView dgvToaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgv_BenhNhanToaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKham;
        private System.Windows.Forms.Label label1;
    }
}