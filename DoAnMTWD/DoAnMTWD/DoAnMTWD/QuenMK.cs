using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAnMTWD
{
    public partial class frmQMK : Form
    {
        public frmQMK()
        {
            InitializeComponent();
            lblkq.Text = "";
        }
        

       Modify modify = new Modify();
        private void frmQMK_Load(object sender, EventArgs e)
        {

        }

        private void btnLayLaiMK_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Email đã đăng kí", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                string query = "Select * from TaiKhoan where Email = '" + email + "'";
                if (modify.TaiKhoans(query, modify.GetSqlConnection()).Count != 0)
                {
                    lblkq.ForeColor = Color.Blue;
                    lblkq.Text = "Mật khẩu:     " + modify.TaiKhoans(query, modify.GetSqlConnection())[0].MatKhau;
                }
                else
                {
                    lblkq.ForeColor = Color.Red;
                    lblkq.Text = "Email vừa nhập không tồn tạo trên hệ thống";
                }
            }
        }

        private void frmQMK_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
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

