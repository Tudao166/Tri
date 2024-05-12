using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class FChangeTinDang : Form
    {
        TinDangDAO tdDAO = new TinDangDAO();
        CongTyDAO ctDAO = new CongTyDAO();
        public FChangeTinDang(string idct, string idtd)
        {
            InitializeComponent();
            lblIDTinDang.Text = idtd;
            lblTaiKhoan.Text = idct;
            LoadData();
        }
        public void LoadData()
        {
            List<TinDang> tinDangs = tdDAO.LoadDataTheoIDTinDang(lblIDTinDang.Text);
            {
                if (tinDangs.Count > 0)
                {
                    TinDang td = tinDangs[0];
                    picture.Image = td.hinhanh;
                    txtTen.Text = td.ten;
                    txtSoDT.Text = td.sodt;
                    txtGmail.Text = td.gmail;
                    txtWebsite.Text = td.website;
                    txtDiaChi.Text = td.noilamviec;
                    txtNganh.Text = td.nganhnghe;
                    txtChucVu.Text = td.chucvu;
                    txtHinhThuc.Text = td.hinhthuclamviec;
                    txtLuongMax.Text = td.luongmax;
                    txtLuongMin.Text = td.luongmin;
                    cbKinhNghiem.Text = td.kinhnghiem;
                    txtMoTa.Text = td.mota;
                    txtKyNang.Text = td.kynang;
                    txtPhucLoi.Text = td.phucloi;
                    picture.Enabled = false;
                    txtTen.Enabled = false;
                    txtSoDT.Enabled = false;
                    txtGmail.Enabled = false;
                    txtWebsite.Enabled = false;
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            TinDang td = new TinDang(
            picture.Image,
            txtTen.Text,
            txtSoDT.Text,
            txtGmail.Text,
            txtWebsite.Text,
            txtDiaChi.Text, 
            txtNganh.Text,
            txtChucVu.Text,
            txtHinhThuc.Text,
            txtLuongMin.Text,
            txtLuongMax.Text,
            cbKinhNghiem.Text,
            txtMoTa.Text,
            txtKyNang.Text,
            txtPhucLoi.Text,
            lblTaiKhoan.Text,
            lblIDTinDang.Text
            );
            tdDAO.UpdateTinDang(td);

        }
    }
}
