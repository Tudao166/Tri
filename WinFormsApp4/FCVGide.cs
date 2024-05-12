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
    public partial class FCVGide : Form
    {
        ChiTietTinDangDAO ctTinDang = new ChiTietTinDangDAO();
        CVDAO ungtuyenDAO = new CVDAO();

        public FCVGide(string taikhoan,string idtd,string idct)
        {
            InitializeComponent();
            lblTaiKhoan.Text = taikhoan;
            lblIDCongTy.Text = idct;
            lblIDTinDang.Text = idtd;
            LoadData();
            //ungtuyenDAO.Xoa();
           
        }
        

        private void btnLike_Click(object sender, EventArgs e)
        {
            ctTinDang.LikeCountCV(btnLike.Text, lblTaiKhoan.Text, lblIDTinDang.Text, lblIDCongTy.Text);
            LoadData();
        }
        public void LoadData()
        {

            if (ctTinDang.CheckCTLike(lblIDTinDang.Text, lblTaiKhoan.Text) > 0)
            {
                btnLike.Text = "LIKED";
            }
            else
            {
                btnLike.Text = "LIKE";
            }

            List<CV> cvs = ungtuyenDAO.LoadData(lblTaiKhoan.Text);
            {
                if (cvs.Count > 0)
                {

                    CV cv = cvs[0];
                    lblTaiKhoan.Text = cv.ID;
                    picture.Image = cv.HinhAnh;
                    lblTen.Text = cv.HoTen;
                    lblGioiTinh.Text = cv.GioiTinh;
                    lblNgaySinh.Text = cv.NgaySinh.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                    lblGmail.Text = cv.Email;
                    lblSDT.Text = cv.SoDienThoai;
                    lblViTri.Text = cv.DiaChi;
                    lblTrinhDo.Text = cv.TrinhDo;
                    lblTruong.Text = cv.Truong;
                    lblXepLoai.Text = cv.XepLoai;
                    lblKhoa.Text = cv.Khoa;
                    lblKyNang.Text = cv.KyNang;
                    lblGiaiThuong.Text = cv.GiaiThuong;
                    lblKinhNghiem.Text = cv.KinhNghiem;
                    lblCongViec.Text = cv.CongViec;
                    lblChucVu.Text = cv.ChucVu;
                    lblLichSu.Text = cv.LichSuLamViec;
                    lblKyNangKhac.Text = cv.KyNangKhac;
                    
                }
            }

        }

        }
    }
