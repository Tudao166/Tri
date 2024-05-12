using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp4
{
    public partial class FDangNhap : Form
    {
        
        
        public string loai;

        FNguoiUngTuyen nut;

        public FDangNhap()
        {
            InitializeComponent();
        }
        
        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan(txtTK.Text,txtMK.Text);
            TaiKhoanDao tkDAO = new TaiKhoanDao();
            tkDAO.DangNhap(tk,loai);
        
            //try
            //{
            //    // Open connection
            //    con.Open();

            //    // Construct SQL query with parameterized query to avoid SQL injection

            //    string sqlStrUngTuyen = "SELECT COUNT(*) FROM TaiKhoan WHERE taiKhoan = @tk AND matKhau = @mk AND tk_Loai =@loai ";

            //    // Create SqlCommand object with the constructed query and SqlConnection

            //    SqlCommand cmdUngTuyen = new SqlCommand(sqlStrUngTuyen, con);

            //    // Add parameters to the query to avoid SQL injection

            //    cmdUngTuyen.Parameters.AddWithValue("@tk", txtTK.Text);
            //    cmdUngTuyen.Parameters.AddWithValue("@mk", txtMK.Text);
            //    cmdUngTuyen.Parameters.AddWithValue("@loai", loai);
            //    // Execute the query and get the result using ExecuteScalar

            //    int countUngTuyen = Convert.ToInt32(cmdUngTuyen.ExecuteScalar());
            //    // Check if the count is greater than 0, indicating a successful login
            //  if (countUngTuyen > 0)
            //    {
            //        if (loai == "congty")
            //        {
            //            MessageBox.Show("Đăng nhập thành công");
            //            FCongTy ct = new FCongTy(txtTK.Text);
            //            this.Hide();
            //            ct.Show();


            //        }
            //        else if (loai =="ungtuyen")
            //        {
            //            MessageBox.Show("Đăng nhập thành công");
            //            FNguoiUngTuyen ut = new FNguoiUngTuyen(txtTK.Text);
            //            this.Hide();
            //            ut.Show();
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Đăng nhập thất bại. Sai tên tài khoản hoặc mật khẩu.");
            //    }
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show("Lỗi: " + exc.Message);
            //}
            //finally
            //{
            //    // Make sure to close the connection in the finally block to ensure it's always closed
            //    con.Close();
            //}

        }
        private void linkLabelDangkiLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FDangKi dk = new FDangKi();
            this.Hide();
            dk.Location = this.Location;
            dk.ShowDialog();

        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                loai = "congty";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                loai = "ungtuyen";
            }
        }
    }
}
