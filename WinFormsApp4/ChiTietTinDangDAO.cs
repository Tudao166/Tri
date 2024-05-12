using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.Identity.Client;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace WinFormsApp4
{
    public class ChiTietTinDangDAO
    {
        
        SqlConnection con = new SqlConnection(Properties.Settings.Default.conn);
        private readonly string connectionString = Properties.Settings.Default.conn;
        public void Apply(LichSuUngTuyen lsut)
        {
            // Assuming a DatabaseHelper class exists (see previous explanation)
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection using the helper class
                    con.Open();

                    byte[] imageBytes = XuLiHinhAnh.AnhSangByte(lsut.AnhCongTy);
                    if (imageBytes == null)
                    {
                        MessageBox.Show("Error converting image. Please try again.");
                        return;
                    }

                    // Use parameterized queries to prevent SQL injection vulnerabilities
                    string sqlStr = "INSERT INTO LichSuUngTuyen (lsut_IDCV, lsut_IDTinDang, lsut_IDCongTy, lsut_AnhCongTy, lsut_TenCongTy,lsut_TenUngVien, lsut_HinhThuc, lsut_DiaDiem, lsut_ChucVu, lsut_LuongMin,lsut_LuongMax, lsut_TrangThai) " +
                  "VALUES (@idtaikhoan, @idtindang, @idcongty, @imageBytes, @tenct, @tenuv,@hinhthuc, @noilamviec, @chucvu, @luongmin, @luongmax, N'Đã Ứng Tuyển')";

                    using (SqlCommand cmd = new SqlCommand(sqlStr, con)) // Use connection from helper and dispose automatically
                    {
                        cmd.Parameters.AddWithValue("@tenuv", lsut.TenNguoiUngTuyen);
                        cmd.Parameters.AddWithValue("@idtaikhoan", lsut.IDCV);
                        cmd.Parameters.AddWithValue("@idtindang", lsut.IDTinDang);
                        cmd.Parameters.AddWithValue("@idcongty", lsut.IDCongTy);
                        cmd.Parameters.AddWithValue("@imageBytes", imageBytes);
                        cmd.Parameters.AddWithValue("@tenct", lsut.TenCongTy);
                        cmd.Parameters.AddWithValue("@hinhthuc", lsut.HinhThuc);
                        cmd.Parameters.AddWithValue("@noilamviec", lsut.DiaDiem);
                        cmd.Parameters.AddWithValue("@chucvu", lsut.ChucVu);
                        cmd.Parameters.AddWithValue("@luongmin", lsut.LuongMin);
                        cmd.Parameters.AddWithValue("@luongmax", lsut.LuongMax);

                        //cmd.ExecuteNonQuery(); // Execute the insert query

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Nộp Thành công");
                        }
                        else
                        {
                            MessageBox.Show("Nộp thất bại. Vui lòng thử lại."); // More informative message
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nộp thất bại: " + ex.Message); // Log the actual exception for debugging
                }
            } // Connection is automatically closed using the DatabaseHelper's IDisposable implementation (recommended)
        }
     
        public bool DaTungUngTuyen(string idtaikhoan, string idtindang, string idcongty)
        {
            int count = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();


                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM LichSuUngTuyen WHERE lsut_IDCV = @idcv AND lsut_IDTinDang = @idtd AND lsut_IDCongTy = @idct", con))
                {
                    cmd.Parameters.AddWithValue("@idcv", idtaikhoan);
                    cmd.Parameters.AddWithValue("@idtd", idtindang);
                    cmd.Parameters.AddWithValue("@idct", idcongty);

                    count = (int)cmd.ExecuteScalar();
                }

                return count > 0;
            }
        }
        

        public List<TinDang> LoadData(string idtindang, string idcv)
        {

            List<TinDang> tinDangs = new List<TinDang>();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open(); // Ensure connection is open
                    SqlCommand cmd = new SqlCommand("SELECT * FROM TinDang WHERE  td_IDTinDang = @ID", con);
                    cmd.Parameters.AddWithValue("@ID", idtindang);

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
            catch (Exception ex)
            {
                Console.WriteLine("Error loading data: " + ex.Message);
                Console.WriteLine(ex.StackTrace);

                MessageBox.Show("Error while reading data: " + ex.Message);
            }
            
            return tinDangs;
            
        }
        public int CheckUserLike(string idTinDang, string idTaiKhoan)
        {
            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                string checkLikeSql = "SELECT COUNT(*) FROM TinDangLike WHERE TDL_idtindang = @idTinDang AND TDL_idungvien = @idUngVien";
                SqlCommand checkLikeCmd = new SqlCommand(checkLikeSql, con);
                checkLikeCmd.Parameters.AddWithValue("@idTinDang", idTinDang);
                checkLikeCmd.Parameters.AddWithValue("@idUngVien", idTaiKhoan);

                return (int)checkLikeCmd.ExecuteScalar();
            }
        }
        public void LikeCount(string like, string idtaikhoan, string idtindang,string idcongty)
        {
            if (like == "LIKE")
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        int likedCount = CheckUserLike(idtindang, idtaikhoan);

                        if (likedCount == 0)
                        {
                            string insertLikeSql = "INSERT INTO TinDangLike (TDL_idtindang, TDL_idcongty, TDL_idungvien) " +
                                                  "VALUES (@idTinDang, @idCongTy, @idUngVien)";

                            SqlCommand insertLikeCmd = new SqlCommand(insertLikeSql, con);
                            insertLikeCmd.Parameters.AddWithValue("@idTinDang", idtindang);
                            insertLikeCmd.Parameters.AddWithValue("@idCongTy", idcongty);
                            insertLikeCmd.Parameters.AddWithValue("@idUngVien", idtaikhoan);

                            insertLikeCmd.ExecuteNonQuery();

                            string updateLikeSql = "UPDATE TinDang SET td_LikeCount = td_LikeCount + 1 WHERE td_IDTinDang = @ID";
                            SqlCommand updateLikeCmd = new SqlCommand(updateLikeSql, con);
                            updateLikeCmd.Parameters.AddWithValue("@ID", idtindang);

                            int rowsAffected = updateLikeCmd.ExecuteNonQuery();


                            MessageBox.Show("Đã thích tin đăng");
                            like = "LIKED";
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật lượt thích: " + ex.Message);
                    Console.WriteLine("Error updating like count: " + ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
            else
            {
                
                    try
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();

                            int likedCount = CheckUserLike(idtindang, idtaikhoan);

                            if (likedCount > 0)
                            {
                                string deleteLikeSql = "DELETE FROM TinDangLike WHERE TDL_idtindang = @idTinDang AND TDL_idungvien = @idUngVien";
                                SqlCommand deleteLikeCmd = new SqlCommand(deleteLikeSql, con);
                                deleteLikeCmd.Parameters.AddWithValue("@idTinDang", idtindang);
                                deleteLikeCmd.Parameters.AddWithValue("@idUngVien", idtaikhoan);
                                deleteLikeCmd.ExecuteNonQuery();


                                string updateLikeSql = "UPDATE TinDang SET td_LikeCount = td_LikeCount - 1 WHERE td_IDTinDang = @ID AND td_LikeCount > 0";
                                SqlCommand updateLikeCmd = new SqlCommand(updateLikeSql, con);
                                updateLikeCmd.Parameters.AddWithValue("@ID", idtindang);
                                updateLikeCmd.ExecuteNonQuery();

                                like = "LIKE";
                                MessageBox.Show("Bài đăng đã được bỏ thích!");
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật lượt thích: " + ex.Message);
                    }
                
            }
        }

        public void LikeCountCV(string like, string idtaikhoan, string idtindang, string idcongty) // Change idtindang to int
        {
            if (like == "LIKE")
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        int likedCount = CheckCTLike(idtindang, idtaikhoan);

                        if (likedCount == 0)
                        {
                            string insertLikeSql = "INSERT INTO CVLike (cvl_IDCV, cvl_IDTD, cvl_IDCT) " +
                                                  "VALUES ( @idUngVien, @idTinDang, @idCongTy)";

                            SqlCommand insertLikeCmd = new SqlCommand(insertLikeSql, con);
                            insertLikeCmd.Parameters.AddWithValue("@idTinDang", idtindang);
                            insertLikeCmd.Parameters.AddWithValue("@idCongTy", idcongty);
                            insertLikeCmd.Parameters.AddWithValue("@idUngVien", idtaikhoan);

                            insertLikeCmd.ExecuteNonQuery();

                            string updateLikeSql = "UPDATE CV SET cv_LikeCount = cv_LikeCount + 1 WHERE cv_TaiKhoan = @ID "; // Check for non-negative like count
                            SqlCommand updateLikeCmd = new SqlCommand(updateLikeSql, con);
                            updateLikeCmd.Parameters.AddWithValue("@ID", idtaikhoan); // Use idtindang (job posting ID)

                            int rowsAffected = updateLikeCmd.ExecuteNonQuery();

                            
                            
                            MessageBox.Show("CV đã được thích!");
                            like = "LIKED";                            
                        }
                    
                    }
                }
                catch (Exception ex)
                {
                    // Handle database or other exceptions more informatively
                    MessageBox.Show("Lỗi khi cập nhật lượt thích: " + ex.Message);
                    Console.WriteLine("Error updating like count: " + ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
            else // Unlike scenario
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        string deleteLikeSql = "DELETE FROM CVLike WHERE cvl_IDTD = @idTinDang AND cvl_IDCV = @idUngVien";
                        SqlCommand deleteLikeCmd = new SqlCommand(deleteLikeSql, con);
                        deleteLikeCmd.Parameters.AddWithValue("@idTinDang", idtindang);
                        deleteLikeCmd.Parameters.AddWithValue("@idUngVien", idtaikhoan);
                        int rowsDeleted = deleteLikeCmd.ExecuteNonQuery();

                        Console.WriteLine("Rows deleted: " + rowsDeleted);  // Log for debugging

                        string updateLikeSql = "UPDATE CV SET cv_LikeCount = cv_LikeCount - 1 WHERE cv_TaiKhoan = @ID AND cv_LikeCount > 0";
                        SqlCommand updateLikeCmd = new SqlCommand(updateLikeSql, con);
                        updateLikeCmd.Parameters.AddWithValue("@ID", idtaikhoan);
                        updateLikeCmd.ExecuteNonQuery();

                        like = "LIKE";
                        MessageBox.Show("CV đã được bỏ thích!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật lượt thích: " + ex.Message);
                }
            }
        }
        public int CheckCTLike(string idTinDang, string idTaiKhoan)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string checkLikeSql = "SELECT COUNT(*) FROM CVLike WHERE cvl_IDTD = @idTinDang AND cvl_IDCV = @idUngVien";
                SqlCommand checkLikeCmd = new SqlCommand(checkLikeSql, con);

                // Add parameters and their values
                checkLikeCmd.Parameters.AddWithValue("@idTinDang", idTinDang);
                checkLikeCmd.Parameters.AddWithValue("@idUngVien", idTaiKhoan);

                // Execute the query and return the result (number of likes)
                int likedCount = (int)checkLikeCmd.ExecuteScalar();
                return likedCount;
            }
        }
    }
}
