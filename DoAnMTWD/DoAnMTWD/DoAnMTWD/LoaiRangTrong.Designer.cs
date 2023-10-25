namespace DoAnMTWD
{
    partial class frmLoaiRangTrong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiRangTrong));
            this.btnIn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvLoaiRangTrong = new System.Windows.Forms.DataGridView();
            this.MaCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChatLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbChatLieu = new System.Windows.Forms.ComboBox();
            this.cbbPhanLoai = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgv_TrongRangBenhNhan = new System.Windows.Forms.DataGridView();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiRangTrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TrongRangBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(740, 451);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(102, 49);
            this.btnIn.TabIndex = 19;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(862, 113);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(610, 451);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 49);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvLoaiRangTrong
            // 
            this.dgvLoaiRangTrong.AllowUserToOrderColumns = true;
            this.dgvLoaiRangTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiRangTrong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCL,
            this.PhanLoai,
            this.ChatLieu,
            this.SL,
            this.DonGia,
            this.Total});
            this.dgvLoaiRangTrong.Location = new System.Drawing.Point(488, 158);
            this.dgvLoaiRangTrong.Name = "dgvLoaiRangTrong";
            this.dgvLoaiRangTrong.RowHeadersWidth = 51;
            this.dgvLoaiRangTrong.RowTemplate.Height = 24;
            this.dgvLoaiRangTrong.Size = new System.Drawing.Size(800, 275);
            this.dgvLoaiRangTrong.TabIndex = 16;
            // 
            // MaCL
            // 
            this.MaCL.HeaderText = "Mã Chất Liệu";
            this.MaCL.MinimumWidth = 6;
            this.MaCL.Name = "MaCL";
            this.MaCL.Width = 125;
            // 
            // PhanLoai
            // 
            this.PhanLoai.HeaderText = "Phân Loại";
            this.PhanLoai.MinimumWidth = 6;
            this.PhanLoai.Name = "PhanLoai";
            this.PhanLoai.Width = 125;
            // 
            // ChatLieu
            // 
            this.ChatLieu.HeaderText = "Chất Liệu";
            this.ChatLieu.MinimumWidth = 6;
            this.ChatLieu.Name = "ChatLieu";
            this.ChatLieu.Width = 125;
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            this.SL.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Tổng Tiền";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // cbbChatLieu
            // 
            this.cbbChatLieu.FormattingEnabled = true;
            this.cbbChatLieu.Location = new System.Drawing.Point(666, 111);
            this.cbbChatLieu.Name = "cbbChatLieu";
            this.cbbChatLieu.Size = new System.Drawing.Size(123, 24);
            this.cbbChatLieu.TabIndex = 15;
            this.cbbChatLieu.SelectedIndexChanged += new System.EventHandler(this.cbbChatLieu_SelectedIndexChanged);
            // 
            // cbbPhanLoai
            // 
            this.cbbPhanLoai.FormattingEnabled = true;
            this.cbbPhanLoai.Location = new System.Drawing.Point(488, 113);
            this.cbbPhanLoai.Name = "cbbPhanLoai";
            this.cbbPhanLoai.Size = new System.Drawing.Size(131, 24);
            this.cbbPhanLoai.TabIndex = 14;
            this.cbbPhanLoai.SelectedIndexChanged += new System.EventHandler(this.cbbPhanLoai_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(488, 451);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 49);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgv_TrongRangBenhNhan
            // 
            this.dgv_TrongRangBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TrongRangBenhNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBN,
            this.HoTen,
            this.NgayKham});
            this.dgv_TrongRangBenhNhan.Location = new System.Drawing.Point(12, 158);
            this.dgv_TrongRangBenhNhan.Name = "dgv_TrongRangBenhNhan";
            this.dgv_TrongRangBenhNhan.RowHeadersWidth = 51;
            this.dgv_TrongRangBenhNhan.RowTemplate.Height = 24;
            this.dgv_TrongRangBenhNhan.Size = new System.Drawing.Size(446, 478);
            this.dgv_TrongRangBenhNhan.TabIndex = 21;
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
            this.label1.Location = new System.Drawing.Point(482, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Phiếu Trồng Răng";
            // 
            // frmLoaiRangTrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1300, 655);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_TrongRangBenhNhan);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvLoaiRangTrong);
            this.Controls.Add(this.cbbChatLieu);
            this.Controls.Add(this.cbbPhanLoai);
            this.Name = "frmLoaiRangTrong";
            this.Text = "LoaiRangTrong";
            this.Load += new System.EventHandler(this.frmLoaiRangTrong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiRangTrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TrongRangBenhNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvLoaiRangTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChatLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ComboBox cbbChatLieu;
        private System.Windows.Forms.ComboBox cbbPhanLoai;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgv_TrongRangBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKham;
        private System.Windows.Forms.Label label1;
    }
}