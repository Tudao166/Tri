using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp4
{
    public partial class UserControlLichSuUngTuyen : UserControl
    {
        private readonly string connectionString = Properties.Settings.Default.conn;
        CVDAO cvDAO = new CVDAO();

        public UserControlLichSuUngTuyen(LichSuUngTuyen ls, int quyen)
        {
            InitializeComponent();
            int a = quyen;
            lblChucVu.Text = ls.ChucVu;
            lblDiaDiem.Text = ls.DiaDiem;
            lblLuongMin.Text = ls.LuongMin;
            lblLuongMax.Text = ls.LuongMax;
            lblNgayUngTuyen.Text = ls.NgayUngTuyen.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            lblHinhThuc.Text = ls.HinhThuc;
            lblTaiKhoan.Text = ls.IDCV;
            lblIDCongTy.Text = ls.IDCongTy;
            lblIDTinDang.Text = ls.IDTinDang;
            lblTrangThai.Text = ls.TrangThai;
            txtGhiChu.Text = ls.GhiChu;
            lblLike.Hide();
            picturelike.Hide();
            if (a == 2)
            {
                lblGhiChu.Hide();
                LoadData();
            }
            else
            {
                lblGhiChu.Text = ls.GhiChu;
                lblTen.Text = ls.TenCongTy;
                txtGhiChu.Hide();
                btnYes.Hide();
                btnNo.Hide();
                picture.Image = ls.AnhCongTy;
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FChiTietTinDang cttd;
            if (lblTaiKhoan.Text.ToString().Substring(0, 3).ToLower() != "can")
            {
                cttd = new FChiTietTinDang(lblIDTinDang.Text, lblIDCongTy.Text);

                cttd.Show();
            }
            else
            {
                cttd = new FChiTietTinDang(lblIDTinDang.Text, lblTaiKhoan.Text);
                cttd.Show();
            }
        }


        public void LoadData()
        {
            List<CV> cvs = cvDAO.LoadData(lblTaiKhoan.Text);
            if (cvs.Count > 0)
            {
                CV cv = cvs[0];
                picture.Image = cv.HinhAnh;
                lblTen.Text = cv.HoTen;
                lblLike.Text = cv.LikeCount.ToString();
                lblLike.Show();
                picturelike.Show();


            }
        }
        private void cbxTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void btnChiTietForCT_Click(object sender, EventArgs e)
        {
            FCVGide cvguide = new FCVGide(lblTaiKhoan.Text, lblIDTinDang.Text, lblIDCongTy.Text); ;
            cvguide.Show();
        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            string trangthai = "đã đậu";
            DateTime ngayUngTuyen;
            if (string.IsNullOrEmpty(lblTaiKhoan.Text) ||
                string.IsNullOrEmpty(lblIDTinDang.Text) ||
                string.IsNullOrEmpty(lblIDCongTy.Text) ||
                // Add checks for other labels as needed
                !DateTime.TryParse(lblNgayUngTuyen.Text, out ngayUngTuyen))
            {
                MessageBox.Show("Please ensure all application details are filled in correctly.");
                return;
            }
            LichSuUngTuyen lsut = new LichSuUngTuyen(lblTaiKhoan.Text, lblIDTinDang.Text, lblIDCongTy.Text);
            LichSuUngTuyenDAO lsutDAO = new LichSuUngTuyenDAO();
            lsutDAO.DuyetCV(lsut, trangthai, txtGhiChu.Text);
        }
        private void btnNo_Click(object sender, EventArgs e)
        {
            string trangthai = "đã rớt";
            DateTime ngayUngTuyen;
            if (string.IsNullOrEmpty(lblTaiKhoan.Text) ||
                string.IsNullOrEmpty(lblIDTinDang.Text) ||
                string.IsNullOrEmpty(lblIDCongTy.Text) ||
                !DateTime.TryParse(lblNgayUngTuyen.Text, out ngayUngTuyen))
            {
                MessageBox.Show("Please ensure all application details are filled in correctly.");
                return;
            }
            LichSuUngTuyen lsut = new LichSuUngTuyen(lblTaiKhoan.Text, lblIDTinDang.Text, lblIDCongTy.Text);
            LichSuUngTuyenDAO lsutDAO = new LichSuUngTuyenDAO();
            lsutDAO.DuyetCV(lsut, trangthai, txtGhiChu.Text);
        }

      
    }
}
