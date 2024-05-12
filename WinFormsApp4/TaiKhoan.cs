using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    internal class TaiKhoan
    {
        private string tenTaiKhoan;
        public string TenTaiKhoan
        {
            get => tenTaiKhoan;
            set => tenTaiKhoan = value;
        }

        private string matkhau;
        public string MatKhau
        {
            get => matkhau;
            set => matkhau = value;
        }
        public TaiKhoan(string tenTaiKhoan, string matkhau)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matkhau = matkhau;
        }

        public TaiKhoan()
        {
        }



    }


}
