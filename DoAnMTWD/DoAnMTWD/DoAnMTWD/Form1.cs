using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnMTWD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Modify modify = new Modify();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenTK = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;

            if (tenTK.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (matKhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '" + tenTK + "'" +
                    " and MatKhau = '" + matKhau + "'";
                if (modify.TaiKhoans(query,modify.GetSqlConnection()).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    HomeBenhVien home = new HomeBenhVien();
                    home.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên hoặc mật khẩu không đúng", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void llblQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           frmQMK frmQMK = new frmQMK();    
            frmQMK.ShowDialog();
        }

        private bool isBtnThoatClicked = false;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn thoát????", "Thông báo",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                isBtnThoatClicked = true;
                this.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isBtnThoatClicked && e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn thoát????", "Thông báo",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
