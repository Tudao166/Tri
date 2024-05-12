using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class UserControlTinDang : UserControl
    {
        public UserControlTinDang(TinDang tinDang)
        {
            InitializeComponent();
            pictureBox6.Image = tinDang.hinhanh;
            labelHVT.Text = tinDang.ten;
            lblLuongMin.Text = tinDang.luongmin.ToString();
            lblLuongMax.Text = tinDang.luongmax.ToString();
            lblViTRi.Text = tinDang.noilamviec;
            lblChucVu.Text = tinDang.chucvu;
            lblNganhNghe.Text = tinDang.nganhnghe;
            lblNgayDang.Text = tinDang.ngaydang.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            lblIDTinDang.Text = tinDang.idtindang;
            lblTaiKhoan.Text = tinDang.idcv;
            lblIDCongTy.Text = tinDang.idct;
            lblLike.Text = tinDang.likeCount.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        private void btnDetail_Click(object sender, EventArgs e)
        {
            FChiTietTinDang chitiet = new FChiTietTinDang(lblIDTinDang.Text, lblTaiKhoan.Text);
            chitiet.Show();
        }

        private void lblLike_Click(object sender, EventArgs e)
        {

        }
    }
}
