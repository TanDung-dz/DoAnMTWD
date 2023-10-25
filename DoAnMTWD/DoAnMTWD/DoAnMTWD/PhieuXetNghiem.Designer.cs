namespace DoAnMTWD
{
    partial class PhieuXetNghiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuXetNghiem));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_TTPXN = new System.Windows.Forms.DataGridView();
            this.maBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketqua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Inpxn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TTPXN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin phiếu xét nghiệm";
            // 
            // dgv_TTPXN
            // 
            this.dgv_TTPXN.AllowUserToAddRows = false;
            this.dgv_TTPXN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TTPXN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maBN,
            this.hoTen,
            this.ngayKham,
            this.makt,
            this.ketqua});
            this.dgv_TTPXN.Location = new System.Drawing.Point(62, 107);
            this.dgv_TTPXN.Name = "dgv_TTPXN";
            this.dgv_TTPXN.RowHeadersWidth = 51;
            this.dgv_TTPXN.RowTemplate.Height = 24;
            this.dgv_TTPXN.Size = new System.Drawing.Size(683, 235);
            this.dgv_TTPXN.TabIndex = 1;
            // 
            // maBN
            // 
            this.maBN.HeaderText = "MaBN";
            this.maBN.MinimumWidth = 6;
            this.maBN.Name = "maBN";
            this.maBN.Width = 125;
            // 
            // hoTen
            // 
            this.hoTen.HeaderText = "TenBN";
            this.hoTen.MinimumWidth = 6;
            this.hoTen.Name = "hoTen";
            this.hoTen.Width = 125;
            // 
            // ngayKham
            // 
            this.ngayKham.HeaderText = "NgayKham";
            this.ngayKham.MinimumWidth = 6;
            this.ngayKham.Name = "ngayKham";
            this.ngayKham.Width = 125;
            // 
            // makt
            // 
            this.makt.HeaderText = "MaXN";
            this.makt.MinimumWidth = 6;
            this.makt.Name = "makt";
            this.makt.Width = 125;
            // 
            // ketqua
            // 
            this.ketqua.HeaderText = "KetQua";
            this.ketqua.MinimumWidth = 6;
            this.ketqua.Name = "ketqua";
            this.ketqua.Width = 125;
            // 
            // btn_Inpxn
            // 
            this.btn_Inpxn.Location = new System.Drawing.Point(62, 372);
            this.btn_Inpxn.Name = "btn_Inpxn";
            this.btn_Inpxn.Size = new System.Drawing.Size(100, 66);
            this.btn_Inpxn.TabIndex = 2;
            this.btn_Inpxn.Text = "IN";
            this.btn_Inpxn.UseVisualStyleBackColor = true;
            this.btn_Inpxn.Click += new System.EventHandler(this.btn_Inpxn_Click);
            // 
            // PhieuXetNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Inpxn);
            this.Controls.Add(this.dgv_TTPXN);
            this.Controls.Add(this.label1);
            this.Name = "PhieuXetNghiem";
            this.Text = "PhieuXetNghiem";
            this.Load += new System.EventHandler(this.PhieuXetNghiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TTPXN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_TTPXN;
        private System.Windows.Forms.Button btn_Inpxn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn makt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketqua;
    }
}