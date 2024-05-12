﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class FNguoiUngTuyen : Form
    {
        public String ten;
        bool menuCollapsed3;
        bool sidebarExpand;
        private int pictureSlide = 1;
        public FNguoiUngTuyen(String taikhoan)
        {
            InitializeComponent();
            pictureBox1.Hide();
            lblTaiKhoan.Text = taikhoan;
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void Slider()
        {
            if (pictureSlide % 2 == 1)
            {
                pictureBox1.Show();
                pictureBox2.Hide();
            }
            else
            {
                pictureBox1.Hide();
                pictureBox2.Show();
            }
            pictureSlide++;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FTimViec(lblTaiKhoan.Text));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FAddCV(lblTaiKhoan.Text));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FCVGide(null,null,null));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FDangNhap dn = new FDangNhap();
            this.Hide();
            dn.Show();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTime.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Slider();
        }      
        private void button11_Click(object sender, EventArgs e)
        {
            FNguoiUngTuyen nut = new FNguoiUngTuyen(lblTaiKhoan.Text);
            this.Hide();
            nut.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FLichSuUngTuyen(lblTaiKhoan.Text,null));
        }
    }
}
