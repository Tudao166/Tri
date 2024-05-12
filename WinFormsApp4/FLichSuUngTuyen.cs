
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class FLichSuUngTuyen : Form
    {
        ChiTietTinDangDAO ctDAO;
        int quyen = 0;
        private readonly string connectionString = Properties.Settings.Default.conn;
        LichSuUngTuyenDAO lsutDAO = new LichSuUngTuyenDAO();
        public FLichSuUngTuyen(string idcv, string idct)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(idcv))
            {
                lblTaiKhoan.Text = idcv;
                btnDaThich.Hide();
                quyen = 1;
            }
            else
            {
                lblTaiKhoan.Text = idct;
                quyen = 2;
            }
            LoadDataFromDatabase();
        }

        private void LoadDataFromDatabase()
        {
            List<LichSuUngTuyen> lichSus = lsutDAO.LoadData(lblTaiKhoan.Text);

            foreach (LichSuUngTuyen ls in lichSus)
            {
                PanelLichSuUngTuyen.Controls.Add(new UserControlLichSuUngTuyen(ls, quyen));
            }

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            PanelLichSuUngTuyen.Controls.Clear();
            LoadDataFromDatabase();
        }

        private void btnDaDau_Click(object sender, EventArgs e)
        {
            PanelLichSuUngTuyen.Controls.Clear();
            List<LichSuUngTuyen> lichSus = lsutDAO.LoadDataLoc(lblTaiKhoan.Text, "đã đậu");

            foreach (LichSuUngTuyen ls in lichSus)
            {
                PanelLichSuUngTuyen.Controls.Add(new UserControlLichSuUngTuyen(ls, quyen));
            }
        }

        private void btnDaRot_Click(object sender, EventArgs e)
        {
            PanelLichSuUngTuyen.Controls.Clear();
            List<LichSuUngTuyen> lichSus = lsutDAO.LoadDataLoc(lblTaiKhoan.Text, "đã rớt");

            foreach (LichSuUngTuyen ls in lichSus)
            {
                PanelLichSuUngTuyen.Controls.Add(new UserControlLichSuUngTuyen(ls, quyen));
            }
        }

        private void btnDaUngTuyen_Click(object sender, EventArgs e)
        {
            PanelLichSuUngTuyen.Controls.Clear();
            List<LichSuUngTuyen> lichSus = lsutDAO.LoadDataLoc(lblTaiKhoan.Text, "Đã ứng tuyển");

            foreach (LichSuUngTuyen ls in lichSus)
            {
                PanelLichSuUngTuyen.Controls.Add(new UserControlLichSuUngTuyen(ls, quyen));
            }
        }

        private void btnDaThich_Click(object sender, EventArgs e)
        {
            PanelLichSuUngTuyen.Controls.Clear();
            List<LichSuUngTuyen> lichSus = lsutDAO.LoadDataLike(lblTaiKhoan.Text);

            foreach (LichSuUngTuyen ls in lichSus)
            {
                PanelLichSuUngTuyen.Controls.Add(new UserControlLichSuUngTuyen(ls, quyen));
            }
        }
    }
}