using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;


namespace WinFormsApp4
{
    public partial class FChiTietTinDang : Form
    {
        CVDAO ungtuyenDAO = new CVDAO();
        TinDangDAO tdDAO = new TinDangDAO();
        ChiTietTinDangDAO ctTinDang = new ChiTietTinDangDAO();
        public FChiTietTinDang(string idtindang, string idcv)
        {
            InitializeComponent();
            lblIDTinDang.Text = idtindang;
            lblTaiKhoan.Text = idcv;
            lblTen.Text = idtindang;
            if (lblTaiKhoan.Text.StartsWith("adm"))
            {
                btnLike.Hide();
                btnApply.Hide();
            }

            LoadIDCT();
            LoadTenUngVien();
            LoadData();
        }
        public void LoadIDCT()
        {
            List<TinDang> tinDangs = tdDAO.LoadDataTimViec(lblTaiKhoan.Text);
            {
                if (tinDangs.Count > 0)
                {
                    TinDang tin = tinDangs[0];
                    lblIDCongTy.Text = tin.idct;
                }
            }
        }
        public void LoadTenUngVien()
        {
            if (ungtuyenDAO != null)
            {
                List<CV> cvs = ungtuyenDAO.LoadData(lblTaiKhoan.Text);
                {
                    if (cvs.Count > 0 && lblTaiKhoan.Text.StartsWith("can"))
                    {
                        CV cv = cvs[0];
                        lblTenUngVien.Text = cv.HoTen;
                    }
                }
            }
        }

        public void LoadData()
        {

            if (ctTinDang.CheckUserLike(lblIDTinDang.Text, lblTaiKhoan.Text) >0 )
            {
                btnLike.Text = "LIKED";
            }
            else
            {
                btnLike.Text = "LIKE";
            }
            if (ctTinDang.DaTungUngTuyen(lblTaiKhoan.Text, lblIDTinDang.Text, lblIDCongTy.Text))
            {
                btnApply.Text = "Applied";

            }
            List<TinDang> tins = ctTinDang.LoadData(lblIDTinDang.Text, lblTaiKhoan.Text);
            {
                if (tins.Count > 0)
                {
                    TinDang tin = tins[0];
                    lblTen.Text = tin.ten;
                    lblSDT.Text = tin.sodt;
                    lblGmail.Text = tin.gmail;
                    lblWebsite.Text = tin.website;
                    lblNoiLamViec.Text = tin.noilamviec;
                    lblNganhNghe.Text = tin.nganhnghe;
                    lblChucVu.Text = tin.chucvu;
                    lblHinhThuc.Text = tin.hinhthuclamviec;
                    lblLuongMax.Text = tin.luongmax;
                    lblLuongMin.Text = tin.luongmin;
                    lblKinhNghiem.Text = tin.kinhnghiem;
                    lblMoTa.Text = tin.mota;
                    lblKyNang.Text = tin.kynang;
                    lblPhucLoi.Text = tin.phucloi;
                    picture.Image = tin.hinhanh;
                    lblNgayDang.Text = tin.ngaydang.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                }

            }


        }
        private bool applied = false;

        private void btnApply_Click(object sender, EventArgs e)
        {
            LichSuUngTuyen lsut = new LichSuUngTuyen(lblTaiKhoan.Text, lblIDTinDang.Text, lblIDCongTy.Text, picture.Image, lblTen.Text, lblTenUngVien.Text, lblHinhThuc.Text, lblNoiLamViec.Text, lblChucVu.Text, lblLuongMin.Text, lblLuongMax.Text, "Đã ứng tuyển");
            if (ctTinDang.DaTungUngTuyen(lblTaiKhoan.Text, lblIDTinDang.Text, lblIDCongTy.Text))
            {
                MessageBox.Show("Đã từng ứng tuyển: ");
            }
            else if (!applied) // Check flag before applying
            {
                ctTinDang.Apply(lsut);
                applied = true; // Set flag to prevent duplicate call in LoadData
            }
            //LoadData();
        }

        public void btnLike_Click(object sender, EventArgs e)
        {
            ctTinDang.LikeCount(btnLike.Text, lblTaiKhoan.Text, lblIDTinDang.Text, lblIDCongTy.Text);
            LoadData();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


            
                
        


        

