using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class CongTyDAO
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.conn);
        private readonly string connectionString = Properties.Settings.Default.conn;
        public void AddCT(CongTy ct)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    byte[] imageBytes = XuLiHinhAnh.AnhSangByte(ct.HinhAnh);
                    if (imageBytes == null)
                    {
                        MessageBox.Show("Error converting image. Please try again.");
                        return;
                    }

                    string sqlStr = string.Format("INSERT INTO CongTy (ct_HinhAnh,ct_Ten,ct_Sdt,ct_Gmail,ct_Website,ct_TruSo,ct_GiayPhepKinhDoanh,ct_NguoiDungDau,ct_MaSoThue,ct_NgayThanhLap,ct_ID) " +
                                                 "VALUES (@imageBytes,N'{0}', N'{1}',N'{2}', N'{3}',N'{4}', N'{5}',N'{6}', N'{7}',N'{8}',@ten)",
                                                 ct.Ten, ct.SDT, ct.Gmail, ct.Website, ct.TruSo, ct.GiayPhepKinhDoanh, ct.NguoiDungDau, ct.MaSoThue, ct.NgayThanhLap);

                    SqlCommand cmd = new SqlCommand(sqlStr, con);
                    cmd.Parameters.AddWithValue("@Ten", ct.ID);
                    cmd.Parameters.Add("@imageBytes", SqlDbType.VarBinary).Value = imageBytes;
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Thêm thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
           
        }
        public void Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                //MessageBox.Show("Please provide a valid ID to delete.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString)) // Use connection string
                {
                    con.Open();

                    string sqlStr = "DELETE FROM CongTy WHERE ct_ID = @id"; // Parameterized query

                    SqlCommand cmd = new SqlCommand(sqlStr, con);
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        //MessageBox.Show("CV deleted successfully.");
                        //LoadData(); // Refresh data after deletion (optional)
                    }
                    else
                    {
                        //MessageBox.Show("No CV found with the provided ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting company: " + ex.Message);
            }
        }
        
        
        
        
        
        
        public List<CongTy> LoadData(string taikhoan) // Modify to return a list of CVs
        {
            List<CongTy> cts = new List<CongTy>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM CongTy WHERE ct_ID = @Ten", con);
                    cmd.Parameters.AddWithValue("@Ten", taikhoan.ToString());
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Image image = null;
                        byte[] imageData = reader["ct_HinhAnh"] as byte[];

                        // Check if image data exists and has content
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
                                // Handle potential exceptions during image conversion (e.g., corrupted data)
                                MessageBox.Show("Error loading image for a company posting: " + ex.Message);
                            }
                        }

                        cts.Add(new CongTy(
                          reader["ct_ID"].ToString(),
                          image,
                          reader["ct_Ten"].ToString(),
                          reader["ct_Sdt"].ToString(),                         
                          reader["ct_Gmail"].ToString(),
                          reader["ct_Website"].ToString(),
                          reader["ct_TruSo"].ToString(),
                          reader["ct_GiayPhepKinhDoanh"].ToString(),
                          reader["ct_NguoiDungDau"].ToString(),
                          reader["ct_MaSoThue"].ToString(),
                          (DateTime)reader["ct_NgayThanhLap"]
                          ));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while reading data: " + ex.Message);
            }

            // Return the populated list of CVs
            return cts;
        }
        public List<LichSuUngTuyen> LoadKetQua(string idtd)
        {
            List<LichSuUngTuyen> lichSus = new List<LichSuUngTuyen>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd;
                    con.Open();

                    cmd = new SqlCommand("SELECT * FROM LichSuUngTuyen  WHERE lsut_IDTinDang = @idtindang ", con);

                    cmd.Parameters.AddWithValue("@idtindang", idtd);
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
                                }
                            }
                        }

                        if (image != null) // Check for successful image loading before adding to list
                        {
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
            catch (Exception ex)
            {
                MessageBox.Show("Error while reading data: " + ex.Message);
            }

            return lichSus;
        }
    }
}
