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

    public partial class FDangKi : Form
    {
        public string loai;
        SqlConnection con = new SqlConnection(Properties.Settings.Default.conn);

        public FDangKi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FDangNhap dn = new FDangNhap();
            this.Hide();
            dn.Show();
            dn.Location = this.Location;

        }
        private void textBoxTaiKhoan_Leave(object sender, EventArgs e)
        {

        }

        private void buttonDangKi_Click(object sender, EventArgs e)
        {
            if (txtMK1.Text == txtMK2.Text)
            {
                try
                {
                    // Mở kết nối
                    con.Open();

                    // Sử dụng parameterized query
                    string sqlStr = "INSERT INTO TaiKhoan (taiKhoan, matKhau, tk_Gmail, tk_Loai) VALUES (@tenTaiKhoan, @matKhau, @gmail, @loai)";
                    SqlCommand cmd = new SqlCommand(sqlStr, con);

                    // Truyền giá trị của các tham số
                    cmd.Parameters.AddWithValue("@tenTaiKhoan", txtTK.Text);
                    cmd.Parameters.AddWithValue("@matKhau", txtMK1.Text);
                    cmd.Parameters.AddWithValue("@gmail", txtGmail.Text);
                    cmd.Parameters.AddWithValue("@loai", loai);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        FDangNhap dn = new FDangNhap();
                        this.Hide();
                        dn.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thất bại: " + ex.Message);
                }
                finally
                {
                    // Đóng kết nối
                    con.Close();
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            loai = "congty";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            loai = "ungtuyen";
        }
    }

}


