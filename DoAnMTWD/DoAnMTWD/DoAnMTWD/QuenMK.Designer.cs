namespace DoAnMTWD
{
    partial class frmQMK
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblkq = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnLayLaiMK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(144, 86);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(133, 146);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(52, 16);
            this.lblkq.TabIndex = 1;
            this.lblkq.Text = "Kết quả";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(277, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(281, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // btnLayLaiMK
            // 
            this.btnLayLaiMK.Location = new System.Drawing.Point(268, 238);
            this.btnLayLaiMK.Name = "btnLayLaiMK";
            this.btnLayLaiMK.Size = new System.Drawing.Size(139, 42);
            this.btnLayLaiMK.TabIndex = 3;
            this.btnLayLaiMK.Text = "Lấy lại mật khẩu";
            this.btnLayLaiMK.UseVisualStyleBackColor = true;
            this.btnLayLaiMK.Click += new System.EventHandler(this.btnLayLaiMK_Click);
            // 
            // frmQMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnMTWD.Properties.Resources.kinh_nghiem_giup_chon_phong_kham_nha_khoa_bac_ninh_uy_tin;
            this.ClientSize = new System.Drawing.Size(656, 378);
            this.Controls.Add(this.btnLayLaiMK);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.lblEmail);
            this.Name = "frmQMK";
            this.Text = "QuenMK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQMK_FormClosing);
            this.Load += new System.EventHandler(this.frmQMK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnLayLaiMK;
    }
}