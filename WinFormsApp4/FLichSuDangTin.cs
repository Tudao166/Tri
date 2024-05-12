using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class FLichSuDangTin : Form
    {

        private readonly string connectionString = Properties.Settings.Default.conn;

        public FLichSuDangTin(string taikhoan)
        {

            InitializeComponent();
            lblTaiKhoan.Text = taikhoan;
            LoadDataFromDatabase();

        }

        private void FLichSuDangTin_Load(object sender, EventArgs e)
        {

        }
        private void LoadDataFromDatabase()
        {
            List<TinDang> tinDangs = new List<TinDang>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM TinDang WHERE td_IDCongTy = @ten", con);

                    cmd.Parameters.AddWithValue("@ten", lblTaiKhoan.Text.ToString());  // Make sure "@ten" matches here
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Image image = null;
                        byte[] imageData = reader["td_HinhAnh"] as byte[];

                        if (imageData != null && imageData.Length > 0)
                        {
                            try
                            {
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    image = Image.FromStream(ms);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error loading image for a job posting: " + ex.Message);
                            }
                        }

                        tinDangs.Add(new TinDang(
                             image,
                            reader["td_Ten"].ToString(),
                            reader["td_Sdt"].ToString(),
                            reader["td_Gmail"].ToString(),
                            reader["td_Website"].ToString(),
                            reader["td_NoiLamViec"].ToString(),
                            reader["td_NganhNghe"].ToString(),
                            reader["td_ChucVu"].ToString(),
                            reader["td_HinhThucLamViec"].ToString(),
                            reader["td_LuongMin"].ToString(),
                            reader["td_LuongMax"].ToString(),
                            reader["td_KinhNghiem"].ToString(),
                            reader["td_MoTa"].ToString(),
                            reader["td_KyNang"].ToString(),

                            reader["td_PhucLoi"].ToString(),
                            reader["td_IDCongTy"].ToString(),
                            reader["td_IDCV"].ToString(),
                            reader["td_IDTinDang"].ToString(),
                            (DateTime)reader["td_NgayDang"],
                            (int)reader["td_LikeCount"]
                            ));
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception exc)
            {
                MessageBox.Show("General error: " + exc.Message);
            }

            foreach (TinDang tinDang in tinDangs)
            {
                flowLayoutPanel1.Controls.Add(new UserControlQuanLyTinDang(tinDang));
            }
        }
    }
}
