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
    public partial class FAddCongTy : Form
    {
        public readonly string connectionString = Properties.Settings.Default.conn;
        CongTyDAO ctDAO = new CongTyDAO();
        SqlConnection con = new SqlConnection(Properties.Settings.Default.conn);
        public FAddCongTy(string taikhoan)
        {
            InitializeComponent();
            lblTaiKhoan.Text = taikhoan;
            LoadData();


        }
        //private void LoadData()
        //{

        //    {
        //        List<CongTy> congTys = new List<CongTy>();

        //        try
        //        {
        //            using (SqlConnection con = new SqlConnection(connectionString))
        //            {
        //                con.Open();
        //                SqlCommand cmd = new SqlCommand("SELECT * FROM CongTy WHERE ct_ID = @ten", con);

        //                cmd.Parameters.AddWithValue("@ten", lblTaiKhoan.Text.ToString());  // Make sure "@ten" matches here
        //                SqlDataReader reader = cmd.ExecuteReader();
        //                while (reader.Read())
        //                {
        //                    Image image = null;
        //                    byte[] imageData = reader["ct_HinhAnh"] as byte[];

        //                    // Check if image data exists and has content
        //                    if (imageData != null && imageData.Length > 0)
        //                    {
        //                        try
        //                        {
        //                            using (MemoryStream ms = new MemoryStream(imageData))
        //                            {
        //                                image = Image.FromStream(ms);
        //                            }
        //                        }
        //                        catch (Exception ex)
        //                        {
        //                            // Handle potential exceptions during image conversion (e.g., corrupted data)

        //                        }
        //                    }

        //                    congTys.Add(new CongTy(
        //                      image,
        //                    reader["ct_Ten"].ToString(),
        //                    reader["ct_Sdt"].ToString(),
        //                    reader["ct_Gmail"].ToString(),
        //                    reader["ct_Website"].ToString(),


        //                    reader["ct_TruSo"].ToString(),
        //                    reader["ct_GiayPhepKinhDoanh"].ToString(),
        //                    reader["ct_NguoiDungDau"].ToString(),
        //                    reader["ct_MaSoThue"].ToString(),
        //                    (DateTime)reader["ct_NgayThanhLap"]



        //                        ));
        //                }
        //            }
        //        }
        //        catch (SqlException ex)
        //        {
        //        }


        //        foreach (CongTy congty in congTys)
        //        {
        //            txtTen.Text = congty.Ten;
        //            txtTruSo.Text = congty.TruSo.ToString();
        //            txtWebsite.Text = congty.Website;
        //            txtSoDT.Text = congty.SDT;
        //            txtMaSoThue.Text = congty.MaSoThue;
        //            txtGiayPhep.Text = congty.GiayPhepKinhDoanh;
        //            txtGmail.Text = congty.Gmail;
        //            dateNgayThanhLap.Text = congty.NgayThanhLap.ToShortDateString();
        //            txtNguoiDungDau.Text = congty.NguoiDungDau;
        //            picture.Image = congty.HinhAnh;
        //        }
        //    }
        //}
        private void btnInsert_Click(object sender, EventArgs e)
        {
            picture.Image = XuLiHinhAnh.MoFileTaiAnh();
        }


        //public void Delete()
        //{
        //    if (string.IsNullOrEmpty(lblTaiKhoan.Text))
        //    {

        //        return;
        //    }

        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            con.Open();

        //            string sqlStr = "DELETE FROM CongTy WHERE ct_ID = @id";
        //            SqlCommand cmd = new SqlCommand(sqlStr, con);


        //            cmd.Parameters.AddWithValue("@id", lblTaiKhoan.Text);


        //            int rowsAffected = cmd.ExecuteNonQuery();

        //            if (rowsAffected > 0)
        //            {
        //            }
        //            else
        //            {
        //            }
        //        }
        //        catch (SqlException ex)
        //        {
        //        }
        //        catch (Exception ex)
        //        {
        //        }
        //    }
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            ctDAO.Delete(lblTaiKhoan.Text);
            CongTy ct = new CongTy(lblTaiKhoan.Text,picture.Image, txtTen.Text, txtSoDT.Text, txtGmail.Text, txtWebsite.Text, txtTruSo.Text, txtGiayPhep.Text, txtNguoiDungDau.Text, txtMaSoThue.Text, dateNgayThanhLap.Value);
            ctDAO.AddCT(ct);
            LoadData();
        }
        public void LoadData()
        {
            List<CongTy> cts = ctDAO.LoadData(lblTaiKhoan.Text);
            {
                if (cts.Count > 0)
                {
                    CongTy ct = cts[0];
                    picture.Image = ct.HinhAnh;
                    txtTen.Text = ct.Ten;
                    txtSoDT.Text = ct.SDT;
                    dateNgayThanhLap.Text = ct.NgayThanhLap.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                    txtGmail.Text = ct.Gmail;
                    txtMaSoThue.Text = ct.MaSoThue;
                    txtNguoiDungDau.Text = ct.NguoiDungDau;
                    txtTruSo.Text = ct.TruSo;
                    txtWebsite.Text = ct.Website;
                    txtGiayPhep.Text = ct.GiayPhepKinhDoanh;
                }
            }
        }
    }
}
