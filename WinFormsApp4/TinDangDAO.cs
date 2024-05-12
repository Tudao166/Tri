using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    internal class TinDangDAO
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.conn);
        private readonly string connectionString = Properties.Settings.Default.conn;
        public List<TinDang> Loadidct(string idtindang) // Modify to return a list of CVs
        {
            List<TinDang> tin = new List<TinDang>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM TinDang WHERE td_IDTinDang = @Ten", con);
                    cmd.Parameters.AddWithValue("@Ten", idtindang);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Image image = null;
                        byte[] imageData = reader["cv_HinhAnh"] as byte[];

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
                                MessageBox.Show("Error loading image for a CV posting: " + ex.Message);
                            }
                        }

                        tin.Add(new TinDang(
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
                MessageBox.Show("Error while reading data: " + ex.Message);
            }

            // Return the populated list of CVs
            return tin;
        }
        public void AddTinDang(TinDang tinDang)
        {
            try
            {
                // Ket noi
                con.Open();
                string sqlStr = string.Format("INSERT INTO TinDang (td_HinhAnh, td_Ten, td_Sdt, td_Gmail, td_Website, td_NoiLamViec, td_NganhNghe, td_ChucVu, td_HinhThucLamViec, td_LuongMin,td_LuongMax, td_KinhNghiem,td_MoTa, td_KyNang, td_PhucLoi,td_IDCongTy)    " +
                    "VALUES (@imageBytes,N'{0}', N'{1}',N'{2}', N'{3}',N'{4}', N'{5}',N'{6}', N'{7}',N'{8}', N'{9}',N'{10}', N'{11}', N'{12}', N'{13}',@ten)"
                    , tinDang.ten, tinDang.sodt, tinDang.gmail,tinDang.website,tinDang.noilamviec,tinDang.nganhnghe, tinDang.chucvu, tinDang.hinhthuclamviec, tinDang.luongmin,tinDang.luongmax, tinDang.kinhnghiem, tinDang.mota, tinDang.kynang, tinDang.phucloi);
                SqlCommand cmd = new SqlCommand(sqlStr, con);
                cmd.Parameters.AddWithValue("@Ten", tinDang.idct);
                cmd.Parameters.Add("@imageBytes", SqlDbType.VarBinary).Value = XuLiHinhAnh.AnhSangByte(tinDang.hinhanh);

                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("them thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("them that bai" + ex);
            }
            finally
            {
                con.Close();
            }
        }
        public void UpdateTinDang(TinDang tinDang)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Optimized SQL query with parameterization to prevent SQL injection
                    string sql = @"
UPDATE TinDang
SET
    td_HinhAnh = @imageBytes,
    td_Ten = @Ten,
    td_Sdt = @Sdt,
    td_Gmail = @Gmail,
    td_Website = @Website,
    td_NoiLamViec = @NoiLamViec,
    td_NganhNghe = @NganhNghe,
    td_ChucVu = @ChucVu,
    td_HinhThucLamViec = @HinhThucLamViec,
    td_LuongMin = @LuongMin,
    td_LuongMax = @LuongMax,
    td_KinhNghiem = @KinhNghiem,
    td_MoTa = @MoTa,
    td_KyNang = @KyNang,
    td_PhucLoi = @PhucLoi,
    td_IDCongTy = @IDCongTy
WHERE td_IDTinDang = @IDTinDang;
";

                    SqlCommand cmd = new SqlCommand(sql, con);

                    // Add parameters with appropriate data types
                    cmd.Parameters.AddWithValue("@imageBytes", SqlDbType.VarBinary).Value = XuLiHinhAnh.AnhSangByte(tinDang.hinhanh);
                    cmd.Parameters.AddWithValue("@Ten", tinDang.ten);
                    cmd.Parameters.AddWithValue("@Sdt", tinDang.sodt);
                    cmd.Parameters.AddWithValue("@Gmail", tinDang.gmail);
                    cmd.Parameters.AddWithValue("@Website", tinDang.website);
                    cmd.Parameters.AddWithValue("@NoiLamViec", tinDang.noilamviec);
                    cmd.Parameters.AddWithValue("@NganhNghe", tinDang.nganhnghe);
                    cmd.Parameters.AddWithValue("@ChucVu", tinDang.chucvu);
                    cmd.Parameters.AddWithValue("@HinhThucLamViec", tinDang.hinhthuclamviec);
                    cmd.Parameters.AddWithValue("@LuongMin", tinDang.luongmin);
                    cmd.Parameters.AddWithValue("@LuongMax", tinDang.luongmax);
                    cmd.Parameters.AddWithValue("@KinhNghiem", tinDang.kinhnghiem);
                    cmd.Parameters.AddWithValue("@MoTa", tinDang.mota);
                    cmd.Parameters.AddWithValue("@KyNang", tinDang.kynang);
                    cmd.Parameters.AddWithValue("@PhucLoi", tinDang.phucloi);
                    cmd.Parameters.AddWithValue("@IDCongTy", tinDang.idct);
                    cmd.Parameters.AddWithValue("@IDTinDang", tinDang.idtindang);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật tin đăng: " + ex.Message);
            }
        }

        public void XoaTinDang(string idTinDang)
        {
            try
            {
                // Connect to database
                con.Open();

                // Prepare SQL statement with parameterized query
                string sqlStr = "DELETE FROM TinDang WHERE td_IDTinDang = @idTinDang";
                SqlCommand cmd = new SqlCommand(sqlStr, con);
                cmd.Parameters.AddWithValue("@idTinDang", idTinDang);

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
        public List<TinDang> LoadDataTheoIDTinDang(string idTinDang)
        {
            List<TinDang> tinDangs = new List<TinDang>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Optimized SQL query with parameterization to prevent SQL injection
                    string sql = "SELECT * FROM TinDang WHERE td_IDTinDang = @IDTinDang";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@IDTinDang", idTinDang);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Image image = null;
                        byte[] imageData = reader["td_HinhAnh"] as byte[];

                        // Handle potential exceptions during image conversion
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
                                Console.WriteLine("Error loading image for a job posting: " + ex.Message);
                            }
                        }

                        int tdIDTinDang = Convert.ToInt32(reader["td_IDTinDang"]);

                        // Consolidated constructor arguments for better readability
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
                // Handle potential database or connection errors gracefully
                Console.WriteLine("Error loading TinDang data: " + ex.Message);
            }

            return tinDangs;
        }
        public List<TinDang> LoadDataTimViec(string taikhoan)
        {
            List<TinDang> tinDangs = new List<TinDang>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM TinDang", con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Image image = null;
                        byte[] imageData = reader["td_HinhAnh"] as byte[];

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
                                Console.WriteLine("Error loading image for a job posting: " + ex.Message);
                            }
                        }

                        int tdIDTinDang = Convert.ToInt32(reader["td_IDTinDang"]);

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
                        taikhoan,
                        reader["td_IDTinDang"].ToString(),
                        (DateTime)reader["td_NgayDang"],
                        (int)reader["td_LikeCount"]
                        ));
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log the SQL exception for further investigation
                Console.WriteLine("Error loading data: " + ex.Message);
                Console.WriteLine(ex.StackTrace);

                // Display a more user-friendly message to the user
                MessageBox.Show("Error while reading data: " + ex.Message);
            }

            return tinDangs; // Return the entire list of TinDang objects
        }
        public List<TinDang> LoadDataTimViecTheoLike(string taikhoan)
        {
            List<TinDang> tinDangs = new List<TinDang>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM TinDang ORDER BY td_LikeCount DESC", con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Image image = null;
                        byte[] imageData = reader["td_HinhAnh"] as byte[];

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
                                Console.WriteLine("Error loading image for a job posting: " + ex.Message);
                            }
                        }

                        int tdIDTinDang = Convert.ToInt32(reader["td_IDTinDang"]);

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
                        taikhoan,
                        reader["td_IDTinDang"].ToString(),
                        (DateTime)reader["td_NgayDang"],
                        (int)reader["td_LikeCount"]
                        ));
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log the SQL exception for further investigation
                Console.WriteLine("Error loading data: " + ex.Message);
                Console.WriteLine(ex.StackTrace);

                // Display a more user-friendly message to the user
                MessageBox.Show("Error while reading data: " + ex.Message);
            }

            return tinDangs; // Return the entire list of TinDang objects
        }
        public List<TinDang> FindNganh(string nganh)
        {
            List<TinDang> tinDangs = new List<TinDang>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = @"SELECT * FROM TinDang WHERE td_NganhNghe LIKE N'%' + @nganh + '%' ";

                    

                    // Create the command
                    SqlCommand command = new SqlCommand(sql, con);
                    command.Parameters.AddWithValue("@nganh", (object)nganh ?? DBNull.Value);
                    // Execute the query and read the results
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Image image = null;
                        byte[] imageData = reader["td_HinhAnh"] as byte[];

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
                                Console.WriteLine("Error loading image for a job posting: " + ex.Message);
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
                MessageBox.Show("Error while reading data: " + ex.Message);
            }

            return tinDangs;

        
    }
        public List<TinDang> Find(string ten, string nganhNghe, string noiLamViec, string cbxLuong, string cbxKinhNghiem)
        {
            string findLuong = null;
            string findKinhNghiem = null;

            // Handle salary range conditions
            if (cbxLuong == "3 - 5 triệu")
                findLuong = "td_LuongMin >= 3 AND td_LuongMax < 5";
            else if (cbxLuong == "5 - 8 triệu")
                findLuong = "td_LuongMin >= 5 AND td_LuongMax < 8";
            else if (cbxLuong == "8 - 12 triệu")
                findLuong = "td_LuongMin >= 8 AND td_LuongMax < 12";
            else if (cbxLuong == "12 - 20 triệu")
                findLuong = "td_LuongMin >= 12 AND td_LuongMax < 20";
            else if (cbxLuong == "Trên 20 triệu")
                findLuong = "td_LuongMin >= 20";

            // Handle experience range conditions
            if (cbxKinhNghiem == "Dưới 1 năm")
                findKinhNghiem = "(td_KinhNghiem < 1)";
            else if (cbxKinhNghiem == "1 - 2 năm")
                findKinhNghiem = "(td_KinhNghiem >= 1 AND td_KinhNghiem < 2)";
            else if (cbxKinhNghiem == "2 - 3 năm")
                findKinhNghiem = "(td_KinhNghiem >= 2 AND td_KinhNghiem < 3)";
            else if (cbxKinhNghiem == "3 - 5 năm")
                findKinhNghiem = "(td_KinhNghiem >= 3 AND td_KinhNghiem < 5)";
            else if (cbxKinhNghiem == "Trên 5 năm")
                findKinhNghiem = "(td_KinhNghiem >= 5)";

            // Combine findLuong and findKinhNghiem using AND if both are not null
            string findCondition = null;
            if (!string.IsNullOrEmpty(findLuong)  &&  !string.IsNullOrEmpty(findKinhNghiem))
            {
                findCondition = findLuong +" AND "+ findKinhNghiem;
            }
            else if (!string.IsNullOrEmpty(findLuong) && string.IsNullOrEmpty(findKinhNghiem))
            {
                findCondition = findLuong;
            } 
            else if (string.IsNullOrEmpty(findLuong) && !string.IsNullOrEmpty(findKinhNghiem))
            {
                findCondition = findKinhNghiem;
            }    

            List<TinDang> tinDangs = new List<TinDang>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = @"SELECT * FROM TinDang";

                    // Add WHERE clause conditions
                    if (!string.IsNullOrEmpty(ten))
                    {
                        sql += $" WHERE (td_Ten LIKE N'%' + @ten + '%' OR @ten IS NULL)";
                    }

                    if (!string.IsNullOrEmpty(nganhNghe) && string.IsNullOrEmpty(ten))
                    {
                        sql +=  $" WHERE (td_NganhNghe LIKE N'%' + @nganhNghe + '%' OR @nganhNghe IS NULL )";
                        if (!string.IsNullOrEmpty(noiLamViec))
                        {
                            sql += (!string.IsNullOrEmpty(sql) ? " AND " : " WHERE ") + "(td_NoiLamViec LIKE '%' + N'@noiLamViec' + '%' OR @noiLamViec IS NULL)";
                        }
                    }
                    if (string.IsNullOrEmpty(nganhNghe) && string.IsNullOrEmpty(ten) && !string.IsNullOrEmpty(noiLamViec))
                        sql += $" WHERE (td_NoiLamViec LIKE N'%' + @noiLamViec + '%' OR @noiLamViec IS NULL)"; 



                        if (!string.IsNullOrEmpty(findCondition))
                    {
                        sql += (!string.IsNullOrEmpty(sql) ? " AND " : " WHERE ") + $"({findCondition})";
                    }

                    // Create the command
                    SqlCommand command = new SqlCommand(sql, con);
                    command.Parameters.AddWithValue("@ten", (object)ten ?? DBNull.Value);
                    command.Parameters.AddWithValue("@nganhNghe", (object)nganhNghe ?? DBNull.Value);
                    command.Parameters.AddWithValue("@noiLamViec", (object)noiLamViec ?? DBNull.Value);

                    // Execute the query and read the results
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Image image = null;
                        byte[] imageData = reader["td_HinhAnh"] as byte[];

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
                                Console.WriteLine("Error loading image for a job posting: " + ex.Message);
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
                MessageBox.Show("Error while reading data: " + ex.Message);
            }

            return tinDangs;
        
            
        }
    }
}
