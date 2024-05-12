using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    internal class TaiKhoanDao
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.conn);
        public void DangNhap(TaiKhoan tk, string loai)
        {
        
            try
            {
                con.Open();
                string sqlStrUngTuyen = "SELECT COUNT(*) FROM TaiKhoan WHERE taiKhoan = @tk AND matKhau = @mk AND tk_Loai =@loai ";
                SqlCommand cmdUngTuyen = new SqlCommand(sqlStrUngTuyen, con);

                cmdUngTuyen.Parameters.AddWithValue("@tk", tk.TenTaiKhoan);
                cmdUngTuyen.Parameters.AddWithValue("@mk", tk.MatKhau);
                cmdUngTuyen.Parameters.AddWithValue("@loai", loai);

                int countUngTuyen = Convert.ToInt32(cmdUngTuyen.ExecuteScalar());
                if (countUngTuyen > 0)
                {
                    if (loai == "congty")
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        FDangNhap dn = new FDangNhap();
                        FCongTy ct = new FCongTy(tk.TenTaiKhoan);
                        ct.Show();
                        dn.Hide();
                    }
                    else if (loai == "ungtuyen")
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        FDangNhap dn = new FDangNhap();
                        FNguoiUngTuyen nut = new FNguoiUngTuyen(tk.TenTaiKhoan);
                        nut.Show();
                        dn.Hide();
                    }
                }                    
                else
                {
                    MessageBox.Show("Đăng nhập thất bại. Sai tên tài khoản hoặc mật khẩu.");
                }
            }
            
            finally
            {
                con.Close();
            }
        }

    }
}
