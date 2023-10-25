namespace DoAnMTWD
{
    partial class PhieuXquang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuXquang));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_xquang = new System.Windows.Forms.DataGridView();
            this.maBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketqua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xquang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN CHỤP X-QUANG";
            // 
            // dgv_xquang
            // 
            this.dgv_xquang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_xquang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maBN,
            this.hoten,
            this.ngaykham,
            this.makt,
            this.ketqua});
            this.dgv_xquang.Location = new System.Drawing.Point(37, 59);
            this.dgv_xquang.Name = "dgv_xquang";
            this.dgv_xquang.RowHeadersWidth = 51;
            this.dgv_xquang.RowTemplate.Height = 24;
            this.dgv_xquang.Size = new System.Drawing.Size(685, 290);
            this.dgv_xquang.TabIndex = 1;
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
            // makt
            // 
            this.makt.HeaderText = "MaXQ";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "IN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhieuXquang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_xquang);
            this.Controls.Add(this.label1);
            this.Name = "PhieuXquang";
            this.Text = "PhieuXquang";
            this.Load += new System.EventHandler(this.PhieuXquang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xquang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_xquang;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykham;
        private System.Windows.Forms.DataGridViewTextBoxColumn makt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketqua;
        private System.Windows.Forms.Button button1;
    }
}