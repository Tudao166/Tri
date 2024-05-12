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
    public partial class UserControlKetQua : UserControl
    {
        CVDAO ungtuyenDAO;    
        public UserControlKetQua(LichSuUngTuyen ls)
        {
            InitializeComponent();
            ungtuyenDAO = new CVDAO();
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
            lblGhiChu.Text = ls.GhiChu;
            lblTen.Text = ls.TenNguoiUngTuyen;
            LoadData();
        }
        public void LoadData()
        {
            List<CV> cvs = ungtuyenDAO.LoadData(lblTaiKhoan.Text);

            if (cvs == null) // Check if list is null
            {
                // Handle the case where no data is returned
                return;
            }

            if (cvs.Count > 0)
            {
                CV cv = cvs[0];
                picture.Image = cv.HinhAnh;
                lblLike.Text = cv.LikeCount.ToString();
            }
            else
            {
                // Handle the case where the list is empty
            }
        }

    }
}
