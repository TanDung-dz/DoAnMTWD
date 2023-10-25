namespace DoAnMTWD
{
    partial class frmDCVT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDCVT));
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbbDCVT = new System.Windows.Forms.ComboBox();
            this.dgvDCVT = new System.Windows.Forms.DataGridView();
            this.MaDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDCVT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(468, 147);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(103, 39);
            this.btnInHoaDon.TabIndex = 22;
            this.btnInHoaDon.Text = "Xuất thống kê";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(319, 145);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 41);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(404, 109);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(84, 22);
            this.numericUpDown1.TabIndex = 20;
            // 
            // cbbDCVT
            // 
            this.cbbDCVT.FormattingEnabled = true;
            this.cbbDCVT.Location = new System.Drawing.Point(404, 68);
            this.cbbDCVT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDCVT.Name = "cbbDCVT";
            this.cbbDCVT.Size = new System.Drawing.Size(121, 24);
            this.cbbDCVT.TabIndex = 19;
            this.cbbDCVT.SelectedIndexChanged += new System.EventHandler(this.cbbDCVT_SelectedIndexChanged);
            // 
            // dgvDCVT
            // 
            this.dgvDCVT.AllowUserToOrderColumns = true;
            this.dgvDCVT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDCVT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDC,
            this.TenDC,
            this.MoTa,
            this.DVT,
            this.SL,
            this.DonGia,
            this.TongTien});
            this.dgvDCVT.Location = new System.Drawing.Point(149, 250);
            this.dgvDCVT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDCVT.Name = "dgvDCVT";
            this.dgvDCVT.RowHeadersWidth = 51;
            this.dgvDCVT.RowTemplate.Height = 24;
            this.dgvDCVT.Size = new System.Drawing.Size(853, 322);
            this.dgvDCVT.TabIndex = 18;
            // 
            // MaDC
            // 
            this.MaDC.HeaderText = "MaDC";
            this.MaDC.MinimumWidth = 6;
            this.MaDC.Name = "MaDC";
            this.MaDC.Width = 125;
            // 
            // TenDC
            // 
            this.TenDC.HeaderText = "TenDC";
            this.TenDC.MinimumWidth = 6;
            this.TenDC.Name = "TenDC";
            this.TenDC.Width = 125;
            // 
            // MoTa
            // 
            this.MoTa.HeaderText = "MoTa";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.Width = 125;
            // 
            // DVT
            // 
            this.DVT.HeaderText = "DVT";
            this.DVT.MinimumWidth = 6;
            this.DVT.Name = "DVT";
            this.DVT.Width = 125;
            // 
            // SL
            // 
            this.SL.HeaderText = "So Luong";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            this.SL.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Don Gia";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "TongTien";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Dụng cụ vật tư";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Số lượng";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(622, 147);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 39);
            this.btnRemove.TabIndex = 26;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmDCVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1186, 583);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cbbDCVT);
            this.Controls.Add(this.dgvDCVT);
            this.Name = "frmDCVT";
            this.Text = "DCVT";
            this.Load += new System.EventHandler(this.DCVT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDCVT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cbbDCVT;
        private System.Windows.Forms.DataGridView dgvDCVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemove;
    }
}