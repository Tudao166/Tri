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

namespace WinFormsApp4
{
    public class CVDAO
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.conn);
        private readonly string connectionString = Properties.Settings.Default.conn;


        public void AddCV(CV cv)
        {
            try
            {
                con.Open();

                byte[] imageBytes = XuLiHinhAnh.AnhSangByte(cv.HinhAnh);
                if (imageBytes == null)
                {
                    MessageBox.Show("Error converting image. Please try again.");
                    return;
                }

                string sqlStr = string.Format("INSERT INTO CV (cv_HinhAnh, cv_Ten,cv_GioiTinh, cv_NgaySinh, cv_Email, cv_Sdt, cv_DiaChi, cv_TrinhDo, cv_Truong, cv_XepLoai, cv_Khoa, cv_KyNang, cv_GiaiThuong,cv_KinhNghiem, cv_CongViec, cv_ChucVu, cv_LichSuLamViec, cv_KyNangKhac,cv_TaiKhoan) " +
                "VALUES (@imageBytes,N'{0}', N'{1}',N'{2}', N'{3}',N'{4}', N'{5}',N'{6}', N'{7}',N'{8}', N'{9}',N'{10}', N'{11}',N'{12}', N'{13}',N'{14}', N'{15}',N'{16}' ,@ten)",
                cv.HoTen, cv.GioiTinh, cv.NgaySinh, cv.Email, cv.SoDienThoai, cv.DiaChi, cv.TrinhDo, cv.Truong, cv.XepLoai, cv.Khoa, cv.KyNang, cv.GiaiThuong, cv.KinhNghiem, cv.CongViec, cv.ChucVu, cv.LichSuLamViec, cv.KyNangKhac);

                SqlCommand cmd = new SqlCommand(sqlStr, con);


                cmd.Parameters.AddWithValue("@Ten", cv.ID);
                cmd.Parameters.Add("@imageBytes", SqlDbType.VarBinary).Value = imageBytes;
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thêm thành công");
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
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString)) // Use connection string
                {
                    con.Open();

                    string sqlStr = "DELETE FROM CV WHERE cv_TaiKhoan = @id"; // Parameterized query

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
                MessageBox.Show("Error deleting CV: " + ex.Message);
            }
        }

        public List<CV> LoadData(string taikhoan)
        {
            List<CV> cvs = new List<CV>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM CV WHERE cv_TaiKhoan = @Ten", con);
                    cmd.Parameters.AddWithValue("@Ten", taikhoan);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Image image = null;
                        byte[] imageData = reader["cv_HinhAnh"] as byte[];

                        // Check for null or empty image data
                        if (imageData != null && imageData.Length > 0)
                        {
                            try
                            {
                                image = Image.FromStream(new MemoryStream(imageData));
                            }
                            catch (Exception ex)
                            {
                                // Log error details (e.g., using a logging library)
                                Console.WriteLine("Error loading image for CV with username: " + taikhoan + ". Exception: " + ex.Message);
                            }
                        }

                        int likeCount; // Assuming cv_LikeCount is not nullable

                        // ... (rest of the code to extract other CV details)

                        cvs.Add(new CV(
                          reader["cv_TaiKhoan"].ToString(),
                          image,
                          reader["cv_Ten"].ToString(),
                          reader["cv_GioiTinh"].ToString(),
                          (DateTime)reader["cv_NgaySinh"],
                          reader["cv_Email"].ToString(),
                          reader["cv_Sdt"].ToString(),
                          reader["cv_DiaChi"].ToString(),
                          reader["cv_TrinhDo"].ToString(),
                          reader["cv_Truong"].ToString(),
                          reader["cv_XepLoai"].ToString(),
                          reader["cv_Khoa"].ToString(),
                          reader["cv_KyNang"].ToString(),
                          reader["cv_GiaiThuong"].ToString(),
                          reader["cv_KinhNghiem"].ToString(),
                          reader["cv_CongViec"].ToString(),
                          reader["cv_ChucVu"].ToString(),
                          reader["cv_LichSuLamViec"].ToString(),
                          reader["cv_KyNangKhac"].ToString()
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error details (e.g., using a logging library)
                Console.WriteLine("Error while reading data: " + ex.Message);
            }

            return cvs;
        }
        public void Xoa()
        {
            try
            {
                // Connect to database
                con.Open();

                // Prepare SQL statement with parameterized query
                string sqlStr = "DELETE FROM CVLike";
                SqlCommand cmd = new SqlCommand(sqlStr, con);

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa tin tuyển thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tin tuyển để xóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa tin tuyển: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

    }
}