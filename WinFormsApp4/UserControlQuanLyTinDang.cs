using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class UserControlQuanLyTinDang : UserControl
    {
        private readonly string connectionString = Properties.Settings.Default.conn;
        TinDangDAO dao = new TinDangDAO();
        public UserControlQuanLyTinDang(TinDang tinDang)
        {
            InitializeComponent();
            pictureBox1.Image = tinDang.hinhanh;
            lblChucVu.Text = tinDang.chucvu;
            lblLuongMin.Text = tinDang.luongmin.ToString();
            lblLuongMax.Text = tinDang.luongmax.ToString();
            lblGmail.Text = tinDang.gmail;
            lblSoDT.Text = tinDang.sodt;
            lblViTri.Text = tinDang.noilamviec;
            lblIDCongTy.Text = tinDang.idct;
            lblIDTinDang.Text = tinDang.idtindang;
            lblTaiKhoan.Text = tinDang.idcv;
            lblNganhNghe.Text = tinDang.nganhnghe;
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FChiTietTinDang chitiet = new FChiTietTinDang(lblIDTinDang.Text, lblIDCongTy.Text);
            chitiet.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dao.XoaTinDang(lblIDTinDang.Text);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FChangeTinDang change = new FChangeTinDang(lblIDCongTy.Text, lblIDTinDang.Text);
            change.Show();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            FKetQua kq = new FKetQua(lblIDTinDang.Text) ;
            kq.Show();
        }
    }
}
