using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class FTimViec : Form
    {
        TinDangDAO tdDAO = new TinDangDAO();
        private readonly string connectionString = Properties.Settings.Default.conn;
        public FChiTietTinDang chitiet;
        public FTimViec(string ten)
        {
            InitializeComponent();
            lblTaiKhoan.Text = ten;
            LoadData();




        }
        public void LoadData()
        {
            List<TinDang> tinDangs = tdDAO.LoadDataTimViec(lblTaiKhoan.Text);
            foreach (TinDang tinDang in tinDangs)
            {
                flowLayoutPanel1.Controls.Add(new UserControlTinDang(tinDang));
            }
        }

        public void Find() // Consider a more descriptive name
        {
            flowLayoutPanel1.Controls.Clear();

            List<TinDang> tinDangs = tdDAO.Find(txtTenCongTy.Text, cbxNganh.Text, cbxViTri.Text, cbxLuong.Text, cbxKinhNghiem.Text);

            foreach (TinDang tinDang in tinDangs)
            {
                flowLayoutPanel1.Controls.Add(new UserControlTinDang(tinDang));
            }

        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Find();
        }

        private void FindNganh(string tukhoa)
        {
            flowLayoutPanel1.Controls.Clear();

            List<TinDang> tinDangs = tdDAO.FindNganh(tukhoa);

            foreach (TinDang tinDang in tinDangs)
            {
                flowLayoutPanel1.Controls.Add(new UserControlTinDang(tinDang));
            }
        }

        private void btnIT_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            FindNganh("Công nghệ thông tin");
        }

        private void btnLuat_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            FindNganh("Luật sư và pháp lý");
            FindNganh("Luật");

        }

        private void btnXayDung_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            FindNganh("Kỹ thuật và xây dựng");
        }

        private void btnYHoc_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            FindNganh("Y tế");
        }

        private void btnGiaoDuc_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            FindNganh("Giáo dục");
        }

        private void btnBaoHiem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            FindNganh("du lịch");
        }

        private void btnOTo_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            FindNganh("Thể thao");
        }
    }
}
