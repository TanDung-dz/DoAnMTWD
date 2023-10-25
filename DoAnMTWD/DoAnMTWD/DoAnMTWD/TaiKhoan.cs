using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnMTWD
{
    class TaiKhoan
    {
        private string tenDangNhap;
        private string matKhau;

        public TaiKhoan()
        {

        }

        public TaiKhoan(string tenDangNhap, string matKhau)
        {
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
        }

        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
