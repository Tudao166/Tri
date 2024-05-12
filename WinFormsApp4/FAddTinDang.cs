using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class FAddTinDang : Form
    {
        private readonly string connectionString = Properties.Settings.Default.conn;
        SqlConnection con = new SqlConnection(Properties.Settings.Default.conn);
        TinDangDAO tdDAO = new TinDangDAO();
        CongTyDAO ctDAO = new CongTyDAO();
        public FAddTinDang(string taikhoan)
        {
            InitializeComponent();

            lblTaiKhoan.Text = taikhoan;
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
                    txtGmail.Text = ct.Gmail;
                    txtWebsite.Text = ct.Website;
                }
            }
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
        //                    reader["ct_id"].ToString(),
        //                    image,
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
        //            picture.Image = congty.HinhAnh;
        //            txtTen.Text = congty.Ten;
        //            txtWebsite.Text = congty.Website;
        //            txtSoDT.Text = congty.SDT;
        //            txtGmail.Text = congty.Gmail;
        //        }
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            TinDang td = new TinDang(picture.Image, txtTen.Text, txtSoDT.Text, txtGmail.Text, txtWebsite.Text, txtDiaChi.Text, txtNganh.Text, txtChucVu.Text, txtHinhThuc.Text, txtLuongMin.Text, txtLuongMax.Text, cbKinhNghiem.Text, txtMoTa.Text, txtKyNang.Text, txtPhucLoi.Text, lblTaiKhoan.Text);
            tdDAO.AddTinDang(td);
            //try
            //{
            //    // Ket noi
            //    con.Open();
            //    string sqlStr = string.Format("INSERT INTO TinDang (td_HinhAnh, td_Ten, td_Sdt, td_Gmail, td_Website, td_NoiLamViec, td_NganhNghe, td_ChucVu, td_HinhThucLamViec, td_MucLuong, td_KinhNghiem,td_MoTa, td_KyNang, td_PhucLoi,td_IDCongTy)    VALUES (@imageBytes,N'{0}', N'{1}',N'{2}', N'{3}',N'{4}', N'{5}',N'{6}', N'{7}',N'{8}', N'{9}',N'{10}', N'{11}', N'{12}',@ten)", txtTen.Text, txtSoDT.Text, txtGmail.Text, txtWebsite.Text, txtDiaChi.Text, txtNganh.Text, txtChucVu.Text, txtHinhThuc.Text, txtLuong.Text, cbKinhNghiem.Text, txtMoTa.Text, txtKyNang.Text, txtPhucLoi.Text);
            //    SqlCommand cmd = new SqlCommand(sqlStr, con);
            //    cmd.Parameters.AddWithValue("@Ten", lblTaiKhoan.Text);
            //    cmd.Parameters.Add("@imageBytes", SqlDbType.VarBinary).Value = XuLiHinhAnh.AnhSangByte(picture.Image);

            //    if (cmd.ExecuteNonQuery() > 0)
            //        MessageBox.Show("them thanh cong");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("them that bai" + ex);
            //}
            //finally
            //{
            //    con.Close();
            //}
        }
    }
}
