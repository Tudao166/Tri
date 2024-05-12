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
using System.Globalization;

namespace WinFormsApp4
{
    public partial class FAddCV : Form
    {
        CVDAO ungtuyenDAO = new CVDAO();

        public FAddCV(string taikhoan)
        {
            InitializeComponent();
            lblTaiKhoan.Text = taikhoan;
            LoadData();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            ungtuyenDAO.Delete(lblTaiKhoan.Text);
            CV cv = new CV(lblTaiKhoan.Text, picture.Image, txtTen.Text, txtGioiTinh.Text, dateNgaySinh.Value, txtGmail.Text, txtSoDT.Text, txtDiaChi.Text, txtTrinhDo.Text, txtTruong.Text, txtXepLoai.Text, txtKhoa.Text, txtKyNang.Text, txtGiaiThuong.Text, lblKinhNghiem.Text, txtCongViec.Text, txtChucVu.Text, txtLichSu.Text, txtKyNangKhac.Text);
            ungtuyenDAO.AddCV(cv);
        }

        public void LoadData()
        {
            List<CV> cvs = ungtuyenDAO.LoadData(lblTaiKhoan.Text);
            {
                if (cvs.Count > 0)
                {
                    CV cv = cvs[0];
                    lblTaiKhoan.Text = cv.ID;
                    picture.Image = cv.HinhAnh;
                    txtTen.Text = cv.HoTen;
                    txtGioiTinh.Text = cv.GioiTinh;
                    dateNgaySinh.Text = cv.NgaySinh.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                    txtGmail.Text = cv.Email;
                    txtSoDT.Text = cv.SoDienThoai;
                    txtDiaChi.Text = cv.DiaChi;
                    txtTrinhDo.Text = cv.TrinhDo;
                    txtTruong.Text = cv.Truong;
                    txtXepLoai.Text = cv.XepLoai;
                    txtKhoa.Text = cv.Khoa;
                    txtKyNang.Text = cv.KyNang;
                    txtGiaiThuong.Text = cv.GiaiThuong;
                    lblKinhNghiem.Text = cv.KinhNghiem;
                    txtCongViec.Text = cv.CongViec;
                    txtChucVu.Text = cv.ChucVu;
                    txtLichSu.Text = cv.LichSuLamViec;
                    txtKyNangKhac.Text = cv.KyNangKhac;
                }
            }
        }

        //public void Delete(string id)
        //{
        //    if (string.IsNullOrEmpty(id))
        //    {
        //        MessageBox.Show("Please provide a valid ID to delete.");
        //        return;
        //    }

        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(connectionString)) // Use connection string
        //        {
        //            con.Open();

        //            string sqlStr = "DELETE FROM CV WHERE cv_TaiKhoan = @id"; // Parameterized query

        //            SqlCommand cmd = new SqlCommand(sqlStr, con);
        //            cmd.Parameters.AddWithValue("@id", id);

        //            int rowsAffected = cmd.ExecuteNonQuery();

        //            if (rowsAffected > 0)
        //            {
        //                MessageBox.Show("CV deleted successfully.");
        //                LoadData(); // Refresh data after deletion (optional)
        //            }
        //            else
        //            {
        //                MessageBox.Show("No CV found with the provided ID.");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error deleting CV: " + ex.Message);
        //    }
        //}

        private void btnInsert_Click(object sender, EventArgs e)
        {
            picture.Image = XuLiHinhAnh.MoFileTaiAnh();
        }
    }
}