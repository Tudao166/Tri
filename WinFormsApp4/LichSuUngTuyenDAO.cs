using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    internal class LichSuUngTuyenDAO
    {
        private readonly string connectionString = Properties.Settings.Default.conn;

        public List<LichSuUngTuyen> LoadData(string id)
        {
            List<LichSuUngTuyen> lichSus = new List<LichSuUngTuyen>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd;
                    con.Open();
                    if (id.Substring(0, 3).ToLower() == "can")
                    {
                        cmd = new SqlCommand("SELECT * FROM LichSuUngTuyen WHERE lsut_IDCV LIKE @taikhoan", con);
                    }
                    else
                    {
                        cmd = new SqlCommand("SELECT * FROM LichSuUngTuyen WHERE lsut_IDCongTy LIKE @taikhoan", con);
                    }
                    cmd.Parameters.AddWithValue("@taikhoan", id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Image image = null;
                        byte[] imageData = reader["lsut_AnhCongTy"] as byte[];

                        if (imageData != null && imageData.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                try
                                {
                                    image = Image.FromStream(ms);
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show("Error loading image for job posting: " + ex.Message);
                                    image = null;
                                }
                            }

                            if (reader != null)
                            {
                                int lsutIDTinDang = Convert.ToInt32(reader["lsut_IDTinDang"]);

                                lichSus.Add(new LichSuUngTuyen(
                                  reader["lsut_IDCV"].ToString(),
                                  reader["lsut_IDTinDang"].ToString(),
                                  reader["lsut_IDCongTy"].ToString(),
                                  image,
                                  reader["lsut_TenCongTy"].ToString(),
                                  reader["lsut_TenUngVien"].ToString(),
                                  reader["lsut_HinhThuc"].ToString(),
                                  (DateTime)reader["lsut_NgayUngTuyen"],
                                  reader["lsut_DiaDiem"].ToString(),
                                  reader["lsut_ChucVu"].ToString(),
                                  reader["lsut_LuongMin"].ToString(),
                                  reader["lsut_LuongMax"].ToString(),
                                  reader["lsut_TrangThai"].ToString(),
                                  reader["lsut_GhiChu"].ToString()
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while reading data: " + ex.Message);
            }

            return lichSus;
        }
        public void DuyetCV(LichSuUngTuyen lichSu, string trangthaimoi, string ghichu)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try // Encapsulate connection opening and execution in a try-catch block
                {
                    con.Open();

                    string sqlStr = "UPDATE LichSuUngTuyen SET lsut_TrangThai = @trangThai, lsut_GhiChu = @ghichu " +
                                     "WHERE lsut_IDCV = @idcv AND lsut_IDTinDang = @idtindang ";

                    SqlCommand cmd = new SqlCommand(sqlStr, con);

                    // Use parameterized queries to prevent SQL injection vulnerabilities
                    cmd.Parameters.AddWithValue("@trangThai", trangthaimoi);
                    cmd.Parameters.AddWithValue("@ghichu", ghichu);
                    cmd.Parameters.AddWithValue("@idcv", lichSu.IDCV); // Assuming IDCV is a property of LichSuUngTuyen
                    cmd.Parameters.AddWithValue("@idtindang", lichSu.IDTinDang); // Assuming IDTinDang is a property of LichSuUngTuyen

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật trạng thái thành công!");
                }
                catch (SqlException ex)
                {
                    // Log the exception for further analysis (consider using a logging library)
                    Console.WriteLine("Error updating data: " + ex.Message);
                    MessageBox.Show("An error occurred while updating data. Please try again later.");
                }
                finally // Ensure connection is closed even if exceptions occur
                {
                    con.Close();
                }
            }
        }
        public List<LichSuUngTuyen> LoadDataLoc(string id,string trangthai)
        {
            List<LichSuUngTuyen> lichSus = new List<LichSuUngTuyen>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd;
                    con.Open();
                    if (id.Substring(0, 3).ToLower() == "can")
                    {
                        cmd = new SqlCommand("SELECT * FROM LichSuUngTuyen WHERE lsut_IDCV LIKE @taikhoan AND lsut_TrangThai = @trangthai", con);
                    }
                    else
                    {
                        cmd = new SqlCommand("SELECT * FROM LichSuUngTuyen WHERE lsut_IDCongTy LIKE @taikhoan AND lsut_TrangThai = @trangthai", con);
                    }
                    cmd.Parameters.AddWithValue("@taikhoan", id);
                    cmd.Parameters.AddWithValue("@trangthai", trangthai);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Image image = null;
                        byte[] imageData = reader["lsut_AnhCongTy"] as byte[];

                        if (imageData != null && imageData.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                try
                                {
                                    image = Image.FromStream(ms);
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show("Error loading image for job posting: " + ex.Message);
                                    image = null;
                                }
                            }

                            if (reader != null)
                            {
                                int lsutIDTinDang = Convert.ToInt32(reader["lsut_IDTinDang"]);

                                lichSus.Add(new LichSuUngTuyen(
                                  reader["lsut_IDCV"].ToString(),
                                  reader["lsut_IDTinDang"].ToString(),
                                  reader["lsut_IDCongTy"].ToString(),
                                  image,
                                  reader["lsut_TenCongTy"].ToString(),
                                  reader["lsut_TenUngVien"].ToString(),
                                  reader["lsut_HinhThuc"].ToString(),
                                  (DateTime)reader["lsut_NgayUngTuyen"],
                                  reader["lsut_DiaDiem"].ToString(),
                                  reader["lsut_ChucVu"].ToString(),
                                  reader["lsut_LuongMin"].ToString(),
                                  reader["lsut_LuongMax"].ToString(),
                                  reader["lsut_TrangThai"].ToString(),
                                  reader["lsut_GhiChu"].ToString()
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while reading data: " + ex.Message);
            }

            return lichSus;
        }
        public List<LichSuUngTuyen> LoadDataLike(string id)
        {
            List<LichSuUngTuyen> lichSus = new List<LichSuUngTuyen>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd;
                    con.Open();
    
                    cmd = new SqlCommand("SELECT * FROM LichSuUngTuyen , CVLike WHERE lsut_IDCongTy LIKE cvl_IDCT AND cvl_IDCT LIKE @taikhoan", con);
                    cmd.Parameters.AddWithValue("@taikhoan", id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Image image = null;
                        byte[] imageData = reader["lsut_AnhCongTy"] as byte[];

                        if (imageData != null && imageData.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                try
                                {
                                    image = Image.FromStream(ms);
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show("Error loading image for job posting: " + ex.Message);
                                    image = null;
                                }
                            }

                            if (reader != null)
                            {
                                int lsutIDTinDang = Convert.ToInt32(reader["lsut_IDTinDang"]);

                                lichSus.Add(new LichSuUngTuyen(
                                  reader["lsut_IDCV"].ToString(),
                                  reader["lsut_IDTinDang"].ToString(),
                                  reader["lsut_IDCongTy"].ToString(),
                                  image,
                                  reader["lsut_TenCongTy"].ToString(),
                                  reader["lsut_TenUngVien"].ToString(),
                                  reader["lsut_HinhThuc"].ToString(),
                                  (DateTime)reader["lsut_NgayUngTuyen"],
                                  reader["lsut_DiaDiem"].ToString(),
                                  reader["lsut_ChucVu"].ToString(),
                                  reader["lsut_LuongMin"].ToString(),
                                  reader["lsut_LuongMax"].ToString(),
                                  reader["lsut_TrangThai"].ToString(),
                                  reader["lsut_GhiChu"].ToString()
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while reading data: " + ex.Message);
            }

            return lichSus;
        }
    }
}
